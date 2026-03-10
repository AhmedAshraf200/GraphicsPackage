using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GraphicsPackage
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void XY_Axis(Brush aBrush)
        {
            aBrush = Brushes.Black;
            var g = panelEllipse.CreateGraphics();
            for (int i = 0; i < panelEllipse.Height; i++)
                g.FillRectangle(aBrush, panelEllipse.Width / 2, i, 3, 3);
            for (int i = 0; i < panelEllipse.Width; i++)
                g.FillRectangle(aBrush, i, panelEllipse.Height / 2, 3, 3);
        }

        private void EllipsPoint(int xc, int yc, int x, int y)
        {
            var aBrush = Brushes.Maroon;
            var g = panelEllipse.CreateGraphics();
            XY_Axis(aBrush);
            g.FillRectangle(aBrush, ((panelEllipse.Width / 2) + (xc + x)), ((panelEllipse.Height / 2) - (yc + y)), 2, 2);
            g.FillRectangle(aBrush, ((panelEllipse.Width / 2) + (xc - x)), ((panelEllipse.Height / 2) - (yc + y)), 2, 2);
            g.FillRectangle(aBrush, ((panelEllipse.Width / 2) + (xc + x)), ((panelEllipse.Height / 2) - (yc - y)), 2, 2);
            g.FillRectangle(aBrush, ((panelEllipse.Width / 2) + (xc - x)), ((panelEllipse.Height / 2) - (yc - y)), 2, 2);
        }
        
        private void buttonDrawEllipse_Click(object sender, EventArgs e)
        {
            int x_center = Convert.ToInt32(textBoxXcenter.Text);
            int y_center = Convert.ToInt32(textBoxYcenter.Text);
            int rx = Convert.ToInt32(textBoxRadiusX.Text);
            int ry = Convert.ToInt32(textBoxRadiusY.Text);
            double x = 0;
            double y = ry;
            double pk = (ry * ry) - (rx * rx * ry) + (0.25 * rx * rx);
            EllipsPoint(x_center, y_center, (int)x, (int)y);
            while ((ry * ry * x) < (rx * rx * y))
            {
                x++;
                if (pk < 0)
                {
                    pk += (2 * ry * ry * x) + (ry * ry);
                }
                else
                {
                    y--;
                    pk += (2 * ry * ry * x) + (ry * ry) - (2 * rx * rx * y);
                }
                EllipsPoint(x_center, y_center, (int)x, (int)y);
            }
            pk = (((ry * ry) * ((x + 0.5) * (x + 0.5))) + ((rx * rx) * ((y - 1) * (y - 1))) - (rx * rx * ry * ry));
            while (y > 0)
            {
                y--;
                if (pk > 0)
                {
                    pk += (rx * rx) - (2 * rx * rx * y);
                }
                else
                {
                    x++;
                    pk += (rx * rx) - (2 * rx * rx * y) + (2 * ry * ry * x);
                }
                EllipsPoint(x_center, y_center, (int)x, (int)y);
            }
        }

        private void buttonClearInputs_Click(object sender, EventArgs e)
        {
            textBoxXcenter.Clear();
            textBoxYcenter.Clear();
            textBoxRadiusX.Clear();
            textBoxRadiusY.Clear();
        }

        private void buttonClearEllipse_Click(object sender, EventArgs e)
        {
            panelEllipse.CreateGraphics().Clear(Color.Magenta);
        }

        private void buttonPrintEllipseTable_Click(object sender, EventArgs e)
        {
            int x_center = Convert.ToInt32(textBoxXcenter.Text);
            int y_center = Convert.ToInt32(textBoxYcenter.Text);
            int rx = Convert.ToInt32(textBoxRadiusX.Text);
            int ry = Convert.ToInt32(textBoxRadiusY.Text);
            double x = 0;
            double y = ry;
            double pk = (ry * ry) - (rx * rx * ry) + (0.25 * rx * rx);

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save As";
            saveFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFile.FileName = "Ellipse_Table.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string strPath = saveFile.FileName;
                StreamWriter sw = new StreamWriter(strPath);
                sw.WriteLine("\tDraw Ellipse Algorithm using point (" + x_center + ", " + y_center + ") and Radius rx = " + rx+", ry = "+ry);
                sw.WriteLine("first one");
                sw.WriteLine("x=" + x + "\t" + "y=" + y + "\t" + "pk= " + Math.Round(pk));
                while ((ry * ry * x) < (rx * rx * y))
                {
                    x++;
                    if (pk < 0)
                    {
                        pk += (2 * ry * ry * x) + (ry * ry);
                    }
                    else
                    {
                        y--;
                        pk += (2 * ry * ry * x) + (ry * ry) - (2 * rx * rx * y);
                    }
                    sw.WriteLine("x=" + x + "\t" + "y=" + y + "\t" + "pk=" + Math.Round(pk));
                }
                sw.WriteLine("second one");
                pk = (((ry * ry) * ((x + 0.5) * (x + 0.5))) + ((rx * rx) * ((y - 1) * (y - 1))) - (rx * rx * ry * ry));
                sw.WriteLine("x=" + x + "\t" + "y=" + y + "\t" + "pk= " + Math.Round(pk));
                while (y > 0)
                {
                    y--;
                    if (pk > 0)
                    {
                        pk += (rx * rx) - (2 * rx * rx * y);
                    }
                    else
                    {
                        x++;
                        pk += (rx * rx) - (2 * rx * rx * y) + (2 * ry * ry * x);
                    }
                    sw.WriteLine("x=" + x + "\t" + "y=" + y + "\t" + "pk= " + Math.Round(pk));
                }
                sw.Close();
            }
        }
    }
}
