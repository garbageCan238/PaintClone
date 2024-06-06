using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace PaintClone
{
    public class Canvas
    {
        private Panel canvasPanel;
        private List<IDrawable> drawables = new List<IDrawable>();
        private List<IDrawable> removedDrawables = new List<IDrawable>();
        public long LastRenderTime {  get; private set; }

        public Bitmap BackgroundMask
        {
            get;
            private set;
        }
        public Canvas(Panel panel)
        {
            this.canvasPanel = panel;
            typeof(Panel).InvokeMember(
                "DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, panel, new object[] { true }); // Нужно чтобы убрать разрывы экрана
            panel.Paint += PanelPaintEventHadler;
            BackgroundMask = ToBitmap();
            Console.Write("Canvas initialized");
        }

        public void AddToCanvas(IDrawable drawable)
        {
            drawables.Add(drawable);
            removedDrawables.Clear();
            canvasPanel.Invalidate();
        }

        public void Update()
        {
            canvasPanel.Invalidate();
        }

        public void Clear(bool clearBackground = true)
        {
            drawables.Clear();
            removedDrawables.Clear();
            if (clearBackground)
                BackgroundMask = ToBitmap();
            canvasPanel.Invalidate();
        }

        public void UndoDrawing()
        {
            try
            {
                removedDrawables.Add(drawables[drawables.Count - 1]);
                drawables.RemoveAt(drawables.Count - 1);
                canvasPanel.Invalidate();
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }

        public void RedoDrawing()
        {
            try
            {
                drawables.Add(removedDrawables[removedDrawables.Count - 1]);
                removedDrawables.RemoveAt(removedDrawables.Count - 1);
                canvasPanel.Invalidate();
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }

        public Color GetColorAt(Point location)
        {
            Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
            using (Graphics gdest = Graphics.FromImage(screenPixel))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }

            return screenPixel.GetPixel(0, 0);
        }

        public Bitmap ToBitmap()
        {
            if (drawables.Count > 0 && drawables.Last().Temporary == true)
            {
                drawables.RemoveAt(drawables.Count - 1);
                canvasPanel.Invalidate();
            }
            var tmpMinimumSize = canvasPanel.MinimumSize;
            var tmpSize = canvasPanel.Size;
            canvasPanel.MinimumSize = canvasPanel.MaximumSize;
            Bitmap bmp = new Bitmap(canvasPanel.MaximumSize.Width, canvasPanel.MaximumSize.Height);

            canvasPanel.DrawToBitmap(bmp, new Rectangle(0, 0, canvasPanel.MaximumSize.Width, canvasPanel.MaximumSize.Height));
            canvasPanel.MinimumSize = tmpMinimumSize;
            canvasPanel.Size = tmpSize;
            canvasPanel.Invalidate();
            return bmp;

        }

        public Bitmap ToBitmap(int firstX, int firstY, int lastX, int lastY)
        {
            if (drawables.Count > 0 && drawables.Last().Temporary == true)
            {
                drawables.RemoveAt(drawables.Count - 1);
                canvasPanel.Invalidate();
            }
            Utils.SwapRectanglePoints(ref firstX, ref firstY, ref lastX, ref lastY);
            var tmpMinimumSize = canvasPanel.MinimumSize;
            var tmpSize = canvasPanel.Size;
            canvasPanel.MinimumSize = canvasPanel.MaximumSize;
            using (Bitmap bmp = new Bitmap(canvasPanel.MaximumSize.Width, canvasPanel.MaximumSize.Height))
            {
                var sizedBmp = new Bitmap(lastX - firstX + 2, lastY - firstY + 2);
                bmp.MakeTransparent();
                canvasPanel.DrawToBitmap(bmp, new Rectangle(0, 0, canvasPanel.MaximumSize.Width, canvasPanel.MaximumSize.Height));
                var bitmapSizeRectangle = new Rectangle(
                    Math.Max(0, firstX), Math.Max(0, firstY),
                    Math.Min(bmp.Width - firstX, lastX - firstX),
                    Math.Min(bmp.Height - firstY, lastY - firstY));
                sizedBmp = bmp.Clone(bitmapSizeRectangle, bmp.PixelFormat);

                canvasPanel.MinimumSize = tmpMinimumSize;
                canvasPanel.Size = tmpSize;
                return sizedBmp;
            }
        }

        private void PanelPaintEventHadler(object sender, PaintEventArgs e)
        {
            var watch = Stopwatch.StartNew();
            var pointsToDelete = new List<int>();
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            for (int i = 0; i < drawables.Count; i++)
            {
                if (i != drawables.Count - 1 && drawables[i].Temporary == true)
                {
                    pointsToDelete.Add(i);
                    drawables[i] = new NoneTool();
                    continue;
                }
                drawables[i].DrawOnGraphics(e.Graphics, canvasPanel.AutoScrollPosition);
            }
            foreach (var index in pointsToDelete)
            {
                drawables.RemoveAt(index);
            }
            watch.Stop();
            LastRenderTime = watch.ElapsedMilliseconds;
            Console.WriteLine($"Time passed : {LastRenderTime} ms");
        }

        public void MergeDrawings()
        {
            var bmp = ToBitmap();
            var lastDrawable = drawables.Last();
            lastDrawable.Points.Clear();
            Clear(false);
            var drawableBitmap = new DrawableImage(bmp);
            drawableBitmap.AddPoint(new Point(0, 0));
            AddToCanvas(drawableBitmap);
            AddToCanvas(lastDrawable);
        }

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);
    }
}
