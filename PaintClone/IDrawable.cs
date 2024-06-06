using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PaintClone
{
    public interface IDrawable
    {
        List<Point> Points { get; }
        Pen Pen { get; }
        Boolean Temporary { get; }
        void AddPoint(Point point);
        void DrawOnGraphics(Graphics canvasGraphics, Point offset);
    }

    public abstract class Drawable : IDrawable
    {

        public Drawable(Pen pen)
        {
            Temporary = false;
            this.Pen = pen;
            Points = new List<Point>();
        }
        public List<Point> Points
        {
            get;
            private set;
        }
        public Pen Pen
        {
            get;
            private set;
        }

        public bool Temporary
        {
            get;
            protected set;
        }

        protected Point[] localScreenPoints;

        public virtual void AddPoint(Point point)
        {
            Points.Add(point);
        }

        public void DrawOnGraphics(Graphics canvasGraphics, Point offset)
        {
            GetLocalScreenPoints(offset);
            DrawOnGraphicsProtected(canvasGraphics, offset);
        }

        protected abstract void DrawOnGraphicsProtected(Graphics canvasGraphics, Point offset);

        protected void GetLocalScreenPoints(Point offset)
        {
            var offsetedPoints = new Point[Points.Count];
            for (int i = 0; i < Points.Count; i++)
            {
                offsetedPoints[i] = ApplyOffset(Points[i], offset);
            }
            localScreenPoints = offsetedPoints;
        }

        protected static Point ApplyOffset(Point point, Point offset)
        {
            point.Offset(offset);
            return point;
        }

    }

    public class RectangleFigure : Drawable
    {
        public RectangleFigure(Pen pen) : base(pen) { }

        public override void AddPoint(Point point)
        {
            var firtsPoint = Points.Count != 0 ? Points[0] : point;
            Points.Clear();
            Points.Add(firtsPoint);
            Points.Add(point);
        }

        protected override void DrawOnGraphicsProtected(Graphics canvasGraphics, Point offset)
        {
            if (Points.Count > 1)
            {
                DrawRectangle(canvasGraphics, localScreenPoints[0], localScreenPoints[1], Pen);
            }
        }

        private static void DrawRectangle(Graphics graphics, Point firstPoint, Point secondPoint, Pen pen)
        {
            var firstX = firstPoint.X;
            var firstY = firstPoint.Y;
            var lastX = secondPoint.X;
            var lastY = secondPoint.Y;
            Utils.SwapRectanglePoints(ref firstX, ref firstY, ref lastX, ref lastY);
            graphics.DrawRectangle(pen, firstX, firstY, lastX - firstX, lastY - firstY);
        }
    }

    public class EllipseFigure : Drawable
    {
        public EllipseFigure(Pen pen) : base(pen) { }

        public override void AddPoint(Point point)
        {
            var firtsPoint = Points.Count != 0 ? Points[0] : point;
            Points.Clear();
            Points.Add(firtsPoint);
            Points.Add(point);
        }

        protected override void DrawOnGraphicsProtected(Graphics canvasGraphics, Point offset)
        {
            if (Points.Count > 1)
            {
                DrawEllipse(canvasGraphics, localScreenPoints[0], localScreenPoints[1], Pen);
            }
        }

        private static void DrawEllipse(Graphics graphics, Point firstPoint, Point secondPoint, Pen pen)
        {
            var firstX = firstPoint.X;
            var firstY = firstPoint.Y;
            var lastX = secondPoint.X;
            var lastY = secondPoint.Y;
            Utils.SwapRectanglePoints(ref firstX, ref firstY, ref lastX, ref lastY);
            graphics.DrawEllipse(pen, firstX, firstY, lastX - firstX, lastY - firstY);
        }
    }

    public class PenTool : Drawable
    {
        public PenTool(Pen pen) : base(pen) { }

        protected override void DrawOnGraphicsProtected(Graphics canvasGraphics, Point offset)
        {
            if (Points.Count > 0)
            {
                canvasGraphics.FillEllipse(new SolidBrush(Pen.Color),
                    localScreenPoints[0].X - Pen.Width / 2,
                    localScreenPoints[0].Y - Pen.Width / 2,
                    Pen.Width,
                    Pen.Width);
            }
            if (Points.Count > 1)
            {
                canvasGraphics.DrawLines(Pen, localScreenPoints);
                canvasGraphics.FillEllipse(new SolidBrush(Pen.Color),
                    localScreenPoints[localScreenPoints.Count() - 1].X - Pen.Width / 2,
                    localScreenPoints[localScreenPoints.Count() - 1].Y - Pen.Width / 2,
                    Pen.Width,
                    Pen.Width);
            }
        }
    }

    public class SprayTool : Drawable
    {
        public SprayTool(Pen pen) : base(pen)
        {
            Pen.Width = Math.Max(1, pen.Width);
        }

        protected override void DrawOnGraphicsProtected(Graphics canvasGraphics, Point offset)
        {
            for (int i = 0; i < Points.Count; i++)
            {
                var random = new Random(GetHashCode() + i);
                var sprayCircle = new Bitmap((int)Pen.Width, (int)Pen.Width);
                for (int x = 0; x < (int)Pen.Width; x++)
                {
                    for (int y = 0; y < (int)Pen.Width; y++)
                    {
                        var dx = (double)x;
                        var dy = (double)y;
                        var radius = ((double)(int)Pen.Width) / 2;
                        if (random.Next(8) == 1 && Math.Pow(dx - radius, 2) + Math.Pow(dy - radius, 2) <= Math.Pow(radius, 2))
                        {
                            sprayCircle.SetPixel(x, y, Pen.Color);
                        }
                    }
                }
                canvasGraphics.DrawImage(sprayCircle, localScreenPoints[i].X - (int)Pen.Width / 2, localScreenPoints[i].Y - (int)Pen.Width / 2);
            }
        }
    }

    public class SelectionTool : Drawable
    {
        private List<Point> CopyPoints;

        public SelectionTool(List<Point> copyPoints) : base(new Pen(Color.Black, 1.5f))
        {
            Pen.DashStyle = DashStyle.Dash;
            Temporary = true;
            CopyPoints = copyPoints;
        }

        public override void AddPoint(Point point)
        {
            var firtsPoint = Points.Count != 0 ? Points[0] : point;
            Points.Clear();
            Points.Add(firtsPoint);
            Points.Add(point);
            var firstX = Points[0].X;
            var firstY = Points[0].Y;
            var lastX = Points[1].X;
            var lastY = Points[1].Y;
            Utils.SwapRectanglePoints(ref firstX, ref firstY, ref lastX, ref lastY);
            CopyPoints.Clear();
            CopyPoints.Add(new Point(firstX, firstY));
            CopyPoints.Add(new Point(lastX, lastY));
        }

        protected override void DrawOnGraphicsProtected(Graphics canvasGraphics, Point offset)
        {
            if (Points.Count > 1)
                DrawRectangle(canvasGraphics, localScreenPoints[0], localScreenPoints[1], Pen);
        }

        private static void DrawRectangle(Graphics graphics, Point firstPoint, Point secondPoint, Pen pen)
        {
            var firstX = firstPoint.X;
            var firstY = firstPoint.Y;
            var lastX = secondPoint.X;
            var lastY = secondPoint.Y;
            Utils.SwapRectanglePoints(ref firstX, ref firstY, ref lastX, ref lastY);
            graphics.DrawRectangle(pen, firstX, firstY, lastX - firstX, lastY - firstY);
        }
    }

    public class EraserTool : Drawable
    {
        private Bitmap BackgroundMask;
        public EraserTool(Bitmap backgroundMask, Pen pen) : base(pen)
        {
            BackgroundMask = backgroundMask;
            Pen.Width = Math.Max(1, pen.Width);
        }

        protected override void DrawOnGraphicsProtected(Graphics canvasGraphics, Point offset)
        {
            for (int i = 0; i < Points.Count; i++)
            {
                var eraserRect = new Bitmap((int)Pen.Width, (int)Pen.Width);
                for (int x = 0; x < (int)Pen.Width; x++)
                {
                    for (int y = 0; y < (int)Pen.Width; y++)
                    {
                        try
                        {
                            var backgroundColor = BackgroundMask.GetPixel((int)(Points[i].X - Pen.Width / 2) + x, (int)(Points[i].Y - Pen.Width / 2) + y);
                            eraserRect.SetPixel(x, y, backgroundColor);
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            // Console.WriteLine($"x = {(int)(Points[i].X - Pen.Width / 2) + x}, y = {(int)(Points[i].Y - Pen.Width / 2) + y}");

                        }
                    }
                }
                canvasGraphics.DrawImage(eraserRect, localScreenPoints[i].X - (int)Pen.Width / 2, localScreenPoints[i].Y - (int)Pen.Width / 2);
            }
        }
    }

    public class BucketTool : Drawable
    {
        private Bitmap BackgroundMask;
        private Bitmap CurrentBitmap;
        public BucketTool(Pen pen, Bitmap backgroundMask, Bitmap currentBitmap) : base(pen)
        {
            BackgroundMask = backgroundMask;
            CurrentBitmap = currentBitmap;
        }

        public override void AddPoint(Point point)
        {
            base.AddPoint(point);
        }

        protected override void DrawOnGraphicsProtected(Graphics canvasGraphics, Point offset)
        {
            try
            {
                if (Points.Count > 0)
                {
                    FloodFill(CurrentBitmap, BackgroundMask, Points[0], CurrentBitmap.GetPixel(Points[0].X, Points[0].Y), Pen.Color);
                    canvasGraphics.DrawImage(CurrentBitmap, ApplyOffset(new Point(0, 0), offset));
                }
            }
            catch (ArgumentOutOfRangeException e) { }
        }

        private void FloodFill(Bitmap bmp, Bitmap backgroundBmp, Point pt, Color targetColor, Color replacementColor)
        {
            targetColor = bmp.GetPixel(pt.X, pt.Y);
            if (targetColor.ToArgb().Equals(replacementColor.ToArgb()))
            {
                return;
            }

            Stack<Point> pixels = new Stack<Point>();

            pixels.Push(pt);
            while (pixels.Count != 0)
            {
                Point temp = pixels.Pop();
                int y1 = temp.Y;
                while (y1 >= 0 && bmp.GetPixel(temp.X, y1) == targetColor)
                {
                    y1--;
                }
                y1++;
                bool spanLeft = false;
                bool spanRight = false;
                while (y1 < bmp.Height && bmp.GetPixel(temp.X, y1) == targetColor)
                {
                    bmp.SetPixel(temp.X, y1, replacementColor);
                    backgroundBmp.SetPixel(temp.X, y1, replacementColor);

                    if (!spanLeft && temp.X > 0 && bmp.GetPixel(temp.X - 1, y1) == targetColor)
                    {
                        pixels.Push(new Point(temp.X - 1, y1));
                        spanLeft = true;
                    }
                    else if (spanLeft && temp.X - 1 == 0 && bmp.GetPixel(temp.X - 1, y1) != targetColor)
                    {
                        spanLeft = false;
                    }
                    if (!spanRight && temp.X < bmp.Width - 1 && bmp.GetPixel(temp.X + 1, y1) == targetColor)
                    {
                        pixels.Push(new Point(temp.X + 1, y1));
                        spanRight = true;
                    }
                    else if (spanRight && temp.X < bmp.Width - 1 && bmp.GetPixel(temp.X + 1, y1) != targetColor)
                    {
                        spanRight = false;
                    }
                    y1++;
                }

            }


        }
    }

    public class DrawableImage : Drawable
    {
        private Bitmap BitmapToInsert;
        public DrawableImage(Bitmap bitmap) : base(null)
        {
            BitmapToInsert = bitmap;
        }

        public override void AddPoint(Point point)
        {
            Points.Clear();
            base.AddPoint(point);
        }

        protected override void DrawOnGraphicsProtected(Graphics canvasGraphics, Point offset)
        {
            canvasGraphics.DrawImage(BitmapToInsert, localScreenPoints[0]);
        }
    }

    public class NoneTool : Drawable
    {
        public NoneTool() : base(null)
        {
        }

        protected override void DrawOnGraphicsProtected(Graphics canvasGraphics, Point offset)
        {

        }
    }
}
