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
            g.FillEllipse(color, position.X, position.Y, Width, Height);
            g.DrawEllipse(outlineColor, position.X, position.Y, Width, Height);
        }

        public override bool IsMouseOverObject(Point mousePos)
        {
            return false;
        }
    }
}
