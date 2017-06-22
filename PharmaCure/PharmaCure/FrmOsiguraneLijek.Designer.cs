namespace PharmaCure
{
    partial class FrmOsiguraneLijek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOsiguraneLijek));
            this.btnPovratak = new System.Windows.Forms.Button();
            this.cmbOsiguranje = new System.Windows.Forms.ComboBox();
            this.dgvLijekovi = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvSviLijekoviRecept = new System.Windows.Forms.DataGridView();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.lblArtikli = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviLijekoviRecept)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPovratak
            // 
            this.btnPovratak.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnPovratak.Image = ((System.Drawing.Image)(resources.GetObject("btnPovratak.Image")));
            this.btnPovratak.Location = new System.Drawing.Point(24, 14);
            this.btnPovratak.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(100, 28);
            this.btnPovratak.TabIndex = 1;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // cmbOsiguranje
            // 
            this.cmbOsiguranje.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbOsiguranje.FormattingEnabled = true;
            this.cmbOsiguranje.Location = new System.Drawing.Point(24, 474);
            this.cmbOsiguranje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbOsiguranje.Name = "cmbOsiguranje";
            this.cmbOsiguranje.Size = new System.Drawing.Size(545, 29);
            this.cmbOsiguranje.TabIndex = 2;
            // 
            // dgvLijekovi
            // 
            this.dgvLijekovi.BackgroundColor = System.Drawing.Color.White;
            this.dgvLijekovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLijekovi.Location = new System.Drawing.Point(24, 49);
            this.dgvLijekovi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvLijekovi.Name = "dgvLijekovi";
            this.dgvLijekovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLijekovi.Size = new System.Drawing.Size(547, 417);
            this.dgvLijekovi.TabIndex = 3;
            this.dgvLijekovi.SelectionChanged += new System.EventHandler(this.dgvLijekovi_SelectionChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnDodaj.Image = ((System.Drawing.Image)(resources.GetObject("btnDodaj.Image")));
            this.btnDodaj.Location = new System.Drawing.Point(923, 474);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(219, 28);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvSviLijekoviRecept
            // 
            this.dgvSviLijekoviRecept.BackgroundColor = System.Drawing.Color.White;
            this.dgvSviLijekoviRecept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviLijekoviRecept.Location = new System.Drawing.Point(595, 49);
            this.dgvSviLijekoviRecept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSviLijekoviRecept.Name = "dgvSviLijekoviRecept";
            this.dgvSviLijekoviRecept.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSviLijekoviRecept.Size = new System.Drawing.Size(547, 417);
            this.dgvSviLijekoviRecept.TabIndex = 5;
            // 
            // btnBrisi
            // 
            this.btnBrisi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnBrisi.Image = ((System.Drawing.Image)(resources.GetObject("btnBrisi.Image")));
            this.btnBrisi.Location = new System.Drawing.Point(595, 473);
            this.btnBrisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(219, 28);
            this.btnBrisi.TabIndex = 6;
            this.btnBrisi.Text = "Obrisi";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // lblArtikli
            // 
            this.lblArtikli.AutoSize = true;
            this.lblArtikli.BackColor = System.Drawing.Color.Transparent;
            this.lblArtikli.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblArtikli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblArtikli.Location = new System.Drawing.Point(131, 18);
            this.lblArtikli.Name = "lblArtikli";
            this.lblArtikli.Size = new System.Drawing.Size(74, 21);
            this.lblArtikli.TabIndex = 39;
            this.lblArtikli.Text = "Lijekovi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(591, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Osiguranja Lijekova:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmOsiguraneLijek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1157, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblArtikli);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.dgvSviLijekoviRecept);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvLijekovi);
            this.Controls.Add(this.cmbOsiguranje);
            this.Controls.Add(this.btnPovratak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmOsiguraneLijek";
            this.Text = "FrmOsiguraneLijek";
            this.Load += new System.EventHandler(this.FrmOsiguraneLijek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviLijekoviRecept)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.ComboBox cmbOsiguranje;
        private System.Windows.Forms.DataGridView dgvLijekovi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvSviLijekoviRecept;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Label lblArtikli;
        private System.Windows.Forms.Label label1;
    }
}