namespace PharmaCure
{
    partial class FrmDostava
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
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmbLijek = new System.Windows.Forms.ComboBox();
            this.txtKorisnik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRacun = new System.Windows.Forms.Button();
            this.dgvRecepti = new System.Windows.Forms.DataGridView();
            this.cmbStanje = new System.Windows.Forms.ComboBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnJedan = new System.Windows.Forms.Button();
            this.btnSve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(17, 30);
            this.btnPovratak.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(100, 28);
            this.btnPovratak.TabIndex = 2;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Location = new System.Drawing.Point(17, 81);
            this.dgvArtikli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArtikli.Size = new System.Drawing.Size(853, 501);
            this.dgvArtikli.TabIndex = 3;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(1281, 28);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 28);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1419, 28);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Dostavljeno";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbLijek
            // 
            this.cmbLijek.FormattingEnabled = true;
            this.cmbLijek.Location = new System.Drawing.Point(1047, 30);
            this.cmbLijek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLijek.Name = "cmbLijek";
            this.cmbLijek.Size = new System.Drawing.Size(209, 24);
            this.cmbLijek.TabIndex = 6;
            // 
            // txtKorisnik
            // 
            this.txtKorisnik.Location = new System.Drawing.Point(157, 33);
            this.txtKorisnik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKorisnik.Name = "txtKorisnik";
            this.txtKorisnik.Size = new System.Drawing.Size(165, 22);
            this.txtKorisnik.TabIndex = 7;
            this.txtKorisnik.TextChanged += new System.EventHandler(this.txtKorisnik_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Korisnik ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1044, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lijek:";
            // 
            // txtCijena
            // 
            this.txtCijena.Enabled = false;
            this.txtCijena.Location = new System.Drawing.Point(1392, 592);
            this.txtCijena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.ReadOnly = true;
            this.txtCijena.Size = new System.Drawing.Size(125, 22);
            this.txtCijena.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1325, 596);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cijena:";
            // 
            // btnRacun
            // 
            this.btnRacun.Location = new System.Drawing.Point(184, 592);
            this.btnRacun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRacun.Name = "btnRacun";
            this.btnRacun.Size = new System.Drawing.Size(168, 33);
            this.btnRacun.TabIndex = 12;
            this.btnRacun.Text = "Dodaj Račun";
            this.btnRacun.UseVisualStyleBackColor = true;
            this.btnRacun.Click += new System.EventHandler(this.btnRacun_Click);
            // 
            // dgvRecepti
            // 
            this.dgvRecepti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecepti.Location = new System.Drawing.Point(931, 81);
            this.dgvRecepti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRecepti.Name = "dgvRecepti";
            this.dgvRecepti.RowTemplate.Height = 24;
            this.dgvRecepti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecepti.Size = new System.Drawing.Size(588, 501);
            this.dgvRecepti.TabIndex = 13;
            // 
            // cmbStanje
            // 
            this.cmbStanje.FormattingEnabled = true;
            this.cmbStanje.Location = new System.Drawing.Point(17, 597);
            this.cmbStanje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStanje.Name = "cmbStanje";
            this.cmbStanje.Size = new System.Drawing.Size(144, 24);
            this.cmbStanje.TabIndex = 14;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(964, 30);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(61, 22);
            this.txtKolicina.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(961, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Količlina:";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(373, 592);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(84, 32);
            this.btnObrisi.TabIndex = 17;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnJedan
            // 
            this.btnJedan.Location = new System.Drawing.Point(877, 278);
            this.btnJedan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJedan.Name = "btnJedan";
            this.btnJedan.Size = new System.Drawing.Size(47, 38);
            this.btnJedan.TabIndex = 18;
            this.btnJedan.Text = "<";
            this.btnJedan.UseVisualStyleBackColor = true;
            this.btnJedan.Click += new System.EventHandler(this.btnJedan_Click);
            // 
            // btnSve
            // 
            this.btnSve.Location = new System.Drawing.Point(877, 338);
            this.btnSve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSve.Name = "btnSve";
            this.btnSve.Size = new System.Drawing.Size(47, 38);
            this.btnSve.TabIndex = 19;
            this.btnSve.Text = "<<";
            this.btnSve.UseVisualStyleBackColor = true;
            this.btnSve.Click += new System.EventHandler(this.btnSve_Click);
            // 
            // FrmDostava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 636);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKorisnik);
            this.Controls.Add(this.cmbLijek);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvArtikli);
            this.Controls.Add(this.btnPovratak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDostava";
            this.Text = "FrmDostava";
            this.Load += new System.EventHandler(this.FrmDostava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbLijek;
        private System.Windows.Forms.TextBox txtKorisnik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRacun;
        private System.Windows.Forms.DataGridView dgvRecepti;
        private System.Windows.Forms.ComboBox cmbStanje;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnJedan;
        private System.Windows.Forms.Button btnSve;
    }
}