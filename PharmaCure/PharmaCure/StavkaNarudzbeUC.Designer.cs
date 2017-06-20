namespace PharmaCure {
    partial class StavkaNarudzbeUC {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.cbxNaziv = new System.Windows.Forms.ComboBox();
            this.tbxKolicina = new System.Windows.Forms.TextBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.btnIzbaci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxNaziv
            // 
            this.cbxNaziv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNaziv.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxNaziv.FormattingEnabled = true;
            this.cbxNaziv.Location = new System.Drawing.Point(20, 43);
            this.cbxNaziv.Name = "cbxNaziv";
            this.cbxNaziv.Size = new System.Drawing.Size(121, 25);
            this.cbxNaziv.TabIndex = 13;
            // 
            // tbxKolicina
            // 
            this.tbxKolicina.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbxKolicina.Location = new System.Drawing.Point(20, 106);
            this.tbxKolicina.Name = "tbxKolicina";
            this.tbxKolicina.Size = new System.Drawing.Size(121, 23);
            this.tbxKolicina.TabIndex = 12;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKolicina.Location = new System.Drawing.Point(17, 90);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(59, 17);
            this.lblKolicina.TabIndex = 11;
            this.lblKolicina.Text = "Kolicina";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.Location = new System.Drawing.Point(17, 27);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(44, 17);
            this.lblNaziv.TabIndex = 10;
            this.lblNaziv.Text = "Naziv";
            // 
            // btnIzbaci
            // 
            this.btnIzbaci.Location = new System.Drawing.Point(164, 72);
            this.btnIzbaci.Name = "btnIzbaci";
            this.btnIzbaci.Size = new System.Drawing.Size(78, 35);
            this.btnIzbaci.TabIndex = 14;
            this.btnIzbaci.Text = "Izbaci";
            this.btnIzbaci.UseVisualStyleBackColor = true;
            // 
            // StavkaNarudzbeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnIzbaci);
            this.Controls.Add(this.cbxNaziv);
            this.Controls.Add(this.tbxKolicina);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.lblNaziv);
            this.Name = "StavkaNarudzbeUC";
            this.Size = new System.Drawing.Size(255, 172);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxNaziv;
        private System.Windows.Forms.TextBox tbxKolicina;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Button btnIzbaci;
    }
}
