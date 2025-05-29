using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class Circular : IAnimacion
    {
        public Circular() { }
        public void Dibujar(Graphics g, int[] values, PictureBox canvas, int currentStep)
        {
            int cx = canvas.Width / 2;
            int cy = canvas.Height / 2;
            int radius = Math.Min(cx, cy) - 10;

            for (int i = 0; i < values.Length; i++)
            {
                double angle = 2 * Math.PI * i / values.Length;
                int x1 = cx + (int)(Math.Cos(angle) * radius);
                int y1 = cy + (int)(Math.Sin(angle) * radius);
                int x2 = cx + (int)(Math.Cos(angle) * (radius - values[i] / 3));
                int y2 = cy + (int)(Math.Sin(angle) * (radius - values[i] / 3));
                g.DrawLine(Pens.Orange, x1, y1, x2, y2);
            }
        }
    }
}
