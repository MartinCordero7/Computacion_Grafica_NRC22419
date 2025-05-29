using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class Rombos : IAnimacion
    {
        public Rombos() { }
        public void Dibujar(Graphics g, int[] values, PictureBox canvas, int currentStep)
        {
            for (int i = 0; i < values.Length - 1; i += 2)
            {
                int x1 = i * canvas.Width / values.Length;
                int y1 = canvas.Height / 2 - values[i];
                int x2 = (i + 1) * canvas.Width / values.Length;
                int y2 = canvas.Height / 2 + values[i + 1];
                g.DrawLine(Pens.Cyan, x1, y1, x2, y2);
                g.DrawLine(Pens.Cyan, x1, y2, x2, y1);
            }
        }
    }
}
