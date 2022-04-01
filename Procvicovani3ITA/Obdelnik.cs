using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procvicovani3ITA
{
    public class Obdelnik : Tvar
    {
        public Obdelnik(Point position) : base(position)
        {
            outlineColor = new Pen(Color.DarkBlue, 3);
            color = new SolidBrush(Color.Blue);
        }

        public override void Draw(Graphics g)
        {
            g.FillRectangle(color, position.X, position.Y, Width, Height);
            g.DrawRectangle(outlineColor, position.X, position.Y, Width, Height);
        }

        public override bool IsMouseOverObject(Point mousePos)
        {
            return false;
        }
    }
}
