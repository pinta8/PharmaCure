namespace PharmaCure
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnZaposlenici = new System.Windows.Forms.Button();
            this.btnNabava = new System.Windows.Forms.Button();
            this.btnPopisL = new System.Windows.Forms.Button();
            this.btnDostava = new System.Windows.Forms.Button();
            this.btnKolicina = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnProdaja = new System.Windows.Forms.Button();
            this.btnRecepti = new System.Windows.Forms.Button();
            this.btnDodajPoslovnicu = new System.Windows.Forms.Button();
            this.lblTip = new System.Windows.Forms.Label();
            this.btnKlijent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZaposlenici
            // 
            this.btnZaposlenici.BackColor = System.Drawing.SystemColors.Control;
            this.btnZaposlenici.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZaposlenici.Image = ((System.Drawing.Image)(resources.GetObject("btnZaposlenici.Image")));
            this.btnZaposlenici.Location = new System.Drawing.Point(240, 356);
            this.btnZaposlenici.Name = "btnZaposlenici";
            this.btnZaposlenici.Size = new System.Drawing.Size(108, 95);
            this.btnZaposlenici.TabIndex = 1;
            this.btnZaposlenici.Text = "Dodaj Zaposlenika";
            this.btnZaposlenici.UseVisualStyleBackColor = false;
            this.btnZaposlenici.Click += new System.EventHandler(this.btnZaposlenici_Click);
            // 
            // btnNabava
            // 
            this.btnNabava.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNabava.Image = ((System.Drawing.Image)(resources.GetObject("btnNabava.Image")));
            this.btnNabava.Location = new System.Drawing.Point(48, 221);
            this.btnNabava.Name = "btnNabava";
            this.btnNabava.Size = new System.Drawing.Size(108, 95);
            this.btnNabava.TabIndex = 2;
            this.btnNabava.Text = "Nabava Lijekova";
            this.btnNabava.UseVisualStyleBackColor = true;
            this.btnNabava.Click += new System.EventHandler(this.btnNabava_Click);
            // 
            // btnPopisL
            // 
            this.btnPopisL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPopisL.Image = ((System.Drawing.Image)(resources.GetObject("btnPopisL.Image")));
            this.btnPopisL.Location = new System.Drawing.Point(48, 86);
            this.btnPopisL.Name = "btnPopisL";
            this.btnPopisL.Size = new System.Drawing.Size(108, 95);
            this.btnPopisL.TabIndex = 3;
            this.btnPopisL.Text = "Popis Lijekova";
            this.btnPopisL.UseVisualStyleBackColor = true;
            this.btnPopisL.Click += new System.EventHandler(this.btnPopisL_Click);
            // 
            // btnDostava
            // 
            this.btnDostava.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDostava.Image = ((System.Drawing.Image)(resources.GetObject("btnDostava.Image")));
            this.btnDostava.Location = new System.Drawing.Point(240, 221);
            this.btnDostava.Name = "btnDostava";
            this.btnDostava.Size = new System.Drawing.Size(108, 95);
            this.btnDostava.TabIndex = 4;
            this.btnDostava.Text = "Dostava Lijekova";
            this.btnDostava.UseVisualStyleBackColor = true;
            this.btnDostava.Click += new System.EventHandler(this.btnDostava_Click);
            // 
            // btnKolicina
            // 
            this.btnKolicina.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKolicina.Image = ((System.Drawing.Image)(resources.GetObject("btnKolicina.Image")));
            this.btnKolicina.Location = new System.Drawing.Point(432, 86);
            this.btnKolicina.Name = "btnKolicina";
            this.btnKolicina.Size = new System.Drawing.Size(108, 95);
            this.btnKolicina.TabIndex = 5;
            this.btnKolicina.Text = "Pregled Količine Lijekova";
            this.btnKolicina.UseVisualStyleBackColor = true;
            this.btnKolicina.Click += new System.EventHandler(this.btnKolicina_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzlaz.Image = ((System.Drawing.Image)(resources.GetObject("btnIzlaz.Image")));
            this.btnIzlaz.Location = new System.Drawing.Point(48, 20);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(108, 33);
            this.btnIzlaz.TabIndex = 6;
            this.btnIzlaz.Text = "Odjavi se";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click_1);
            // 
            // btnProdaja
            // 
            this.btnProdaja.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProdaja.Image = ((System.Drawing.Image)(resources.GetObject("btnProdaja.Image")));
            this.btnProdaja.Location = new System.Drawing.Point(240, 86);
            this.btnProdaja.Name = "btnProdaja";
            this.btnProdaja.Size = new System.Drawing.Size(108, 95);
            this.btnProdaja.TabIndex = 7;
            this.btnProdaja.Text = "Prodaja Lijekova";
            this.btnProdaja.UseVisualStyleBackColor = true;
            this.btnProdaja.Click += new System.EventHandler(this.btnProdaja_Click);
            // 
            // btnRecepti
            // 
            this.btnRecepti.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRecepti.Image = ((System.Drawing.Image)(resources.GetObject("btnRecepti.Image")));
            this.btnRecepti.Location = new System.Drawing.Point(432, 356);
            this.btnRecepti.Name = "btnRecepti";
            this.btnRecepti.Size = new System.Drawing.Size(108, 95);
            this.btnRecepti.TabIndex = 8;
            this.btnRecepti.Text = "Dodaj Recept";
            this.btnRecepti.UseVisualStyleBackColor = true;
            this.btnRecepti.Click += new System.EventHandler(this.btnRecepti_Click);
            // 
            // btnDodajPoslovnicu
            // 
            this.btnDodajPoslovnicu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajPoslovnicu.Image = ((System.Drawing.Image)(resources.GetObject("btnDodajPoslovnicu.Image")));
            this.btnDodajPoslovnicu.Location = new System.Drawing.Point(48, 356);
            this.btnDodajPoslovnicu.Name = "btnDodajPoslovnicu";
            this.btnDodajPoslovnicu.Size = new System.Drawing.Size(108, 95);
            this.btnDodajPoslovnicu.TabIndex = 9;
            this.btnDodajPoslovnicu.Text = "Dodaj Poslovnicu";
            this.btnDodajPoslovnicu.UseVisualStyleBackColor = true;
            this.btnDodajPoslovnicu.Click += new System.EventHandler(this.btnDodajPoslovnicu_Click);
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.BackColor = System.Drawing.Color.Transparent;
            this.lblTip.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTip.ForeColor = System.Drawing.Color.Black;
            this.lblTip.Location = new System.Drawing.Point(333, 28);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(49, 16);
            this.lblTip.TabIndex = 10;
            this.lblTip.Text = "label1";
            // 
            // btnKlijent
            // 
            this.btnKlijent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKlijent.Image = ((System.Drawing.Image)(resources.GetObject("btnKlijent.Image")));
            this.btnKlijent.Location = new System.Drawing.Point(432, 221);
            this.btnKlijent.Name = "btnKlijent";
            this.btnKlijent.Size = new System.Drawing.Size(108, 95);
            this.btnKlijent.TabIndex = 11;
            this.btnKlijent.Text = "Dodaj Klijenta";
            this.btnKlijent.UseVisualStyleBackColor = true;
            this.btnKlijent.Click += new System.EventHandler(this.btnKlijent_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(588, 491);
            this.Controls.Add(this.btnKlijent);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.btnDodajPoslovnicu);
            this.Controls.Add(this.btnRecepti);
            this.Controls.Add(this.btnProdaja);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnKolicina);
            this.Controls.Add(this.btnDostava);
            this.Controls.Add(this.btnPopisL);
            this.Controls.Add(this.btnNabava);
            this.Controls.Add(this.btnZaposlenici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZaposlenici;
        private System.Windows.Forms.Button btnNabava;
        private System.Windows.Forms.Button btnPopisL;
        private System.Windows.Forms.Button btnDostava;
        private System.Windows.Forms.Button btnKolicina;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnProdaja;
        private System.Windows.Forms.Button btnRecepti;
		private System.Windows.Forms.Button btnDodajPoslovnicu;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Button btnKlijent;
    }
}