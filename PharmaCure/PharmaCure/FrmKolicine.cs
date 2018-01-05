using GoogleChartSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PharmaCure
{
    public partial class FrmKolicine : Form
    {
        public int Lijek_id { get; set; }
        public int Poslovnica_id { get; set; }
        public FrmKolicine()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        private void FrmKolicine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r17003/wiki/Korisni%C4%8Dka-dokumentacija#23-koli%C4%8Dina-lijekova-po-poslovnicama");
            }
        }private void prikaziSve_Click(object sender, EventArgs e)
        {
            this.PregledLijekovaTableAdapter.Fill(this._17003_DBDataSet.PregledLijekova);
            OsvjeziPrikaz();
        }
        private void FrmKolicine_Load(object sender, EventArgs e)
        {
            this.PregledLijekovaTableAdapter.Fill(this._17003_DBDataSet.PregledLijekova);
            this.lijekoviTableAdapter.Fill(this._17003_DBDataSet.Lijekovi);
            this.poslovnicaTableAdapter.Fill(this._17003_DBDataSet.Poslovnica);
            poslovniceComboBox.SelectedIndex = -1;
            lijekoviComboBox.Text="";
        }
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnPovratak_Click_1(object sender, EventArgs e)
        {
            FrmMain m = new FrmMain();
            m.Show();
            this.Close();
        }
        private void poslovniceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (poslovniceComboBox.SelectedItem != null)
            {
                Lijek_id = int.Parse(lijekoviComboBox.SelectedValue.ToString());
                Poslovnica_id = int.Parse(poslovniceComboBox.SelectedValue.ToString());
                this.dostupnostTableAdapter.FillById(this._17003_DBDataSet.Dostupnost, Lijek_id, Poslovnica_id);
                this.PregledLijekovaTableAdapter.selectPremaPoslovnici(this._17003_DBDataSet.PregledLijekova, Poslovnica_id);
                CrtajGraf();
                OsvjeziPrikaz();
            }
        }
        private void LijekoviComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lijekoviComboBox.SelectedItem != null && poslovniceComboBox.SelectedItem!=null) 
            {
                Lijek_id = int.Parse(lijekoviComboBox.SelectedValue.ToString());
                Poslovnica_id = int.Parse(poslovniceComboBox.SelectedValue.ToString());
                this.dostupnostTableAdapter.FillById(this._17003_DBDataSet.Dostupnost, Lijek_id, Poslovnica_id);
                this.PregledLijekovaTableAdapter.FillById(this._17003_DBDataSet.PregledLijekova, Lijek_id, Poslovnica_id);
                OsvjeziPrikaz();
            }
        }
        private void OsvjeziPrikaz()
        {
            this.reportViewer1.RefreshReport();
        }
        private void CrtajGraf()
        {
            Series podaciGraf = new Series();
            grafStatistika.DataSource = PregledLijekovaBindingSource;
            grafStatistika.DataBind();
        }
    }
}