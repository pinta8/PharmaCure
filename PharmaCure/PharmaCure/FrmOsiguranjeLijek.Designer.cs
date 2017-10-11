namespace PharmaCure
{
    partial class FrmOsiguranjeLijek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOsiguranjeLijek));
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
            this.btnPovratak.Location = new System.Drawing.Point(18, 11);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(75, 23);
            this.btnPovratak.TabIndex = 1;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // cmbOsiguranje
            // 
            this.cmbOsiguranje.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbOsiguranje.FormattingEnabled = true;
            this.cmbOsiguranje.Location = new System.Drawing.Point(18, 385);
            this.cmbOsiguranje.Name = "cmbOsiguranje";
            this.cmbOsiguranje.Size = new System.Drawing.Size(410, 25);
            this.cmbOsiguranje.TabIndex = 2;
            // 
            // dgvLijekovi
            // 
            this.dgvLijekovi.BackgroundColor = System.Drawing.Color.White;
            this.dgvLijekovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLijekovi.Location = new System.Drawing.Point(18, 40);
            this.dgvLijekovi.Name = "dgvLijekovi";
            this.dgvLijekovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLijekovi.Size = new System.Drawing.Size(410, 339);
            this.dgvLijekovi.TabIndex = 3;
            this.dgvLijekovi.SelectionChanged += new System.EventHandler(this.dgvLijekovi_SelectionChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnDodaj.Image = ((System.Drawing.Image)(resources.GetObject("btnDodaj.Image")));
            this.btnDodaj.Location = new System.Drawing.Point(692, 385);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(164, 23);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvSviLijekoviRecept
            // 
            this.dgvSviLijekoviRecept.BackgroundColor = System.Drawing.Color.White;
            this.dgvSviLijekoviRecept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviLijekoviRecept.Location = new System.Drawing.Point(446, 40);
            this.dgvSviLijekoviRecept.Name = "dgvSviLijekoviRecept";
            this.dgvSviLijekoviRecept.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSviLijekoviRecept.Size = new System.Drawing.Size(410, 339);
            this.dgvSviLijekoviRecept.TabIndex = 5;
            // 
            // btnBrisi
            // 
            this.btnBrisi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnBrisi.Image = ((System.Drawing.Image)(resources.GetObject("btnBrisi.Image")));
            this.btnBrisi.Location = new System.Drawing.Point(446, 384);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(164, 23);
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
            this.lblArtikli.Location = new System.Drawing.Point(98, 15);
            this.lblArtikli.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArtikli.Name = "lblArtikli";
            this.lblArtikli.Size = new System.Drawing.Size(59, 17);
            this.lblArtikli.TabIndex = 39;
            this.lblArtikli.Text = "Lijekovi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(443, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Osiguranja Lijekova:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmOsiguranjeLijek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(868, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblArtikli);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.dgvSviLijekoviRecept);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvLijekovi);
            this.Controls.Add(this.cmbOsiguranje);
            this.Controls.Add(this.btnPovratak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmOsiguranjeLijek";
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