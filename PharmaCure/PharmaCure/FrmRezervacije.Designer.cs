namespace PharmaCure
{
    partial class FrmRezervacije
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
            this.klijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._17003_DBDataSet = new PharmaCure._17003_DBDataSet();
            this.lijekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new PharmaCure._17003_DBDataSetTableAdapters.TableAdapterManager();
            this.klijentTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.KlijentTableAdapter();
            this.lijekoviTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.LijekoviTableAdapter();
            this.rezervacijaTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.RezervacijaTableAdapter();
            this.rezervacijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prezimeComboBox = new System.Windows.Forms.ComboBox();
            this.nazivComboBox = new System.Windows.Forms.ComboBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this._17003_DBDataSet1 = new PharmaCure._17003_DBDataSet();
            this.dBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pregledRezervacijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pregledRezervacijaTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.PregledRezervacijaTableAdapter();
            this.pregledRezervacijaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pregledRezervacijaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnObrisiRezervaciju = new System.Windows.Forms.Button();
            lblKolicina = new System.Windows.Forms.Label();
            prezimeLabel = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._17003_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._17003_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledRezervacijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledRezervacijaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledRezervacijaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKolicina
            // 
            lblKolicina.AutoSize = true;
            lblKolicina.Location = new System.Drawing.Point(346, 15);
            lblKolicina.Name = "lblKolicina";
            lblKolicina.Size = new System.Drawing.Size(47, 13);
            lblKolicina.TabIndex = 8;
            lblKolicina.Text = "Količina:";
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.Location = new System.Drawing.Point(134, 10);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(47, 13);
            prezimeLabel.TabIndex = 9;
            prezimeLabel.Text = "Prezime:";
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(144, 42);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(37, 13);
            nazivLabel.TabIndex = 10;
            nazivLabel.Text = "Naziv:";
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(13, 29);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(75, 23);
            this.btnPovratak.TabIndex = 4;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(13, 58);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 5;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // dodajRezervaciju
            // 
            this.dodajRezervaciju.Location = new System.Drawing.Point(384, 42);
            this.dodajRezervaciju.Name = "dodajRezervaciju";
            this.dodajRezervaciju.Size = new System.Drawing.Size(146, 23);
            this.dodajRezervaciju.TabIndex = 6;
            this.dodajRezervaciju.Text = "Dodaj rezervaciju";
            this.dodajRezervaciju.UseVisualStyleBackColor = true;
            this.dodajRezervaciju.Click += new System.EventHandler(this.dodajRezervaciju_Click);
            // 
            // klijentBindingSource
            // 
            this.klijentBindingSource.DataMember = "Klijent";
            this.klijentBindingSource.DataSource = this._17003_DBDataSet;
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
            // rezervacijaBindingSource
            // 
            this.rezervacijaBindingSource.DataMember = "Rezervacija";
            this.rezervacijaBindingSource.DataSource = this._17003_DBDataSet;
            // 
            // prezimeComboBox
            // 
            this.prezimeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klijentBindingSource, "Prezime", true));
            this.prezimeComboBox.DataSource = this.klijentBindingSource;
            this.prezimeComboBox.DisplayMember = "Prezime";
            this.prezimeComboBox.FormattingEnabled = true;
            this.prezimeComboBox.Location = new System.Drawing.Point(187, 7);
            this.prezimeComboBox.Name = "prezimeComboBox";
            this.prezimeComboBox.Size = new System.Drawing.Size(121, 21);
            this.prezimeComboBox.TabIndex = 10;
            this.prezimeComboBox.ValueMember = "ID_Klijent";
            this.prezimeComboBox.SelectedIndexChanged += new System.EventHandler(this.prezimeComboBox_SelectedIndexChanged);
            // 
            // nazivComboBox
            // 
            this.nazivComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lijekoviBindingSource, "Naziv", true));
            this.nazivComboBox.DataSource = this.lijekoviBindingSource;
            this.nazivComboBox.DisplayMember = "Naziv";
            this.nazivComboBox.FormattingEnabled = true;
            this.nazivComboBox.Location = new System.Drawing.Point(187, 39);
            this.nazivComboBox.Name = "nazivComboBox";
            this.nazivComboBox.Size = new System.Drawing.Size(121, 21);
            this.nazivComboBox.TabIndex = 11;
            this.nazivComboBox.ValueMember = "ID_Lijek";
            this.nazivComboBox.SelectedIndexChanged += new System.EventHandler(this.nazivComboBox_SelectedIndexChanged);
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(399, 10);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(100, 20);
            this.txtKolicina.TabIndex = 12;
            this.txtKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _17003_DBDataSet1
            // 
            this._17003_DBDataSet1.DataSetName = "_17003_DBDataSet";
            this._17003_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBDataSet1BindingSource
            // 
            this.dBDataSet1BindingSource.DataSource = this._17003_DBDataSet1;
            this.dBDataSet1BindingSource.Position = 0;
            // 
            // pregledRezervacijaBindingSource
            // 
            this.pregledRezervacijaBindingSource.DataMember = "PregledRezervacija";
            this.pregledRezervacijaBindingSource.DataSource = this._17003_DBDataSet;
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
            // pregledRezervacijaDataGridView
            // 
            this.pregledRezervacijaDataGridView.AutoGenerateColumns = false;
            this.pregledRezervacijaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pregledRezervacijaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.pregledRezervacijaDataGridView.DataSource = this.pregledRezervacijaBindingSource;
            this.pregledRezervacijaDataGridView.Location = new System.Drawing.Point(90, 85);
            this.pregledRezervacijaDataGridView.Name = "pregledRezervacijaDataGridView";
            this.pregledRezervacijaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pregledRezervacijaDataGridView.Size = new System.Drawing.Size(547, 220);
            this.pregledRezervacijaDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Naziv";
            this.dataGridViewTextBoxColumn2.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prezime";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prezime";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "datum";
            this.dataGridViewTextBoxColumn4.HeaderText = "datum";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Kolicina";
            this.dataGridViewTextBoxColumn5.HeaderText = "Kolicina";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // btnObrisiRezervaciju
            // 
            this.btnObrisiRezervaciju.Location = new System.Drawing.Point(558, 42);
            this.btnObrisiRezervaciju.Name = "btnObrisiRezervaciju";
            this.btnObrisiRezervaciju.Size = new System.Drawing.Size(146, 23);
            this.btnObrisiRezervaciju.TabIndex = 13;
            this.btnObrisiRezervaciju.Text = "Obrisi rezervaciju";
            this.btnObrisiRezervaciju.UseVisualStyleBackColor = true;
            this.btnObrisiRezervaciju.Click += new System.EventHandler(this.btnObrisiRezervaciju_Click);
            // 
            // FrmRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PharmaCure.Properties.Resources.medical_cross_background_11;
            this.ClientSize = new System.Drawing.Size(757, 423);
            this.Controls.Add(this.btnObrisiRezervaciju);
            this.Controls.Add(this.pregledRezervacijaDataGridView);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.nazivComboBox);
            this.Controls.Add(prezimeLabel);
            this.Controls.Add(this.prezimeComboBox);
            this.Controls.Add(lblKolicina);
            this.Controls.Add(this.dodajRezervaciju);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnPovratak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRezervacije";
            this.Text = "FrmRezervacije";
            this.Load += new System.EventHandler(this.FrmRezervacije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._17003_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._17003_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledRezervacijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledRezervacijaBindingSource1)).EndInit();
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
        private System.Windows.Forms.ComboBox prezimeComboBox;
        private System.Windows.Forms.ComboBox nazivComboBox;
        private System.Windows.Forms.TextBox txtKolicina;
        private _17003_DBDataSet _17003_DBDataSet1;
        private System.Windows.Forms.BindingSource dBDataSet1BindingSource;
        private System.Windows.Forms.BindingSource pregledRezervacijaBindingSource;
        private _17003_DBDataSetTableAdapters.PregledRezervacijaTableAdapter pregledRezervacijaTableAdapter;
        private System.Windows.Forms.BindingSource pregledRezervacijaBindingSource1;
        private System.Windows.Forms.DataGridView pregledRezervacijaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnObrisiRezervaciju;
    }
}