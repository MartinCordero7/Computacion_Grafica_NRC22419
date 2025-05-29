using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class Radiantes : IAnimacion
    {
        public Radiantes() { }
        public void Dibujar(Graphics g, int[] values, PictureBox canvas, int currentStep)
        {
            int cx = canvas.Width / 2;
            int cy = canvas.Height / 2;

            for (int i = 0; i < values.Length; i++)
            {
                double angle = i * Math.PI / values.Length;
                int x = cx + (int)(Math.Cos(angle) * values[i]);
                int y = cy + (int)(Math.Sin(angle) * values[i]);
                g.DrawLine(Pens.LightBlue, cx, cy, x, y);
            }
        }
    }
}
