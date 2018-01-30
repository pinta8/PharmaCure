namespace PharmaCure
{
    partial class FrmLijekNovi
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
            System.Windows.Forms.Label cijenaLabel;
            System.Windows.Forms.Label zemlja_porijeklaLabel;
            System.Windows.Forms.Label nazivLabel1;
            System.Windows.Forms.Label lblDatumIsteka;
            System.Windows.Forms.Label datum_proizvodnjeLabel;
            System.Windows.Forms.Label kratki_opisLabel;
            System.Windows.Forms.Label nazivLabel;
            this.cijenaTextBox = new System.Windows.Forms.TextBox();
            this.zemlja_porijeklaTextBox = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.nazivComboBox = new System.Windows.Forms.ComboBox();
            this.kategorijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._17003_DBDataSet = new PharmaCure._17003_DBDataSet();
            this.datum_istekaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datum_proizvodnjeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.kratki_opisTextBox = new System.Windows.Forms.TextBox();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.lijekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lijekoviTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.LijekoviTableAdapter();
            this.kategorijaTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.KategorijaTableAdapter();
            this.tableAdapterManager = new PharmaCure._17003_DBDataSetTableAdapters.TableAdapterManager();
            this.stanjeCheckBox = new System.Windows.Forms.CheckBox();
            this.lblStanje = new System.Windows.Forms.Label();
            cijenaLabel = new System.Windows.Forms.Label();
            zemlja_porijeklaLabel = new System.Windows.Forms.Label();
            nazivLabel1 = new System.Windows.Forms.Label();
            lblDatumIsteka = new System.Windows.Forms.Label();
            datum_proizvodnjeLabel = new System.Windows.Forms.Label();
            kratki_opisLabel = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._17003_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cijenaLabel
            // 
            cijenaLabel.AutoSize = true;
            cijenaLabel.BackColor = System.Drawing.Color.Transparent;
            cijenaLabel.Location = new System.Drawing.Point(191, 153);
            cijenaLabel.Name = "cijenaLabel";
            cijenaLabel.Size = new System.Drawing.Size(39, 13);
            cijenaLabel.TabIndex = 55;
            cijenaLabel.Text = "Cijena:";
            // 
            // zemlja_porijeklaLabel
            // 
            zemlja_porijeklaLabel.AutoSize = true;
            zemlja_porijeklaLabel.BackColor = System.Drawing.Color.Transparent;
            zemlja_porijeklaLabel.Location = new System.Drawing.Point(191, 186);
            zemlja_porijeklaLabel.Name = "zemlja_porijeklaLabel";
            zemlja_porijeklaLabel.Size = new System.Drawing.Size(83, 13);
            zemlja_porijeklaLabel.TabIndex = 57;
            zemlja_porijeklaLabel.Text = "Zemlja porijekla:";
            // 
            // nazivLabel1
            // 
            nazivLabel1.AutoSize = true;
            nazivLabel1.BackColor = System.Drawing.Color.Transparent;
            nazivLabel1.Location = new System.Drawing.Point(191, 222);
            nazivLabel1.Name = "nazivLabel1";
            nazivLabel1.Size = new System.Drawing.Size(86, 13);
            nazivLabel1.TabIndex = 60;
            nazivLabel1.Text = "Naziv kategorije:";
            // 
            // lblDatumIsteka
            // 
            lblDatumIsteka.AutoSize = true;
            lblDatumIsteka.BackColor = System.Drawing.Color.Transparent;
            lblDatumIsteka.Location = new System.Drawing.Point(191, 115);
            lblDatumIsteka.Name = "lblDatumIsteka";
            lblDatumIsteka.Size = new System.Drawing.Size(72, 13);
            lblDatumIsteka.TabIndex = 70;
            lblDatumIsteka.Text = "Datum isteka:";
            // 
            // datum_proizvodnjeLabel
            // 
            datum_proizvodnjeLabel.AutoSize = true;
            datum_proizvodnjeLabel.BackColor = System.Drawing.Color.Transparent;
            datum_proizvodnjeLabel.Location = new System.Drawing.Point(191, 82);
            datum_proizvodnjeLabel.Name = "datum_proizvodnjeLabel";
            datum_proizvodnjeLabel.Size = new System.Drawing.Size(98, 13);
            datum_proizvodnjeLabel.TabIndex = 68;
            datum_proizvodnjeLabel.Text = "Datum proizvodnje:";
            // 
            // kratki_opisLabel
            // 
            kratki_opisLabel.AutoSize = true;
            kratki_opisLabel.BackColor = System.Drawing.Color.Transparent;
            kratki_opisLabel.Location = new System.Drawing.Point(191, 42);
            kratki_opisLabel.Name = "kratki_opisLabel";
            kratki_opisLabel.Size = new System.Drawing.Size(59, 13);
            kratki_opisLabel.TabIndex = 64;
            kratki_opisLabel.Text = "Kratki opis:";
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.BackColor = System.Drawing.Color.Transparent;
            nazivLabel.Location = new System.Drawing.Point(191, 9);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(37, 13);
            nazivLabel.TabIndex = 63;
            nazivLabel.Text = "Naziv:";
            // 
            // cijenaTextBox
            // 
            this.cijenaTextBox.Location = new System.Drawing.Point(291, 150);
            this.cijenaTextBox.Name = "cijenaTextBox";
            this.cijenaTextBox.Size = new System.Drawing.Size(111, 20);
            this.cijenaTextBox.TabIndex = 6;
            // 
            // zemlja_porijeklaTextBox
            // 
            this.zemlja_porijeklaTextBox.Location = new System.Drawing.Point(291, 183);
            this.zemlja_porijeklaTextBox.Name = "zemlja_porijeklaTextBox";
            this.zemlja_porijeklaTextBox.Size = new System.Drawing.Size(111, 20);
            this.zemlja_porijeklaTextBox.TabIndex = 7;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(164, 285);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(117, 32);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj lijek";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // nazivComboBox
            // 
            this.nazivComboBox.DataSource = this.kategorijaBindingSource;
            this.nazivComboBox.DisplayMember = "Naziv";
            this.nazivComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nazivComboBox.FormattingEnabled = true;
            this.nazivComboBox.Location = new System.Drawing.Point(291, 219);
            this.nazivComboBox.Name = "nazivComboBox";
            this.nazivComboBox.Size = new System.Drawing.Size(111, 21);
            this.nazivComboBox.TabIndex = 8;
            this.nazivComboBox.ValueMember = "ID_kategorija";
            // 
            // kategorijaBindingSource
            // 
            this.kategorijaBindingSource.DataMember = "Kategorija";
            this.kategorijaBindingSource.DataSource = this._17003_DBDataSet;
            // 
            // _17003_DBDataSet
            // 
            this._17003_DBDataSet.DataSetName = "_17003_DBDataSet";
            this._17003_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datum_istekaDateTimePicker
            // 
            this.datum_istekaDateTimePicker.Location = new System.Drawing.Point(291, 112);
            this.datum_istekaDateTimePicker.Name = "datum_istekaDateTimePicker";
            this.datum_istekaDateTimePicker.Size = new System.Drawing.Size(111, 20);
            this.datum_istekaDateTimePicker.TabIndex = 5;
            // 
            // datum_proizvodnjeDateTimePicker
            // 
            this.datum_proizvodnjeDateTimePicker.Location = new System.Drawing.Point(291, 79);
            this.datum_proizvodnjeDateTimePicker.Name = "datum_proizvodnjeDateTimePicker";
            this.datum_proizvodnjeDateTimePicker.Size = new System.Drawing.Size(111, 20);
            this.datum_proizvodnjeDateTimePicker.TabIndex = 4;
            // 
            // kratki_opisTextBox
            // 
            this.kratki_opisTextBox.Location = new System.Drawing.Point(291, 39);
            this.kratki_opisTextBox.Name = "kratki_opisTextBox";
            this.kratki_opisTextBox.Size = new System.Drawing.Size(111, 20);
            this.kratki_opisTextBox.TabIndex = 2;
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.Location = new System.Drawing.Point(291, 6);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(111, 20);
            this.nazivTextBox.TabIndex = 1;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(321, 285);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(111, 32);
            this.btnOdustani.TabIndex = 10;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
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
            // kategorijaTableAdapter
            // 
            this.kategorijaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AkcijaTableAdapter = null;
            this.tableAdapterManager.Artikli_RacunTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DjelatnikTableAdapter = null;
            this.tableAdapterManager.DostupnostTableAdapter = null;
            this.tableAdapterManager.KategorijaTableAdapter = this.kategorijaTableAdapter;
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
            // stanjeCheckBox
            // 
            this.stanjeCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.stanjeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.lijekoviBindingSource, "Stanje", true));
            this.stanjeCheckBox.Location = new System.Drawing.Point(333, 246);
            this.stanjeCheckBox.Name = "stanjeCheckBox";
            this.stanjeCheckBox.Size = new System.Drawing.Size(81, 24);
            this.stanjeCheckBox.TabIndex = 9;
            this.stanjeCheckBox.Text = "aktivan";
            this.stanjeCheckBox.UseVisualStyleBackColor = false;
            // 
            // lblStanje
            // 
            this.lblStanje.AutoSize = true;
            this.lblStanje.BackColor = System.Drawing.Color.Transparent;
            this.lblStanje.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStanje.Location = new System.Drawing.Point(191, 251);
            this.lblStanje.Name = "lblStanje";
            this.lblStanje.Size = new System.Drawing.Size(40, 13);
            this.lblStanje.TabIndex = 71;
            this.lblStanje.Text = "Stanje:";
            // 
            // FrmLijekNovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PharmaCure.Properties.Resources.medical_cross_background_11;
            this.ClientSize = new System.Drawing.Size(535, 337);
            this.Controls.Add(this.lblStanje);
            this.Controls.Add(this.stanjeCheckBox);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(lblDatumIsteka);
            this.Controls.Add(this.datum_istekaDateTimePicker);
            this.Controls.Add(datum_proizvodnjeLabel);
            this.Controls.Add(this.datum_proizvodnjeDateTimePicker);
            this.Controls.Add(kratki_opisLabel);
            this.Controls.Add(this.kratki_opisTextBox);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(nazivLabel1);
            this.Controls.Add(this.nazivComboBox);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(zemlja_porijeklaLabel);
            this.Controls.Add(this.zemlja_porijeklaTextBox);
            this.Controls.Add(cijenaLabel);
            this.Controls.Add(this.cijenaTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLijekNovi";
            this.Text = "FrmNoviLijek";
            this.Load += new System.EventHandler(this.FrmNoviLijek_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLijekNovi_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._17003_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox cijenaTextBox;
        private System.Windows.Forms.TextBox zemlja_porijeklaTextBox;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox nazivComboBox;
        private System.Windows.Forms.DateTimePicker datum_istekaDateTimePicker;
        private System.Windows.Forms.DateTimePicker datum_proizvodnjeDateTimePicker;
        private System.Windows.Forms.TextBox kratki_opisTextBox;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.Button btnOdustani;
        private _17003_DBDataSet _17003_DBDataSet;
        private System.Windows.Forms.BindingSource lijekoviBindingSource;
        private _17003_DBDataSetTableAdapters.LijekoviTableAdapter lijekoviTableAdapter;
        private System.Windows.Forms.BindingSource kategorijaBindingSource;
        private _17003_DBDataSetTableAdapters.KategorijaTableAdapter kategorijaTableAdapter;
        private _17003_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.CheckBox stanjeCheckBox;
        private System.Windows.Forms.Label lblStanje;
    }
}