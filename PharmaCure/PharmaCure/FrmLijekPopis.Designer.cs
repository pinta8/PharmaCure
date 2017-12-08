namespace PharmaCure
{
    partial class FrmLijekoviPopis
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLijekoviPopis));
            this.btnPovratak = new System.Windows.Forms.Button();
            this.lblArtikli = new System.Windows.Forms.Label();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnPromijeni = new System.Windows.Forms.Button();
            this.btnNoviLijek = new System.Windows.Forms.Button();
            this.txtBoxPretrazi = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.pregledLijekovaKategorijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._17003_DBDataSet = new PharmaCure._17003_DBDataSet();
            this.lijekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lijekoviTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.LijekoviTableAdapter();
            this.tableAdapterManager = new PharmaCure._17003_DBDataSetTableAdapters.TableAdapterManager();
            this.kategorijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorijaTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.KategorijaTableAdapter();
            this.pregledLijekovaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pregledLijekovaTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.PregledLijekovaTableAdapter();
            this.pregledLijekovaKategorijaTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.PregledLijekovaKategorijaTableAdapter();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLijekovi = new System.Windows.Forms.DataGridView();
            this.Stanje = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.comboBoxPretraga = new System.Windows.Forms.ComboBox();
            this.lblPretragaCombo = new System.Windows.Forms.Label();
            this.lblPretragaTekst = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pregledLijekovaKategorijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._17003_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledLijekovaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekovi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPovratak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnPovratak.Location = new System.Drawing.Point(12, 7);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(75, 23);
            this.btnPovratak.TabIndex = 1;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // lblArtikli
            // 
            this.lblArtikli.AutoSize = true;
            this.lblArtikli.BackColor = System.Drawing.Color.Transparent;
            this.lblArtikli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtikli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblArtikli.Location = new System.Drawing.Point(9, 84);
            this.lblArtikli.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArtikli.Name = "lblArtikli";
            this.lblArtikli.Size = new System.Drawing.Size(57, 16);
            this.lblArtikli.TabIndex = 39;
            this.lblArtikli.Text = "Lijekovi:";
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(829, 12);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 50;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnPromijeni
            // 
            this.btnPromijeni.Location = new System.Drawing.Point(246, 54);
            this.btnPromijeni.Name = "btnPromijeni";
            this.btnPromijeni.Size = new System.Drawing.Size(142, 38);
            this.btnPromijeni.TabIndex = 51;
            this.btnPromijeni.Text = "Promijeni podatke";
            this.btnPromijeni.UseVisualStyleBackColor = true;
            this.btnPromijeni.Click += new System.EventHandler(this.btnPromijeni_Click);
            // 
            // btnNoviLijek
            // 
            this.btnNoviLijek.Location = new System.Drawing.Point(83, 54);
            this.btnNoviLijek.Name = "btnNoviLijek";
            this.btnNoviLijek.Size = new System.Drawing.Size(142, 38);
            this.btnNoviLijek.TabIndex = 53;
            this.btnNoviLijek.Text = "Unesi novi lijek";
            this.btnNoviLijek.UseVisualStyleBackColor = true;
            this.btnNoviLijek.Click += new System.EventHandler(this.btnNoviLijek_Click);
            // 
            // txtBoxPretrazi
            // 
            this.txtBoxPretrazi.Location = new System.Drawing.Point(696, 72);
            this.txtBoxPretrazi.Name = "txtBoxPretrazi";
            this.txtBoxPretrazi.Size = new System.Drawing.Size(92, 20);
            this.txtBoxPretrazi.TabIndex = 54;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(818, 69);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(79, 26);
            this.btnPretrazi.TabIndex = 55;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // pregledLijekovaKategorijaBindingSource
            // 
            this.pregledLijekovaKategorijaBindingSource.DataMember = "PregledLijekovaKategorija";
            this.pregledLijekovaKategorijaBindingSource.DataSource = this._17003_DBDataSet;
            // 
            // _17003_DBDataSet
            // 
            this._17003_DBDataSet.DataSetName = "_17003_DBDataSet";
            this._17003_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lijekoviBindingSource
            // 
            this.lijekoviBindingSource.DataMember = "Lijekovi";
            this.lijekoviBindingSource.DataSource = this._17003_DBDataSet;
            // 
            // lijekoviTableAdapter
            // 
            this.lijekoviTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AkcijaTableAdapter = null;
            this.tableAdapterManager.Artikli_RacunTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DjelatnikTableAdapter = null;
            this.tableAdapterManager.DostupnostTableAdapter = null;
            this.tableAdapterManager.KategorijaTableAdapter = null;
            this.tableAdapterManager.KlijentTableAdapter = null;
            this.tableAdapterManager.LijekoviOsiguranjeTableAdapter = null;
            this.tableAdapterManager.LijekoviReceptTableAdapter = null;
            this.tableAdapterManager.LijekoviTableAdapter = this.lijekoviTableAdapter;
            this.tableAdapterManager.NarudzbaTableAdapter = null;
            this.tableAdapterManager.OsiguranjeTableAdapter = null;
            this.tableAdapterManager.PopisOsiguranihLijekovaTableAdapter = null;
            this.tableAdapterManager.PopisTableAdapter = null;
            this.tableAdapterManager.PoslovnicaTableAdapter = null;
            this.tableAdapterManager.RacunTableAdapter = null;
            this.tableAdapterManager.RezervacijaTableAdapter = null;
            this.tableAdapterManager.StanjaTableAdapter = null;
            this.tableAdapterManager.StavkeNarudzbeTableAdapter = null;
            this.tableAdapterManager.TipDjelatnikaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PharmaCure._17003_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kategorijaBindingSource
            // 
            this.kategorijaBindingSource.DataMember = "Kategorija";
            this.kategorijaBindingSource.DataSource = this._17003_DBDataSet;
            // 
            // kategorijaTableAdapter
            // 
            this.kategorijaTableAdapter.ClearBeforeFill = true;
            // 
            // pregledLijekovaBindingSource
            // 
            this.pregledLijekovaBindingSource.DataMember = "PregledLijekova";
            this.pregledLijekovaBindingSource.DataSource = this._17003_DBDataSet;
            // 
            // pregledLijekovaTableAdapter
            // 
            this.pregledLijekovaTableAdapter.ClearBeforeFill = true;
            // 
            // pregledLijekovaKategorijaTableAdapter
            // 
            this.pregledLijekovaKategorijaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "NazivKategorije";
            this.dataGridViewTextBoxColumn17.HeaderText = "Naziv kategorije";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 140;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Zemlja_porijekla";
            this.dataGridViewTextBoxColumn15.HeaderText = "Zemlja porijekla";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 110;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Cijena";
            this.dataGridViewTextBoxColumn14.HeaderText = "Cijena";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 60;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Datum_isteka";
            this.dataGridViewTextBoxColumn13.HeaderText = "Datum isteka";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 92;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Datum_proizvodnje";
            this.dataGridViewTextBoxColumn12.HeaderText = "Datum proizvodnje";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 118;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Kratki_opis";
            this.dataGridViewTextBoxColumn11.HeaderText = "Kratki opis";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "naziv";
            this.dataGridViewTextBoxColumn10.HeaderText = "Naziv lijeka";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ID_Lijek";
            this.dataGridViewTextBoxColumn9.HeaderText = "ID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 30;
            // 
            // dgvLijekovi
            // 
            this.dgvLijekovi.AutoGenerateColumns = false;
            this.dgvLijekovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLijekovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn17,
            this.Stanje});
            this.dgvLijekovi.DataSource = this.pregledLijekovaKategorijaBindingSource;
            this.dgvLijekovi.Location = new System.Drawing.Point(8, 116);
            this.dgvLijekovi.Name = "dgvLijekovi";
            this.dgvLijekovi.ReadOnly = true;
            this.dgvLijekovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLijekovi.Size = new System.Drawing.Size(896, 257);
            this.dgvLijekovi.TabIndex = 54;
            // 
            // Stanje
            // 
            this.Stanje.DataPropertyName = "Stanje";
            this.Stanje.HeaderText = "Stanje";
            this.Stanje.Name = "Stanje";
            this.Stanje.ReadOnly = true;
            // 
            // comboBoxPretraga
            // 
            this.comboBoxPretraga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPretraga.FormattingEnabled = true;
            this.comboBoxPretraga.Items.AddRange(new object[] {
            "ID ",
            "Naziv"});
            this.comboBoxPretraga.Location = new System.Drawing.Point(517, 72);
            this.comboBoxPretraga.Name = "comboBoxPretraga";
            this.comboBoxPretraga.Size = new System.Drawing.Size(88, 21);
            this.comboBoxPretraga.TabIndex = 56;
            // 
            // lblPretragaCombo
            // 
            this.lblPretragaCombo.AutoSize = true;
            this.lblPretragaCombo.BackColor = System.Drawing.Color.Transparent;
            this.lblPretragaCombo.Location = new System.Drawing.Point(434, 76);
            this.lblPretragaCombo.Name = "lblPretragaCombo";
            this.lblPretragaCombo.Size = new System.Drawing.Size(77, 13);
            this.lblPretragaCombo.TabIndex = 57;
            this.lblPretragaCombo.Text = "Pretraži prema:";
            // 
            // lblPretragaTekst
            // 
            this.lblPretragaTekst.AutoSize = true;
            this.lblPretragaTekst.BackColor = System.Drawing.Color.Transparent;
            this.lblPretragaTekst.Location = new System.Drawing.Point(611, 76);
            this.lblPretragaTekst.Name = "lblPretragaTekst";
            this.lblPretragaTekst.Size = new System.Drawing.Size(79, 13);
            this.lblPretragaTekst.TabIndex = 58;
            this.lblPretragaTekst.Text = "Tekst pretrage:";
            // 
            // FrmLijekoviPopis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(916, 385);
            this.ControlBox = false;
            this.Controls.Add(this.lblPretragaTekst);
            this.Controls.Add(this.lblPretragaCombo);
            this.Controls.Add(this.comboBoxPretraga);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.dgvLijekovi);
            this.Controls.Add(this.txtBoxPretrazi);
            this.Controls.Add(this.btnNoviLijek);
            this.Controls.Add(this.btnPromijeni);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.lblArtikli);
            this.Controls.Add(this.btnPovratak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(150, 150);
            this.Name = "FrmLijekoviPopis";
            this.Text = "FrmPopisLijekova";
            this.Load += new System.EventHandler(this.FrmPopisLijekova_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPopisLijekova_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pregledLijekovaKategorijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._17003_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledLijekovaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Label lblArtikli;
        private _17003_DBDataSet _17003_DBDataSet;
        private System.Windows.Forms.BindingSource lijekoviBindingSource;
        private _17003_DBDataSetTableAdapters.LijekoviTableAdapter lijekoviTableAdapter;
        private _17003_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource kategorijaBindingSource;
        private _17003_DBDataSetTableAdapters.KategorijaTableAdapter kategorijaTableAdapter;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnPromijeni;
        private System.Windows.Forms.Button btnNoviLijek;
        private System.Windows.Forms.BindingSource pregledLijekovaBindingSource;
        private _17003_DBDataSetTableAdapters.PregledLijekovaTableAdapter pregledLijekovaTableAdapter;
        private System.Windows.Forms.TextBox txtBoxPretrazi;
        private System.Windows.Forms.BindingSource pregledLijekovaKategorijaBindingSource;
        private _17003_DBDataSetTableAdapters.PregledLijekovaKategorijaTableAdapter pregledLijekovaKategorijaTableAdapter;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridView dgvLijekovi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Stanje;
        private System.Windows.Forms.ComboBox comboBoxPretraga;
        private System.Windows.Forms.Label lblPretragaCombo;
        private System.Windows.Forms.Label lblPretragaTekst;
    }
}