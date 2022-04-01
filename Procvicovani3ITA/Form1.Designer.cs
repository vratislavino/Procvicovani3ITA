namespace Procvicovani3ITA
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawCheckbox = new System.Windows.Forms.CheckBox();
            this.canvas1 = new Procvicovani3ITA.Canvas();
            this.SuspendLayout();
            // 
            // drawCheckbox
            // 
            this.drawCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.drawCheckbox.AutoSize = true;
            this.drawCheckbox.Location = new System.Drawing.Point(862, 612);
            this.drawCheckbox.Name = "drawCheckbox";
            this.drawCheckbox.Size = new System.Drawing.Size(65, 17);
            this.drawCheckbox.TabIndex = 0;
            this.drawCheckbox.Text = "Vykreslit";
            this.drawCheckbox.UseVisualStyleBackColor = true;
            this.drawCheckbox.CheckedChanged += new System.EventHandler(this.drawCheckbox_CheckedChanged);
            // 
            // canvas1
            // 
            this.canvas1.BackColor = System.Drawing.Color.White;
            this.canvas1.Location = new System.Drawing.Point(12, 12);
            this.canvas1.Name = "canvas1";
            this.canvas1.Size = new System.Drawing.Size(918, 587);
            this.canvas1.TabIndex = 1;
            this.canvas1.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas1_Paint);
            this.canvas1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.canvas1_KeyDown);
            this.canvas1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.canvas1_KeyUp);
            this.canvas1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas1_MouseDown);
            this.canvas1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas1_MouseMove);
            this.canvas1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 648);
            this.Controls.Add(this.canvas1);
            this.Controls.Add(this.drawCheckbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox drawCheckbox;
        private Canvas canvas1;
    }
}

