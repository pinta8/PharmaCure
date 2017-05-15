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
            this.tbxKolicina = new System.Windows.Forms.TextBox();
            this.btnPosaljiNarudzbu = new System.Windows.Forms.Button();
            this.cbxNaziv = new System.Windows.Forms.ComboBox();
            this.tbxPoslovnciaId = new System.Windows.Forms.TextBox();
            this.lblPoslovnicaId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.Location = new System.Drawing.Point(139, 35);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(44, 17);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv";
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKolicina.Location = new System.Drawing.Point(139, 155);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(59, 17);
            this.lblKolicina.TabIndex = 1;
            this.lblKolicina.Text = "Kolicina";
            // 
            // tbxKolicina
            // 
            this.tbxKolicina.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbxKolicina.Location = new System.Drawing.Point(142, 171);
            this.tbxKolicina.Name = "tbxKolicina";
            this.tbxKolicina.Size = new System.Drawing.Size(121, 23);
            this.tbxKolicina.TabIndex = 4;
            // 
            // btnPosaljiNarudzbu
            // 
            this.btnPosaljiNarudzbu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPosaljiNarudzbu.Location = new System.Drawing.Point(142, 226);
            this.btnPosaljiNarudzbu.Name = "btnPosaljiNarudzbu";
            this.btnPosaljiNarudzbu.Size = new System.Drawing.Size(106, 54);
            this.btnPosaljiNarudzbu.TabIndex = 6;
            this.btnPosaljiNarudzbu.Text = "Pošalji narudžbu";
            this.btnPosaljiNarudzbu.UseVisualStyleBackColor = true;
            this.btnPosaljiNarudzbu.Click += new System.EventHandler(this.btnPosaljiNarudzbu_Click);
            // 
            // cbxNaziv
            // 
            this.cbxNaziv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNaziv.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxNaziv.FormattingEnabled = true;
            this.cbxNaziv.Location = new System.Drawing.Point(142, 51);
            this.cbxNaziv.Name = "cbxNaziv";
            this.cbxNaziv.Size = new System.Drawing.Size(121, 25);
            this.cbxNaziv.TabIndex = 7;
            // 
            // tbxPoslovnciaId
            // 
            this.tbxPoslovnciaId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbxPoslovnciaId.Location = new System.Drawing.Point(142, 119);
            this.tbxPoslovnciaId.Name = "tbxPoslovnciaId";
            this.tbxPoslovnciaId.Size = new System.Drawing.Size(121, 23);
            this.tbxPoslovnciaId.TabIndex = 8;
            // 
            // lblPoslovnicaId
            // 
            this.lblPoslovnicaId.AutoSize = true;
            this.lblPoslovnicaId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPoslovnicaId.Location = new System.Drawing.Point(139, 99);
            this.lblPoslovnicaId.Name = "lblPoslovnicaId";
            this.lblPoslovnicaId.Size = new System.Drawing.Size(95, 17);
            this.lblPoslovnicaId.TabIndex = 9;
            this.lblPoslovnicaId.Text = "Poslovnica ID";
            // 
            // FrmNabava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 308);
            this.Controls.Add(this.lblPoslovnicaId);
            this.Controls.Add(this.tbxPoslovnciaId);
            this.Controls.Add(this.cbxNaziv);
            this.Controls.Add(this.btnPosaljiNarudzbu);
            this.Controls.Add(this.tbxKolicina);
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
        private System.Windows.Forms.TextBox tbxKolicina;
        private System.Windows.Forms.Button btnPosaljiNarudzbu;
        private System.Windows.Forms.ComboBox cbxNaziv;
        private System.Windows.Forms.TextBox tbxPoslovnciaId;
        private System.Windows.Forms.Label lblPoslovnicaId;
    }
}