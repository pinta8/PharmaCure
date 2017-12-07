namespace PharmaCure
{
    partial class FrmZaposlenici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmZaposlenici));
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.lblZaposlenici = new System.Windows.Forms.Label();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPovratak
            // 
            this.btnPovratak.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnPovratak.Image = ((System.Drawing.Image)(resources.GetObject("btnPovratak.Image")));
            this.btnPovratak.Location = new System.Drawing.Point(12, 12);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(75, 23);
            this.btnPovratak.TabIndex = 0;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.Image = ((System.Drawing.Image)(resources.GetObject("btnDodaj.Image")));
            this.btnDodaj.Location = new System.Drawing.Point(374, 377);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(90, 36);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.BackgroundColor = System.Drawing.Color.White;
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Location = new System.Drawing.Point(31, 120);
            this.dgvZaposlenici.MultiSelect = false;
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaposlenici.Size = new System.Drawing.Size(794, 226);
            this.dgvZaposlenici.TabIndex = 8;
            // 
            // lblZaposlenici
            // 
            this.lblZaposlenici.AutoSize = true;
            this.lblZaposlenici.BackColor = System.Drawing.Color.Transparent;
            this.lblZaposlenici.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZaposlenici.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblZaposlenici.Location = new System.Drawing.Point(28, 94);
            this.lblZaposlenici.Name = "lblZaposlenici";
            this.lblZaposlenici.Size = new System.Drawing.Size(83, 17);
            this.lblZaposlenici.TabIndex = 9;
            this.lblZaposlenici.Text = "Zaposlenici:";
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAzuriraj.Image = ((System.Drawing.Image)(resources.GetObject("btnAzuriraj.Image")));
            this.btnAzuriraj.Location = new System.Drawing.Point(238, 376);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(82, 39);
            this.btnAzuriraj.TabIndex = 10;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisi.Image = ((System.Drawing.Image)(resources.GetObject("btnIzbrisi.Image")));
            this.btnIzbrisi.Location = new System.Drawing.Point(533, 376);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(79, 39);
            this.btnIzbrisi.TabIndex = 11;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // FrmZaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(915, 485);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.lblZaposlenici);
            this.Controls.Add(this.dgvZaposlenici);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnPovratak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmZaposlenici";
            this.Text = "FrmDodajZaposlenika";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
		private System.Windows.Forms.Button btnDodaj;
		private System.Windows.Forms.DataGridView dgvZaposlenici;
		private System.Windows.Forms.Label lblZaposlenici;
		private System.Windows.Forms.Button btnAzuriraj;
		private System.Windows.Forms.Button btnIzbrisi;
	}
}