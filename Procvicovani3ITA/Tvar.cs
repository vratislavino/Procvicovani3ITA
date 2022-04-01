using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procvicovani3ITA
{
    public abstract class Tvar
    {
        private Size size;
        protected Point position;
        protected Pen outlineColor;
        protected Brush color;

        public int X => position.X;
        public int Y => position.Y;

        public int Width
        {
            get { return size.Width; }
            set
            {
                if(value > 0) {
                    size.Width = value;
                } else {
                    Console.WriteLine("Hej, v klidu, dávám výchozí velikost 1");
                    size.Width = 1;
                }
            }
        }

        public int Height
        {
            get { return size.Height; }
            set
            {
                if (value > 0)
                {
                    size.Height = value;
                }
                else
                {
                    Console.WriteLine("Hej, v klidu, dávám výchozí velikost 1");
                    size.Height = 1;
                }
            }
        }

        public Tvar(Point position)
        {
            this.position = position;
            this.size = new Size(1,1);
        }

        public abstract bool IsMouseOverObject(Point mousePos);

        public abstract void Draw(Graphics g);
    }
}
