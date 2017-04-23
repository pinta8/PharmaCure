namespace PharmaCure
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnPrijaviSe = new System.Windows.Forms.Button();
			this.lblKorisnickoIme = new System.Windows.Forms.Label();
			this.lblLozinka = new System.Windows.Forms.Label();
			this.tbxKorisnickoIme = new System.Windows.Forms.TextBox();
			this.tbxLozinka = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnPrijaviSe
			// 
			this.btnPrijaviSe.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnPrijaviSe.Location = new System.Drawing.Point(161, 203);
			this.btnPrijaviSe.Name = "btnPrijaviSe";
			this.btnPrijaviSe.Size = new System.Drawing.Size(85, 42);
			this.btnPrijaviSe.TabIndex = 0;
			this.btnPrijaviSe.Text = "Prijavi se";
			this.btnPrijaviSe.UseVisualStyleBackColor = true;
			this.btnPrijaviSe.Click += new System.EventHandler(this.button1_Click);
			// 
			// lblKorisnickoIme
			// 
			this.lblKorisnickoIme.AutoSize = true;
			this.lblKorisnickoIme.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblKorisnickoIme.Location = new System.Drawing.Point(131, 68);
			this.lblKorisnickoIme.Name = "lblKorisnickoIme";
			this.lblKorisnickoIme.Size = new System.Drawing.Size(100, 17);
			this.lblKorisnickoIme.TabIndex = 1;
			this.lblKorisnickoIme.Text = "Korisničko ime";
			// 
			// lblLozinka
			// 
			this.lblLozinka.AutoSize = true;
			this.lblLozinka.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblLozinka.Location = new System.Drawing.Point(131, 127);
			this.lblLozinka.Name = "lblLozinka";
			this.lblLozinka.Size = new System.Drawing.Size(56, 17);
			this.lblLozinka.TabIndex = 2;
			this.lblLozinka.Text = "Lozinka";
			// 
			// tbxKorisnickoIme
			// 
			this.tbxKorisnickoIme.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tbxKorisnickoIme.Location = new System.Drawing.Point(131, 84);
			this.tbxKorisnickoIme.Name = "tbxKorisnickoIme";
			this.tbxKorisnickoIme.Size = new System.Drawing.Size(158, 23);
			this.tbxKorisnickoIme.TabIndex = 3;
			// 
			// tbxLozinka
			// 
			this.tbxLozinka.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tbxLozinka.Location = new System.Drawing.Point(131, 144);
			this.tbxLozinka.Name = "tbxLozinka";
			this.tbxLozinka.Size = new System.Drawing.Size(158, 23);
			this.tbxLozinka.TabIndex = 4;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 184);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(103, 118);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(403, 314);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.tbxLozinka);
			this.Controls.Add(this.tbxKorisnickoIme);
			this.Controls.Add(this.lblLozinka);
			this.Controls.Add(this.lblKorisnickoIme);
			this.Controls.Add(this.btnPrijaviSe);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button btnPrijaviSe;
		private System.Windows.Forms.Label lblKorisnickoIme;
		private System.Windows.Forms.Label lblLozinka;
		private System.Windows.Forms.TextBox tbxKorisnickoIme;
		private System.Windows.Forms.TextBox tbxLozinka;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

