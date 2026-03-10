using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace GraphicsPackage
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void XY_Axis(Brush aBrush)
        {
            aBrush = Brushes.Black;
            var g = panelLine.CreateGraphics();
            for (int i = 0; i < panelLine.Height; i++)
                g.FillRectangle(aBrush, panelLine.Width / 2, i, 3, 3);
            for (int i = 0; i < panelLine.Width; i++)
                g.FillRectangle(aBrush, i, panelLine.Height / 2, 3, 3);
        }

        static int GetOctant(int x1, int y1, int x2, int y2)
        {
            // check slope 
            float slope = (float)(y2 - y1) / (x2 - x1);
            Console.WriteLine("slope is " + slope);

            int Octant;
            // get the Octant
            if (slope >= 0) // 1st , 2nd , 5th , 6th
            {
                if (slope <= 1) //1st , 5th
                {
                    if (x1 < x2) Octant = 1;
                    else Octant = 5;
                }
                else // 2nd , 6th
                {
                    if (y1 < y2) Octant = 2;
                    else Octant = 6;
                }
            }
            else // 3rd , 4th , 7th , 8th
            {
                if (slope < -1) //3rd , 7th
                {
                    if (y1 < y2) Octant = 3;
                    else Octant = 7;
                }
                else // 4th , 8th
                {
                    if (x1 > x2) Octant = 4;
                    else Octant = 8;
                }
            }
            return Octant;
        }

        static int[] Swap(int x, int y)
        {
            int[] temp = new int[2];
            temp[0] = y;
            temp[1] = x;
            return temp;
        }

        private void buttonDDA_Click(object sender, EventArgs e)
        {
            var aBrush = Brushes.Blue;
            var g = panelLine.CreateGraphics();
            XY_Axis(aBrush);

            int x1 = Convert.ToInt32(textBoxX1.Text);
            int y1 = Convert.ToInt32(textBoxY1.Text);
            int x2 = Convert.ToInt32(textBoxX2.Text);
            int y2 = Convert.ToInt32(textBoxY2.Text);
            int dx = x2 -  x1, dy = y2 - y1, steps;
            float x_increment, y_increment, x = x1, y = y1;

            steps = Math.Max(Math.Abs(dx), Math.Abs(dy));

            x_increment = (float)dx / (float)steps;
            y_increment = (float)dy / (float)steps;

            g.FillRectangle(aBrush, ((int)Math.Round(x) + (panelLine.Width / 2)), ((panelLine.Height / 2) - (int)Math.Round(y)) ,2, 2);
            for (int k = 0; k < steps; k++)
            {
                x += x_increment;
                y += y_increment;
                g.FillRectangle(aBrush, ((int)Math.Round(x) + (panelLine.Width / 2)), ((panelLine.Height / 2) - (int)Math.Round(y)), 2, 2);
            }
        }

        private void buttonClearPoints_Click(object sender, EventArgs e)
        {
            textBoxX1.Clear();
            textBoxY1.Clear();
            textBoxX2.Clear();
            textBoxY2.Clear();
        }

        private void buttonClearLine_Click(object sender, EventArgs e)
        {
            panelLine.CreateGraphics().Clear(Color.Yellow);
        }

        private void buttonDDA_Table_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(textBoxX1.Text);
            int y1 = Convert.ToInt32(textBoxY1.Text);
            int x2 = Convert.ToInt32(textBoxX2.Text);
            int y2 = Convert.ToInt32(textBoxY2.Text);
            int dx = x2 - x1, dy = y2 - y1, steps;
            float x_increment, y_increment, x = x1, y = y1;
            steps = Math.Max(Math.Abs(dx), Math.Abs(dy));
            x_increment = (float)dx / (float)steps;
            y_increment = (float)dy / (float)steps;

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save As";
            saveFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFile.FileName = "DDA_Table.txt";
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                string strPath = saveFile.FileName;
                StreamWriter sw = new StreamWriter(strPath);
                sw.WriteLine("\tDraw DDA Line form (" + x1 + ", " + y1 + ") to (" + x2 + ", " + y2 + ")");
                sw.WriteLine("\nX\t Y \t (X, Y)");
                for (int k = 0; k < steps; k++)
                {
                    x += x_increment;
                    y += y_increment;
                    sw.WriteLine(Math.Round(x, 2) + " \t " + Math.Round(y, 2) + " \t (" + Math.Round(x) + ", " + Math.Round(y) + ")");
                }
                sw.Close();
            }
        }

        private void buttonBresenham_Click(object sender, EventArgs e)
        {
            var aBrush = Brushes.Red;
            var g = panelLine.CreateGraphics();
            XY_Axis(aBrush);

            int x1 = Convert.ToInt32(textBoxX1.Text);
            int y1 = Convert.ToInt32(textBoxY1.Text);
            int x2 = Convert.ToInt32(textBoxX2.Text);
            int y2 = Convert.ToInt32(textBoxY2.Text);
            int Octant = GetOctant(x1, y1, x2, y2);
            Console.WriteLine("Octant is " + Octant);

            // Get dx, dy, p0
            int dx, dy, p0, Dc, Xk, Yk, Pk;
            switch (Octant)
            {
                case 1: //Without Changes
                    dx = x2 - x1;
                    dy = y2 - y1;
                    p0 = 2 * dy - dx;
                    Dc = 2 * dy - 2 * dx;
                    Xk = x1; Yk = y1; Pk = p0;
                    while ((Xk != x2))
                    {
                        g.FillRectangle(aBrush, ((panelLine.Width / 2) + Xk), ((panelLine.Height / 2) - Yk), 2, 2);
                        if (Pk >= 0)
                        { Xk++; Yk++; Pk += Dc; }
                        else
                        { Xk++; Pk += 2 * dy; }
                        Console.WriteLine("(" + Xk + "," + Yk + ")");
                    }
                    break;
                case 2://Swap(x1,y1) & Swap(x2,y2)
                    int[] Point1 = Swap(x1, y1);
                    int[] Point2 = Swap(x2, y2);
                    x1 = Point1[0]; y1 = Point1[1];
                    x2 = Point2[0]; y2 = Point2[1];
                    dx = x2 - x1;
                    dy = y2 - y1;
                    p0 = 2 * dy - dx;
                    Dc = 2 * dy - 2 * dx;
                    Xk = x1; Yk = y1; Pk = p0;
                    while ((Xk != x2))
                    {
                        g.FillRectangle(aBrush, ((panelLine.Width / 2) + Yk), ((panelLine.Height / 2) - Xk), 2, 2);
                        if (Pk >= 0)
                        { Xk++; Yk++; Pk += Dc; }
                        else
                        { Xk++; Pk += 2 * dy; }
                        Console.WriteLine("(" + Xk + "," + Yk + ")");
                    }
                    break;

                case 3://Swap(x1,y1) , Swap(x2,y2) , Set dy = -dy & Dectrment Y
                    Point1 = Swap(x1, y1);
                    Point2 = Swap(x2, y2);
                    x1 = Point1[0]; y1 = Point1[1];
                    x2 = Point2[0]; y2 = Point2[1];
                    dx = x2 - x1;
                    dy = (y2 - y1) * (-1);
                    p0 = 2 * dy - dx;
                    Dc = 2 * dy - 2 * dx;
                    Xk = x1; Yk = y1; Pk = p0;
                    while ((Xk != x2))
                    {
                        g.FillRectangle(aBrush, ((panelLine.Width / 2) + Yk), ((panelLine.Height / 2) - Xk), 2, 2);
                        if (Pk >= 0)
                        { Xk++; Yk--; Pk += Dc; }
                        else
                        { Xk++; Pk += 2 * dy; }
                        Console.WriteLine("(" + Xk + "," + Yk + ")");
                    }
                    break;
                case 4://Set dx = -dx & Decrement X
                    dx = (x2 - x1) * (-1);
                    dy = y2 - y1;
                    p0 = 2 * dy - dx;
                    Dc = 2 * dy - 2 * dx;
                    Xk = x1; Yk = y1; Pk = p0;
                    while ((Xk != x2))
                    {
                        g.FillRectangle(aBrush, ((panelLine.Width / 2) + Xk), ((panelLine.Height / 2) - Yk), 2, 2);
                        if (Pk >= 0)
                        { Xk--; Yk++; Pk += Dc; }
                        else
                        { Xk--; Pk += 2 * dy; }
                        Console.WriteLine("(" + Xk + "," + Yk + ")");
                    }
                    break;
                case 5://Set dx = -dx , Set dy = -dy , Decrement x & Decrement y
                    dx = (x2 - x1) * (-1);
                    dy = (y2 - y1) * (-1);
                    p0 = 2 * dy - dx;
                    Dc = 2 * dy - 2 * dx;
                    Xk = x1; Yk = y1; Pk = p0;
                    while ((Xk != x2))
                    {
                        g.FillRectangle(aBrush, ((panelLine.Width / 2) + Xk), ((panelLine.Height / 2) - Yk), 2, 2);
                        if (Pk >= 0)
                        { Xk--; Yk--; Pk += Dc; }
                        else
                        { Xk--; Pk += 2 * dy; }
                        Console.WriteLine("(" + Xk + "," + Yk + ")");
                    }
                    break;
                case 6://Swap(x1,y1) , Swap(x2,y2) , Set dx = -dx , Set dy = -dy , Dectrment x & Dectrment Y
                    Point1 = Swap(x1, y1);
                    Point2 = Swap(x2, y2);
                    x1 = Point1[0]; y1 = Point1[1];
                    x2 = Point2[0]; y2 = Point2[1];
                    dx = (x2 - x1) * (-1);
                    dy = (y2 - y1) * (-1);
                    p0 = 2 * dy - dx;
                    Dc = 2 * dy - 2 * dx;
                    Xk = x1; Yk = y1; Pk = p0;
                    while ((Xk != x2))
                    {
                        g.FillRectangle(aBrush, ((panelLine.Width / 2) + Yk), ((panelLine.Height / 2) - Xk), 2, 2);
                        if (Pk >= 0)
                        { Xk--; Yk--; Pk += Dc; }
                        else
                        { Xk--; Pk += 2 * dy; }
                        Console.WriteLine("(" + Xk + "," + Yk + ")");
                    }
                    break;
                case 7://Swap(x1,y1) , Swap(x2,y2) , Set dx = -dx & Dectrment x 
                    Point1 = Swap(x1, y1);
                    Point2 = Swap(x2, y2);
                    x1 = Point1[0]; y1 = Point1[1];
                    x2 = Point2[0]; y2 = Point2[1];
                    dx = (x2 - x1) * (-1);
                    dy = y2 - y1;
                    p0 = 2 * dy - dx;
                    Dc = 2 * dy - 2 * dx;
                    Xk = x1; Yk = y1; Pk = p0;
                    while ((Xk != x2))
                    {
                        g.FillRectangle(aBrush, ((panelLine.Width / 2) + Yk), ((panelLine.Height / 2) - Xk), 2, 2);
                        if (Pk >= 0)
                        { Xk--; Yk++; Pk += Dc; }
                        else
                        { Xk--; Pk += 2 * dy; }
                        Console.WriteLine("(" + Xk + "," + Yk + ")");
                    }
                    break;
                case 8://Set dy = -dy & Dectrment Y
                    dx = x2 - x1;
                    dy = (y2 - y1) * (-1);
                    p0 = 2 * dy - dx;
                    Dc = 2 * dy - 2 * dx;
                    Xk = x1; Yk = y1; Pk = p0;
                    while ((Xk != x2))
                    {
                        g.FillRectangle(aBrush, (panelLine.Width / 2) + Xk, ((panelLine.Height / 2) - Yk), 2, 2);
                        if (Pk >= 0)
                        { Xk++; Yk--; Pk += Dc; }
                        else
                        { Xk++; Pk += 2 * dy; }
                        Console.WriteLine("(" + Xk + "," + Yk + ")");
                    }
                    break;
            }
        }

        private void buttonBresenham_Table_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(textBoxX1.Text);
            int y1 = Convert.ToInt32(textBoxY1.Text);
            int x2 = Convert.ToInt32(textBoxX2.Text);
            int y2 = Convert.ToInt32(textBoxY2.Text);
            int Octant = GetOctant(x1, y1, x2, y2);
            // Get dx, dy, p0
            int dx, dy, p0, Dc, Xk, Yk, Pk;
            Console.WriteLine("Octant is " + Octant);

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save As";
            saveFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFile.FileName = "Bresenham_Table.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string strPath = saveFile.FileName;
                StreamWriter sw = new StreamWriter(strPath);
                sw.WriteLine("\tDraw Bresenham Line form (" + x1 + ", " + y1 + ") to (" + x2 + ", " + y2 + ")");
                sw.WriteLine("\nPK\t X \t Y \t (X, Y)");
                switch (Octant)
                {
                    case 1: //Without Changes
                        dx = x2 - x1;
                        dy = y2 - y1;
                        p0 = 2 * dy - dx;
                        Dc = 2 * dy - 2 * dx;
                        Xk = x1; Yk = y1; Pk = p0;
                        while ((Xk != x2))
                        {
                            if (Pk >= 0)
                            { Xk++; Yk++; Pk += Dc; }
                            else
                            { Xk++; Pk += 2 * dy; }
                            Console.WriteLine("(" + Xk + "," + Yk + ")");
                            sw.WriteLine(Pk + " \t " + Xk + " \t " + Yk + " \t (" + Xk + ", " + Yk + ")");
                        }
                        break;
                    case 2://Swap(x1,y1) & Swap(x2,y2)
                        int[] Point1 = Swap(x1, y1);
                        int[] Point2 = Swap(x2, y2);
                        x1 = Point1[0]; y1 = Point1[1];
                        x2 = Point2[0]; y2 = Point2[1];
                        dx = x2 - x1;
                        dy = y2 - y1;
                        p0 = 2 * dy - dx;
                        Dc = 2 * dy - 2 * dx;
                        Xk = x1; Yk = y1; Pk = p0;
                        while ((Xk != x2))
                        {
                            if (Pk >= 0)
                            { Xk++; Yk++; Pk += Dc; }
                            else
                            { Xk++; Pk += 2 * dy; }
                            Console.WriteLine("(" + Xk + "," + Yk + ")");
                            sw.WriteLine(Pk + " \t " + Yk + " \t " + Xk + " \t (" + Yk + ", " + Xk + ")");
                        }
                        break;

                    case 3://Swap(x1,y1) , Swap(x2,y2) , Set dy = -dy & Dectrment Y
                        Point1 = Swap(x1, y1);
                        Point2 = Swap(x2, y2);
                        x1 = Point1[0]; y1 = Point1[1];
                        x2 = Point2[0]; y2 = Point2[1];
                        dx = x2 - x1;
                        dy = (y2 - y1) * (-1);
                        p0 = 2 * dy - dx;
                        Dc = 2 * dy - 2 * dx;
                        Xk = x1; Yk = y1; Pk = p0;
                        while ((Xk != x2))
                        {
                            if (Pk >= 0)
                            { Xk++; Yk--; Pk += Dc; }
                            else
                            { Xk++; Pk += 2 * dy; }
                            Console.WriteLine("(" + Xk + "," + Yk + ")");
                            sw.WriteLine(Pk + " \t " + Yk + " \t " + Xk + " \t (" + Yk + ", " + Xk + ")");
                        }
                        break;
                    case 4://Set dx = -dx & Decrement X
                        dx = (x2 - x1) * (-1);
                        dy = y2 - y1;
                        p0 = 2 * dy - dx;
                        Dc = 2 * dy - 2 * dx;
                        Xk = x1; Yk = y1; Pk = p0;
                        while ((Xk != x2))
                        {
                            if (Pk >= 0)
                            { Xk--; Yk++; Pk += Dc; }
                            else
                            { Xk--; Pk += 2 * dy; }
                            Console.WriteLine("(" + Xk + "," + Yk + ")");
                            sw.WriteLine(Pk + " \t " + Xk + " \t " + Yk + " \t (" + Xk + ", " + Yk + ")");
                        }
                        break;
                    case 5://Set dx = -dx , Set dy = -dy , Decrement x & Decrement y
                        dx = (x2 - x1) * (-1);
                        dy = (y2 - y1) * (-1);
                        p0 = 2 * dy - dx;
                        Dc = 2 * dy - 2 * dx;
                        Xk = x1; Yk = y1; Pk = p0;
                        while ((Xk != x2))
                        {
                            if (Pk >= 0)
                            { Xk--; Yk--; Pk += Dc; }
                            else
                            { Xk--; Pk += 2 * dy; }
                            Console.WriteLine("(" + Xk + "," + Yk + ")");
                            sw.WriteLine(Pk + " \t " + Xk + " \t " + Yk + " \t (" + Xk + ", " + Yk + ")");
                        }
                        break;
                    case 6://Swap(x1,y1) , Swap(x2,y2) , Set dx = -dx , Set dy = -dy , Dectrment x & Dectrment Y
                        Point1 = Swap(x1, y1);
                        Point2 = Swap(x2, y2);
                        x1 = Point1[0]; y1 = Point1[1];
                        x2 = Point2[0]; y2 = Point2[1];
                        dx = (x2 - x1) * (-1);
                        dy = (y2 - y1) * (-1);
                        p0 = 2 * dy - dx;
                        Dc = 2 * dy - 2 * dx;
                        Xk = x1; Yk = y1; Pk = p0;
                        while ((Xk != x2))
                        {
                            if (Pk >= 0)
                            { Xk--; Yk--; Pk += Dc; }
                            else
                            { Xk--; Pk += 2 * dy; }
                            Console.WriteLine("(" + Xk + "," + Yk + ")");
                            sw.WriteLine(Pk + " \t " + Yk + " \t " + Xk + " \t (" + Yk + ", " + Xk + ")");
                        }
                        break;
                    case 7://Swap(x1,y1) , Swap(x2,y2) , Set dx = -dx & Dectrment x 
                        Point1 = Swap(x1, y1);
                        Point2 = Swap(x2, y2);
                        x1 = Point1[0]; y1 = Point1[1];
                        x2 = Point2[0]; y2 = Point2[1];
                        dx = (x2 - x1) * (-1);
                        dy = y2 - y1;
                        p0 = 2 * dy - dx;
                        Dc = 2 * dy - 2 * dx;
                        Xk = x1; Yk = y1; Pk = p0;
                        while ((Xk != x2))
                        {
                            if (Pk >= 0)
                            { Xk--; Yk++; Pk += Dc; }
                            else
                            { Xk--; Pk += 2 * dy; }
                            Console.WriteLine("(" + Xk + "," + Yk + ")");
                            sw.WriteLine(Pk + " \t " + Yk + " \t " + Xk + " \t (" + Yk + ", " + Xk + ")");
                        }
                        break;
                    case 8://Set dy = -dy & Dectrment Y
                        dx = x2 - x1;
                        dy = (y2 - y1) * (-1);
                        p0 = 2 * dy - dx;
                        Dc = 2 * dy - 2 * dx;
                        Xk = x1; Yk = y1; Pk = p0;
                        while ((Xk != x2))
                        {
                            if (Pk >= 0)
                            { Xk++; Yk--; Pk += Dc; }
                            else
                            { Xk++; Pk += 2 * dy; }
                            Console.WriteLine("(" + Xk + "," + Yk + ")");
                            sw.WriteLine(Pk + " \t " + Xk + " \t " + Yk + " \t (" + Xk + ", " + Yk + ")");
                        }
                        break;
                }
                sw.Close();
            }
        }
    }
}