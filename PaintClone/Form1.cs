using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace PaintClone
{
    public partial class Form1 : Form
    {
        private CurrentColorButton _selectedColorButton;
        private CurrentColorButton selectedColorButton
        {
            get
            {
                return _selectedColorButton;
            }
            set
            {
                _selectedColorButton = value;
                _selectedColorButton.isSelected = true;
            }
        }

        public UsedTool usedTool = UsedTool.Pen;
        public Canvas canvas;
        public IDrawable currentDrawable;
        private String filePath;
        private List<Point> copyPoints = new List<Point>();
        private Bitmap copiedBitmap;
        private DrawableImage copiedDrawableImage;

        public Form1()
        {
            InitializeComponent();
            selectedColorButton = firstCurrentColorButton;
            addStatusBarEventHandlers();
            canvas = new Canvas(canvasPanel);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

        }

        private void changeColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = selectedColorButton.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                selectedColorButton.BackColor = colorDialog.Color;
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программу сделал Ямалиев Рашит, группа 2231117", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CurrentColorButton_Click(object sender, EventArgs e)
        {
            var button = (CurrentColorButton)sender;
            if (button != selectedColorButton)
            {
                if (button == secondCurrentColorButton)
                {
                    firstCurrentColorButton.isSelected = false;
                }
                else
                {
                    secondCurrentColorButton.isSelected = false;
                }
            }
            selectedColorButton = button;
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            selectedColorButton.BackColor = ((ColorButton)sender).BackColor;
        }

        private void addStatusBarEventHandlers()
        {
            canvasPanel.MouseMove += showCursorPosition_MouseMove;
            canvasPanel.MouseLeave += DisableCursorPosition_MouseLeave;
        }

        private void showCursorPosition_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X >= 0 && e.X <= canvasPanel.Width && e.Y >= 0 && e.Y <= canvasPanel.Height)
            {
                cursorPositionStatusLabel.Text = $"{e.X - canvasPanel.AutoScrollPosition.X}, {e.Y - canvasPanel.AutoScrollPosition.Y}";
            }
        }

        private void DisableCursorPosition_MouseLeave(object sender, EventArgs e)
        {
            cursorPositionStatusLabel.Text = "";
        }

        private void canvasPanel_MouseDown(object sender, MouseEventArgs e)
        {
            var pen = new Pen(selectedColorButton.BackColor, width);
            copyPoints.Clear();
            var autoScrollPos = canvasPanel.AutoScrollPosition;
            switch (usedTool)
            {
                case (UsedTool.Pen):

                    currentDrawable = new PenTool(pen);
                    break;
                case (UsedTool.Rectangle):
                    currentDrawable = new RectangleFigure(pen);
                    break;
                case (UsedTool.Spray):
                    currentDrawable = new SprayTool(pen);
                    break;
                case (UsedTool.Ellipse):
                    currentDrawable = new EllipseFigure(pen);
                    break;
                case (UsedTool.Selector):
                    currentDrawable = new SelectionTool(copyPoints);
                    break;
                case (UsedTool.Eraser):
                    currentDrawable = new EraserTool(canvas.BackgroundMask, pen);
                    break;
                case (UsedTool.Bucket):
                    currentDrawable = new BucketTool(pen, canvas.BackgroundMask, canvas.ToBitmap());
                    break;
                case (UsedTool.Paste):
                    currentDrawable = copiedBitmap != null ? new DrawableImage(new Bitmap(copiedBitmap)) : null;
                    break;

            }
            if (currentDrawable != null)
            {
                var point = new Point(
                    e.X - autoScrollPos.X,
                    e.Y - autoScrollPos.Y);
                currentDrawable.AddPoint(point);
                canvas.AddToCanvas(currentDrawable);
                canvas.Update();
            }
        }

        private void canvasPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentDrawable != null)
            {
                var point = new Point(
                    e.X - canvasPanel.AutoScrollPosition.X,
                    e.Y - canvasPanel.AutoScrollPosition.Y);
                currentDrawable.AddPoint(point);
                canvas.Update();
                if (copyPoints.Count > 1)
                    Console.WriteLine($"{copyPoints[0]}, {copyPoints[1]}");
            }
        }

        private void canvasPanel_MouseUp(object sender, MouseEventArgs e)
        {
            currentDrawable = null;
            if (canvas.LastRenderTime > 30)
            {
                canvas.MergeDrawings();
            }
        }


        private int width;



        private void widthButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                width = Convert.ToInt32(((RadioButton)sender).Text);
            }
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            canvas.UndoDrawing();
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            canvas.RedoDrawing();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            canvas.Clear();
        }

        private void sprayButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sprayButton.Checked)
            {
                unselectAllExceptSelected(((RadioButton)sender));
                usedTool = UsedTool.Spray;
            }
        }

        private void penButton_CheckedChanged(object sender, EventArgs e)
        {
            if (penButton.Checked)
            {
                unselectAllExceptSelected(((RadioButton)sender));
                usedTool = UsedTool.Pen;
            }
        }

        private void eraserButton_CheckedChanged(object sender, EventArgs e)
        {
            if (eraserButton.Checked)
            {
                unselectAllExceptSelected(((RadioButton)sender));
                usedTool = UsedTool.Eraser;
            }
        }

        private void canvasPanel_Click(object sender, EventArgs e)
        {
            if (usedTool == UsedTool.Eyedropper)
            {
                selectedColorButton.BackColor = canvas.GetColorAt(MousePosition);
            }
        }

        private void eyedropperButton_CheckedChanged(object sender, EventArgs e)
        {
            if (eyedropperButton.Checked)
            {
                unselectAllExceptSelected(((RadioButton)sender));
                usedTool = UsedTool.Eyedropper;
            }
        }

        private void bucketButton_CheckedChanged(object sender, EventArgs e)
        {
            if (bucketButton.Checked)
            {
                unselectAllExceptSelected(((RadioButton)sender));
                usedTool = UsedTool.Bucket;
            }
        }

        private void rectangleButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rectangleButton.Checked)
            {
                unselectAllExceptSelected(((RadioButton)sender));
                usedTool = UsedTool.Rectangle;
            }
        }

        private void ellipseButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ellipseButton.Checked)
            {
                unselectAllExceptSelected(((RadioButton)sender));
                ((RadioButton)sender).Checked = true;
                usedTool = UsedTool.Ellipse;
            }
        }

        private void selectButton_CheckedChanged(object sender, EventArgs e)
        {
            if (selectButton.Checked)
            {
                unselectAllExceptSelected(((RadioButton)sender));
                usedTool = UsedTool.Selector;
            }
        }

        private void unselectAllExceptSelected(RadioButton radioButton)
        {
            foreach (RadioButton rb in groupBox1.Controls.OfType<RadioButton>())
            {
                if (radioButton != rb)
                    rb.Checked = false;
            }
            foreach (RadioButton rb in flowLayoutPanel2.Controls.OfType<RadioButton>())
            {
                if (radioButton != rb)
                    rb.Checked = false;
            }
            foreach (RadioButton rb in flowLayoutPanel3.Controls.OfType<RadioButton>())
            {
                if (radioButton != rb)
                    rb.Checked = false;
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if (copyPoints.Count > 1)
            {
                copiedBitmap = canvas.ToBitmap(copyPoints[0].X, copyPoints[0].Y, copyPoints[1].X, copyPoints[1].Y);
            }
        }

        private void pasteButton_CheckedChanged(object sender, EventArgs e)
        {
            if (pasteButton.Checked)
            {
                unselectAllExceptSelected(((RadioButton)sender));
                usedTool = UsedTool.Paste;
            }
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.Clear();
            filePath = null;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Jpeg images(*.jpeg)|*.jpeg"; ;
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            filePath = saveFileDialog.FileName;

            canvas.ToBitmap().Save(filePath);
            MessageBox.Show("Файл сохранен");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filePath != null)
            {
                canvas.ToBitmap().Save(filePath);
            }
            else
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Jpeg images(*.jpeg)|*.jpeg";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            filePath = openFileDialog.FileName;

            var bmp = new Bitmap(filePath);
            var drawableBmp = new DrawableImage(bmp);
            canvas.Clear();
            drawableBmp.AddPoint(new Point(0, 0));
            canvas.AddToCanvas(drawableBmp);

            MessageBox.Show("Файл открыт");
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var imgSizeForm = new ImageSizeForm(this);
            var upDowns = imgSizeForm.Controls.OfType<NumericUpDown>().ToList();
            upDowns[1].Value = canvasPanel.MaximumSize.Width;
            upDowns[0].Value = canvasPanel.MaximumSize.Height;
            imgSizeForm.Show();
        }

        public void ResizePanel(int width, int height)
        {
            canvasPanel.MaximumSize = new Size(width, height);
            canvasPanel.AutoScrollMinSize = new Size(width, height);
        }

        private void optimizationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

class CurrentColorButton : ColorButton
{
    private bool _isSelected = false;
    public bool isSelected
    {
        get
        {
            return _isSelected;
        }
        set
        {
            _isSelected = value;
            Invalidate();
        }
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);
        if (isSelected)
            ControlPaint.DrawBorder(
                pevent.Graphics, ClientRectangle,
                Color.FromArgb(255 - BackColor.R, 255 - BackColor.G, 255 - BackColor.B),
                ButtonBorderStyle.Inset);
        else
            ControlPaint.DrawBorder(
                pevent.Graphics,
                ClientRectangle,
                Color.FromArgb(255 - BackColor.R, 255 - BackColor.G, 255 - BackColor.B),
                ButtonBorderStyle.None);
    }
}

class ColorButton : Button
{

    public ColorButton() : base()
    {
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
    }

    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        FlatAppearance.MouseOverBackColor = BackColor;
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);
        FlatAppearance.MouseDownBackColor = BackColor;
    }
}

public enum UsedTool
{
    Pen,
    Spray,
    Eraser,
    Eyedropper,
    Rectangle,
    Ellipse,
    Selector,
    Paste,
    Bucket
}

