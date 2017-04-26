namespace PharmaCure {
	partial class FrmAzurirajZaposlenika {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.btnSpremi = new System.Windows.Forms.Button();
			this.cbxPoslovnice = new System.Windows.Forms.ComboBox();
			this.tbxLozinka = new System.Windows.Forms.TextBox();
			this.tbxKorisnickoIme = new System.Windows.Forms.TextBox();
			this.lblPoslovnica = new System.Windows.Forms.Label();
			this.lblLozinka = new System.Windows.Forms.Label();
			this.lblKorisnickoIme = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnSpremi
			// 
			this.btnSpremi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnSpremi.Location = new System.Drawing.Point(93, 182);
			this.btnSpremi.Name = "btnSpremi";
			this.btnSpremi.Size = new System.Drawing.Size(90, 58);
			this.btnSpremi.TabIndex = 14;
			this.btnSpremi.Text = "Spremi promjene";
			this.btnSpremi.UseVisualStyleBackColor = true;
			// 
			// cbxPoslovnice
			// 
			this.cbxPoslovnice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.cbxPoslovnice.FormattingEnabled = true;
			this.cbxPoslovnice.Location = new System.Drawing.Point(129, 138);
			this.cbxPoslovnice.Name = "cbxPoslovnice";
			this.cbxPoslovnice.Size = new System.Drawing.Size(146, 25);
			this.cbxPoslovnice.TabIndex = 13;
			// 
			// tbxLozinka
			// 
			this.tbxLozinka.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tbxLozinka.Location = new System.Drawing.Point(129, 84);
			this.tbxLozinka.Name = "tbxLozinka";
			this.tbxLozinka.Size = new System.Drawing.Size(146, 23);
			this.tbxLozinka.TabIndex = 12;
			// 
			// tbxKorisnickoIme
			// 
			this.tbxKorisnickoIme.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tbxKorisnickoIme.Location = new System.Drawing.Point(129, 35);
			this.tbxKorisnickoIme.Name = "tbxKorisnickoIme";
			this.tbxKorisnickoIme.Size = new System.Drawing.Size(146, 23);
			this.tbxKorisnickoIme.TabIndex = 11;
			// 
			// lblPoslovnica
			// 
			this.lblPoslovnica.AutoSize = true;
			this.lblPoslovnica.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblPoslovnica.Location = new System.Drawing.Point(10, 144);
			this.lblPoslovnica.Name = "lblPoslovnica";
			this.lblPoslovnica.Size = new System.Drawing.Size(78, 17);
			this.lblPoslovnica.TabIndex = 10;
			this.lblPoslovnica.Text = "Poslovnica";
			// 
			// lblLozinka
			// 
			this.lblLozinka.AutoSize = true;
			this.lblLozinka.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblLozinka.Location = new System.Drawing.Point(10, 88);
			this.lblLozinka.Name = "lblLozinka";
			this.lblLozinka.Size = new System.Drawing.Size(56, 17);
			this.lblLozinka.TabIndex = 9;
			this.lblLozinka.Text = "Lozinka";
			// 
			// lblKorisnickoIme
			// 
			this.lblKorisnickoIme.AutoSize = true;
			this.lblKorisnickoIme.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblKorisnickoIme.Location = new System.Drawing.Point(10, 35);
			this.lblKorisnickoIme.Name = "lblKorisnickoIme";
			this.lblKorisnickoIme.Size = new System.Drawing.Size(100, 17);
			this.lblKorisnickoIme.TabIndex = 8;
			this.lblKorisnickoIme.Text = "Korisničko ime";
			// 
			// FrmAzurirajZaposlenika
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.btnSpremi);
			this.Controls.Add(this.cbxPoslovnice);
			this.Controls.Add(this.tbxLozinka);
			this.Controls.Add(this.tbxKorisnickoIme);
			this.Controls.Add(this.lblPoslovnica);
			this.Controls.Add(this.lblLozinka);
			this.Controls.Add(this.lblKorisnickoIme);
			this.Name = "FrmAzurirajZaposlenika";
			this.Text = "FrmAzurirajZaposlenika";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSpremi;
		private System.Windows.Forms.ComboBox cbxPoslovnice;
		private System.Windows.Forms.TextBox tbxLozinka;
		private System.Windows.Forms.TextBox tbxKorisnickoIme;
		private System.Windows.Forms.Label lblPoslovnica;
		private System.Windows.Forms.Label lblLozinka;
		private System.Windows.Forms.Label lblKorisnickoIme;
	}
}