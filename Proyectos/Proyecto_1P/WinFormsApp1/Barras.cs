using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class Barras : IAnimacion
    {
        public Barras() { }
        public void Dibujar(Graphics g, int[] values, PictureBox canvas, int currentStep)
        {
            int barWidth = canvas.Width / values.Length;
            for (int i = 0; i < values.Length; i++)
            {
                int x = i * barWidth;
                int y = canvas.Height - values[i];
                g.DrawLine(Pens.Lime, x, canvas.Height, x, y);
            }
        }
    }
}
