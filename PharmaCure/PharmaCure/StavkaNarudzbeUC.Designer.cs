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
            this.cbxNaziv.Location = new System.Drawing.Point(15, 24);
            this.cbxNaziv.Name = "cbxNaziv";
            this.cbxNaziv.Size = new System.Drawing.Size(235, 25);
            this.cbxNaziv.TabIndex = 13;
            // 
            // tbxKolicina
            // 
            this.tbxKolicina.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbxKolicina.Location = new System.Drawing.Point(15, 87);
            this.tbxKolicina.Name = "tbxKolicina";
            this.tbxKolicina.Size = new System.Drawing.Size(131, 23);
            this.tbxKolicina.TabIndex = 12;
            this.tbxKolicina.TextChanged += new System.EventHandler(this.tbxKolicina_TextChanged);
            this.tbxKolicina.Leave += new System.EventHandler(this.tbxKolicina_Leave);
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKolicina.Location = new System.Drawing.Point(12, 71);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(59, 17);
            this.lblKolicina.TabIndex = 11;
            this.lblKolicina.Text = "Količina";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.Location = new System.Drawing.Point(12, 8);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(44, 17);
            this.lblNaziv.TabIndex = 10;
            this.lblNaziv.Text = "Naziv";
            // 
            // btnIzbaci
            // 
            this.btnIzbaci.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbaci.Location = new System.Drawing.Point(293, 53);
            this.btnIzbaci.Name = "btnIzbaci";
            this.btnIzbaci.Size = new System.Drawing.Size(89, 35);
            this.btnIzbaci.TabIndex = 14;
            this.btnIzbaci.Text = "Izbaci";
            this.btnIzbaci.UseVisualStyleBackColor = true;
            this.btnIzbaci.Click += new System.EventHandler(this.btnIzbaci_Click);
            // 
            // StavkaNarudzbeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnIzbaci);
            this.Controls.Add(this.cbxNaziv);
            this.Controls.Add(this.tbxKolicina);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.lblNaziv);
            this.Name = "StavkaNarudzbeUC";
            this.Size = new System.Drawing.Size(424, 120);
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
