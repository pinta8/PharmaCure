namespace PharmaCure
{
    partial class FrmPopisLijekova
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPopisLijekova));
            this.btnPovratak = new System.Windows.Forms.Button();
            this.dgvLijekovi = new System.Windows.Forms.DataGridView();
            this.lblArtikli = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekovi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPovratak.BackgroundImage")));
            this.btnPovratak.Font = new System.Drawing.Font("Century Gothic", 9.75F);
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
            this.dgvLijekovi.BackgroundColor = System.Drawing.Color.White;
            this.dgvLijekovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLijekovi.Location = new System.Drawing.Point(13, 42);
            this.dgvLijekovi.Name = "dgvLijekovi";
            this.dgvLijekovi.Size = new System.Drawing.Size(890, 348);
            this.dgvLijekovi.TabIndex = 2;
            this.dgvLijekovi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLijekovi_CellContentClick);
            // 
            // lblArtikli
            // 
            this.lblArtikli.AutoSize = true;
            this.lblArtikli.BackColor = System.Drawing.Color.Transparent;
            this.lblArtikli.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblArtikli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblArtikli.Location = new System.Drawing.Point(100, 16);
            this.lblArtikli.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArtikli.Name = "lblArtikli";
            this.lblArtikli.Size = new System.Drawing.Size(59, 17);
            this.lblArtikli.TabIndex = 39;
            this.lblArtikli.Text = "Lijekovi:";
            // 
            // FrmPopisLijekova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(915, 405);
            this.Controls.Add(this.lblArtikli);
            this.Controls.Add(this.dgvLijekovi);
            this.Controls.Add(this.btnPovratak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPopisLijekova";
            this.Text = "FrmPopisLijekova";
            this.Load += new System.EventHandler(this.FrmPopisLijekova_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPopisLijekova_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.DataGridView dgvLijekovi;
        private System.Windows.Forms.Label lblArtikli;
    }
}