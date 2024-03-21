namespace Semestralka_Macrohard_Draw
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
            this.panel = new System.Windows.Forms.Panel();
            this.platno = new System.Windows.Forms.PictureBox();
            this.kneldikVyber = new System.Windows.Forms.RadioButton();
            this.knedlikVymaz = new System.Windows.Forms.RadioButton();
            this.knedlikVypln = new System.Windows.Forms.RadioButton();
            this.knedlikPen = new System.Windows.Forms.RadioButton();
            this.knedlikElipsa = new System.Windows.Forms.RadioButton();
            this.knedlikRect = new System.Windows.Forms.RadioButton();
            this.knedlikLine = new System.Windows.Forms.RadioButton();
            this.knedlikSmaz = new System.Windows.Forms.RadioButton();
            this.knedlikUloz = new System.Windows.Forms.RadioButton();
            this.panelUkaz = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.platno)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel.Controls.Add(this.panelUkaz);
            this.panel.Controls.Add(this.knedlikUloz);
            this.panel.Controls.Add(this.knedlikSmaz);
            this.panel.Controls.Add(this.knedlikLine);
            this.panel.Controls.Add(this.knedlikRect);
            this.panel.Controls.Add(this.knedlikElipsa);
            this.panel.Controls.Add(this.knedlikPen);
            this.panel.Controls.Add(this.knedlikVypln);
            this.panel.Controls.Add(this.knedlikVymaz);
            this.panel.Controls.Add(this.kneldikVyber);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1159, 100);
            this.panel.TabIndex = 0;
            // 
            // platno
            // 
            this.platno.BackColor = System.Drawing.Color.White;
            this.platno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.platno.Location = new System.Drawing.Point(0, 100);
            this.platno.Name = "platno";
            this.platno.Size = new System.Drawing.Size(1159, 680);
            this.platno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.platno.TabIndex = 1;
            this.platno.TabStop = false;
            this.platno.Paint += new System.Windows.Forms.PaintEventHandler(this.platno_Paint);
            this.platno.MouseClick += new System.Windows.Forms.MouseEventHandler(this.platno_MouseClick);
            this.platno.MouseDown += new System.Windows.Forms.MouseEventHandler(this.platno_MouseDown);
            this.platno.MouseMove += new System.Windows.Forms.MouseEventHandler(this.platno_MouseMove);
            this.platno.MouseUp += new System.Windows.Forms.MouseEventHandler(this.platno_MouseUp);
            // 
            // kneldikVyber
            // 
            this.kneldikVyber.Appearance = System.Windows.Forms.Appearance.Button;
            this.kneldikVyber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kneldikVyber.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.kneldikVyber.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.kneldikVyber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kneldikVyber.Location = new System.Drawing.Point(331, 12);
            this.kneldikVyber.Name = "kneldikVyber";
            this.kneldikVyber.Size = new System.Drawing.Size(80, 71);
            this.kneldikVyber.TabIndex = 0;
            this.kneldikVyber.Text = "Vyber Barvu";
            this.kneldikVyber.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kneldikVyber.UseVisualStyleBackColor = true;
            this.kneldikVyber.Click += new System.EventHandler(this.kneldikVyber_Click);
            // 
            // knedlikVymaz
            // 
            this.knedlikVymaz.Appearance = System.Windows.Forms.Appearance.Button;
            this.knedlikVymaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.knedlikVymaz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.knedlikVymaz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.knedlikVymaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.knedlikVymaz.Location = new System.Drawing.Point(417, 12);
            this.knedlikVymaz.Name = "knedlikVymaz";
            this.knedlikVymaz.Size = new System.Drawing.Size(80, 71);
            this.knedlikVymaz.TabIndex = 1;
            this.knedlikVymaz.Text = "Guma";
            this.knedlikVymaz.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.knedlikVymaz.UseVisualStyleBackColor = true;
            this.knedlikVymaz.Click += new System.EventHandler(this.knedlikVymaz_Click);
            // 
            // knedlikVypln
            // 
            this.knedlikVypln.Appearance = System.Windows.Forms.Appearance.Button;
            this.knedlikVypln.Cursor = System.Windows.Forms.Cursors.Hand;
            this.knedlikVypln.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.knedlikVypln.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.knedlikVypln.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.knedlikVypln.Location = new System.Drawing.Point(503, 12);
            this.knedlikVypln.Name = "knedlikVypln";
            this.knedlikVypln.Size = new System.Drawing.Size(80, 71);
            this.knedlikVypln.TabIndex = 2;
            this.knedlikVypln.Text = "Kyblik";
            this.knedlikVypln.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.knedlikVypln.UseVisualStyleBackColor = true;
            this.knedlikVypln.Click += new System.EventHandler(this.knedlikVypln_Click);
            // 
            // knedlikPen
            // 
            this.knedlikPen.Appearance = System.Windows.Forms.Appearance.Button;
            this.knedlikPen.Checked = true;
            this.knedlikPen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.knedlikPen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.knedlikPen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.knedlikPen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.knedlikPen.Location = new System.Drawing.Point(589, 12);
            this.knedlikPen.Name = "knedlikPen";
            this.knedlikPen.Size = new System.Drawing.Size(80, 71);
            this.knedlikPen.TabIndex = 3;
            this.knedlikPen.TabStop = true;
            this.knedlikPen.Text = "Tuzka";
            this.knedlikPen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.knedlikPen.UseVisualStyleBackColor = true;
            this.knedlikPen.Click += new System.EventHandler(this.knedlikPen_Click);
            // 
            // knedlikElipsa
            // 
            this.knedlikElipsa.Appearance = System.Windows.Forms.Appearance.Button;
            this.knedlikElipsa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.knedlikElipsa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.knedlikElipsa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.knedlikElipsa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.knedlikElipsa.Location = new System.Drawing.Point(675, 12);
            this.knedlikElipsa.Name = "knedlikElipsa";
            this.knedlikElipsa.Size = new System.Drawing.Size(80, 71);
            this.knedlikElipsa.TabIndex = 4;
            this.knedlikElipsa.Text = "Boban";
            this.knedlikElipsa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.knedlikElipsa.UseVisualStyleBackColor = true;
            this.knedlikElipsa.Click += new System.EventHandler(this.knedlikElipsa_Click);
            // 
            // knedlikRect
            // 
            this.knedlikRect.Appearance = System.Windows.Forms.Appearance.Button;
            this.knedlikRect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.knedlikRect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.knedlikRect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.knedlikRect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.knedlikRect.Location = new System.Drawing.Point(761, 12);
            this.knedlikRect.Name = "knedlikRect";
            this.knedlikRect.Size = new System.Drawing.Size(80, 71);
            this.knedlikRect.TabIndex = 5;
            this.knedlikRect.Text = "Obdelnik";
            this.knedlikRect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.knedlikRect.UseVisualStyleBackColor = true;
            this.knedlikRect.Click += new System.EventHandler(this.knedlikRect_Click);
            // 
            // knedlikLine
            // 
            this.knedlikLine.Appearance = System.Windows.Forms.Appearance.Button;
            this.knedlikLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.knedlikLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.knedlikLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.knedlikLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.knedlikLine.Location = new System.Drawing.Point(847, 12);
            this.knedlikLine.Name = "knedlikLine";
            this.knedlikLine.Size = new System.Drawing.Size(80, 71);
            this.knedlikLine.TabIndex = 6;
            this.knedlikLine.Text = "Cara";
            this.knedlikLine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.knedlikLine.UseVisualStyleBackColor = true;
            this.knedlikLine.Click += new System.EventHandler(this.knedlikLine_Click);
            // 
            // knedlikSmaz
            // 
            this.knedlikSmaz.Appearance = System.Windows.Forms.Appearance.Button;
            this.knedlikSmaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.knedlikSmaz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.knedlikSmaz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.knedlikSmaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.knedlikSmaz.Location = new System.Drawing.Point(1067, 12);
            this.knedlikSmaz.Name = "knedlikSmaz";
            this.knedlikSmaz.Size = new System.Drawing.Size(80, 71);
            this.knedlikSmaz.TabIndex = 7;
            this.knedlikSmaz.Text = "Vycistit";
            this.knedlikSmaz.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.knedlikSmaz.UseVisualStyleBackColor = true;
            this.knedlikSmaz.Click += new System.EventHandler(this.knedlikSmaz_Click);
            // 
            // knedlikUloz
            // 
            this.knedlikUloz.Appearance = System.Windows.Forms.Appearance.Button;
            this.knedlikUloz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.knedlikUloz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.knedlikUloz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.knedlikUloz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.knedlikUloz.Location = new System.Drawing.Point(981, 12);
            this.knedlikUloz.Name = "knedlikUloz";
            this.knedlikUloz.Size = new System.Drawing.Size(80, 71);
            this.knedlikUloz.TabIndex = 8;
            this.knedlikUloz.Text = "Ulozit";
            this.knedlikUloz.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.knedlikUloz.UseVisualStyleBackColor = true;
            this.knedlikUloz.Click += new System.EventHandler(this.knedlikUloz_Click);
            // 
            // panelUkaz
            // 
            this.panelUkaz.BackColor = System.Drawing.Color.Black;
            this.panelUkaz.Location = new System.Drawing.Point(74, 12);
            this.panelUkaz.Name = "panelUkaz";
            this.panelUkaz.Size = new System.Drawing.Size(216, 71);
            this.panelUkaz.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 780);
            this.Controls.Add(this.platno);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.platno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox platno;
        private System.Windows.Forms.RadioButton kneldikVyber;
        private System.Windows.Forms.RadioButton knedlikLine;
        private System.Windows.Forms.RadioButton knedlikRect;
        private System.Windows.Forms.RadioButton knedlikElipsa;
        private System.Windows.Forms.RadioButton knedlikPen;
        private System.Windows.Forms.RadioButton knedlikVypln;
        private System.Windows.Forms.RadioButton knedlikVymaz;
        private System.Windows.Forms.RadioButton knedlikUloz;
        private System.Windows.Forms.RadioButton knedlikSmaz;
        private System.Windows.Forms.Panel panelUkaz;
    }
}

