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
    public partial class Form5 : Form
    {
        private double Dx = 0, Dy = 0;
        private double[,] Points = new double[3, 2];
        private double[,] Translation;
        private double[] Scalling;
        private double[] Reflection;
        private double[] Shearing;
        private double angle;
        public Form5()
        {
            InitializeComponent();
            chart1.Titles.Add("2D Geometric Transformation");
            Translation = new double[3, 3] { { 1, 0, Dx }, { 0, 1, Dy }, { 0, 0, 1 } };
            Scalling = new double[2];
            Reflection = new double[2];
            Shearing = new double[2];
        }

        private void panelBackground_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonClearPoints_Click(object sender, EventArgs e)
        {
            textBoxX1triangle.Clear();
            textBoxX2triangle.Clear();
            textBoxX3triangle.Clear();
            textBoxY1triangle.Clear();
            textBoxY2triangle.Clear();
            textBoxY3triangle.Clear();
        }

        private void buttonClearInputs_Click(object sender, EventArgs e)
        {
            textBoxXTranslation.Clear();
            textBoxYTranslation.Clear();
            textBoxXScalling.Clear();
            textBoxYScalling.Clear();
            textBoxXReflection.Clear();
            textBoxYReflection.Clear();
            textBoxXShearing.Clear();
            textBoxYShearing.Clear();
            textBoxAngleRotation.Clear();
        }

        private void checkBoxTranslation_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTranslation.Checked == true)
            {
                listBoxReadOperations.Items.Add("Translation");
            }
            else
                listBoxReadOperations.Items.Remove("Translation");
        }

        private void checkBoxScalling_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxScalling.Checked == true)
            {
                listBoxReadOperations.Items.Add("Scalling");
            }
            else
                listBoxReadOperations.Items.Remove("Scalling");
        }

        private void checkBoxReflection_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxReflection.Checked == true)
            {
                listBoxReadOperations.Items.Add("Reflection");
            }
            else
                listBoxReadOperations.Items.Remove("Reflection");
        }

        private void checkBoxShearing_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShearing.Checked == true)
            {
                listBoxReadOperations.Items.Add("Shearing");
            }
            else
                listBoxReadOperations.Items.Remove("Shearing");
        }

        private void checkBoxRotation_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRotation.Checked == true)
            {
                listBoxReadOperations.Items.Add("Rotation");
            }
            else
                listBoxReadOperations.Items.Remove("Rotation");
        }

        private void buttonClearOperations_Click(object sender, EventArgs e)
        {
            chart1.Series["TranslationShap"].Points.Clear();
            chart1.Series["ScalingShap"].Points.Clear();
            chart1.Series["RotationShap"].Points.Clear();
            chart1.Series["ReflictionShap"].Points.Clear();
            chart1.Series["ShearingShap"].Points.Clear();
        }

        private void buttonClearTriangle_Click(object sender, EventArgs e)
        {
            chart1.Series["Shape1"].Points.Clear();
        }

        private void buttonDrawOperations_Click(object sender, EventArgs e)
        {
            if (checkBoxTranslation.Checked == true)
            {
                Translation[0, 2] = Convert.ToDouble(textBoxXTranslation.Text);
                Translation[1, 2] = Convert.ToDouble(textBoxYTranslation.Text);
                for (int i = 0; i < 3; i++)
                {
                    Points[i, 0] += Translation[0, 2];
                    Points[i, 1] += Translation[1, 2];
                    chart1.Series["TranslationShap"].Points.AddXY(Points[i, 0], Points[i, 1]);
                }
                chart1.Series["TranslationShap"].Points.AddXY(Points[0, 0], Points[0, 1]);
            }

            if (checkBoxScalling.Checked == true)
            {
                Scalling[0] = Convert.ToDouble(textBoxXScalling.Text);
                Scalling[1] = Convert.ToDouble(textBoxYScalling.Text);
                for (int i = 0; i < 3; i++)
                {
                    Points[i, 0] *= Scalling[0];
                    Points[i, 1] *= Scalling[1];
                    chart1.Series["ScalingShap"].Points.AddXY(Points[i, 0], Points[i, 1]);
                }
                chart1.Series["ScalingShap"].Points.AddXY(Points[0, 0], Points[0, 1]);
            }

            if (checkBoxReflection.Checked == true)
            {
                Reflection[0] = Convert.ToDouble(textBoxXReflection.Text);
                Reflection[1] = Convert.ToDouble(textBoxYReflection.Text);
                for (int i = 0; i < 3; i++)
                {
                    Points[i, 0] *= Reflection[0];
                    Points[i, 1] *= Reflection[1];
                    chart1.Series["ReflictionShap"].Points.AddXY(Points[i, 0], Points[i, 1]);
                }
                chart1.Series["ReflictionShap"].Points.AddXY(Points[0, 0], Points[0, 1]);
            }

            if (checkBoxShearing.Checked == true)
            {
                Shearing[0] = Convert.ToDouble(textBoxXShearing.Text);
                Shearing[1] = Convert.ToDouble(textBoxYShearing.Text);
                for (int i = 0; i < 3; i++)
                {
                    Points[i, 0] += Shearing[0] * Points[i, 1];
                    Points[i, 1] += Shearing[1] * Points[i, 0];
                    chart1.Series["ShearingShap"].Points.AddXY(Points[i, 0], Points[i, 1]);
                }
                chart1.Series["ShearingShap"].Points.AddXY(Points[0, 0], Points[0, 1]);
            }

            if (checkBoxRotation.Checked == true)
            {
                angle = Convert.ToDouble(textBoxAngleRotation.Text);
                for (int i = 0; i < 3; i++)
                {
                    double x = Points[i, 0];
                    double y = Points[i, 1];
                    x = Points[i, 0] * Math.Cos(angle) - Points[i, 1] * Math.Sin(angle);
                    y = Points[i, 0] * Math.Sin(angle) + Points[i, 1] * Math.Cos(angle);
                    chart1.Series["RotationShap"].Points.AddXY(x, y);
                    Points[i, 0] = x;
                    Points[i, 1] = y;
                }
                chart1.Series["RotationShap"].Points.AddXY(Points[0, 0], Points[0, 1]);
            }
        }

        private void buttonDrawTriangle_Click(object sender, EventArgs e)
        {
            Points[0, 0] = Convert.ToDouble(textBoxX1triangle.Text);
            Points[0, 1] = Convert.ToDouble(textBoxY1triangle.Text);
            Points[1, 0] = Convert.ToDouble(textBoxX2triangle.Text);
            Points[1, 1] = Convert.ToDouble(textBoxY2triangle.Text);
            Points[2, 0] = Convert.ToDouble(textBoxX3triangle.Text);
            Points[2, 1] = Convert.ToDouble(textBoxY3triangle.Text);
            for (int i = 0; i < 3; i++)
            {
                chart1.Series["Shape1"].Points.AddXY(Points[i, 0], Points[i, 1]);
            }
            chart1.Series["Shape1"].Points.AddXY(Points[0, 0], Points[0, 1]);
        }
    }
}
