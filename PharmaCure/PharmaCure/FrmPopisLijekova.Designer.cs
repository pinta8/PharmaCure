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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label kratki_opisLabel;
            System.Windows.Forms.Label puni_opisLabel;
            System.Windows.Forms.Label datum_proizvodnjeLabel;
            System.Windows.Forms.Label datum_istekaLabel;
            System.Windows.Forms.Label cijenaLabel;
            System.Windows.Forms.Label zemlja_porijeklaLabel;
            System.Windows.Forms.Label nazivLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPopisLijekova));
            this.btnPovratak = new System.Windows.Forms.Button();
            this.dgvLijekovi = new System.Windows.Forms.DataGridView();
            this.lblArtikli = new System.Windows.Forms.Label();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.lijekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._17003_DBDataSet = new PharmaCure._17003_DBDataSet();
            this.kratki_opisTextBox = new System.Windows.Forms.TextBox();
            this.puni_opisTextBox = new System.Windows.Forms.TextBox();
            this.datum_proizvodnjeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datum_istekaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cijenaTextBox = new System.Windows.Forms.TextBox();
            this.zemlja_porijeklaTextBox = new System.Windows.Forms.TextBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.lijekoviTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.LijekoviTableAdapter();
            this.tableAdapterManager = new PharmaCure._17003_DBDataSetTableAdapters.TableAdapterManager();
            this.kategorijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorijaTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.KategorijaTableAdapter();
            this.nazivComboBox = new System.Windows.Forms.ComboBox();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnPromijeni = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnNoviLijek = new System.Windows.Forms.Button();
            nazivLabel = new System.Windows.Forms.Label();
            kratki_opisLabel = new System.Windows.Forms.Label();
            puni_opisLabel = new System.Windows.Forms.Label();
            datum_proizvodnjeLabel = new System.Windows.Forms.Label();
            datum_istekaLabel = new System.Windows.Forms.Label();
            cijenaLabel = new System.Windows.Forms.Label();
            zemlja_porijeklaLabel = new System.Windows.Forms.Label();
            nazivLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._17003_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.BackColor = System.Drawing.Color.Transparent;
            nazivLabel.Location = new System.Drawing.Point(181, 17);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(37, 13);
            nazivLabel.TabIndex = 40;
            nazivLabel.Text = "Naziv:";
            // 
            // kratki_opisLabel
            // 
            kratki_opisLabel.AutoSize = true;
            kratki_opisLabel.BackColor = System.Drawing.Color.Transparent;
            kratki_opisLabel.Location = new System.Drawing.Point(181, 50);
            kratki_opisLabel.Name = "kratki_opisLabel";
            kratki_opisLabel.Size = new System.Drawing.Size(59, 13);
            kratki_opisLabel.TabIndex = 41;
            kratki_opisLabel.Text = "Kratki opis:";
            // 
            // puni_opisLabel
            // 
            puni_opisLabel.AutoSize = true;
            puni_opisLabel.BackColor = System.Drawing.Color.Transparent;
            puni_opisLabel.Location = new System.Drawing.Point(181, 83);
            puni_opisLabel.Name = "puni_opisLabel";
            puni_opisLabel.Size = new System.Drawing.Size(53, 13);
            puni_opisLabel.TabIndex = 42;
            puni_opisLabel.Text = "Puni opis:";
            // 
            // datum_proizvodnjeLabel
            // 
            datum_proizvodnjeLabel.AutoSize = true;
            datum_proizvodnjeLabel.BackColor = System.Drawing.Color.Transparent;
            datum_proizvodnjeLabel.Location = new System.Drawing.Point(181, 115);
            datum_proizvodnjeLabel.Name = "datum_proizvodnjeLabel";
            datum_proizvodnjeLabel.Size = new System.Drawing.Size(98, 13);
            datum_proizvodnjeLabel.TabIndex = 43;
            datum_proizvodnjeLabel.Text = "Datum proizvodnje:";
            // 
            // datum_istekaLabel
            // 
            datum_istekaLabel.AutoSize = true;
            datum_istekaLabel.BackColor = System.Drawing.Color.Transparent;
            datum_istekaLabel.Location = new System.Drawing.Point(181, 148);
            datum_istekaLabel.Name = "datum_istekaLabel";
            datum_istekaLabel.Size = new System.Drawing.Size(72, 13);
            datum_istekaLabel.TabIndex = 44;
            datum_istekaLabel.Text = "Datum isteka:";
            // 
            // cijenaLabel
            // 
            cijenaLabel.AutoSize = true;
            cijenaLabel.BackColor = System.Drawing.Color.Transparent;
            cijenaLabel.Location = new System.Drawing.Point(181, 181);
            cijenaLabel.Name = "cijenaLabel";
            cijenaLabel.Size = new System.Drawing.Size(39, 13);
            cijenaLabel.TabIndex = 45;
            cijenaLabel.Text = "Cijena:";
            // 
            // zemlja_porijeklaLabel
            // 
            zemlja_porijeklaLabel.AutoSize = true;
            zemlja_porijeklaLabel.BackColor = System.Drawing.Color.Transparent;
            zemlja_porijeklaLabel.Location = new System.Drawing.Point(181, 214);
            zemlja_porijeklaLabel.Name = "zemlja_porijeklaLabel";
            zemlja_porijeklaLabel.Size = new System.Drawing.Size(83, 13);
            zemlja_porijeklaLabel.TabIndex = 46;
            zemlja_porijeklaLabel.Text = "Zemlja porijekla:";
            // 
            // nazivLabel1
            // 
            nazivLabel1.AutoSize = true;
            nazivLabel1.BackColor = System.Drawing.Color.Transparent;
            nazivLabel1.Location = new System.Drawing.Point(181, 250);
            nazivLabel1.Name = "nazivLabel1";
            nazivLabel1.Size = new System.Drawing.Size(86, 13);
            nazivLabel1.TabIndex = 48;
            nazivLabel1.Text = "Naziv kategorije:";
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPovratak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPovratak.Location = new System.Drawing.Point(12, 7);
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
            this.dgvLijekovi.Location = new System.Drawing.Point(12, 390);
            this.dgvLijekovi.Name = "dgvLijekovi";
            this.dgvLijekovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLijekovi.Size = new System.Drawing.Size(841, 255);
            this.dgvLijekovi.TabIndex = 2;
            // 
            // lblArtikli
            // 
            this.lblArtikli.AutoSize = true;
            this.lblArtikli.BackColor = System.Drawing.Color.Transparent;
            this.lblArtikli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtikli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblArtikli.Location = new System.Drawing.Point(11, 371);
            this.lblArtikli.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArtikli.Name = "lblArtikli";
            this.lblArtikli.Size = new System.Drawing.Size(57, 16);
            this.lblArtikli.TabIndex = 39;
            this.lblArtikli.Text = "Lijekovi:";
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lijekoviBindingSource, "Naziv", true));
            this.nazivTextBox.Location = new System.Drawing.Point(281, 14);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(83, 20);
            this.nazivTextBox.TabIndex = 41;
            // 
            // lijekoviBindingSource
            // 
            this.lijekoviBindingSource.DataMember = "Lijekovi";
            this.lijekoviBindingSource.DataSource = this._17003_DBDataSet;
            // 
            // _17003_DBDataSet
            // 
            this._17003_DBDataSet.DataSetName = "_17003_DBDataSet";
            this._17003_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kratki_opisTextBox
            // 
            this.kratki_opisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lijekoviBindingSource, "Kratki_opis", true));
            this.kratki_opisTextBox.Location = new System.Drawing.Point(281, 47);
            this.kratki_opisTextBox.Name = "kratki_opisTextBox";
            this.kratki_opisTextBox.Size = new System.Drawing.Size(83, 20);
            this.kratki_opisTextBox.TabIndex = 42;
            // 
            // puni_opisTextBox
            // 
            this.puni_opisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lijekoviBindingSource, "Puni_opis", true));
            this.puni_opisTextBox.Location = new System.Drawing.Point(281, 80);
            this.puni_opisTextBox.Name = "puni_opisTextBox";
            this.puni_opisTextBox.Size = new System.Drawing.Size(83, 20);
            this.puni_opisTextBox.TabIndex = 43;
            this.puni_opisTextBox.TextChanged += new System.EventHandler(this.puni_opisTextBox_TextChanged);
            // 
            // datum_proizvodnjeDateTimePicker
            // 
            this.datum_proizvodnjeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lijekoviBindingSource, "Datum_proizvodnje", true));
            this.datum_proizvodnjeDateTimePicker.Location = new System.Drawing.Point(281, 112);
            this.datum_proizvodnjeDateTimePicker.Name = "datum_proizvodnjeDateTimePicker";
            this.datum_proizvodnjeDateTimePicker.Size = new System.Drawing.Size(111, 20);
            this.datum_proizvodnjeDateTimePicker.TabIndex = 44;
            // 
            // datum_istekaDateTimePicker
            // 
            this.datum_istekaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lijekoviBindingSource, "Datum_isteka", true));
            this.datum_istekaDateTimePicker.Location = new System.Drawing.Point(281, 145);
            this.datum_istekaDateTimePicker.Name = "datum_istekaDateTimePicker";
            this.datum_istekaDateTimePicker.Size = new System.Drawing.Size(111, 20);
            this.datum_istekaDateTimePicker.TabIndex = 45;
            // 
            // cijenaTextBox
            // 
            this.cijenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lijekoviBindingSource, "Cijena", true));
            this.cijenaTextBox.Location = new System.Drawing.Point(281, 178);
            this.cijenaTextBox.Name = "cijenaTextBox";
            this.cijenaTextBox.Size = new System.Drawing.Size(83, 20);
            this.cijenaTextBox.TabIndex = 46;
            // 
            // zemlja_porijeklaTextBox
            // 
            this.zemlja_porijeklaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lijekoviBindingSource, "Zemlja_porijekla", true));
            this.zemlja_porijeklaTextBox.Location = new System.Drawing.Point(281, 211);
            this.zemlja_porijeklaTextBox.Name = "zemlja_porijeklaTextBox";
            this.zemlja_porijeklaTextBox.Size = new System.Drawing.Size(83, 20);
            this.zemlja_porijeklaTextBox.TabIndex = 47;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(251, 285);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(169, 34);
            this.btnUnesi.TabIndex = 48;
            this.btnUnesi.Text = "Unesi ";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
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
            // nazivComboBox
            // 
            this.nazivComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kategorijaBindingSource, "Naziv", true));
            this.nazivComboBox.DataSource = this.kategorijaBindingSource;
            this.nazivComboBox.DisplayMember = "Naziv";
            this.nazivComboBox.FormattingEnabled = true;
            this.nazivComboBox.Location = new System.Drawing.Point(281, 247);
            this.nazivComboBox.Name = "nazivComboBox";
            this.nazivComboBox.Size = new System.Drawing.Size(111, 21);
            this.nazivComboBox.TabIndex = 49;
            this.nazivComboBox.ValueMember = "ID_kategorija";
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(728, 7);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 50;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnPromijeni
            // 
            this.btnPromijeni.Location = new System.Drawing.Point(162, 351);
            this.btnPromijeni.Name = "btnPromijeni";
            this.btnPromijeni.Size = new System.Drawing.Size(117, 33);
            this.btnPromijeni.TabIndex = 51;
            this.btnPromijeni.Text = "Promijeni";
            this.btnPromijeni.UseVisualStyleBackColor = true;
            this.btnPromijeni.Click += new System.EventHandler(this.btnPromijeni_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(510, 351);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(117, 33);
            this.btnBrisi.TabIndex = 52;
            this.btnBrisi.Text = "Brisi";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // btnNoviLijek
            // 
            this.btnNoviLijek.Location = new System.Drawing.Point(65, 285);
            this.btnNoviLijek.Name = "btnNoviLijek";
            this.btnNoviLijek.Size = new System.Drawing.Size(169, 34);
            this.btnNoviLijek.TabIndex = 53;
            this.btnNoviLijek.Text = "Unesi ";
            this.btnNoviLijek.UseVisualStyleBackColor = true;
            this.btnNoviLijek.Click += new System.EventHandler(this.btnNoviLijek_Click);
            // 
            // FrmPopisLijekova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(883, 657);
            this.Controls.Add(this.btnNoviLijek);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnPromijeni);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(nazivLabel1);
            this.Controls.Add(this.nazivComboBox);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(zemlja_porijeklaLabel);
            this.Controls.Add(this.zemlja_porijeklaTextBox);
            this.Controls.Add(cijenaLabel);
            this.Controls.Add(this.cijenaTextBox);
            this.Controls.Add(datum_istekaLabel);
            this.Controls.Add(this.datum_istekaDateTimePicker);
            this.Controls.Add(datum_proizvodnjeLabel);
            this.Controls.Add(this.datum_proizvodnjeDateTimePicker);
            this.Controls.Add(puni_opisLabel);
            this.Controls.Add(this.puni_opisTextBox);
            this.Controls.Add(kratki_opisLabel);
            this.Controls.Add(this.kratki_opisTextBox);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(this.lblArtikli);
            this.Controls.Add(this.dgvLijekovi);
            this.Controls.Add(this.btnPovratak);
            this.Location = new System.Drawing.Point(150, 150);
            this.Name = "FrmPopisLijekova";
            this.Text = "FrmPopisLijekova";
            this.Load += new System.EventHandler(this.FrmPopisLijekova_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPopisLijekova_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._17003_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.DataGridView dgvLijekovi;
        private System.Windows.Forms.Label lblArtikli;
        private _17003_DBDataSet _17003_DBDataSet;
        private System.Windows.Forms.BindingSource lijekoviBindingSource;
        private _17003_DBDataSetTableAdapters.LijekoviTableAdapter lijekoviTableAdapter;
        private _17003_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.TextBox kratki_opisTextBox;
        private System.Windows.Forms.TextBox puni_opisTextBox;
        private System.Windows.Forms.DateTimePicker datum_proizvodnjeDateTimePicker;
        private System.Windows.Forms.DateTimePicker datum_istekaDateTimePicker;
        private System.Windows.Forms.TextBox cijenaTextBox;
        private System.Windows.Forms.TextBox zemlja_porijeklaTextBox;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.BindingSource kategorijaBindingSource;
        private _17003_DBDataSetTableAdapters.KategorijaTableAdapter kategorijaTableAdapter;
        private System.Windows.Forms.ComboBox nazivComboBox;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnPromijeni;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnNoviLijek;
    }
}