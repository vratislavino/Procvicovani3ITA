using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procvicovani3ITA
{
    public class Elipsa : Tvar
    {
        public Elipsa(Point position) : base(position)
        {
            outlineColor = new Pen(Color.DarkRed, 3);
            color = new SolidBrush(Color.Red);
        }

        public override void Draw(Graphics g)
        {
            g.FillEllipse(CurrentColor, position.X, position.Y, Width, Height);
            g.DrawEllipse(CurrentOutlineColor, position.X, position.Y, Width, Height);
        }

        public override bool IsMouseOverObject(Point mousePos)
        {
            int cx = X + Width / 2;
            int cy = Y + Height / 2;

            return (Math.Pow(mousePos.X - cx, 2) / Math.Pow(Width / 2, 2) +
                   Math.Pow(mousePos.Y - cy, 2) / Math.Pow(Height / 2, 2)) < 1;
        }
    }
}
