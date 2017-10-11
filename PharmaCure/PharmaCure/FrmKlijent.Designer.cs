namespace PharmaCure
{
    partial class FrmKlijent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKlijent));
            this.btnPovratak = new System.Windows.Forms.Button();
            this.dgvKlijenti = new System.Windows.Forms.DataGridView();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblOsiguranje = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.cmbOsiguranje = new System.Windows.Forms.ComboBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPovratak.BackgroundImage")));
            this.btnPovratak.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnPovratak.Location = new System.Drawing.Point(12, 12);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(75, 23);
            this.btnPovratak.TabIndex = 2;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // dgvKlijenti
            // 
            this.dgvKlijenti.BackgroundColor = System.Drawing.Color.White;
            this.dgvKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijenti.Location = new System.Drawing.Point(443, 12);
            this.dgvKlijenti.Name = "dgvKlijenti";
            this.dgvKlijenti.Size = new System.Drawing.Size(485, 532);
            this.dgvKlijenti.TabIndex = 3;
            this.dgvKlijenti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKlijenti_CellContentClick);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.BackColor = System.Drawing.Color.Transparent;
            this.lblIme.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblIme.Location = new System.Drawing.Point(13, 68);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(36, 17);
            this.lblIme.TabIndex = 4;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.BackColor = System.Drawing.Color.Transparent;
            this.lblPrezime.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblPrezime.Location = new System.Drawing.Point(12, 143);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(62, 17);
            this.lblPrezime.TabIndex = 5;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblOsiguranje
            // 
            this.lblOsiguranje.AutoSize = true;
            this.lblOsiguranje.BackColor = System.Drawing.Color.Transparent;
            this.lblOsiguranje.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblOsiguranje.Location = new System.Drawing.Point(12, 218);
            this.lblOsiguranje.Name = "lblOsiguranje";
            this.lblOsiguranje.Size = new System.Drawing.Size(80, 17);
            this.lblOsiguranje.TabIndex = 6;
            this.lblOsiguranje.Text = "Osiguranje:";
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIme.Location = new System.Drawing.Point(12, 84);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(264, 23);
            this.txtIme.TabIndex = 7;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrezime.Location = new System.Drawing.Point(12, 159);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(264, 23);
            this.txtPrezime.TabIndex = 8;
            // 
            // cmbOsiguranje
            // 
            this.cmbOsiguranje.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbOsiguranje.FormattingEnabled = true;
            this.cmbOsiguranje.Location = new System.Drawing.Point(12, 234);
            this.cmbOsiguranje.Name = "cmbOsiguranje";
            this.cmbOsiguranje.Size = new System.Drawing.Size(264, 25);
            this.cmbOsiguranje.TabIndex = 9;
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSpremi.BackgroundImage")));
            this.btnSpremi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnSpremi.Location = new System.Drawing.Point(12, 289);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(105, 23);
            this.btnSpremi.TabIndex = 10;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnObrisi.BackgroundImage")));
            this.btnObrisi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnObrisi.Location = new System.Drawing.Point(171, 289);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(105, 23);
            this.btnObrisi.TabIndex = 11;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // FrmKlijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(940, 556);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.cmbOsiguranje);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblOsiguranje);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.dgvKlijenti);
            this.Controls.Add(this.btnPovratak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKlijent";
            this.Text = "FrmKlijenti";
            this.Load += new System.EventHandler(this.FrmKlijenti_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmKlijent_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.DataGridView dgvKlijenti;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblOsiguranje;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.ComboBox cmbOsiguranje;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnObrisi;
    }
}