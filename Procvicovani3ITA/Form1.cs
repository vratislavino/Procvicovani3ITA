using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procvicovani3ITA
{
    public partial class Form1 : Form
    {
        bool shouldDraw = false;
        bool holdingCtrl = false;

        List<Tvar> shapes = new List<Tvar>();
        Tvar currentShape = null;
        Tvar lastHighlightedShape = null;

        public Form1()
        {
            InitializeComponent();
            shouldDraw = drawCheckbox.Checked;
        }

        private void drawCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            shouldDraw = drawCheckbox.Checked;
            canvas1.Refresh();
            canvas1.Focus();
        }

        private void canvas1_Paint(object sender, PaintEventArgs e)
        {
            if (!shouldDraw) return;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            
            shapes.ForEach(shape => shape.Draw(e.Graphics));
            
            if(currentShape != null)
                currentShape.Draw(e.Graphics);
        }

        private void canvas1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if(holdingCtrl)
                {
                    SelectShape(e.Location);
                } else
                {
                    currentShape = new Obdelnik(e.Location);
                }
            }
            if(e.Button == MouseButtons.Right)
                currentShape = new Elipsa(e.Location);

            
            canvas1.Refresh();
        }

        private void canvas1_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentShape == null) return;

            currentShape.Width = e.X - currentShape.X;
            currentShape.Height = e.Y - currentShape.Y;
            canvas1.Refresh();
        }

        private void canvas1_MouseUp(object sender, MouseEventArgs e)
        {
            if(currentShape == null) return;

            shapes.Add(currentShape);
            currentShape.Highlighted = false;
            currentShape = null;
            canvas1.Refresh();
        }

        private void canvas1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
                holdingCtrl = true;
        }

        private void canvas1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
                holdingCtrl = false;
        }

        private void SelectShape(Point mousePos)
        {
            for (int i = shapes.Count-1; i >= 0; i--)
            {
                if(shapes[i].IsMouseOverObject(mousePos))
                {

                    if (lastHighlightedShape != null)
                        lastHighlightedShape.Highlighted = false;

                    shapes[i].Highlighted = true;
                    lastHighlightedShape = shapes[i];
                    //currentShape = shapes[i];
                    return;
                }
            }
            if (lastHighlightedShape != null)
            {
                lastHighlightedShape.Highlighted = false;
                lastHighlightedShape = null;
            }
        }
    }
}
