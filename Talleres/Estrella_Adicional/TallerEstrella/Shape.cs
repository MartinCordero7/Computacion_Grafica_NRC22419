using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerEstrella
{
    abstract class Shape
    {
        protected float radius = 50;
        protected float angle = 0;
        protected float scale = 1;
        protected int offsetX = 0;
        protected int offsetY = 0;
        protected Pen pen = new Pen(Color.Blue, 3);

        public virtual void SetScale(float value)
        {
            scale = value / 10.0f;
        }

        public virtual void RotateClockwise()
        {
            angle += (float)(Math.PI / 18);
        }

        public virtual void RotateCounterClockwise()
        {
            angle -= (float)(Math.PI / 18);
        }

        public virtual void MoveUp()
        {
            offsetY -= 10;
        }

        public virtual void MoveDown()
        {
            offsetY += 10;
        }

        public virtual void MoveLeft()
        {
            offsetX -= 10;
        }

        public virtual void MoveRight()
        {
            offsetX += 10;
        }

        public abstract void ReadData(TextBox txtRadius);
        public abstract void PlotShape(PictureBox picCanvas);
    }


}
