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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnPosaljiNarudzbu = new System.Windows.Forms.Button();
            this.cbxNaziv = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPoslovnicaId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(139, 40);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv";
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(139, 155);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(44, 13);
            this.lblKolicina.TabIndex = 1;
            this.lblKolicina.Text = "Kolicina";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 4;
            // 
            // btnPosaljiNarudzbu
            // 
            this.btnPosaljiNarudzbu.Location = new System.Drawing.Point(157, 220);
            this.btnPosaljiNarudzbu.Name = "btnPosaljiNarudzbu";
            this.btnPosaljiNarudzbu.Size = new System.Drawing.Size(106, 54);
            this.btnPosaljiNarudzbu.TabIndex = 6;
            this.btnPosaljiNarudzbu.Text = "Pošalji narudžbu";
            this.btnPosaljiNarudzbu.UseVisualStyleBackColor = true;
            // 
            // cbxNaziv
            // 
            this.cbxNaziv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNaziv.FormattingEnabled = true;
            this.cbxNaziv.Location = new System.Drawing.Point(142, 56);
            this.cbxNaziv.Name = "cbxNaziv";
            this.cbxNaziv.Size = new System.Drawing.Size(121, 21);
            this.cbxNaziv.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 8;
            // 
            // lblPoslovnicaId
            // 
            this.lblPoslovnicaId.AutoSize = true;
            this.lblPoslovnicaId.Location = new System.Drawing.Point(139, 103);
            this.lblPoslovnicaId.Name = "lblPoslovnicaId";
            this.lblPoslovnicaId.Size = new System.Drawing.Size(73, 13);
            this.lblPoslovnicaId.TabIndex = 9;
            this.lblPoslovnicaId.Text = "Poslovnica ID";
            // 
            // FrmNabava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 308);
            this.Controls.Add(this.lblPoslovnicaId);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbxNaziv);
            this.Controls.Add(this.btnPosaljiNarudzbu);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.lblNaziv);
            this.Name = "FrmNabava";
            this.Text = "FrmNabava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnPosaljiNarudzbu;
        private System.Windows.Forms.ComboBox cbxNaziv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPoslovnicaId;
    }
}