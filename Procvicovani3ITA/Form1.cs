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

        List<Tvar> shapes = new List<Tvar>();
        Tvar currentShape = null;

        public Form1()
        {
            InitializeComponent();
            shouldDraw = drawCheckbox.Checked;
        }

        private void drawCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            shouldDraw = drawCheckbox.Checked;
            canvas1.Refresh();
        }

        private void canvas1_Paint(object sender, PaintEventArgs e)
        {
            if (!shouldDraw) return;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            
            shapes.ForEach(shape => shape.Draw(e.Graphics));
        }

        private void canvas1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
                currentShape = new Obdelnik(e.Location);
            if(e.Button == MouseButtons.Right)
                currentShape = new Elipsa(e.Location);

            shapes.Add(currentShape);
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
            currentShape = null;
            canvas1.Refresh();
        }
    }
}
