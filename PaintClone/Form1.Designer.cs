namespace PaintClone
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.changeColorButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.penButton = new System.Windows.Forms.RadioButton();
            this.sprayButton = new System.Windows.Forms.RadioButton();
            this.eyedropperButton = new System.Windows.Forms.RadioButton();
            this.eraserButton = new System.Windows.Forms.RadioButton();
            this.bucketButton = new System.Windows.Forms.RadioButton();
            this.undoButton = new System.Windows.Forms.Button();
            this.redoButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.rectangleButton = new System.Windows.Forms.RadioButton();
            this.ellipseButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectButton = new System.Windows.Forms.RadioButton();
            this.pasteButton = new System.Windows.Forms.RadioButton();
            this.copyButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.cursorPositionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorButton1 = new ColorButton();
            this.colorButton2 = new ColorButton();
            this.colorButton3 = new ColorButton();
            this.colorButton4 = new ColorButton();
            this.colorButton5 = new ColorButton();
            this.colorButton6 = new ColorButton();
            this.colorButton7 = new ColorButton();
            this.colorButton8 = new ColorButton();
            this.colorButton9 = new ColorButton();
            this.colorButton10 = new ColorButton();
            this.colorButton11 = new ColorButton();
            this.colorButton12 = new ColorButton();
            this.firstCurrentColorButton = new CurrentColorButton();
            this.secondCurrentColorButton = new CurrentColorButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.canvasPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 114);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(14, 14, 2, 2);
            this.panel1.Size = new System.Drawing.Size(784, 225);
            this.panel1.TabIndex = 0;
            // 
            // canvasPanel
            // 
            this.canvasPanel.AutoScroll = true;
            this.canvasPanel.AutoScrollMinSize = new System.Drawing.Size(1920, 860);
            this.canvasPanel.AutoSize = true;
            this.canvasPanel.BackColor = System.Drawing.SystemColors.Window;
            this.canvasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasPanel.Location = new System.Drawing.Point(14, 14);
            this.canvasPanel.MaximumSize = new System.Drawing.Size(1920, 860);
            this.canvasPanel.MinimumSize = new System.Drawing.Size(400, 200);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(768, 209);
            this.canvasPanel.TabIndex = 0;
            this.canvasPanel.Click += new System.EventHandler(this.canvasPanel_Click);
            this.canvasPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvasPanel_MouseDown);
            this.canvasPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvasPanel_MouseMove);
            this.canvasPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvasPanel_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 90);
            this.panel2.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.changeColorButton);
            this.groupBox4.Controls.Add(this.flowLayoutPanel5);
            this.groupBox4.Controls.Add(this.flowLayoutPanel4);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(507, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(179, 90);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Цвета";
            // 
            // changeColorButton
            // 
            this.changeColorButton.BackColor = System.Drawing.Color.Transparent;
            this.changeColorButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("changeColorButton.BackgroundImage")));
            this.changeColorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.changeColorButton.FlatAppearance.BorderSize = 0;
            this.changeColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeColorButton.Location = new System.Drawing.Point(140, 35);
            this.changeColorButton.Name = "changeColorButton";
            this.changeColorButton.Size = new System.Drawing.Size(32, 32);
            this.changeColorButton.TabIndex = 5;
            this.toolTip1.SetToolTip(this.changeColorButton, "Изменить цвет");
            this.changeColorButton.UseVisualStyleBackColor = false;
            this.changeColorButton.Click += new System.EventHandler(this.changeColorButton_Click);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.colorButton1);
            this.flowLayoutPanel5.Controls.Add(this.colorButton2);
            this.flowLayoutPanel5.Controls.Add(this.colorButton3);
            this.flowLayoutPanel5.Controls.Add(this.colorButton4);
            this.flowLayoutPanel5.Controls.Add(this.colorButton5);
            this.flowLayoutPanel5.Controls.Add(this.colorButton6);
            this.flowLayoutPanel5.Controls.Add(this.colorButton7);
            this.flowLayoutPanel5.Controls.Add(this.colorButton8);
            this.flowLayoutPanel5.Controls.Add(this.colorButton9);
            this.flowLayoutPanel5.Controls.Add(this.colorButton10);
            this.flowLayoutPanel5.Controls.Add(this.colorButton11);
            this.flowLayoutPanel5.Controls.Add(this.colorButton12);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(40, 16);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Padding = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel5.Size = new System.Drawing.Size(94, 71);
            this.flowLayoutPanel5.TabIndex = 4;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.firstCurrentColorButton);
            this.flowLayoutPanel4.Controls.Add(this.secondCurrentColorButton);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(37, 71);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.flowLayoutPanel1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox5.Location = new System.Drawing.Point(416, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(91, 90);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Толщина";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radioButton1);
            this.flowLayoutPanel1.Controls.Add(this.radioButton2);
            this.flowLayoutPanel1.Controls.Add(this.radioButton3);
            this.flowLayoutPanel1.Controls.Add(this.radioButton4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(85, 71);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radioButton1.Checked = true;
            this.radioButton1.FlatAppearance.BorderSize = 0;
            this.radioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(36, 28);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.widthButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radioButton2.FlatAppearance.BorderSize = 0;
            this.radioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(45, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(36, 28);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "4";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.widthButton_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton3.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radioButton3.FlatAppearance.BorderSize = 0;
            this.radioButton3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(3, 37);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(36, 28);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.Text = "8";
            this.radioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.widthButton_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton4.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radioButton4.FlatAppearance.BorderSize = 0;
            this.radioButton4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton4.Location = new System.Drawing.Point(45, 37);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(36, 28);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.Text = "12";
            this.radioButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton4.UseVisualStyleBackColor = false;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.widthButton_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flowLayoutPanel3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(274, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(142, 90);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Инструменты";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.penButton);
            this.flowLayoutPanel3.Controls.Add(this.sprayButton);
            this.flowLayoutPanel3.Controls.Add(this.eyedropperButton);
            this.flowLayoutPanel3.Controls.Add(this.eraserButton);
            this.flowLayoutPanel3.Controls.Add(this.bucketButton);
            this.flowLayoutPanel3.Controls.Add(this.undoButton);
            this.flowLayoutPanel3.Controls.Add(this.redoButton);
            this.flowLayoutPanel3.Controls.Add(this.refreshButton);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(136, 71);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // penButton
            // 
            this.penButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.penButton.BackColor = System.Drawing.Color.Transparent;
            this.penButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("penButton.BackgroundImage")));
            this.penButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.penButton.Checked = true;
            this.penButton.FlatAppearance.BorderSize = 0;
            this.penButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.penButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.penButton.Location = new System.Drawing.Point(3, 3);
            this.penButton.Name = "penButton";
            this.penButton.Size = new System.Drawing.Size(28, 28);
            this.penButton.TabIndex = 0;
            this.penButton.TabStop = true;
            this.penButton.UseVisualStyleBackColor = false;
            this.penButton.CheckedChanged += new System.EventHandler(this.penButton_CheckedChanged);
            // 
            // sprayButton
            // 
            this.sprayButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.sprayButton.BackColor = System.Drawing.Color.Transparent;
            this.sprayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sprayButton.BackgroundImage")));
            this.sprayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sprayButton.FlatAppearance.BorderSize = 0;
            this.sprayButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.sprayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sprayButton.Location = new System.Drawing.Point(37, 3);
            this.sprayButton.Name = "sprayButton";
            this.sprayButton.Size = new System.Drawing.Size(28, 28);
            this.sprayButton.TabIndex = 1;
            this.toolTip1.SetToolTip(this.sprayButton, "Распылитель");
            this.sprayButton.UseVisualStyleBackColor = false;
            this.sprayButton.CheckedChanged += new System.EventHandler(this.sprayButton_CheckedChanged);
            // 
            // eyedropperButton
            // 
            this.eyedropperButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.eyedropperButton.BackColor = System.Drawing.Color.Transparent;
            this.eyedropperButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eyedropperButton.BackgroundImage")));
            this.eyedropperButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eyedropperButton.FlatAppearance.BorderSize = 0;
            this.eyedropperButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.eyedropperButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eyedropperButton.Location = new System.Drawing.Point(71, 3);
            this.eyedropperButton.Name = "eyedropperButton";
            this.eyedropperButton.Size = new System.Drawing.Size(28, 28);
            this.eyedropperButton.TabIndex = 2;
            this.toolTip1.SetToolTip(this.eyedropperButton, "Пипетка");
            this.eyedropperButton.UseVisualStyleBackColor = false;
            this.eyedropperButton.CheckedChanged += new System.EventHandler(this.eyedropperButton_CheckedChanged);
            // 
            // eraserButton
            // 
            this.eraserButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.eraserButton.BackColor = System.Drawing.Color.Transparent;
            this.eraserButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eraserButton.BackgroundImage")));
            this.eraserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eraserButton.FlatAppearance.BorderSize = 0;
            this.eraserButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.eraserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eraserButton.Location = new System.Drawing.Point(105, 3);
            this.eraserButton.Name = "eraserButton";
            this.eraserButton.Size = new System.Drawing.Size(28, 28);
            this.eraserButton.TabIndex = 3;
            this.toolTip1.SetToolTip(this.eraserButton, "Ластик");
            this.eraserButton.UseVisualStyleBackColor = false;
            this.eraserButton.CheckedChanged += new System.EventHandler(this.eraserButton_CheckedChanged);
            // 
            // bucketButton
            // 
            this.bucketButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.bucketButton.BackColor = System.Drawing.Color.Transparent;
            this.bucketButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bucketButton.BackgroundImage")));
            this.bucketButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bucketButton.FlatAppearance.BorderSize = 0;
            this.bucketButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.bucketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bucketButton.Location = new System.Drawing.Point(3, 37);
            this.bucketButton.Name = "bucketButton";
            this.bucketButton.Size = new System.Drawing.Size(28, 28);
            this.bucketButton.TabIndex = 10;
            this.toolTip1.SetToolTip(this.bucketButton, "Ластик");
            this.bucketButton.UseVisualStyleBackColor = false;
            this.bucketButton.CheckedChanged += new System.EventHandler(this.bucketButton_CheckedChanged);
            // 
            // undoButton
            // 
            this.undoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("undoButton.BackgroundImage")));
            this.undoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.undoButton.FlatAppearance.BorderSize = 0;
            this.undoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undoButton.Location = new System.Drawing.Point(37, 37);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(28, 28);
            this.undoButton.TabIndex = 7;
            this.toolTip1.SetToolTip(this.undoButton, "Отменить действие");
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // redoButton
            // 
            this.redoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("redoButton.BackgroundImage")));
            this.redoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.redoButton.FlatAppearance.BorderSize = 0;
            this.redoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redoButton.Location = new System.Drawing.Point(71, 37);
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(28, 28);
            this.redoButton.TabIndex = 8;
            this.toolTip1.SetToolTip(this.redoButton, "Повторить действие");
            this.redoButton.UseVisualStyleBackColor = true;
            this.redoButton.Click += new System.EventHandler(this.redoButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshButton.BackgroundImage")));
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refreshButton.FlatAppearance.BorderSize = 0;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Location = new System.Drawing.Point(105, 37);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(28, 28);
            this.refreshButton.TabIndex = 9;
            this.toolTip1.SetToolTip(this.refreshButton, "Стереть все с экрана");
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(128, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 90);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фигуры";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.rectangleButton);
            this.flowLayoutPanel2.Controls.Add(this.ellipseButton);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(140, 71);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // rectangleButton
            // 
            this.rectangleButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.rectangleButton.BackColor = System.Drawing.Color.Transparent;
            this.rectangleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rectangleButton.BackgroundImage")));
            this.rectangleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rectangleButton.FlatAppearance.BorderSize = 0;
            this.rectangleButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.rectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectangleButton.Location = new System.Drawing.Point(3, 3);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(28, 28);
            this.rectangleButton.TabIndex = 2;
            this.toolTip1.SetToolTip(this.rectangleButton, "Прямоугольник");
            this.rectangleButton.UseVisualStyleBackColor = false;
            this.rectangleButton.CheckedChanged += new System.EventHandler(this.rectangleButton_CheckedChanged);
            // 
            // ellipseButton
            // 
            this.ellipseButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.ellipseButton.BackColor = System.Drawing.Color.Transparent;
            this.ellipseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ellipseButton.BackgroundImage")));
            this.ellipseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ellipseButton.FlatAppearance.BorderSize = 0;
            this.ellipseButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.ellipseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ellipseButton.Location = new System.Drawing.Point(37, 3);
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Size = new System.Drawing.Size(28, 28);
            this.ellipseButton.TabIndex = 3;
            this.toolTip1.SetToolTip(this.ellipseButton, "Эллипс");
            this.ellipseButton.UseVisualStyleBackColor = false;
            this.ellipseButton.CheckedChanged += new System.EventHandler(this.ellipseButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectButton);
            this.groupBox1.Controls.Add(this.pasteButton);
            this.groupBox1.Controls.Add(this.copyButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Буфер обмена";
            // 
            // selectButton
            // 
            this.selectButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.selectButton.BackColor = System.Drawing.Color.Transparent;
            this.selectButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selectButton.BackgroundImage")));
            this.selectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.selectButton.FlatAppearance.BorderSize = 0;
            this.selectButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.selectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectButton.Location = new System.Drawing.Point(82, 50);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(36, 36);
            this.selectButton.TabIndex = 8;
            this.toolTip1.SetToolTip(this.selectButton, "Выделить");
            this.selectButton.UseVisualStyleBackColor = false;
            this.selectButton.CheckedChanged += new System.EventHandler(this.selectButton_CheckedChanged);
            // 
            // pasteButton
            // 
            this.pasteButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.pasteButton.BackColor = System.Drawing.Color.Transparent;
            this.pasteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pasteButton.BackgroundImage")));
            this.pasteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pasteButton.FlatAppearance.BorderSize = 0;
            this.pasteButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.pasteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pasteButton.Location = new System.Drawing.Point(16, 21);
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.Size = new System.Drawing.Size(60, 60);
            this.pasteButton.TabIndex = 7;
            this.toolTip1.SetToolTip(this.pasteButton, "Вставить");
            this.pasteButton.UseVisualStyleBackColor = false;
            this.pasteButton.CheckedChanged += new System.EventHandler(this.pasteButton_CheckedChanged);
            // 
            // copyButton
            // 
            this.copyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("copyButton.BackgroundImage")));
            this.copyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.copyButton.FlatAppearance.BorderSize = 0;
            this.copyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyButton.Location = new System.Drawing.Point(82, 11);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(36, 36);
            this.copyButton.TabIndex = 5;
            this.toolTip1.SetToolTip(this.copyButton, "Скопировать");
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsКакToolStripMenuItem,
            this.openToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.createToolStripMenuItem.Text = "Создать";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsКакToolStripMenuItem
            // 
            this.saveAsКакToolStripMenuItem.Name = "saveAsКакToolStripMenuItem";
            this.saveAsКакToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.saveAsКакToolStripMenuItem.Text = "Сохранить как";
            this.saveAsКакToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.infoToolStripMenuItem.Text = "Справка";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.настройкиToolStripMenuItem.Text = "Вид";
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.sizeToolStripMenuItem.Text = "Размер изображения";
            this.sizeToolStripMenuItem.Click += new System.EventHandler(this.sizeToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursorPositionStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // cursorPositionStatusLabel
            // 
            this.cursorPositionStatusLabel.Name = "cursorPositionStatusLabel";
            this.cursorPositionStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // colorButton1
            // 
            this.colorButton1.BackColor = System.Drawing.Color.LightCoral;
            this.colorButton1.FlatAppearance.BorderSize = 0;
            this.colorButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton1.Location = new System.Drawing.Point(5, 5);
            this.colorButton1.Name = "colorButton1";
            this.colorButton1.Size = new System.Drawing.Size(16, 16);
            this.colorButton1.TabIndex = 0;
            this.colorButton1.UseVisualStyleBackColor = false;
            this.colorButton1.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // colorButton2
            // 
            this.colorButton2.BackColor = System.Drawing.Color.Red;
            this.colorButton2.FlatAppearance.BorderSize = 0;
            this.colorButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton2.Location = new System.Drawing.Point(27, 5);
            this.colorButton2.Name = "colorButton2";
            this.colorButton2.Size = new System.Drawing.Size(16, 16);
            this.colorButton2.TabIndex = 1;
            this.colorButton2.UseVisualStyleBackColor = false;
            this.colorButton2.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // colorButton3
            // 
            this.colorButton3.BackColor = System.Drawing.Color.Brown;
            this.colorButton3.FlatAppearance.BorderSize = 0;
            this.colorButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton3.Location = new System.Drawing.Point(49, 5);
            this.colorButton3.Name = "colorButton3";
            this.colorButton3.Size = new System.Drawing.Size(16, 16);
            this.colorButton3.TabIndex = 2;
            this.colorButton3.UseVisualStyleBackColor = false;
            this.colorButton3.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // colorButton4
            // 
            this.colorButton4.BackColor = System.Drawing.Color.Maroon;
            this.colorButton4.FlatAppearance.BorderSize = 0;
            this.colorButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton4.Location = new System.Drawing.Point(71, 5);
            this.colorButton4.Name = "colorButton4";
            this.colorButton4.Size = new System.Drawing.Size(16, 16);
            this.colorButton4.TabIndex = 3;
            this.colorButton4.UseVisualStyleBackColor = false;
            this.colorButton4.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // colorButton5
            // 
            this.colorButton5.BackColor = System.Drawing.Color.PaleGreen;
            this.colorButton5.FlatAppearance.BorderSize = 0;
            this.colorButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton5.Location = new System.Drawing.Point(5, 27);
            this.colorButton5.Name = "colorButton5";
            this.colorButton5.Size = new System.Drawing.Size(16, 16);
            this.colorButton5.TabIndex = 4;
            this.colorButton5.UseVisualStyleBackColor = false;
            this.colorButton5.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // colorButton6
            // 
            this.colorButton6.BackColor = System.Drawing.Color.Lime;
            this.colorButton6.FlatAppearance.BorderSize = 0;
            this.colorButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton6.Location = new System.Drawing.Point(27, 27);
            this.colorButton6.Name = "colorButton6";
            this.colorButton6.Size = new System.Drawing.Size(16, 16);
            this.colorButton6.TabIndex = 5;
            this.colorButton6.UseVisualStyleBackColor = false;
            this.colorButton6.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // colorButton7
            // 
            this.colorButton7.BackColor = System.Drawing.Color.Green;
            this.colorButton7.FlatAppearance.BorderSize = 0;
            this.colorButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton7.Location = new System.Drawing.Point(49, 27);
            this.colorButton7.Name = "colorButton7";
            this.colorButton7.Size = new System.Drawing.Size(16, 16);
            this.colorButton7.TabIndex = 6;
            this.colorButton7.UseVisualStyleBackColor = false;
            this.colorButton7.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // colorButton8
            // 
            this.colorButton8.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.colorButton8.FlatAppearance.BorderSize = 0;
            this.colorButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton8.Location = new System.Drawing.Point(71, 27);
            this.colorButton8.Name = "colorButton8";
            this.colorButton8.Size = new System.Drawing.Size(16, 16);
            this.colorButton8.TabIndex = 7;
            this.colorButton8.UseVisualStyleBackColor = false;
            this.colorButton8.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // colorButton9
            // 
            this.colorButton9.BackColor = System.Drawing.Color.LightBlue;
            this.colorButton9.FlatAppearance.BorderSize = 0;
            this.colorButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton9.Location = new System.Drawing.Point(5, 49);
            this.colorButton9.Name = "colorButton9";
            this.colorButton9.Size = new System.Drawing.Size(16, 16);
            this.colorButton9.TabIndex = 8;
            this.colorButton9.UseVisualStyleBackColor = false;
            this.colorButton9.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // colorButton10
            // 
            this.colorButton10.BackColor = System.Drawing.Color.Cyan;
            this.colorButton10.FlatAppearance.BorderSize = 0;
            this.colorButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton10.Location = new System.Drawing.Point(27, 49);
            this.colorButton10.Name = "colorButton10";
            this.colorButton10.Size = new System.Drawing.Size(16, 16);
            this.colorButton10.TabIndex = 9;
            this.colorButton10.UseVisualStyleBackColor = false;
            this.colorButton10.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // colorButton11
            // 
            this.colorButton11.BackColor = System.Drawing.Color.SteelBlue;
            this.colorButton11.FlatAppearance.BorderSize = 0;
            this.colorButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton11.Location = new System.Drawing.Point(49, 49);
            this.colorButton11.Name = "colorButton11";
            this.colorButton11.Size = new System.Drawing.Size(16, 16);
            this.colorButton11.TabIndex = 10;
            this.colorButton11.UseVisualStyleBackColor = false;
            this.colorButton11.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // colorButton12
            // 
            this.colorButton12.BackColor = System.Drawing.Color.DarkCyan;
            this.colorButton12.FlatAppearance.BorderSize = 0;
            this.colorButton12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton12.Location = new System.Drawing.Point(71, 49);
            this.colorButton12.Name = "colorButton12";
            this.colorButton12.Size = new System.Drawing.Size(16, 16);
            this.colorButton12.TabIndex = 11;
            this.colorButton12.UseVisualStyleBackColor = false;
            this.colorButton12.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // firstCurrentColorButton
            // 
            this.firstCurrentColorButton.BackColor = System.Drawing.Color.Black;
            this.firstCurrentColorButton.FlatAppearance.BorderSize = 0;
            this.firstCurrentColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstCurrentColorButton.isSelected = false;
            this.firstCurrentColorButton.Location = new System.Drawing.Point(3, 3);
            this.firstCurrentColorButton.Name = "firstCurrentColorButton";
            this.firstCurrentColorButton.Size = new System.Drawing.Size(30, 30);
            this.firstCurrentColorButton.TabIndex = 0;
            this.firstCurrentColorButton.UseVisualStyleBackColor = false;
            this.firstCurrentColorButton.Click += new System.EventHandler(this.CurrentColorButton_Click);
            // 
            // secondCurrentColorButton
            // 
            this.secondCurrentColorButton.BackColor = System.Drawing.Color.White;
            this.secondCurrentColorButton.FlatAppearance.BorderSize = 0;
            this.secondCurrentColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secondCurrentColorButton.isSelected = false;
            this.secondCurrentColorButton.Location = new System.Drawing.Point(3, 39);
            this.secondCurrentColorButton.Name = "secondCurrentColorButton";
            this.secondCurrentColorButton.Size = new System.Drawing.Size(30, 30);
            this.secondCurrentColorButton.TabIndex = 1;
            this.secondCurrentColorButton.UseVisualStyleBackColor = false;
            this.secondCurrentColorButton.Click += new System.EventHandler(this.CurrentColorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.Text = "Firebit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private ColorButton colorButton1;
        private CurrentColorButton firstCurrentColorButton;
        private CurrentColorButton secondCurrentColorButton;
        private ColorButton colorButton2;
        private ColorButton colorButton3;
        private ColorButton colorButton4;
        private ColorButton colorButton5;
        private ColorButton colorButton6;
        private ColorButton colorButton7;
        private ColorButton colorButton8;
        private ColorButton colorButton9;
        private ColorButton colorButton10;
        private ColorButton colorButton11;
        private ColorButton colorButton12;
        private System.Windows.Forms.Button changeColorButton;
        private System.Windows.Forms.Panel canvasPanel;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel cursorPositionStatusLabel;
        private System.Windows.Forms.RadioButton penButton;
        private System.Windows.Forms.RadioButton sprayButton;
        private System.Windows.Forms.RadioButton eyedropperButton;
        private System.Windows.Forms.RadioButton eraserButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button redoButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.RadioButton rectangleButton;
        private System.Windows.Forms.RadioButton ellipseButton;
        private System.Windows.Forms.RadioButton pasteButton;
        private System.Windows.Forms.RadioButton selectButton;
        private System.Windows.Forms.RadioButton bucketButton;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
    }
}

