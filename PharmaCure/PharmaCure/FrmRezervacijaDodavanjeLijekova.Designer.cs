namespace PharmaCure
{
    partial class FrmRezervacijaDodavanjeLijekova
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
            this._17003_DBDataSet = new PharmaCure._17003_DBDataSet();
            this.pregledRezervacija_LijekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pregledRezervacija_LijekoviTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.PregledRezervacija_LijekoviTableAdapter();
            this.tableAdapterManager = new PharmaCure._17003_DBDataSetTableAdapters.TableAdapterManager();
            this.pregledRezervacija_LijekoviDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klijentTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.KlijentTableAdapter();
            this.pregledLijekovaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pregledLijekovaTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.PregledLijekovaTableAdapter();
            this.lijekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lijekoviTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.LijekoviTableAdapter();
            this.lijekoviDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._17003_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledRezervacija_LijekoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledRezervacija_LijekoviDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledLijekovaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _17003_DBDataSet
            // 
            this._17003_DBDataSet.DataSetName = "_17003_DBDataSet";
            this._17003_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pregledRezervacija_LijekoviBindingSource
            // 
            this.pregledRezervacija_LijekoviBindingSource.DataMember = "PregledRezervacija_Lijekovi";
            this.pregledRezervacija_LijekoviBindingSource.DataSource = this._17003_DBDataSet;
            // 
            // pregledRezervacija_LijekoviTableAdapter
            // 
            this.pregledRezervacija_LijekoviTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.RezervacijaTableAdapter = null;
            this.tableAdapterManager.StanjaTableAdapter = null;
            this.tableAdapterManager.StavkeNarudzbeTableAdapter = null;
            this.tableAdapterManager.TipDjelatnikaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PharmaCure._17003_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pregledRezervacija_LijekoviDataGridView
            // 
            this.pregledRezervacija_LijekoviDataGridView.AutoGenerateColumns = false;
            this.pregledRezervacija_LijekoviDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pregledRezervacija_LijekoviDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.pregledRezervacija_LijekoviDataGridView.DataSource = this.pregledRezervacija_LijekoviBindingSource;
            this.pregledRezervacija_LijekoviDataGridView.Location = new System.Drawing.Point(36, 137);
            this.pregledRezervacija_LijekoviDataGridView.Name = "pregledRezervacija_LijekoviDataGridView";
            this.pregledRezervacija_LijekoviDataGridView.Size = new System.Drawing.Size(559, 224);
            this.pregledRezervacija_LijekoviDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID__Rezervacija";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID__Rezervacija";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Kolicina";
            this.dataGridViewTextBoxColumn3.HeaderText = "Kolicina";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID_Lijeka";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID_Lijeka";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
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
            // pregledLijekovaBindingSource
            // 
            this.pregledLijekovaBindingSource.DataMember = "PregledLijekova";
            this.pregledLijekovaBindingSource.DataSource = this._17003_DBDataSet;
            // 
            // pregledLijekovaTableAdapter
            // 
            this.pregledLijekovaTableAdapter.ClearBeforeFill = true;
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
            // lijekoviDataGridView
            // 
            this.lijekoviDataGridView.AutoGenerateColumns = false;
            this.lijekoviDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lijekoviDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewCheckBoxColumn1});
            this.lijekoviDataGridView.DataSource = this.lijekoviBindingSource;
            this.lijekoviDataGridView.Location = new System.Drawing.Point(12, 47);
            this.lijekoviDataGridView.Name = "lijekoviDataGridView";
            this.lijekoviDataGridView.Size = new System.Drawing.Size(964, 84);
            this.lijekoviDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID_Lijek";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID_Lijek";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Naziv";
            this.dataGridViewTextBoxColumn6.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Kratki_opis";
            this.dataGridViewTextBoxColumn7.HeaderText = "Kratki_opis";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Datum_proizvodnje";
            this.dataGridViewTextBoxColumn8.HeaderText = "Datum_proizvodnje";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Datum_isteka";
            this.dataGridViewTextBoxColumn9.HeaderText = "Datum_isteka";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Cijena";
            this.dataGridViewTextBoxColumn10.HeaderText = "Cijena";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Zemlja_porijekla";
            this.dataGridViewTextBoxColumn11.HeaderText = "Zemlja_porijekla";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Kategorija_ID";
            this.dataGridViewTextBoxColumn12.HeaderText = "Kategorija_ID";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Stanje";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Stanje";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // FrmRezervacijaDodavanjeLijekova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PharmaCure.Properties.Resources.medical_cross_background_11;
            this.ClientSize = new System.Drawing.Size(1013, 390);
            this.Controls.Add(this.lijekoviDataGridView);
            this.Controls.Add(this.pregledRezervacija_LijekoviDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRezervacijaDodavanjeLijekova";
            this.Text = "FrmRezervacijaDodavanjeLijekova";
            this.Load += new System.EventHandler(this.FrmRezervacijaDodavanjeLijekova_Load);
            ((System.ComponentModel.ISupportInitialize)(this._17003_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledRezervacija_LijekoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledRezervacija_LijekoviDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledLijekovaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private _17003_DBDataSet _17003_DBDataSet;
        private System.Windows.Forms.BindingSource pregledRezervacija_LijekoviBindingSource;
        private _17003_DBDataSetTableAdapters.PregledRezervacija_LijekoviTableAdapter pregledRezervacija_LijekoviTableAdapter;
        private _17003_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView pregledRezervacija_LijekoviDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private _17003_DBDataSetTableAdapters.KlijentTableAdapter klijentTableAdapter;
        private System.Windows.Forms.BindingSource klijentBindingSource;
        private System.Windows.Forms.BindingSource pregledLijekovaBindingSource;
        private _17003_DBDataSetTableAdapters.PregledLijekovaTableAdapter pregledLijekovaTableAdapter;
        private _17003_DBDataSetTableAdapters.LijekoviTableAdapter lijekoviTableAdapter;
        private System.Windows.Forms.BindingSource lijekoviBindingSource;
        private System.Windows.Forms.DataGridView lijekoviDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}