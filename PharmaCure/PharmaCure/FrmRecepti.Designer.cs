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
            this.btnPovratak.Location = new System.Drawing.Point(17, 26);
            this.btnPovratak.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(100, 28);
            this.btnPovratak.TabIndex = 0;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // dgvLijekoviRecept
            // 
            this.dgvLijekoviRecept.BackgroundColor = System.Drawing.Color.White;
            this.dgvLijekoviRecept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLijekoviRecept.Location = new System.Drawing.Point(629, 89);
            this.dgvLijekoviRecept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvLijekoviRecept.Name = "dgvLijekoviRecept";
            this.dgvLijekoviRecept.Size = new System.Drawing.Size(579, 485);
            this.dgvLijekoviRecept.TabIndex = 1;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtKolicina.Location = new System.Drawing.Point(900, 583);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(91, 27);
            this.txtKolicina.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(149, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID Klijenta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(795, 587);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kolicina:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnDodaj.Image = ((System.Drawing.Image)(resources.GetObject("btnDodaj.Image")));
            this.btnDodaj.Location = new System.Drawing.Point(1051, 26);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(156, 28);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtIDKlijent
            // 
            this.txtIDKlijent.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIDKlijent.Location = new System.Drawing.Point(153, 30);
            this.txtIDKlijent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDKlijent.Name = "txtIDKlijent";
            this.txtIDKlijent.Size = new System.Drawing.Size(137, 27);
            this.txtIDKlijent.TabIndex = 11;
            this.txtIDKlijent.TextChanged += new System.EventHandler(this.txtIDLijek_TextChanged);
            // 
            // dgvLijekoviPravo
            // 
            this.dgvLijekoviPravo.BackgroundColor = System.Drawing.Color.White;
            this.dgvLijekoviPravo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLijekoviPravo.Location = new System.Drawing.Point(20, 89);
            this.dgvLijekoviPravo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvLijekoviPravo.Name = "dgvLijekoviPravo";
            this.dgvLijekoviPravo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLijekoviPravo.Size = new System.Drawing.Size(575, 485);
            this.dgvLijekoviPravo.TabIndex = 12;
            this.dgvLijekoviPravo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLijekoviPravo_CellContentClick);
            this.dgvLijekoviPravo.SelectionChanged += new System.EventHandler(this.dgvLijekoviPravo_SelectionChanged);
            // 
            // btnPropisi
            // 
            this.btnPropisi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnPropisi.Image = ((System.Drawing.Image)(resources.GetObject("btnPropisi.Image")));
            this.btnPropisi.Location = new System.Drawing.Point(1051, 581);
            this.btnPropisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPropisi.Name = "btnPropisi";
            this.btnPropisi.Size = new System.Drawing.Size(156, 28);
            this.btnPropisi.TabIndex = 13;
            this.btnPropisi.Text = "Propiši";
            this.btnPropisi.UseVisualStyleBackColor = true;
            this.btnPropisi.Click += new System.EventHandler(this.btnPropisi_Click);
            // 
            // cmbOsiguranje
            // 
            this.cmbOsiguranje.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbOsiguranje.FormattingEnabled = true;
            this.cmbOsiguranje.Location = new System.Drawing.Point(20, 583);
            this.cmbOsiguranje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbOsiguranje.Name = "cmbOsiguranje";
            this.cmbOsiguranje.Size = new System.Drawing.Size(575, 29);
            this.cmbOsiguranje.TabIndex = 14;
            // 
            // lblArtikli
            // 
            this.lblArtikli.AutoSize = true;
            this.lblArtikli.BackColor = System.Drawing.Color.Transparent;
            this.lblArtikli.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblArtikli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblArtikli.Location = new System.Drawing.Point(16, 64);
            this.lblArtikli.Name = "lblArtikli";
            this.lblArtikli.Size = new System.Drawing.Size(160, 21);
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
            this.label1.Location = new System.Drawing.Point(625, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Recepti:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmRecepti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1220, 624);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmRecepti";
            this.Text = "FrmRecepti";
            this.Load += new System.EventHandler(this.FrmRecepti_Load);
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