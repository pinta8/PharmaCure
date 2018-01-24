namespace PharmaCure
{
    partial class FrmRecepti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecepti));
            this.btnPovratak = new System.Windows.Forms.Button();
            this.dgvLijekoviRecept = new System.Windows.Forms.DataGridView();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtIDKlijent = new System.Windows.Forms.TextBox();
            this.dgvLijekoviPravo = new System.Windows.Forms.DataGridView();
            this.btnPropisi = new System.Windows.Forms.Button();
            this.cmbOsiguranje = new System.Windows.Forms.ComboBox();
            this.lblArtikli = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekoviRecept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekoviPravo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPovratak
            // 
            this.btnPovratak.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnPovratak.Image = ((System.Drawing.Image)(resources.GetObject("btnPovratak.Image")));
            this.btnPovratak.Location = new System.Drawing.Point(13, 21);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(75, 23);
            this.btnPovratak.TabIndex = 0;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // dgvLijekoviRecept
            // 
            this.dgvLijekoviRecept.BackgroundColor = System.Drawing.Color.White;
            this.dgvLijekoviRecept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLijekoviRecept.Location = new System.Drawing.Point(472, 72);
            this.dgvLijekoviRecept.Name = "dgvLijekoviRecept";
            this.dgvLijekoviRecept.Size = new System.Drawing.Size(434, 394);
            this.dgvLijekoviRecept.TabIndex = 1;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtKolicina.Location = new System.Drawing.Point(675, 474);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(69, 23);
            this.txtKolicina.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(112, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID Klijenta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(596, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kolicina:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnDodaj.Image = ((System.Drawing.Image)(resources.GetObject("btnDodaj.Image")));
            this.btnDodaj.Location = new System.Drawing.Point(788, 21);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(117, 23);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtIDKlijent
            // 
            this.txtIDKlijent.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIDKlijent.Location = new System.Drawing.Point(115, 24);
            this.txtIDKlijent.Name = "txtIDKlijent";
            this.txtIDKlijent.Size = new System.Drawing.Size(104, 23);
            this.txtIDKlijent.TabIndex = 11;
            this.txtIDKlijent.TextChanged += new System.EventHandler(this.txtIDLijek_TextChanged);
            // 
            // dgvLijekoviPravo
            // 
            this.dgvLijekoviPravo.BackgroundColor = System.Drawing.Color.White;
            this.dgvLijekoviPravo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLijekoviPravo.Location = new System.Drawing.Point(15, 72);
            this.dgvLijekoviPravo.Name = "dgvLijekoviPravo";
            this.dgvLijekoviPravo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLijekoviPravo.Size = new System.Drawing.Size(431, 394);
            this.dgvLijekoviPravo.TabIndex = 12;
            this.dgvLijekoviPravo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLijekoviPravo_CellContentClick);
            this.dgvLijekoviPravo.SelectionChanged += new System.EventHandler(this.dgvLijekoviPravo_SelectionChanged);
            // 
            // btnPropisi
            // 
            this.btnPropisi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnPropisi.Image = ((System.Drawing.Image)(resources.GetObject("btnPropisi.Image")));
            this.btnPropisi.Location = new System.Drawing.Point(788, 472);
            this.btnPropisi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPropisi.Name = "btnPropisi";
            this.btnPropisi.Size = new System.Drawing.Size(117, 23);
            this.btnPropisi.TabIndex = 13;
            this.btnPropisi.Text = "Propiši";
            this.btnPropisi.UseVisualStyleBackColor = true;
            this.btnPropisi.Click += new System.EventHandler(this.btnPropisi_Click);
            // 
            // cmbOsiguranje
            // 
            this.cmbOsiguranje.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbOsiguranje.FormattingEnabled = true;
            this.cmbOsiguranje.Location = new System.Drawing.Point(15, 474);
            this.cmbOsiguranje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbOsiguranje.Name = "cmbOsiguranje";
            this.cmbOsiguranje.Size = new System.Drawing.Size(432, 25);
            this.cmbOsiguranje.TabIndex = 14;
            // 
            // lblArtikli
            // 
            this.lblArtikli.AutoSize = true;
            this.lblArtikli.BackColor = System.Drawing.Color.Transparent;
            this.lblArtikli.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblArtikli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblArtikli.Location = new System.Drawing.Point(12, 52);
            this.lblArtikli.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArtikli.Name = "lblArtikli";
            this.lblArtikli.Size = new System.Drawing.Size(124, 17);
            this.lblArtikli.TabIndex = 39;
            this.lblArtikli.Text = "Lijekovi za recept:";
            this.lblArtikli.Click += new System.EventHandler(this.lblArtikli_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(469, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Recepti:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmRecepti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(915, 507);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblArtikli);
            this.Controls.Add(this.cmbOsiguranje);
            this.Controls.Add(this.btnPropisi);
            this.Controls.Add(this.dgvLijekoviPravo);
            this.Controls.Add(this.txtIDKlijent);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.dgvLijekoviRecept);
            this.Controls.Add(this.btnPovratak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRecepti";
            this.Text = "FrmRecepti";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekoviRecept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekoviPravo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.DataGridView dgvLijekoviRecept;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtIDKlijent;
        private System.Windows.Forms.DataGridView dgvLijekoviPravo;
        private System.Windows.Forms.Button btnPropisi;
        private System.Windows.Forms.ComboBox cmbOsiguranje;
        private System.Windows.Forms.Label lblArtikli;
        private System.Windows.Forms.Label label1;
    }
}