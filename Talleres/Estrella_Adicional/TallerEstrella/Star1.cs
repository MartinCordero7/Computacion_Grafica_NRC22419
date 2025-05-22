
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerEstrella;

namespace Figuras
{
    public partial class frmStar1 : Form
    {
        private Star currentShape = new Star();

        public frmStar1()
        {
            InitializeComponent();
        }
        private void frmStar1_Load(object sender, EventArgs e)
        {
            txtRadius.Text = "";
            txtRadius.Focus();
            picCanvas.Refresh();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            currentShape.ReadData(txtRadius);
            currentShape.PlotShape(picCanvas);
        }

        private void btnClockwise_Click(object sender, EventArgs e)
        {
            currentShape.RotateClockwise();
            currentShape.PlotShape(picCanvas);
        }

        private void btnCounterclockwise_Click(object sender, EventArgs e)
        {
            currentShape.RotateCounterClockwise();
            currentShape.PlotShape(picCanvas);
        }

        private void tbScale_Scroll(object sender, EventArgs e)
        {
            float value = tbScale.Value + float.Parse(txtRadius.Text);
            currentShape.SetScale(value);
            currentShape.PlotShape(picCanvas);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            currentShape.MoveUp();
            currentShape.PlotShape(picCanvas);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            currentShape.MoveDown();
            currentShape.PlotShape(picCanvas);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            currentShape.MoveLeft();
            currentShape.PlotShape(picCanvas);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            currentShape.MoveRight();
            currentShape.PlotShape(picCanvas);
        }

    }
    class Star : Shape
    {
        private int numPoints = 5;

        public override void ReadData(TextBox txtRadius)
        {
            try
            {
                radius = float.Parse(txtRadius.Text);
                if(radius < 25)
                {
                    MessageBox.Show("El radio debe ser mayor de 25 para que se muestre esta figura", "Error");
                    radius = 0;
                }
            }
            catch
            {
                MessageBox.Show("Radio no valido", "Error");
            }
        }

        public override void PlotShape(PictureBox picCanvas)
        {
            Graphics g = picCanvas.CreateGraphics();
            picCanvas.Refresh();

            float cx = picCanvas.Width / 2 + offsetX;
            float cy = picCanvas.Height / 2 + offsetY;

            float currentRadius = radius * scale;
            float minRadius = 15f;        // Detener cuando el radio llegue a 15
            float shrinkFactor = 0.6f;    // Controla la separación entre estrellas

            while (currentRadius >= minRadius)
            {
                PointF[] points = new PointF[numPoints * 2];
                double angleStep = Math.PI / numPoints;

                for (int i = 0; i < numPoints * 2; i++)
                {
                    float r = (i % 2 == 0) ? currentRadius : currentRadius / 2;
                    double angleNow = i * angleStep + angle - Math.PI / 2;

                    float x = cx + (float)(r * Math.Cos(angleNow));
                    float y = cy + (float)(r * Math.Sin(angleNow));

                    points[i] = new PointF(x, y);
                }

                g.DrawPolygon(pen, points);
                currentRadius *= shrinkFactor;
            }
        }

    }

}