namespace PharmaCure
{
    partial class FrmKolicine
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
            System.Windows.Forms.Label kolicina_skladisteLabel;
            System.Windows.Forms.Label lijekovi_IDLabel;
            System.Windows.Forms.Label poslovnica_IDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKolicine));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PregledLijekovaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._17003_DBDataSet = new PharmaCure._17003_DBDataSet();
            this.dostupnostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPovratak = new System.Windows.Forms.Button();
            this.poslovnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poslovnicaTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.PoslovnicaTableAdapter();
            this.tableAdapterManager = new PharmaCure._17003_DBDataSetTableAdapters.TableAdapterManager();
            this.dostupnostTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.DostupnostTableAdapter();
            this.lijekoviTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.LijekoviTableAdapter();
            this.kolicina_skladisteTextBox = new System.Windows.Forms.TextBox();
            this.lijekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lijekoviComboBox = new System.Windows.Forms.ComboBox();
            this.poslovniceComboBox = new System.Windows.Forms.ComboBox();
            this.izlaz = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PregledLijekovaTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.PregledLijekovaTableAdapter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            kolicina_skladisteLabel = new System.Windows.Forms.Label();
            lijekovi_IDLabel = new System.Windows.Forms.Label();
            poslovnica_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PregledLijekovaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._17003_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostupnostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // kolicina_skladisteLabel
            // 
            kolicina_skladisteLabel.AutoSize = true;
            kolicina_skladisteLabel.Location = new System.Drawing.Point(105, 288);
            kolicina_skladisteLabel.Name = "kolicina_skladisteLabel";
            kolicina_skladisteLabel.Size = new System.Drawing.Size(91, 13);
            kolicina_skladisteLabel.TabIndex = 2;
            kolicina_skladisteLabel.Text = "Kolicina skladiste:";
            // 
            // lijekovi_IDLabel
            // 
            lijekovi_IDLabel.AutoSize = true;
            lijekovi_IDLabel.Location = new System.Drawing.Point(404, 21);
            lijekovi_IDLabel.Name = "lijekovi_IDLabel";
            lijekovi_IDLabel.Size = new System.Drawing.Size(61, 13);
            lijekovi_IDLabel.TabIndex = 4;
            lijekovi_IDLabel.Text = "Naziv lijeka";
            // 
            // poslovnica_IDLabel
            // 
            poslovnica_IDLabel.AutoSize = true;
            poslovnica_IDLabel.Location = new System.Drawing.Point(167, 20);
            poslovnica_IDLabel.Name = "poslovnica_IDLabel";
            poslovnica_IDLabel.Size = new System.Drawing.Size(88, 13);
            poslovnica_IDLabel.TabIndex = 5;
            poslovnica_IDLabel.Text = "Naziv poslovnice";
            // 
            // PregledLijekovaBindingSource
            // 
            this.PregledLijekovaBindingSource.DataMember = "PregledLijekova";
            this.PregledLijekovaBindingSource.DataSource = this._17003_DBDataSet;
            // 
            // _17003_DBDataSet
            // 
            this._17003_DBDataSet.DataSetName = "_17003_DBDataSet";
            this._17003_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dostupnostBindingSource
            // 
            this.dostupnostBindingSource.DataMember = "Dostupnost";
            this.dostupnostBindingSource.DataSource = this._17003_DBDataSet;
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPovratak.BackgroundImage")));
            this.btnPovratak.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnPovratak.Location = new System.Drawing.Point(13, 13);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(75, 23);
            this.btnPovratak.TabIndex = 1;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // poslovnicaBindingSource
            // 
            this.poslovnicaBindingSource.DataMember = "Poslovnica";
            this.poslovnicaBindingSource.DataSource = this._17003_DBDataSet;
            // 
            // poslovnicaTableAdapter
            // 
            this.poslovnicaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AkcijaTableAdapter = null;
            this.tableAdapterManager.Artikli_RacunTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DjelatnikTableAdapter = null;
            this.tableAdapterManager.DostupnostTableAdapter = this.dostupnostTableAdapter;
            this.tableAdapterManager.KategorijaTableAdapter = null;
            this.tableAdapterManager.KlijentTableAdapter = null;
            this.tableAdapterManager.LijekoviOsiguranjeTableAdapter = null;
            this.tableAdapterManager.LijekoviReceptTableAdapter = null;
            this.tableAdapterManager.LijekoviTableAdapter = this.lijekoviTableAdapter;
            this.tableAdapterManager.NarudzbaTableAdapter = null;
            this.tableAdapterManager.OsiguranjeTableAdapter = null;
            this.tableAdapterManager.PopisOsiguranihLijekovaTableAdapter = null;
            this.tableAdapterManager.PopisTableAdapter = null;
            this.tableAdapterManager.PoslovnicaTableAdapter = this.poslovnicaTableAdapter;
            this.tableAdapterManager.RacunTableAdapter = null;
            this.tableAdapterManager.RezervacijaTableAdapter = null;
            this.tableAdapterManager.StanjaTableAdapter = null;
            this.tableAdapterManager.StavkeNarudzbeTableAdapter = null;
            this.tableAdapterManager.TipDjelatnikaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PharmaCure._17003_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dostupnostTableAdapter
            // 
            this.dostupnostTableAdapter.ClearBeforeFill = true;
            // 
            // lijekoviTableAdapter
            // 
            this.lijekoviTableAdapter.ClearBeforeFill = true;
            // 
            // kolicina_skladisteTextBox
            // 
            this.kolicina_skladisteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dostupnostBindingSource, "Kolicina_skladiste", true));
            this.kolicina_skladisteTextBox.Location = new System.Drawing.Point(217, 281);
            this.kolicina_skladisteTextBox.Name = "kolicina_skladisteTextBox";
            this.kolicina_skladisteTextBox.Size = new System.Drawing.Size(100, 20);
            this.kolicina_skladisteTextBox.TabIndex = 3;
            // 
            // lijekoviBindingSource
            // 
            this.lijekoviBindingSource.DataMember = "Lijekovi";
            this.lijekoviBindingSource.DataSource = this._17003_DBDataSet;
            // 
            // lijekoviComboBox
            // 
            this.lijekoviComboBox.DataSource = this.lijekoviBindingSource;
            this.lijekoviComboBox.DisplayMember = "Naziv";
            this.lijekoviComboBox.FormattingEnabled = true;
            this.lijekoviComboBox.Location = new System.Drawing.Point(496, 12);
            this.lijekoviComboBox.Name = "lijekoviComboBox";
            this.lijekoviComboBox.Size = new System.Drawing.Size(121, 21);
            this.lijekoviComboBox.TabIndex = 6;
            this.lijekoviComboBox.ValueMember = "ID_Lijek";
            this.lijekoviComboBox.SelectedIndexChanged += new System.EventHandler(this.lijekoviComboBox_SelectedIndexChanged);
            // 
            // poslovniceComboBox
            // 
            this.poslovniceComboBox.DataSource = this.poslovnicaBindingSource;
            this.poslovniceComboBox.DisplayMember = "Naziv";
            this.poslovniceComboBox.FormattingEnabled = true;
            this.poslovniceComboBox.Location = new System.Drawing.Point(275, 10);
            this.poslovniceComboBox.Name = "poslovniceComboBox";
            this.poslovniceComboBox.Size = new System.Drawing.Size(121, 21);
            this.poslovniceComboBox.TabIndex = 7;
            this.poslovniceComboBox.ValueMember = "ID_Poslovnica";
            this.poslovniceComboBox.SelectedIndexChanged += new System.EventHandler(this.poslovniceComboBox_SelectedIndexChanged);
            // 
            // izlaz
            // 
            this.izlaz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("izlaz.BackgroundImage")));
            this.izlaz.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.izlaz.Location = new System.Drawing.Point(273, 311);
            this.izlaz.Name = "izlaz";
            this.izlaz.Size = new System.Drawing.Size(75, 23);
            this.izlaz.TabIndex = 8;
            this.izlaz.Text = "Izlaz";
            this.izlaz.UseVisualStyleBackColor = true;
            this.izlaz.Click += new System.EventHandler(this.izlaz_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.button2.Location = new System.Drawing.Point(108, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "ctaj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.PregledLijekovaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PharmaCure.Izvjestaj_KolicinaLijekova.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 54);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(604, 218);
            this.reportViewer1.TabIndex = 13;
            // 
            // PregledLijekovaTableAdapter
            // 
            this.PregledLijekovaTableAdapter.ClearBeforeFill = true;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(655, 34);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // FrmKolicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(985, 392);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.izlaz);
            this.Controls.Add(this.poslovniceComboBox);
            this.Controls.Add(this.lijekoviComboBox);
            this.Controls.Add(poslovnica_IDLabel);
            this.Controls.Add(lijekovi_IDLabel);
            this.Controls.Add(kolicina_skladisteLabel);
            this.Controls.Add(this.kolicina_skladisteTextBox);
            this.Controls.Add(this.btnPovratak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKolicine";
            this.Text = "FrmKolicine";
            this.Load += new System.EventHandler(this.FrmKolicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PregledLijekovaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._17003_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostupnostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
        private _17003_DBDataSet _17003_DBDataSet;
        private System.Windows.Forms.BindingSource poslovnicaBindingSource;
        private _17003_DBDataSetTableAdapters.PoslovnicaTableAdapter poslovnicaTableAdapter;
        private _17003_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private _17003_DBDataSetTableAdapters.DostupnostTableAdapter dostupnostTableAdapter;
        private System.Windows.Forms.BindingSource dostupnostBindingSource;
        private System.Windows.Forms.TextBox kolicina_skladisteTextBox;
        private _17003_DBDataSetTableAdapters.LijekoviTableAdapter lijekoviTableAdapter;
        private System.Windows.Forms.BindingSource lijekoviBindingSource;
        private System.Windows.Forms.ComboBox lijekoviComboBox;
        private System.Windows.Forms.ComboBox poslovniceComboBox;
        private System.Windows.Forms.Button izlaz;
        private System.Windows.Forms.Button button2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PregledLijekovaBindingSource;
        private _17003_DBDataSetTableAdapters.PregledLijekovaTableAdapter PregledLijekovaTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}