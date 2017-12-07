namespace PharmaCure
{
    partial class FrmRezervacijaKlijent
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
            this.txtBoxPretrazi = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.pregledKlijenataDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pregledKlijenataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._17003_DBDataSet = new PharmaCure._17003_DBDataSet();
            this.klijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klijentTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.KlijentTableAdapter();
            this.tableAdapterManager = new PharmaCure._17003_DBDataSetTableAdapters.TableAdapterManager();
            this.pregledKlijenataTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.PregledKlijenataTableAdapter();
            this.btnDodajKlijenta = new System.Windows.Forms.Button();
            this.lblPretragaTekst = new System.Windows.Forms.Label();
            this.lblPretragaCombo = new System.Windows.Forms.Label();
            this.comboBoxPretraga = new System.Windows.Forms.ComboBox();
            this.rezervacijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervacijaTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.RezervacijaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pregledKlijenataDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledKlijenataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._17003_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxPretrazi
            // 
            this.txtBoxPretrazi.Location = new System.Drawing.Point(433, 65);
            this.txtBoxPretrazi.Name = "txtBoxPretrazi";
            this.txtBoxPretrazi.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPretrazi.TabIndex = 50;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(556, 61);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 26);
            this.btnPretrazi.TabIndex = 49;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(556, 12);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 26);
            this.btnIzlaz.TabIndex = 48;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(12, 12);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(75, 26);
            this.btnPovratak.TabIndex = 47;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // pregledKlijenataDataGridView
            // 
            this.pregledKlijenataDataGridView.AutoGenerateColumns = false;
            this.pregledKlijenataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pregledKlijenataDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.pregledKlijenataDataGridView.DataSource = this.pregledKlijenataBindingSource;
            this.pregledKlijenataDataGridView.Location = new System.Drawing.Point(65, 141);
            this.pregledKlijenataDataGridView.Name = "pregledKlijenataDataGridView";
            this.pregledKlijenataDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pregledKlijenataDataGridView.Size = new System.Drawing.Size(455, 220);
            this.pregledKlijenataDataGridView.TabIndex = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Klijent";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID klijent";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ImePrezime";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ime i prezime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Naziv";
            this.dataGridViewTextBoxColumn3.HeaderText = "Vrsta osiguranja";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // pregledKlijenataBindingSource
            // 
            this.pregledKlijenataBindingSource.DataMember = "PregledKlijenata";
            this.pregledKlijenataBindingSource.DataSource = this._17003_DBDataSet;
            // 
            // _17003_DBDataSet
            // 
            this._17003_DBDataSet.DataSetName = "_17003_DBDataSet";
            this._17003_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klijentBindingSource
            // 
            this.klijentBindingSource.DataMember = "Klijent";
            this.klijentBindingSource.DataSource = this._17003_DBDataSet;
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
            this.tableAdapterManager.DjelatnikTableAdapter = null;
            this.tableAdapterManager.DostupnostTableAdapter = null;
            this.tableAdapterManager.KategorijaTableAdapter = null;
            this.tableAdapterManager.KlijentTableAdapter = this.klijentTableAdapter;
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
            // pregledKlijenataTableAdapter
            // 
            this.pregledKlijenataTableAdapter.ClearBeforeFill = true;
            // 
            // btnDodajKlijenta
            // 
            this.btnDodajKlijenta.Location = new System.Drawing.Point(235, 109);
            this.btnDodajKlijenta.Name = "btnDodajKlijenta";
            this.btnDodajKlijenta.Size = new System.Drawing.Size(141, 26);
            this.btnDodajKlijenta.TabIndex = 51;
            this.btnDodajKlijenta.Text = "Odaberi klijenta";
            this.btnDodajKlijenta.UseVisualStyleBackColor = true;
            this.btnDodajKlijenta.Click += new System.EventHandler(this.btnDodajKlijenta_Click);
            // 
            // lblPretragaTekst
            // 
            this.lblPretragaTekst.AutoSize = true;
            this.lblPretragaTekst.BackColor = System.Drawing.Color.Transparent;
            this.lblPretragaTekst.Location = new System.Drawing.Point(348, 68);
            this.lblPretragaTekst.Name = "lblPretragaTekst";
            this.lblPretragaTekst.Size = new System.Drawing.Size(79, 13);
            this.lblPretragaTekst.TabIndex = 61;
            this.lblPretragaTekst.Text = "Tekst pretrage:";
            // 
            // lblPretragaCombo
            // 
            this.lblPretragaCombo.AutoSize = true;
            this.lblPretragaCombo.BackColor = System.Drawing.Color.Transparent;
            this.lblPretragaCombo.Location = new System.Drawing.Point(171, 68);
            this.lblPretragaCombo.Name = "lblPretragaCombo";
            this.lblPretragaCombo.Size = new System.Drawing.Size(77, 13);
            this.lblPretragaCombo.TabIndex = 60;
            this.lblPretragaCombo.Text = "Pretraži prema:";
            // 
            // comboBoxPretraga
            // 
            this.comboBoxPretraga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPretraga.FormattingEnabled = true;
            this.comboBoxPretraga.Items.AddRange(new object[] {
            "ID ",
            "Naziv"});
            this.comboBoxPretraga.Location = new System.Drawing.Point(254, 64);
            this.comboBoxPretraga.Name = "comboBoxPretraga";
            this.comboBoxPretraga.Size = new System.Drawing.Size(88, 21);
            this.comboBoxPretraga.TabIndex = 59;
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
            // FrmRezervacijaKlijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PharmaCure.Properties.Resources.medical_cross_background_11;
            this.ClientSize = new System.Drawing.Size(685, 381);
            this.Controls.Add(this.lblPretragaTekst);
            this.Controls.Add(this.lblPretragaCombo);
            this.Controls.Add(this.comboBoxPretraga);
            this.Controls.Add(this.btnDodajKlijenta);
            this.Controls.Add(this.pregledKlijenataDataGridView);
            this.Controls.Add(this.txtBoxPretrazi);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnPovratak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRezervacijaKlijent";
            this.Text = "FrmRezervacijaNova";
            this.Load += new System.EventHandler(this.FrmRezervacijaKlijent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pregledKlijenataDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledKlijenataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._17003_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxPretrazi;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnPovratak;
        private _17003_DBDataSet _17003_DBDataSet;
        private System.Windows.Forms.BindingSource klijentBindingSource;
        private _17003_DBDataSetTableAdapters.KlijentTableAdapter klijentTableAdapter;
        private _17003_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource pregledKlijenataBindingSource;
        private _17003_DBDataSetTableAdapters.PregledKlijenataTableAdapter pregledKlijenataTableAdapter;
        private System.Windows.Forms.DataGridView pregledKlijenataDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnDodajKlijenta;
        private System.Windows.Forms.Label lblPretragaTekst;
        private System.Windows.Forms.Label lblPretragaCombo;
        private System.Windows.Forms.ComboBox comboBoxPretraga;
        private System.Windows.Forms.BindingSource rezervacijaBindingSource;
        private _17003_DBDataSetTableAdapters.RezervacijaTableAdapter rezervacijaTableAdapter;
    }
}