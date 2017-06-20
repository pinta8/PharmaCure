namespace PharmaCure {
    partial class FrmNabava {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnPosaljiNarudzbu = new System.Windows.Forms.Button();
            this.flpStavke = new System.Windows.Forms.FlowLayoutPanel();
            this.tbxCijena = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPosaljiNarudzbu
            // 
            this.btnPosaljiNarudzbu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPosaljiNarudzbu.Location = new System.Drawing.Point(548, 282);
            this.btnPosaljiNarudzbu.Name = "btnPosaljiNarudzbu";
            this.btnPosaljiNarudzbu.Size = new System.Drawing.Size(106, 54);
            this.btnPosaljiNarudzbu.TabIndex = 6;
            this.btnPosaljiNarudzbu.Text = "Pošalji narudžbu";
            this.btnPosaljiNarudzbu.UseVisualStyleBackColor = true;
            this.btnPosaljiNarudzbu.Click += new System.EventHandler(this.btnPosaljiNarudzbu_Click);
            // 
            // flpStavke
            // 
            this.flpStavke.AutoScroll = true;
            this.flpStavke.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpStavke.Location = new System.Drawing.Point(21, 44);
            this.flpStavke.Name = "flpStavke";
            this.flpStavke.Size = new System.Drawing.Size(441, 428);
            this.flpStavke.TabIndex = 7;
            // 
            // tbxCijena
            // 
            this.tbxCijena.Location = new System.Drawing.Point(530, 179);
            this.tbxCijena.Name = "tbxCijena";
            this.tbxCijena.ReadOnly = true;
            this.tbxCijena.Size = new System.Drawing.Size(138, 20);
            this.tbxCijena.TabIndex = 8;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.Location = new System.Drawing.Point(21, 6);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(441, 32);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj lijek";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(530, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ukupna cijena narudžbe (kn) :";
            // 
            // FrmNabava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 484);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.tbxCijena);
            this.Controls.Add(this.flpStavke);
            this.Controls.Add(this.btnPosaljiNarudzbu);
            this.Name = "FrmNabava";
            this.Text = "FrmNabava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPosaljiNarudzbu;
        private System.Windows.Forms.FlowLayoutPanel flpStavke;
        private System.Windows.Forms.TextBox tbxCijena;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label1;
    }
}