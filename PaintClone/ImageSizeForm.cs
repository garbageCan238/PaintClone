using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintClone
{
    public partial class ImageSizeForm : Form
    {
        private Form1 mainForm;
        public ImageSizeForm(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainForm.ResizePanel((int)numericUpDown1.Value, (int)numericUpDown2.Value);
        }
    }
}
