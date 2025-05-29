using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class Rejillas : IAnimacion
    {
        public Rejillas() { }
        public void Dibujar(Graphics g, int[] values, PictureBox canvas, int currentStep)
        {
            int spacing = canvas.Width / 20;
            for (int x = 0; x < canvas.Width; x += spacing)
            {
                for (int y = 0; y < canvas.Height; y += spacing)
                {
                    int offset = (int)(Math.Sin((x + y + currentStep * 10) * 0.01) * 10);
                    g.DrawLine(Pens.LightGreen, x, y, x + offset, y + offset);
                }
            }
        }
    }
}
