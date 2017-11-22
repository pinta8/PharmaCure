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
            System.Windows.Forms.Label lblKolicina;
            System.Windows.Forms.Label prezimeLabel;
            System.Windows.Forms.Label nazivLabel;
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.dodajRezervaciju = new System.Windows.Forms.Button();
            this.nazivComboBox = new System.Windows.Forms.ComboBox();
            this.lijekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._17003_DBDataSet = new PharmaCure._17003_DBDataSet();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.btnObrisiRezervaciju = new System.Windows.Forms.Button();
            this.prezimeComboBox = new System.Windows.Forms.ComboBox();
            this.klijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDodajLijek = new System.Windows.Forms.Button();
            this.popisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rezervacijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervacijaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._17003_DBDataSet1 = new PharmaCure._17003_DBDataSet();
            this.pregledRezervacijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.popisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new PharmaCure._17003_DBDataSetTableAdapters.TableAdapterManager();
            this.klijentTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.KlijentTableAdapter();
            this.lijekoviTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.LijekoviTableAdapter();
            this.rezervacijaTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.RezervacijaTableAdapter();
            this.dBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pregledRezervacijaTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.PregledRezervacijaTableAdapter();
            this.pregledRezervacijaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lijekoviReceptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lijekoviReceptTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.LijekoviReceptTableAdapter();
            this.popisTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.PopisTableAdapter();
            this.pregledRezervacija_LijekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pregledRezervacija_LijekoviTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.PregledRezervacija_LijekoviTableAdapter();
            this.pregledRezervacija_LijekoviDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Lijeka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pregledRezervacijaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnObrisiLijek = new System.Windows.Forms.Button();
            lblKolicina = new System.Windows.Forms.Label();
            prezimeLabel = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._17003_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._17003_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledRezervacijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledRezervacijaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviReceptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledRezervacija_LijekoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledRezervacija_LijekoviDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledRezervacijaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKolicina
            // 
            lblKolicina.AutoSize = true;
            lblKolicina.BackColor = System.Drawing.Color.Transparent;
            lblKolicina.Location = new System.Drawing.Point(565, 41);
            lblKolicina.Name = "lblKolicina";
            lblKolicina.Size = new System.Drawing.Size(47, 13);
            lblKolicina.TabIndex = 8;
            lblKolicina.Text = "Količina:";
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.BackColor = System.Drawing.Color.Transparent;
            prezimeLabel.Location = new System.Drawing.Point(24, 41);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(107, 13);
            prezimeLabel.TabIndex = 9;
            prezimeLabel.Text = "Ime i prezime klijenta:";
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.BackColor = System.Drawing.Color.Transparent;
            nazivLabel.Location = new System.Drawing.Point(309, 41);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(64, 13);
            nazivLabel.TabIndex = 10;
            nazivLabel.Text = "Naziv lijeka:";
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(12, 5);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(75, 23);
            this.btnPovratak.TabIndex = 6;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(829, 5);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 7;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // dodajRezervaciju
            // 
            this.dodajRezervaciju.Location = new System.Drawing.Point(43, 84);
            this.dodajRezervaciju.Name = "dodajRezervaciju";
            this.dodajRezervaciju.Size = new System.Drawing.Size(128, 36);
            this.dodajRezervaciju.TabIndex = 4;
            this.dodajRezervaciju.Text = "Kreiraj rezervaciju";
            this.dodajRezervaciju.UseVisualStyleBackColor = true;
            this.dodajRezervaciju.Click += new System.EventHandler(this.dodajRezervaciju_Click);
            // 
            // nazivComboBox
            // 
            this.nazivComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lijekoviBindingSource, "Naziv", true));
            this.nazivComboBox.DataSource = this.lijekoviBindingSource;
            this.nazivComboBox.DisplayMember = "Naziv";
            this.nazivComboBox.FormattingEnabled = true;
            this.nazivComboBox.Location = new System.Drawing.Point(379, 37);
            this.nazivComboBox.Name = "nazivComboBox";
            this.nazivComboBox.Size = new System.Drawing.Size(121, 21);
            this.nazivComboBox.TabIndex = 2;
            this.nazivComboBox.ValueMember = "ID_Lijek";
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
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(618, 37);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(121, 20);
            this.txtKolicina.TabIndex = 3;
            this.txtKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnObrisiRezervaciju
            // 
            this.btnObrisiRezervaciju.Location = new System.Drawing.Point(497, 84);
            this.btnObrisiRezervaciju.Name = "btnObrisiRezervaciju";
            this.btnObrisiRezervaciju.Size = new System.Drawing.Size(149, 36);
            this.btnObrisiRezervaciju.TabIndex = 5;
            this.btnObrisiRezervaciju.Text = "Obrisi rezervaciju";
            this.btnObrisiRezervaciju.UseVisualStyleBackColor = true;
            this.btnObrisiRezervaciju.Click += new System.EventHandler(this.btnObrisiRezervaciju_Click);
            // 
            // prezimeComboBox
            // 
            this.prezimeComboBox.DataSource = this.klijentBindingSource;
            this.prezimeComboBox.DisplayMember = "ImePrezime";
            this.prezimeComboBox.FormattingEnabled = true;
            this.prezimeComboBox.Location = new System.Drawing.Point(137, 37);
            this.prezimeComboBox.Name = "prezimeComboBox";
            this.prezimeComboBox.Size = new System.Drawing.Size(121, 21);
            this.prezimeComboBox.TabIndex = 1;
            this.prezimeComboBox.ValueMember = "ID_Klijent";
            this.prezimeComboBox.SelectedIndexChanged += new System.EventHandler(this.prezimeComboBox_SelectedIndexChanged_1);
            // 
            // klijentBindingSource
            // 
            this.klijentBindingSource.DataMember = "Klijent";
            this.klijentBindingSource.DataSource = this._17003_DBDataSet;
            // 
            // btnDodajLijek
            // 
            this.btnDodajLijek.Location = new System.Drawing.Point(294, 85);
            this.btnDodajLijek.Name = "btnDodajLijek";
            this.btnDodajLijek.Size = new System.Drawing.Size(123, 34);
            this.btnDodajLijek.TabIndex = 18;
            this.btnDodajLijek.Text = "Dodaj lijek";
            this.btnDodajLijek.UseVisualStyleBackColor = true;
            this.btnDodajLijek.Click += new System.EventHandler(this.btnDodajLijek_Click);
            // 
            // popisBindingSource1
            // 
            this.popisBindingSource1.DataMember = "FK_Popis_Rezervacija";
            this.popisBindingSource1.DataSource = this.rezervacijaBindingSource;
            // 
            // rezervacijaBindingSource
            // 
            this.rezervacijaBindingSource.DataMember = "Rezervacija";
            this.rezervacijaBindingSource.DataSource = this._17003_DBDataSet;
            // 
            // rezervacijaBindingSource1
            // 
            this.rezervacijaBindingSource1.DataMember = "Rezervacija";
            this.rezervacijaBindingSource1.DataSource = this._17003_DBDataSet1;
            // 
            // _17003_DBDataSet1
            // 
            this._17003_DBDataSet1.DataSetName = "_17003_DBDataSet";
            this._17003_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pregledRezervacijaBindingSource
            // 
            this.pregledRezervacijaBindingSource.DataMember = "PregledRezervacija";
            this.pregledRezervacijaBindingSource.DataSource = this._17003_DBDataSet;
            // 
            // popisBindingSource
            // 
            this.popisBindingSource.DataMember = "Popis";
            this.popisBindingSource.DataSource = this._17003_DBDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AkcijaTableAdapter = null;
            this.tableAdapterManager.Artikli_RacunTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DjelatnikTableAdapter = null;
            this.tableAdapterManager.DostupnostTableAdapter = null;
            this.tableAdapterManager.KategorijaTableAdapter = null;
            this.tableAdapterManager.KlijentTableAdapter = this.klijentTableAdapter;
            this.tableAdapterManager.LijekoviOsiguranjeTableAdapter = null;
            this.tableAdapterManager.LijekoviReceptTableAdapter = null;
            this.tableAdapterManager.LijekoviTableAdapter = this.lijekoviTableAdapter;
            this.tableAdapterManager.NarudzbaTableAdapter = null;
            this.tableAdapterManager.OsiguranjeTableAdapter = null;
            this.tableAdapterManager.PopisOsiguranihLijekovaTableAdapter = null;
            this.tableAdapterManager.PopisTableAdapter = null;
            this.tableAdapterManager.PoslovnicaTableAdapter = null;
            this.tableAdapterManager.RacunTableAdapter = null;
            this.tableAdapterManager.RezervacijaTableAdapter = this.rezervacijaTableAdapter;
            this.tableAdapterManager.StanjaTableAdapter = null;
            this.tableAdapterManager.StavkeNarudzbeTableAdapter = null;
            this.tableAdapterManager.TipDjelatnikaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PharmaCure._17003_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // klijentTableAdapter
            // 
            this.klijentTableAdapter.ClearBeforeFill = true;
            // 
            // lijekoviTableAdapter
            // 
            this.lijekoviTableAdapter.ClearBeforeFill = true;
            // 
            // rezervacijaTableAdapter
            // 
            this.rezervacijaTableAdapter.ClearBeforeFill = true;
            // 
            // dBDataSet1BindingSource
            // 
            this.dBDataSet1BindingSource.DataSource = this._17003_DBDataSet1;
            this.dBDataSet1BindingSource.Position = 0;
            // 
            // pregledRezervacijaTableAdapter
            // 
            this.pregledRezervacijaTableAdapter.ClearBeforeFill = true;
            // 
            // pregledRezervacijaBindingSource1
            // 
            this.pregledRezervacijaBindingSource1.DataMember = "PregledRezervacija";
            this.pregledRezervacijaBindingSource1.DataSource = this._17003_DBDataSet1;
            // 
            // lijekoviReceptBindingSource
            // 
            this.lijekoviReceptBindingSource.DataMember = "LijekoviRecept";
            this.lijekoviReceptBindingSource.DataSource = this._17003_DBDataSet;
            // 
            // lijekoviReceptTableAdapter
            // 
            this.lijekoviReceptTableAdapter.ClearBeforeFill = true;
            // 
            // popisTableAdapter
            // 
            this.popisTableAdapter.ClearBeforeFill = true;
            // 
            // pregledRezervacija_LijekoviBindingSource
            // 
            this.pregledRezervacija_LijekoviBindingSource.DataMember = "PregledRezervacija_Lijekovi";
            this.pregledRezervacija_LijekoviBindingSource.DataSource = this._17003_DBDataSet1;
            // 
            // pregledRezervacija_LijekoviTableAdapter
            // 
            this.pregledRezervacija_LijekoviTableAdapter.ClearBeforeFill = true;
            // 
            // pregledRezervacija_LijekoviDataGridView
            // 
            this.pregledRezervacija_LijekoviDataGridView.AutoGenerateColumns = false;
            this.pregledRezervacija_LijekoviDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pregledRezervacija_LijekoviDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.ID_Lijeka,
            this.dataGridViewTextBoxColumn9});
            this.pregledRezervacija_LijekoviDataGridView.DataSource = this.pregledRezervacija_LijekoviBindingSource;
            this.pregledRezervacija_LijekoviDataGridView.Location = new System.Drawing.Point(480, 182);
            this.pregledRezervacija_LijekoviDataGridView.Name = "pregledRezervacija_LijekoviDataGridView";
            this.pregledRezervacija_LijekoviDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pregledRezervacija_LijekoviDataGridView.Size = new System.Drawing.Size(424, 220);
            this.pregledRezervacija_LijekoviDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ID__Rezervacija";
            this.dataGridViewTextBoxColumn7.HeaderText = "idRezervacija";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Naziv";
            this.dataGridViewTextBoxColumn8.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // ID_Lijeka
            // 
            this.ID_Lijeka.DataPropertyName = "ID_Lijeka";
            this.ID_Lijeka.HeaderText = "ID_Lijeka";
            this.ID_Lijeka.Name = "ID_Lijeka";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Kolicina";
            this.dataGridViewTextBoxColumn9.HeaderText = "Kolicina";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 70;
            // 
            // pregledRezervacijaDataGridView
            // 
            this.pregledRezervacijaDataGridView.AutoGenerateColumns = false;
            this.pregledRezervacijaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pregledRezervacijaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn10});
            this.pregledRezervacijaDataGridView.DataSource = this.pregledRezervacijaBindingSource;
            this.pregledRezervacijaDataGridView.Location = new System.Drawing.Point(27, 182);
            this.pregledRezervacijaDataGridView.Name = "pregledRezervacijaDataGridView";
            this.pregledRezervacijaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pregledRezervacijaDataGridView.Size = new System.Drawing.Size(317, 220);
            this.pregledRezervacijaDataGridView.TabIndex = 18;
            this.pregledRezervacijaDataGridView.SelectionChanged += new System.EventHandler(this.pregledRezervacijaDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "idRezervacija";
            this.dataGridViewTextBoxColumn11.HeaderText = "id";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 35;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ImePrezime";
            this.dataGridViewTextBoxColumn12.HeaderText = "ImePrezime klijenta";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 140;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "datum";
            this.dataGridViewTextBoxColumn10.HeaderText = "Datum";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // btnObrisiLijek
            // 
            this.btnObrisiLijek.Location = new System.Drawing.Point(729, 84);
            this.btnObrisiLijek.Name = "btnObrisiLijek";
            this.btnObrisiLijek.Size = new System.Drawing.Size(113, 36);
            this.btnObrisiLijek.TabIndex = 19;
            this.btnObrisiLijek.Text = "Obrisi lijek";
            this.btnObrisiLijek.UseVisualStyleBackColor = true;
            this.btnObrisiLijek.Click += new System.EventHandler(this.btnObrisiLijek_Click);
            // 
            // FrmRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PharmaCure.Properties.Resources.medical_cross_background_11;
            this.ClientSize = new System.Drawing.Size(935, 431);
            this.Controls.Add(this.btnObrisiLijek);
            this.Controls.Add(this.pregledRezervacijaDataGridView);
            this.Controls.Add(this.pregledRezervacija_LijekoviDataGridView);
            this.Controls.Add(this.btnDodajLijek);
            this.Controls.Add(this.prezimeComboBox);
            this.Controls.Add(this.btnObrisiRezervaciju);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.nazivComboBox);
            this.Controls.Add(prezimeLabel);
            this.Controls.Add(lblKolicina);
            this.Controls.Add(this.dodajRezervaciju);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnPovratak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRezervacija";
            this.Text = "FrmRezervacije";
            this.Load += new System.EventHandler(this.FrmRezervacije_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmRezervacija_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._17003_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._17003_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledRezervacijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledRezervacijaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviReceptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledRezervacija_LijekoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledRezervacija_LijekoviDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledRezervacijaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _17003_DBDataSet _17003_DBDataSet;
        private _17003_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private _17003_DBDataSetTableAdapters.LijekoviTableAdapter lijekoviTableAdapter;
        private System.Windows.Forms.BindingSource lijekoviBindingSource;
        private _17003_DBDataSetTableAdapters.KlijentTableAdapter klijentTableAdapter;
        private System.Windows.Forms.BindingSource klijentBindingSource;
        private _17003_DBDataSetTableAdapters.RezervacijaTableAdapter rezervacijaTableAdapter;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button dodajRezervaciju;
        private System.Windows.Forms.BindingSource rezervacijaBindingSource;
        private System.Windows.Forms.ComboBox nazivComboBox;
        private System.Windows.Forms.TextBox txtKolicina;
        private _17003_DBDataSet _17003_DBDataSet1;
        private System.Windows.Forms.BindingSource dBDataSet1BindingSource;
        private System.Windows.Forms.BindingSource pregledRezervacijaBindingSource;
        private _17003_DBDataSetTableAdapters.PregledRezervacijaTableAdapter pregledRezervacijaTableAdapter;
        private System.Windows.Forms.BindingSource pregledRezervacijaBindingSource1;
        private System.Windows.Forms.Button btnObrisiRezervaciju;
        private System.Windows.Forms.ComboBox prezimeComboBox;
        private System.Windows.Forms.BindingSource lijekoviReceptBindingSource;
        private _17003_DBDataSetTableAdapters.LijekoviReceptTableAdapter lijekoviReceptTableAdapter;
        private System.Windows.Forms.Button btnDodajLijek;
        private System.Windows.Forms.BindingSource popisBindingSource;
        private _17003_DBDataSetTableAdapters.PopisTableAdapter popisTableAdapter;
        private System.Windows.Forms.BindingSource popisBindingSource1;
        private System.Windows.Forms.BindingSource rezervacijaBindingSource1;
        private System.Windows.Forms.BindingSource pregledRezervacija_LijekoviBindingSource;
        private _17003_DBDataSetTableAdapters.PregledRezervacija_LijekoviTableAdapter pregledRezervacija_LijekoviTableAdapter;
        private System.Windows.Forms.DataGridView pregledRezervacija_LijekoviDataGridView;
        private System.Windows.Forms.DataGridView pregledRezervacijaDataGridView;
        private System.Windows.Forms.Button btnObrisiLijek;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Lijeka;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}