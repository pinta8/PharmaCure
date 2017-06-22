namespace PharmaCure
{
    partial class FrmProdaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdaja));
            this.btnSve = new System.Windows.Forms.Button();
            this.btnJedan = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.cmbStanje = new System.Windows.Forms.ComboBox();
            this.dgvRecepti = new System.Windows.Forms.DataGridView();
            this.btnRacun = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKorisnik = new System.Windows.Forms.TextBox();
            this.cmbLijek = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.lblArtikli = new System.Windows.Forms.Label();
            this.lblRecepti = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSve
            // 
            this.btnSve.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSve.BackgroundImage")));
            this.btnSve.Location = new System.Drawing.Point(879, 355);
            this.btnSve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSve.Name = "btnSve";
            this.btnSve.Size = new System.Drawing.Size(47, 38);
            this.btnSve.TabIndex = 37;
            this.btnSve.Text = "<<";
            this.btnSve.UseVisualStyleBackColor = true;
            this.btnSve.Click += new System.EventHandler(this.btnSve_Click);
            // 
            // btnJedan
            // 
            this.btnJedan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnJedan.BackgroundImage")));
            this.btnJedan.Location = new System.Drawing.Point(879, 295);
            this.btnJedan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJedan.Name = "btnJedan";
            this.btnJedan.Size = new System.Drawing.Size(47, 38);
            this.btnJedan.TabIndex = 36;
            this.btnJedan.Text = "<";
            this.btnJedan.UseVisualStyleBackColor = true;
            this.btnJedan.Click += new System.EventHandler(this.btnJedan_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnObrisi.BackgroundImage")));
            this.btnObrisi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnObrisi.Location = new System.Drawing.Point(375, 608);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(84, 32);
            this.btnObrisi.TabIndex = 35;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.Location = new System.Drawing.Point(931, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 34;
            this.label4.Text = "Količlina:";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtKolicina.Location = new System.Drawing.Point(933, 31);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(61, 27);
            this.txtKolicina.TabIndex = 33;
            // 
            // cmbStanje
            // 
            this.cmbStanje.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbStanje.FormattingEnabled = true;
            this.cmbStanje.Location = new System.Drawing.Point(19, 612);
            this.cmbStanje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStanje.Name = "cmbStanje";
            this.cmbStanje.Size = new System.Drawing.Size(144, 29);
            this.cmbStanje.TabIndex = 32;
            // 
            // dgvRecepti
            // 
            this.dgvRecepti.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecepti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecepti.Location = new System.Drawing.Point(933, 98);
            this.dgvRecepti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRecepti.Name = "dgvRecepti";
            this.dgvRecepti.RowTemplate.Height = 24;
            this.dgvRecepti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecepti.Size = new System.Drawing.Size(588, 501);
            this.dgvRecepti.TabIndex = 31;
            // 
            // btnRacun
            // 
            this.btnRacun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRacun.BackgroundImage")));
            this.btnRacun.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnRacun.Location = new System.Drawing.Point(187, 608);
            this.btnRacun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRacun.Name = "btnRacun";
            this.btnRacun.Size = new System.Drawing.Size(168, 33);
            this.btnRacun.TabIndex = 30;
            this.btnRacun.Text = "Dodaj Račun";
            this.btnRacun.UseVisualStyleBackColor = true;
            this.btnRacun.Click += new System.EventHandler(this.btnRacun_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.Location = new System.Drawing.Point(1279, 610);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cijena:";
            // 
            // txtCijena
            // 
            this.txtCijena.Enabled = false;
            this.txtCijena.Location = new System.Drawing.Point(1395, 608);
            this.txtCijena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(125, 22);
            this.txtCijena.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(155, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Korisnik ID:";
            // 
            // txtKorisnik
            // 
            this.txtKorisnik.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtKorisnik.Location = new System.Drawing.Point(159, 31);
            this.txtKorisnik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKorisnik.Name = "txtKorisnik";
            this.txtKorisnik.Size = new System.Drawing.Size(165, 27);
            this.txtKorisnik.TabIndex = 25;
            this.txtKorisnik.TextChanged += new System.EventHandler(this.txtKorisnik_TextChanged);
            // 
            // cmbLijek
            // 
            this.cmbLijek.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbLijek.FormattingEnabled = true;
            this.cmbLijek.Location = new System.Drawing.Point(1049, 28);
            this.cmbLijek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLijek.Name = "cmbLijek";
            this.cmbLijek.Size = new System.Drawing.Size(209, 29);
            this.cmbLijek.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.Location = new System.Drawing.Point(1045, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "Lijek:";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.button2.Location = new System.Drawing.Point(1421, 28);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 23;
            this.button2.Text = "Prodaj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDodaj.BackgroundImage")));
            this.btnDodaj.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnDodaj.Location = new System.Drawing.Point(1283, 28);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 28);
            this.btnDodaj.TabIndex = 22;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.BackgroundColor = System.Drawing.Color.White;
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Location = new System.Drawing.Point(19, 98);
            this.dgvArtikli.Margin = new System.Windows.Forms.Padding(4);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArtikli.Size = new System.Drawing.Size(853, 501);
            this.dgvArtikli.TabIndex = 21;
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPovratak.BackgroundImage")));
            this.btnPovratak.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnPovratak.Location = new System.Drawing.Point(19, 28);
            this.btnPovratak.Margin = new System.Windows.Forms.Padding(4);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(100, 28);
            this.btnPovratak.TabIndex = 20;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click_1);
            // 
            // lblArtikli
            // 
            this.lblArtikli.AutoSize = true;
            this.lblArtikli.BackColor = System.Drawing.Color.Transparent;
            this.lblArtikli.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblArtikli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblArtikli.Location = new System.Drawing.Point(15, 73);
            this.lblArtikli.Name = "lblArtikli";
            this.lblArtikli.Size = new System.Drawing.Size(58, 21);
            this.lblArtikli.TabIndex = 38;
            this.lblArtikli.Text = "Artikli:";
            // 
            // lblRecepti
            // 
            this.lblRecepti.AutoSize = true;
            this.lblRecepti.BackColor = System.Drawing.Color.Transparent;
            this.lblRecepti.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblRecepti.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRecepti.Location = new System.Drawing.Point(936, 73);
            this.lblRecepti.Name = "lblRecepti";
            this.lblRecepti.Size = new System.Drawing.Size(80, 21);
            this.lblRecepti.TabIndex = 39;
            this.lblRecepti.Text = "Recepti:";
            // 
            // FrmProdaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1540, 652);
            this.Controls.Add(this.lblRecepti);
            this.Controls.Add(this.lblArtikli);
            this.Controls.Add(this.btnSve);
            this.Controls.Add(this.btnJedan);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.cmbStanje);
            this.Controls.Add(this.dgvRecepti);
            this.Controls.Add(this.btnRacun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKorisnik);
            this.Controls.Add(this.cmbLijek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvArtikli);
            this.Controls.Add(this.btnPovratak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProdaja";
            this.Text = "FrmProdaja";
            this.Load += new System.EventHandler(this.FrmProdaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSve;
        private System.Windows.Forms.Button btnJedan;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.ComboBox cmbStanje;
        private System.Windows.Forms.DataGridView dgvRecepti;
        private System.Windows.Forms.Button btnRacun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKorisnik;
        private System.Windows.Forms.ComboBox cmbLijek;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Label lblArtikli;
        private System.Windows.Forms.Label lblRecepti;
    }
}