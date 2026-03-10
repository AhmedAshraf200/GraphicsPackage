using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GraphicsPackage
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void panelBackground_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelCircle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void XY_Axis(Brush aBrush)
        {
            aBrush = Brushes.Black;
            var g = panelCircle.CreateGraphics();
            for (int i = 0; i < panelCircle.Height; i++)
                g.FillRectangle(aBrush, panelCircle.Width / 2, i, 3, 3);
            for (int i = 0; i < panelCircle.Width; i++)
                g.FillRectangle(aBrush, i, panelCircle.Height / 2, 3, 3);
        }

        private void circlePoint(int xc, int yc, int x, int y)
        {
            var aBrush = Brushes.Red;
            var g = panelCircle.CreateGraphics();
            XY_Axis(aBrush);
            g.FillRectangle(aBrush, ((panelCircle.Width / 2) + (xc + x)), ((panelCircle.Height / 2) - (yc + y)), 2, 2);
            g.FillRectangle(aBrush, ((panelCircle.Width / 2) + (xc - x)), ((panelCircle.Height / 2) - (yc + y)), 2, 2);
            g.FillRectangle(aBrush, ((panelCircle.Width / 2) + (xc + x)), ((panelCircle.Height / 2) - (yc - y)), 2, 2);
            g.FillRectangle(aBrush, ((panelCircle.Width / 2) + (xc - x)), ((panelCircle.Height / 2) - (yc - y)), 2, 2);
            g.FillRectangle(aBrush, ((panelCircle.Width / 2) + (xc + y)), ((panelCircle.Height / 2) - (yc + x)), 2, 2);
            g.FillRectangle(aBrush, ((panelCircle.Width / 2) + (xc - y)), ((panelCircle.Height / 2) - (yc + x)), 2, 2);
            g.FillRectangle(aBrush, ((panelCircle.Width / 2) + (xc + y)), ((panelCircle.Height / 2) - (yc - x)), 2, 2);
            g.FillRectangle(aBrush, ((panelCircle.Width / 2) + (xc - y)), ((panelCircle.Height / 2) - (yc - x)), 2, 2);
        }

        private void buttonDrawCircle_Click(object sender, EventArgs e)
        {
            int x_center = Convert.ToInt32(textBoxX.Text);
            int y_center = Convert.ToInt32(textBoxY.Text);
            int r = Convert.ToInt32(textBoxRadius.Text);
            int x = 0;
            int y = r;
            double pk = (1.25 - r);
            circlePoint(x_center, y_center, x, y);
            while (x < y)
            {
                if (pk < 0)
                {
                    x++;
                    pk = pk + (2 * x) + 1;
                }
                else
                {
                    x++;
                    y--;
                    pk = pk + (2 * x) + 1 - (2 * y);
                }
                circlePoint(x_center, y_center, x, y);
            }
        }

        private void buttonClearInputs_Click(object sender, EventArgs e)
        {
            textBoxX.Clear();
            textBoxY.Clear();
            textBoxRadius.Clear();
        }

        private void buttonClearCircle_Click(object sender, EventArgs e)
        {
            panelCircle.CreateGraphics().Clear(Color.Cyan);
        }

        private void buttonPrintTable_Click(object sender, EventArgs e)
        {
            int x_center = Convert.ToInt32(textBoxX.Text);
            int y_center = Convert.ToInt32(textBoxY.Text);
            int r = Convert.ToInt32(textBoxRadius.Text);
            int x = 0;
            int y = r;
            double pk = (1.25 - r);

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save As";
            saveFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFile.FileName = "Circle_Table.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string strPath = saveFile.FileName;
                StreamWriter sw = new StreamWriter(strPath);
                sw.WriteLine("\tDraw Bresenham Circle using (" + x_center + ", " + y_center + ") and Radius r = " + r);
                sw.WriteLine("\nPK\t (X, Y) \t 2X \t 2Y");
                sw.WriteLine(Math.Round(pk) + " \t (" + x + ", " + y + ") \t " + (2 * x) + " \t " + (2 * y));
                while (x < y)
                {
                    if (pk < 0)
                    {
                        x++;
                        pk = pk + (2 * x) + 1;
                    }
                    else
                    {
                        x++;
                        y--;
                        pk = pk + (2 * x) + 1 - (2 * y);
                    }
                    sw.WriteLine(Math.Round(pk) + " \t (" + x + ", " + y + ") \t " + (2 * x) + " \t " + (2 * y));
                }
                sw.Close();
            }
        }
    }
}