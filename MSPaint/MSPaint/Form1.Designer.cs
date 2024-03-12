namespace MSPaint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.knedlikDel = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(235, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 657);
            this.panel1.TabIndex = 0;
            // 
            // knedlikDel
            // 
            this.knedlikDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.knedlikDel.Appearance = System.Windows.Forms.Appearance.Button;
            this.knedlikDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.knedlikDel.Location = new System.Drawing.Point(235, 64);
            this.knedlikDel.Name = "knedlikDel";
            this.knedlikDel.Size = new System.Drawing.Size(104, 81);
            this.knedlikDel.TabIndex = 1;
            this.knedlikDel.TabStop = true;
            this.knedlikDel.Text = "ERASE";
            this.knedlikDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.knedlikDel.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 923);
            this.Controls.Add(this.knedlikDel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton knedlikDel;
    }
}

