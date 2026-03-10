using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsPackage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDrawLine_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.ShowDialog();
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3();
            f1.ShowDialog();
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            Form4 f1 = new Form4();
            f1.ShowDialog();
        }

        private void button2D_Transformation_Click(object sender, EventArgs e)
        {
            Form5 f1 = new Form5();
            f1.ShowDialog();
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
