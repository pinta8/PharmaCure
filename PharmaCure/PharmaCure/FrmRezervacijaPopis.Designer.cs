namespace PharmaCure
{
    partial class FrmRezervacijaPopis
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
            this.pregledRezervacijaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pregledRezervacijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._17003_DBDataSet = new PharmaCure._17003_DBDataSet();
            this.lblArtikli = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnPromijeni = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtBoxPretrazi = new System.Windows.Forms.TextBox();
            this.lblPretragaTekst = new System.Windows.Forms.Label();
            this.pregledRezervacijaTableAdapter = new PharmaCure._17003_DBDataSet1TableAdapters.PregledRezervacijaTableAdapter();
            this.tableAdapterManager = new PharmaCure._17003_DBDataSet1TableAdapters.TableAdapterManager();
            this.rezervacijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervacijaTableAdapter = new PharmaCure._17003_DBDataSet1TableAdapters.RezervacijaTableAdapter();
            this.btnIzmijeniPodatke = new System.Windows.Forms.Button();
            this.lblPretragaCombo = new System.Windows.Forms.Label();
            this.comboBoxPretraga = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pregledRezervacijaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledRezervacijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._17003_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pregledRezervacijaDataGridView
            // 
            this.pregledRezervacijaDataGridView.AutoGenerateColumns = false;
            this.pregledRezervacijaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pregledRezervacijaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1});
            this.pregledRezervacijaDataGridView.DataSource = this.pregledRezervacijaBindingSource;
            this.pregledRezervacijaDataGridView.Location = new System.Drawing.Point(51, 142);
            this.pregledRezervacijaDataGridView.Name = "pregledRezervacijaDataGridView";
            this.pregledRezervacijaDataGridView.ReadOnly = true;
            this.pregledRezervacijaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pregledRezervacijaDataGridView.Size = new System.Drawing.Size(571, 220);
            this.pregledRezervacijaDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idRezervacija";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ImePrezime";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ime i prezime";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "datum";
            this.dataGridViewTextBoxColumn1.HeaderText = "Datum";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Stanje";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Stanje";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // pregledRezervacijaBindingSource
            // 
            this.pregledRezervacijaBindingSource.DataMember = "PregledRezervacija";
            this.pregledRezervacijaBindingSource.DataSource = this._17003_DBDataSet;
            // 
            // _17003_DBDataSet
            // 
            this._17003_DBDataSet.DataSetName = "_17003_DBDataSet";
            this._17003_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblArtikli
            // 
            this.lblArtikli.AutoSize = true;
            this.lblArtikli.BackColor = System.Drawing.Color.Transparent;
            this.lblArtikli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtikli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblArtikli.Location = new System.Drawing.Point(9, 123);
            this.lblArtikli.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArtikli.Name = "lblArtikli";
            this.lblArtikli.Size = new System.Drawing.Size(83, 16);
            this.lblArtikli.TabIndex = 40;
            this.lblArtikli.Text = "Rezervacije:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(90, 66);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(119, 28);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj rezervaciju";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnPromijeni
            // 
            this.btnPromijeni.Location = new System.Drawing.Point(374, 68);
            this.btnPromijeni.Name = "btnPromijeni";
            this.btnPromijeni.Size = new System.Drawing.Size(86, 26);
            this.btnPromijeni.TabIndex = 3;
            this.btnPromijeni.Text = "Arhiviraj";
            this.btnPromijeni.UseVisualStyleBackColor = true;
            this.btnPromijeni.Click += new System.EventHandler(this.btnPromijeni_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(12, 12);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(75, 26);
            this.btnPovratak.TabIndex = 7;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(795, 12);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 26);
            this.btnIzlaz.TabIndex = 8;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(798, 97);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(79, 26);
            this.btnPretrazi.TabIndex = 5;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // txtBoxPretrazi
            // 
            this.txtBoxPretrazi.Location = new System.Drawing.Point(713, 100);
            this.txtBoxPretrazi.Name = "txtBoxPretrazi";
            this.txtBoxPretrazi.Size = new System.Drawing.Size(79, 20);
            this.txtBoxPretrazi.TabIndex = 4;
            // 
            // lblPretragaTekst
            // 
            this.lblPretragaTekst.AutoSize = true;
            this.lblPretragaTekst.BackColor = System.Drawing.Color.Transparent;
            this.lblPretragaTekst.Location = new System.Drawing.Point(628, 103);
            this.lblPretragaTekst.Name = "lblPretragaTekst";
            this.lblPretragaTekst.Size = new System.Drawing.Size(79, 13);
            this.lblPretragaTekst.TabIndex = 61;
            this.lblPretragaTekst.Text = "Tekst pretrage:";
            // 
            // pregledRezervacijaTableAdapter
            // 
            this.pregledRezervacijaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AkcijaTableAdapter = null;
            this.tableAdapterManager.Artikli_RacunTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DjelatnikTableAdapter = null;
            this.tableAdapterManager.DostupnostTableAdapter = null;
            this.tableAdapterManager.KategorijaTableAdapter = null;
            this.tableAdapterManager.KlijentTableAdapter = null;
            this.tableAdapterManager.LijekoviOsiguranjeTableAdapter = null;
            this.tableAdapterManager.LijekoviReceptTableAdapter = null;
            this.tableAdapterManager.LijekoviTableAdapter = null;
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
            this.tableAdapterManager.UpdateOrder = PharmaCure._17003_DBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rezervacijaBindingSource
            // 
            this.rezervacijaBindingSource.DataMember = "Rezervacija";
            this.rezervacijaBindingSource.DataSource = this._17003_DBDataSet;
            // 
            // rezervacijaTableAdapter
            // 
            this.rezervacijaTableAdapter.ClearBeforeFill = true;
            // 
            // btnIzmijeniPodatke
            // 
            this.btnIzmijeniPodatke.Location = new System.Drawing.Point(229, 66);
            this.btnIzmijeniPodatke.Name = "btnIzmijeniPodatke";
            this.btnIzmijeniPodatke.Size = new System.Drawing.Size(119, 28);
            this.btnIzmijeniPodatke.TabIndex = 2;
            this.btnIzmijeniPodatke.Text = "Izmijeni podatke";
            this.btnIzmijeniPodatke.UseVisualStyleBackColor = true;
            this.btnIzmijeniPodatke.Click += new System.EventHandler(this.btnIzmijeniPodatke_Click);
            // 
            // lblPretragaCombo
            // 
            this.lblPretragaCombo.AutoSize = true;
            this.lblPretragaCombo.BackColor = System.Drawing.Color.Transparent;
            this.lblPretragaCombo.Location = new System.Drawing.Point(451, 104);
            this.lblPretragaCombo.Name = "lblPretragaCombo";
            this.lblPretragaCombo.Size = new System.Drawing.Size(77, 13);
            this.lblPretragaCombo.TabIndex = 63;
            this.lblPretragaCombo.Text = "Pretraži prema:";
            // 
            // comboBoxPretraga
            // 
            this.comboBoxPretraga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPretraga.FormattingEnabled = true;
            this.comboBoxPretraga.Items.AddRange(new object[] {
            "ID ",
            "Ime i prezime"});
            this.comboBoxPretraga.Location = new System.Drawing.Point(534, 100);
            this.comboBoxPretraga.Name = "comboBoxPretraga";
            this.comboBoxPretraga.Size = new System.Drawing.Size(88, 21);
            this.comboBoxPretraga.TabIndex = 62;
            // 
            // FrmRezervacijaPopis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PharmaCure.Properties.Resources.medical_cross_background_11;
            this.ClientSize = new System.Drawing.Size(882, 378);
            this.Controls.Add(this.lblPretragaCombo);
            this.Controls.Add(this.comboBoxPretraga);
            this.Controls.Add(this.btnIzmijeniPodatke);
            this.Controls.Add(this.lblPretragaTekst);
            this.Controls.Add(this.txtBoxPretrazi);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnPromijeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblArtikli);
            this.Controls.Add(this.pregledRezervacijaDataGridView);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRezervacijaPopis";
            this.Text = "FrmPopisRezervacija";
            this.Load += new System.EventHandler(this.FrmPopisRezervacija_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmRezervacijaPopis_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pregledRezervacijaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledRezervacijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._17003_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _17003_DBDataSet _17003_DBDataSet;
        private System.Windows.Forms.BindingSource pregledRezervacijaBindingSource;
        private _17003_DBDataSet1TableAdapters.PregledRezervacijaTableAdapter pregledRezervacijaTableAdapter;
        private _17003_DBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView pregledRezervacijaDataGridView;
        private System.Windows.Forms.Label lblArtikli;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnPromijeni;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtBoxPretrazi;
        private System.Windows.Forms.BindingSource rezervacijaBindingSource;
        private _17003_DBDataSet1TableAdapters.RezervacijaTableAdapter rezervacijaTableAdapter;
        private System.Windows.Forms.Label lblPretragaTekst;
        private System.Windows.Forms.Button btnIzmijeniPodatke;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Label lblPretragaCombo;
        private System.Windows.Forms.ComboBox comboBoxPretraga;
    }
}