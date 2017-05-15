namespace PharmaCure
{
    partial class FrmStanje
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
            this.dgvLijekovi = new System.Windows.Forms.DataGridView();
            this.btnNaruci = new System.Windows.Forms.Button();
            this.lblLijekovi = new System.Windows.Forms.Label();
            this.lblMinLijekovi = new System.Windows.Forms.Label();
            this.tbxMinLijekovi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekovi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(13, 13);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(75, 23);
            this.btnPovratak.TabIndex = 1;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // dgvLijekovi
            // 
            this.dgvLijekovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLijekovi.Location = new System.Drawing.Point(12, 101);
            this.dgvLijekovi.Name = "dgvLijekovi";
            this.dgvLijekovi.Size = new System.Drawing.Size(580, 263);
            this.dgvLijekovi.TabIndex = 2;
            // 
            // btnNaruci
            // 
            this.btnNaruci.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNaruci.Location = new System.Drawing.Point(235, 391);
            this.btnNaruci.Name = "btnNaruci";
            this.btnNaruci.Size = new System.Drawing.Size(109, 42);
            this.btnNaruci.TabIndex = 4;
            this.btnNaruci.Text = "Napravi narudžbu";
            this.btnNaruci.UseVisualStyleBackColor = true;
            // 
            // lblLijekovi
            // 
            this.lblLijekovi.AutoSize = true;
            this.lblLijekovi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLijekovi.Location = new System.Drawing.Point(13, 82);
            this.lblLijekovi.Name = "lblLijekovi";
            this.lblLijekovi.Size = new System.Drawing.Size(175, 17);
            this.lblLijekovi.TabIndex = 5;
            this.lblLijekovi.Text = "Stanje lijekova poslovnice";
            // 
            // lblMinLijekovi
            // 
            this.lblMinLijekovi.AutoSize = true;
            this.lblMinLijekovi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMinLijekovi.Location = new System.Drawing.Point(632, 81);
            this.lblMinLijekovi.Name = "lblMinLijekovi";
            this.lblMinLijekovi.Size = new System.Drawing.Size(177, 17);
            this.lblMinLijekovi.TabIndex = 6;
            this.lblMinLijekovi.Text = "Lijekovi koje treba naručiti";
            // 
            // tbxMinLijekovi
            // 
            this.tbxMinLijekovi.Location = new System.Drawing.Point(625, 101);
            this.tbxMinLijekovi.Multiline = true;
            this.tbxMinLijekovi.Name = "tbxMinLijekovi";
            this.tbxMinLijekovi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxMinLijekovi.Size = new System.Drawing.Size(278, 263);
            this.tbxMinLijekovi.TabIndex = 7;
            // 
            // FrmStanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 485);
            this.Controls.Add(this.tbxMinLijekovi);
            this.Controls.Add(this.lblMinLijekovi);
            this.Controls.Add(this.lblLijekovi);
            this.Controls.Add(this.btnNaruci);
            this.Controls.Add(this.dgvLijekovi);
            this.Controls.Add(this.btnPovratak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStanje";
            this.Text = "FrmStanje";
            this.Load += new System.EventHandler(this.FrmStanje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.DataGridView dgvLijekovi;
        private System.Windows.Forms.Button btnNaruci;
        private System.Windows.Forms.Label lblLijekovi;
        private System.Windows.Forms.Label lblMinLijekovi;
        private System.Windows.Forms.TextBox tbxMinLijekovi;
    }
}