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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNabava));
            this.btnPosaljiNarudzbu = new System.Windows.Forms.Button();
            this.flpStavke = new System.Windows.Forms.FlowLayoutPanel();
            this.tbxCijena = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPosaljiNarudzbu
            // 
            this.btnPosaljiNarudzbu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPosaljiNarudzbu.BackgroundImage")));
            this.btnPosaljiNarudzbu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPosaljiNarudzbu.Location = new System.Drawing.Point(539, 334);
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
            this.flpStavke.Location = new System.Drawing.Point(12, 96);
            this.flpStavke.Name = "flpStavke";
            this.flpStavke.Size = new System.Drawing.Size(441, 428);
            this.flpStavke.TabIndex = 7;
            this.flpStavke.Paint += new System.Windows.Forms.PaintEventHandler(this.flpStavke_Paint);
            // 
            // tbxCijena
            // 
            this.tbxCijena.Location = new System.Drawing.Point(521, 231);
            this.tbxCijena.Name = "tbxCijena";
            this.tbxCijena.ReadOnly = true;
            this.tbxCijena.Size = new System.Drawing.Size(138, 20);
            this.tbxCijena.TabIndex = 8;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDodaj.BackgroundImage")));
            this.btnDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDodaj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.Location = new System.Drawing.Point(12, 58);
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(521, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ukupna cijena narudžbe (kn) :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPovratak.BackgroundImage")));
            this.btnPovratak.Location = new System.Drawing.Point(12, 12);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(75, 23);
            this.btnPovratak.TabIndex = 11;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // FrmNabava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(802, 535);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.tbxCijena);
            this.Controls.Add(this.flpStavke);
            this.Controls.Add(this.btnPosaljiNarudzbu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNabava";
            this.Text = "FrmNabava";
            this.Load += new System.EventHandler(this.FrmNabava_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmNabava_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPosaljiNarudzbu;
        private System.Windows.Forms.FlowLayoutPanel flpStavke;
        private System.Windows.Forms.TextBox tbxCijena;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPovratak;
    }
}