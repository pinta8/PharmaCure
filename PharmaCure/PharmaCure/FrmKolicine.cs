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
        }
        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FrmMain m = new FrmMain();
            m.Show();
            this.Close();
        }
        private void FrmKolicine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_17003_DBDataSet.PregledLijekova' table. You can move, or remove it, as needed.
            this.PregledLijekovaTableAdapter.Fill(this._17003_DBDataSet.PregledLijekova);
            // TODO: This line of code loads data into the '_17003_DBDataSet.Lijekovi' table. You can move, or remove it, as needed.
            this.lijekoviTableAdapter.Fill(this._17003_DBDataSet.Lijekovi);
            // TODO: This line of code loads data into the '_17003_DBDataSet.Dostupnost' table. You can move, or remove it, as needed.
            this.dostupnostTableAdapter.Fill(this._17003_DBDataSet.Dostupnost);
            // TODO: This line of code loads data into the '_17003_DBDataSet.Poslovnica' table. You can move, or remove it, as needed.
            this.poslovnicaTableAdapter.Fill(this._17003_DBDataSet.Poslovnica);
            this.reportViewer1.RefreshReport();
        }

        private void lijekoviComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lijekoviComboBox.SelectedItem !=null) { 
                Lijek_id = int.Parse(lijekoviComboBox.SelectedValue.ToString());
                Poslovnica_id = int.Parse(poslovniceComboBox.SelectedValue.ToString());
                this.dostupnostTableAdapter.FillById(this._17003_DBDataSet.Dostupnost, Lijek_id, Poslovnica_id);
                this.PregledLijekovaTableAdapter.FillById(this._17003_DBDataSet.PregledLijekova, Lijek_id, Poslovnica_id);
                this.reportViewer1.RefreshReport();
            }
        }
        private void poslovniceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (poslovniceComboBox.SelectedItem != null)
            {
                Lijek_id = int.Parse(lijekoviComboBox.SelectedValue.ToString());
                Poslovnica_id = int.Parse(poslovniceComboBox.SelectedValue.ToString());
                this.dostupnostTableAdapter.FillById(this._17003_DBDataSet.Dostupnost, Lijek_id, Poslovnica_id);
                this.PregledLijekovaTableAdapter.FillById(this._17003_DBDataSet.PregledLijekova, Lijek_id, Poslovnica_id);
                this.reportViewer1.RefreshReport();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void izlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double[] xData = new double[] { 1, 2, 3, 4, 5 };
            double[] yData = new double[] { 6, 7, 3, 4, 5 };
            //Vertical bar chart
            //create another area and add it to the chart
            ChartArea area2 = new ChartArea("Second");
            chart1.ChartAreas.Add(area2);
            //Create the series using just the y data
            Series barSeries2 = new Series();
            barSeries2.Points.DataBindY(yData);
            //Set the chart type, column; vertical bars
            barSeries2.ChartType = SeriesChartType.Column;
            barSeries2.ChartArea = "Second";
            //Add the series to the chart
            chart1.Series.Add(barSeries2);
        }
    }
}
