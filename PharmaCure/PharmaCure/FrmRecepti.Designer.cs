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
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekoviRecept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekoviPravo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(17, 26);
            this.btnPovratak.Margin = new System.Windows.Forms.Padding(4);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(100, 28);
            this.btnPovratak.TabIndex = 0;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // dgvLijekoviRecept
            // 
            this.dgvLijekoviRecept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLijekoviRecept.Location = new System.Drawing.Point(629, 88);
            this.dgvLijekoviRecept.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLijekoviRecept.Name = "dgvLijekoviRecept";
            this.dgvLijekoviRecept.Size = new System.Drawing.Size(578, 485);
            this.dgvLijekoviRecept.TabIndex = 1;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(900, 584);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(4);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(91, 22);
            this.txtKolicina.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID Klijenta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(831, 587);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kolicina:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(1051, 26);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(156, 28);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtIDKlijent
            // 
            this.txtIDKlijent.Location = new System.Drawing.Point(153, 29);
            this.txtIDKlijent.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDKlijent.Name = "txtIDKlijent";
            this.txtIDKlijent.Size = new System.Drawing.Size(137, 22);
            this.txtIDKlijent.TabIndex = 11;
            this.txtIDKlijent.TextChanged += new System.EventHandler(this.txtIDLijek_TextChanged);
            // 
            // dgvLijekoviPravo
            // 
            this.dgvLijekoviPravo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLijekoviPravo.Location = new System.Drawing.Point(20, 88);
            this.dgvLijekoviPravo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLijekoviPravo.Name = "dgvLijekoviPravo";
            this.dgvLijekoviPravo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLijekoviPravo.Size = new System.Drawing.Size(575, 485);
            this.dgvLijekoviPravo.TabIndex = 12;
            this.dgvLijekoviPravo.SelectionChanged += new System.EventHandler(this.dgvLijekoviPravo_SelectionChanged);
            // 
            // btnPropisi
            // 
            this.btnPropisi.Location = new System.Drawing.Point(1051, 581);
            this.btnPropisi.Name = "btnPropisi";
            this.btnPropisi.Size = new System.Drawing.Size(156, 28);
            this.btnPropisi.TabIndex = 13;
            this.btnPropisi.Text = "Propiši";
            this.btnPropisi.UseVisualStyleBackColor = true;
            this.btnPropisi.Click += new System.EventHandler(this.btnPropisi_Click);
            // 
            // cmbOsiguranje
            // 
            this.cmbOsiguranje.FormattingEnabled = true;
            this.cmbOsiguranje.Location = new System.Drawing.Point(20, 583);
            this.cmbOsiguranje.Name = "cmbOsiguranje";
            this.cmbOsiguranje.Size = new System.Drawing.Size(575, 24);
            this.cmbOsiguranje.TabIndex = 14;
            // 
            // FrmRecepti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 624);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}