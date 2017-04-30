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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtIDKlijent = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDLijek = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekoviRecept)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(13, 13);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(75, 23);
            this.btnPovratak.TabIndex = 0;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // dgvLijekoviRecept
            // 
            this.dgvLijekoviRecept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLijekoviRecept.Location = new System.Drawing.Point(372, 13);
            this.dgvLijekoviRecept.Name = "dgvLijekoviRecept";
            this.dgvLijekoviRecept.Size = new System.Drawing.Size(531, 460);
            this.dgvLijekoviRecept.TabIndex = 1;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(116, 172);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(215, 20);
            this.txtNaziv.TabIndex = 2;
            // 
            // txtIDKlijent
            // 
            this.txtIDKlijent.Location = new System.Drawing.Point(116, 247);
            this.txtIDKlijent.Name = "txtIDKlijent";
            this.txtIDKlijent.Size = new System.Drawing.Size(215, 20);
            this.txtIDKlijent.TabIndex = 3;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(115, 322);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(215, 20);
            this.txtKolicina.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID Klijenta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kolicina:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(213, 403);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(117, 23);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID Lijek:";
            // 
            // txtIDLijek
            // 
            this.txtIDLijek.Location = new System.Drawing.Point(115, 97);
            this.txtIDLijek.Name = "txtIDLijek";
            this.txtIDLijek.Size = new System.Drawing.Size(215, 20);
            this.txtIDLijek.TabIndex = 11;
            // 
            // FrmRecepti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 485);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIDLijek);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.txtIDKlijent);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.dgvLijekoviRecept);
            this.Controls.Add(this.btnPovratak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRecepti";
            this.Text = "FrmRecepti";
            this.Load += new System.EventHandler(this.FrmRecepti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekoviRecept)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.DataGridView dgvLijekoviRecept;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtIDKlijent;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDLijek;
    }
}