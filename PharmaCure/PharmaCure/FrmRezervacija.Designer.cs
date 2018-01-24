namespace PharmaCure
{
    partial class FrmRezervacija
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
            System.Windows.Forms.Label iD__rezervacijeLabel;
            System.Windows.Forms.Label datumLabel;
            System.Windows.Forms.Label imePrezimeLabel;
            this.datumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.imePrezimeTextBox = new System.Windows.Forms.TextBox();
            this.btnOdaberiKlijenta = new System.Windows.Forms.Button();
            this.pregledRezervacija_LijekoviDataGridView = new System.Windows.Forms.DataGridView();
            this.ID_Lijeka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.lblArtikli = new System.Windows.Forms.Label();
            this.iD__rezervacijeTextBox = new System.Windows.Forms.Label();
            this.pregledRezervacijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._17003_DBDataSet = new PharmaCure._17003_DBDataSet();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pregledRezervacija_LijekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervacijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervacijaTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.RezervacijaTableAdapter();
            this.klijentTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.KlijentTableAdapter();
            this.tableAdapterManager = new PharmaCure._17003_DBDataSetTableAdapters.TableAdapterManager();
            this.popisTableAdapter1 = new PharmaCure._17003_DBDataSetTableAdapters.PopisTableAdapter();
            this.pregledRezervacija_LijekoviTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.PregledRezervacija_LijekoviTableAdapter();
            this.pregledRezervacijaTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.PregledRezervacijaTableAdapter();
            this.rezervacijaTableAdapter1 = new PharmaCure._17003_DBDataSetTableAdapters.RezervacijaTableAdapter();
            iD__rezervacijeLabel = new System.Windows.Forms.Label();
            datumLabel = new System.Windows.Forms.Label();
            imePrezimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pregledRezervacija_LijekoviDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledRezervacijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._17003_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledRezervacija_LijekoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD__rezervacijeLabel
            // 
            iD__rezervacijeLabel.AutoSize = true;
            iD__rezervacijeLabel.BackColor = System.Drawing.Color.Transparent;
            iD__rezervacijeLabel.Location = new System.Drawing.Point(12, 60);
            iD__rezervacijeLabel.Name = "iD__rezervacijeLabel";
            iD__rezervacijeLabel.Size = new System.Drawing.Size(75, 13);
            iD__rezervacijeLabel.TabIndex = 1;
            iD__rezervacijeLabel.Text = "ID rezervacije:";
            // 
            // datumLabel
            // 
            datumLabel.AutoSize = true;
            datumLabel.BackColor = System.Drawing.Color.Transparent;
            datumLabel.Location = new System.Drawing.Point(12, 97);
            datumLabel.Name = "datumLabel";
            datumLabel.Size = new System.Drawing.Size(41, 13);
            datumLabel.TabIndex = 2;
            datumLabel.Text = "Datum:";
            // 
            // imePrezimeLabel
            // 
            imePrezimeLabel.AutoSize = true;
            imePrezimeLabel.BackColor = System.Drawing.Color.Transparent;
            imePrezimeLabel.Location = new System.Drawing.Point(12, 131);
            imePrezimeLabel.Name = "imePrezimeLabel";
            imePrezimeLabel.Size = new System.Drawing.Size(107, 13);
            imePrezimeLabel.TabIndex = 4;
            imePrezimeLabel.Text = "Ime i prezime klijenta:";
            // 
            // datumDateTimePicker
            // 
            this.datumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rezervacijaBindingSource, "Datum", true));
            this.datumDateTimePicker.Enabled = false;
            this.datumDateTimePicker.Location = new System.Drawing.Point(124, 91);
            this.datumDateTimePicker.Name = "datumDateTimePicker";
            this.datumDateTimePicker.Size = new System.Drawing.Size(139, 20);
            this.datumDateTimePicker.TabIndex = 3;
            // 
            // imePrezimeTextBox
            // 
            this.imePrezimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klijentBindingSource, "ImePrezime", true));
            this.imePrezimeTextBox.Location = new System.Drawing.Point(124, 128);
            this.imePrezimeTextBox.Name = "imePrezimeTextBox";
            this.imePrezimeTextBox.Size = new System.Drawing.Size(139, 20);
            this.imePrezimeTextBox.TabIndex = 5;
            // 
            // btnOdaberiKlijenta
            // 
            this.btnOdaberiKlijenta.Location = new System.Drawing.Point(269, 128);
            this.btnOdaberiKlijenta.Name = "btnOdaberiKlijenta";
            this.btnOdaberiKlijenta.Size = new System.Drawing.Size(32, 20);
            this.btnOdaberiKlijenta.TabIndex = 6;
            this.btnOdaberiKlijenta.Text = "...";
            this.btnOdaberiKlijenta.UseVisualStyleBackColor = true;
            this.btnOdaberiKlijenta.Click += new System.EventHandler(this.btnOdaberiKlijenta_Click);
            // 
            // pregledRezervacija_LijekoviDataGridView
            // 
            this.pregledRezervacija_LijekoviDataGridView.AutoGenerateColumns = false;
            this.pregledRezervacija_LijekoviDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pregledRezervacija_LijekoviDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.ID_Lijeka});
            this.pregledRezervacija_LijekoviDataGridView.DataSource = this.pregledRezervacija_LijekoviBindingSource;
            this.pregledRezervacija_LijekoviDataGridView.Location = new System.Drawing.Point(28, 227);
            this.pregledRezervacija_LijekoviDataGridView.Name = "pregledRezervacija_LijekoviDataGridView";
            this.pregledRezervacija_LijekoviDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pregledRezervacija_LijekoviDataGridView.Size = new System.Drawing.Size(481, 223);
            this.pregledRezervacija_LijekoviDataGridView.TabIndex = 7;
            // 
            // ID_Lijeka
            // 
            this.ID_Lijeka.DataPropertyName = "ID_Lijeka";
            this.ID_Lijeka.HeaderText = "ID lijek";
            this.ID_Lijeka.Name = "ID_Lijeka";
            this.ID_Lijeka.ReadOnly = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(104, 194);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(128, 23);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj lijek";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(307, 194);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(128, 23);
            this.btnObrisi.TabIndex = 9;
            this.btnObrisi.Text = "Obrisi lijek";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(8, 11);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(78, 27);
            this.btnSpremi.TabIndex = 44;
            this.btnSpremi.Text = "Spremi ";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremiPromjene_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(522, 11);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 26);
            this.btnOdustani.TabIndex = 45;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // lblArtikli
            // 
            this.lblArtikli.AutoSize = true;
            this.lblArtikli.BackColor = System.Drawing.Color.Transparent;
            this.lblArtikli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtikli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblArtikli.Location = new System.Drawing.Point(11, 194);
            this.lblArtikli.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArtikli.Name = "lblArtikli";
            this.lblArtikli.Size = new System.Drawing.Size(57, 16);
            this.lblArtikli.TabIndex = 46;
            this.lblArtikli.Text = "Lijekovi:";
            // 
            // iD__rezervacijeTextBox
            // 
            this.iD__rezervacijeTextBox.AutoSize = true;
            this.iD__rezervacijeTextBox.Location = new System.Drawing.Point(124, 60);
            this.iD__rezervacijeTextBox.Name = "iD__rezervacijeTextBox";
            this.iD__rezervacijeTextBox.Size = new System.Drawing.Size(35, 13);
            this.iD__rezervacijeTextBox.TabIndex = 47;
            this.iD__rezervacijeTextBox.Text = "label1";
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Naziv";
            this.dataGridViewTextBoxColumn2.HeaderText = "Naziv lijeka";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Kolicina";
            this.dataGridViewTextBoxColumn3.HeaderText = "Kolicina";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // pregledRezervacija_LijekoviBindingSource
            // 
            this.pregledRezervacija_LijekoviBindingSource.DataMember = "PregledRezervacija_Lijekovi";
            this.pregledRezervacija_LijekoviBindingSource.DataSource = this._17003_DBDataSet;
            // 
            // klijentBindingSource
            // 
            this.klijentBindingSource.DataMember = "Klijent";
            this.klijentBindingSource.DataSource = this._17003_DBDataSet;
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
            // klijentTableAdapter
            // 
            this.klijentTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.UpdateOrder = PharmaCure._17003_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // popisTableAdapter1
            // 
            this.popisTableAdapter1.ClearBeforeFill = true;
            // 
            // pregledRezervacija_LijekoviTableAdapter
            // 
            this.pregledRezervacija_LijekoviTableAdapter.ClearBeforeFill = true;
            // 
            // pregledRezervacijaTableAdapter
            // 
            this.pregledRezervacijaTableAdapter.ClearBeforeFill = true;
            // 
            // rezervacijaTableAdapter1
            // 
            this.rezervacijaTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PharmaCure.Properties.Resources.medical_cross_background_11;
            this.ClientSize = new System.Drawing.Size(617, 470);
            this.Controls.Add(this.iD__rezervacijeTextBox);
            this.Controls.Add(this.lblArtikli);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.pregledRezervacija_LijekoviDataGridView);
            this.Controls.Add(this.btnOdaberiKlijenta);
            this.Controls.Add(imePrezimeLabel);
            this.Controls.Add(this.imePrezimeTextBox);
            this.Controls.Add(datumLabel);
            this.Controls.Add(this.datumDateTimePicker);
            this.Controls.Add(iD__rezervacijeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRezervacija";
            this.Text = "FrmRezervacija";
            this.Load += new System.EventHandler(this.FrmRezervacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pregledRezervacija_LijekoviDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledRezervacijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._17003_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledRezervacija_LijekoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _17003_DBDataSet _17003_DBDataSet;
        private System.Windows.Forms.BindingSource rezervacijaBindingSource;
        private _17003_DBDataSetTableAdapters.RezervacijaTableAdapter rezervacijaTableAdapter;
        private _17003_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private _17003_DBDataSetTableAdapters.KlijentTableAdapter klijentTableAdapter;
        private System.Windows.Forms.DateTimePicker datumDateTimePicker;
        private System.Windows.Forms.BindingSource klijentBindingSource;
        private System.Windows.Forms.TextBox imePrezimeTextBox;
        private System.Windows.Forms.Button btnOdaberiKlijenta;
        private System.Windows.Forms.BindingSource pregledRezervacija_LijekoviBindingSource;
        private _17003_DBDataSetTableAdapters.PregledRezervacija_LijekoviTableAdapter pregledRezervacija_LijekoviTableAdapter;
        private System.Windows.Forms.DataGridView pregledRezervacija_LijekoviDataGridView;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblArtikli;
        private System.Windows.Forms.BindingSource pregledRezervacijaBindingSource;
        private _17003_DBDataSetTableAdapters.PregledRezervacijaTableAdapter pregledRezervacijaTableAdapter;
        private _17003_DBDataSetTableAdapters.PopisTableAdapter popisTableAdapter1;
        private _17003_DBDataSetTableAdapters.RezervacijaTableAdapter rezervacijaTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Lijeka;
        private System.Windows.Forms.Label iD__rezervacijeTextBox;
    }
}