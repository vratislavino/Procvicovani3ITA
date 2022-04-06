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
    public partial class TvarProperties : UserControl
    {
        public event Action SendUpRequested;
        public event Action SendDownRequested;

        private Tvar tvar;

        public Tvar Tvar
        {
            get { return tvar; }
            set { 
                tvar = value;
                SetProperties();
            }
        }

        public TvarProperties()
        {
            InitializeComponent();
        }

        private void SetProperties()
        {
            if(tvar == null)
            {
                this.Visible = false;
                return;
            }
            this.Visible = true;

            label1.Text = $"{ tvar.GetType().Name }";
            label2.Text = $"X: {tvar.X}";
            label3.Text = $"Y: {tvar.Y}";
            label4.Text = $"Šířka: {tvar.Width}";
            label5.Text = $"Výška: {tvar.Height}";
        }

        private void button1_Click(object sender, EventArgs e)
        { // o vrstvu výš
            SendUpRequested?.Invoke();
        }

        private void button2_Click(object sender, EventArgs e)
        { // o vrstvu níž
            SendDownRequested?.Invoke();
        }
    }
}
