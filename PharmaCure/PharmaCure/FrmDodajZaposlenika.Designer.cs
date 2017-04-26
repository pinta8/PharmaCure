namespace PharmaCure
{
    partial class FrmDodajZaposlenika
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
			this.btnPovratak = new System.Windows.Forms.Button();
			this.lblKorisnickoIme = new System.Windows.Forms.Label();
			this.lblLozinka = new System.Windows.Forms.Label();
			this.lblPoslovnica = new System.Windows.Forms.Label();
			this.tbxKorisnickoIme = new System.Windows.Forms.TextBox();
			this.tbxLozinka = new System.Windows.Forms.TextBox();
			this.cbxPoslovnice = new System.Windows.Forms.ComboBox();
			this.btnDodaj = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnPovratak
			// 
			this.btnPovratak.Location = new System.Drawing.Point(12, 12);
			this.btnPovratak.Name = "btnPovratak";
			this.btnPovratak.Size = new System.Drawing.Size(75, 23);
			this.btnPovratak.TabIndex = 0;
			this.btnPovratak.Text = "Povratak";
			this.btnPovratak.UseVisualStyleBackColor = true;
			this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
			// 
			// lblKorisnickoIme
			// 
			this.lblKorisnickoIme.AutoSize = true;
			this.lblKorisnickoIme.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblKorisnickoIme.Location = new System.Drawing.Point(338, 134);
			this.lblKorisnickoIme.Name = "lblKorisnickoIme";
			this.lblKorisnickoIme.Size = new System.Drawing.Size(100, 17);
			this.lblKorisnickoIme.TabIndex = 1;
			this.lblKorisnickoIme.Text = "Korisničko ime";
			// 
			// lblLozinka
			// 
			this.lblLozinka.AutoSize = true;
			this.lblLozinka.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblLozinka.Location = new System.Drawing.Point(338, 187);
			this.lblLozinka.Name = "lblLozinka";
			this.lblLozinka.Size = new System.Drawing.Size(56, 17);
			this.lblLozinka.TabIndex = 2;
			this.lblLozinka.Text = "Lozinka";
			// 
			// lblPoslovnica
			// 
			this.lblPoslovnica.AutoSize = true;
			this.lblPoslovnica.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblPoslovnica.Location = new System.Drawing.Point(338, 243);
			this.lblPoslovnica.Name = "lblPoslovnica";
			this.lblPoslovnica.Size = new System.Drawing.Size(78, 17);
			this.lblPoslovnica.TabIndex = 3;
			this.lblPoslovnica.Text = "Poslovnica";
			// 
			// tbxKorisnickoIme
			// 
			this.tbxKorisnickoIme.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tbxKorisnickoIme.Location = new System.Drawing.Point(457, 134);
			this.tbxKorisnickoIme.Name = "tbxKorisnickoIme";
			this.tbxKorisnickoIme.Size = new System.Drawing.Size(146, 23);
			this.tbxKorisnickoIme.TabIndex = 4;
			// 
			// tbxLozinka
			// 
			this.tbxLozinka.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tbxLozinka.Location = new System.Drawing.Point(457, 183);
			this.tbxLozinka.Name = "tbxLozinka";
			this.tbxLozinka.Size = new System.Drawing.Size(146, 23);
			this.tbxLozinka.TabIndex = 5;
			// 
			// cbxPoslovnice
			// 
			this.cbxPoslovnice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.cbxPoslovnice.FormattingEnabled = true;
			this.cbxPoslovnice.Location = new System.Drawing.Point(457, 237);
			this.cbxPoslovnice.Name = "cbxPoslovnice";
			this.cbxPoslovnice.Size = new System.Drawing.Size(146, 25);
			this.cbxPoslovnice.TabIndex = 6;
			// 
			// btnDodaj
			// 
			this.btnDodaj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnDodaj.Location = new System.Drawing.Point(420, 291);
			this.btnDodaj.Name = "btnDodaj";
			this.btnDodaj.Size = new System.Drawing.Size(90, 36);
			this.btnDodaj.TabIndex = 7;
			this.btnDodaj.Text = "Dodaj";
			this.btnDodaj.UseVisualStyleBackColor = true;
			this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
			// 
			// FrmDodajZaposlenika
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(915, 485);
			this.Controls.Add(this.btnDodaj);
			this.Controls.Add(this.cbxPoslovnice);
			this.Controls.Add(this.tbxLozinka);
			this.Controls.Add(this.tbxKorisnickoIme);
			this.Controls.Add(this.lblPoslovnica);
			this.Controls.Add(this.lblLozinka);
			this.Controls.Add(this.lblKorisnickoIme);
			this.Controls.Add(this.btnPovratak);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmDodajZaposlenika";
			this.Text = "FrmDodajZaposlenika";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
		private System.Windows.Forms.Label lblKorisnickoIme;
		private System.Windows.Forms.Label lblLozinka;
		private System.Windows.Forms.Label lblPoslovnica;
		private System.Windows.Forms.TextBox tbxKorisnickoIme;
		private System.Windows.Forms.TextBox tbxLozinka;
		private System.Windows.Forms.ComboBox cbxPoslovnice;
		private System.Windows.Forms.Button btnDodaj;
	}
}