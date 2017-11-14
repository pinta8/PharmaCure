namespace PharmaCure
{
    partial class FrmNoviLijek
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label datum_proizvodnjeLabel;
            System.Windows.Forms.Label puni_opisLabel;
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
            this.puni_opisTextBox = new System.Windows.Forms.TextBox();
            this.kratki_opisTextBox = new System.Windows.Forms.TextBox();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.lijekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lijekoviTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.LijekoviTableAdapter();
            this.kategorijaTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.KategorijaTableAdapter();
            cijenaLabel = new System.Windows.Forms.Label();
            zemlja_porijeklaLabel = new System.Windows.Forms.Label();
            nazivLabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            datum_proizvodnjeLabel = new System.Windows.Forms.Label();
            puni_opisLabel = new System.Windows.Forms.Label();
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
            cijenaLabel.Location = new System.Drawing.Point(181, 178);
            cijenaLabel.Name = "cijenaLabel";
            cijenaLabel.Size = new System.Drawing.Size(39, 13);
            cijenaLabel.TabIndex = 55;
            cijenaLabel.Text = "Cijena:";
            // 
            // zemlja_porijeklaLabel
            // 
            zemlja_porijeklaLabel.AutoSize = true;
            zemlja_porijeklaLabel.BackColor = System.Drawing.Color.Transparent;
            zemlja_porijeklaLabel.Location = new System.Drawing.Point(181, 211);
            zemlja_porijeklaLabel.Name = "zemlja_porijeklaLabel";
            zemlja_porijeklaLabel.Size = new System.Drawing.Size(83, 13);
            zemlja_porijeklaLabel.TabIndex = 57;
            zemlja_porijeklaLabel.Text = "Zemlja porijekla:";
            // 
            // nazivLabel1
            // 
            nazivLabel1.AutoSize = true;
            nazivLabel1.BackColor = System.Drawing.Color.Transparent;
            nazivLabel1.Location = new System.Drawing.Point(181, 247);
            nazivLabel1.Name = "nazivLabel1";
            nazivLabel1.Size = new System.Drawing.Size(86, 13);
            nazivLabel1.TabIndex = 60;
            nazivLabel1.Text = "Naziv kategorije:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Location = new System.Drawing.Point(181, 140);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 13);
            label1.TabIndex = 70;
            label1.Text = "Datum isteka:";
            // 
            // datum_proizvodnjeLabel
            // 
            datum_proizvodnjeLabel.AutoSize = true;
            datum_proizvodnjeLabel.BackColor = System.Drawing.Color.Transparent;
            datum_proizvodnjeLabel.Location = new System.Drawing.Point(181, 107);
            datum_proizvodnjeLabel.Name = "datum_proizvodnjeLabel";
            datum_proizvodnjeLabel.Size = new System.Drawing.Size(98, 13);
            datum_proizvodnjeLabel.TabIndex = 68;
            datum_proizvodnjeLabel.Text = "Datum proizvodnje:";
            // 
            // puni_opisLabel
            // 
            puni_opisLabel.AutoSize = true;
            puni_opisLabel.BackColor = System.Drawing.Color.Transparent;
            puni_opisLabel.Location = new System.Drawing.Point(181, 75);
            puni_opisLabel.Name = "puni_opisLabel";
            puni_opisLabel.Size = new System.Drawing.Size(53, 13);
            puni_opisLabel.TabIndex = 66;
            puni_opisLabel.Text = "Puni opis:";
            // 
            // kratki_opisLabel
            // 
            kratki_opisLabel.AutoSize = true;
            kratki_opisLabel.BackColor = System.Drawing.Color.Transparent;
            kratki_opisLabel.Location = new System.Drawing.Point(181, 42);
            kratki_opisLabel.Name = "kratki_opisLabel";
            kratki_opisLabel.Size = new System.Drawing.Size(59, 13);
            kratki_opisLabel.TabIndex = 64;
            kratki_opisLabel.Text = "Kratki opis:";
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.BackColor = System.Drawing.Color.Transparent;
            nazivLabel.Location = new System.Drawing.Point(181, 9);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(37, 13);
            nazivLabel.TabIndex = 63;
            nazivLabel.Text = "Naziv:";
            // 
            // cijenaTextBox
            // 
            this.cijenaTextBox.Location = new System.Drawing.Point(281, 175);
            this.cijenaTextBox.Name = "cijenaTextBox";
            this.cijenaTextBox.Size = new System.Drawing.Size(111, 20);
            this.cijenaTextBox.TabIndex = 6;
            // 
            // zemlja_porijeklaTextBox
            // 
            this.zemlja_porijeklaTextBox.Location = new System.Drawing.Point(281, 208);
            this.zemlja_porijeklaTextBox.Name = "zemlja_porijeklaTextBox";
            this.zemlja_porijeklaTextBox.Size = new System.Drawing.Size(111, 20);
            this.zemlja_porijeklaTextBox.TabIndex = 7;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(171, 286);
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
            this.nazivComboBox.FormattingEnabled = true;
            this.nazivComboBox.Location = new System.Drawing.Point(281, 244);
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
            this.datum_istekaDateTimePicker.Location = new System.Drawing.Point(281, 137);
            this.datum_istekaDateTimePicker.Name = "datum_istekaDateTimePicker";
            this.datum_istekaDateTimePicker.Size = new System.Drawing.Size(111, 20);
            this.datum_istekaDateTimePicker.TabIndex = 5;
            // 
            // datum_proizvodnjeDateTimePicker
            // 
            this.datum_proizvodnjeDateTimePicker.Location = new System.Drawing.Point(281, 104);
            this.datum_proizvodnjeDateTimePicker.Name = "datum_proizvodnjeDateTimePicker";
            this.datum_proizvodnjeDateTimePicker.Size = new System.Drawing.Size(111, 20);
            this.datum_proizvodnjeDateTimePicker.TabIndex = 4;
            // 
            // puni_opisTextBox
            // 
            this.puni_opisTextBox.Location = new System.Drawing.Point(281, 72);
            this.puni_opisTextBox.Name = "puni_opisTextBox";
            this.puni_opisTextBox.Size = new System.Drawing.Size(111, 20);
            this.puni_opisTextBox.TabIndex = 3;
            this.puni_opisTextBox.TextChanged += new System.EventHandler(this.puni_opisTextBox_TextChanged);
            // 
            // kratki_opisTextBox
            // 
            this.kratki_opisTextBox.Location = new System.Drawing.Point(281, 39);
            this.kratki_opisTextBox.Name = "kratki_opisTextBox";
            this.kratki_opisTextBox.Size = new System.Drawing.Size(111, 20);
            this.kratki_opisTextBox.TabIndex = 2;
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.Location = new System.Drawing.Point(281, 6);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(111, 20);
            this.nazivTextBox.TabIndex = 1;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(328, 286);
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
            // FrmNoviLijek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PharmaCure.Properties.Resources.medical_cross_background_11;
            this.ClientSize = new System.Drawing.Size(535, 330);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(label1);
            this.Controls.Add(this.datum_istekaDateTimePicker);
            this.Controls.Add(datum_proizvodnjeLabel);
            this.Controls.Add(this.datum_proizvodnjeDateTimePicker);
            this.Controls.Add(puni_opisLabel);
            this.Controls.Add(this.puni_opisTextBox);
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
            this.Name = "FrmNoviLijek";
            this.Text = "FrmNoviLijek";
            this.Load += new System.EventHandler(this.FrmNoviLijek_Load);
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
        private System.Windows.Forms.TextBox puni_opisTextBox;
        private System.Windows.Forms.TextBox kratki_opisTextBox;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.Button btnOdustani;
        private _17003_DBDataSet _17003_DBDataSet;
        private System.Windows.Forms.BindingSource lijekoviBindingSource;
        private _17003_DBDataSetTableAdapters.LijekoviTableAdapter lijekoviTableAdapter;
        private System.Windows.Forms.BindingSource kategorijaBindingSource;
        private _17003_DBDataSetTableAdapters.KategorijaTableAdapter kategorijaTableAdapter;
    }
}