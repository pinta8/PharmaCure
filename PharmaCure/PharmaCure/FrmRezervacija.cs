using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaCure
{
    public partial class FrmRezervacija : Form
    {
        public int IDRezervacija { get; set; }
        public string ImePrezimeKlijenta { get; set; }
        public FrmRezervacija()
        {
            InitializeComponent();
        }
        private void FrmRezervacija_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_17003_DBDataSet.PregledRezervacija' table. You can move, or remove it, as needed.
            this.pregledRezervacijaTableAdapter.Fill(this._17003_DBDataSet.PregledRezervacija);
            this.pregledRezervacija_LijekoviTableAdapter.Fill(this._17003_DBDataSet.PregledRezervacija_Lijekovi);
            PopuniPodatke();
        }
        private void PopuniPodatke()
        {
            IDRezervacija=int.Parse(rezervacijaTableAdapter.VratizadnjiID().ToString());
            iD__rezervacijeTextBox.Text = IDRezervacija.ToString();
            imePrezimeTextBox.Text = pregledRezervacijaTableAdapter.SelectVratiNaziv(IDRezervacija);
        }
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FrmRezervacijaPopis frmRezervacijaPopis = new FrmRezervacijaPopis();
            frmRezervacijaPopis.Show();
            this.Close();
        }
        private void btnOdaberiKlijenta_Click(object sender, EventArgs e)
        {
            FrmRezervacijaKlijent frmRezervacijaKlijent = new FrmRezervacijaKlijent();
            frmRezervacijaKlijent.Show();
            this.Close();
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmRezervacijaDodavanjeLijekova frmRezervacijaDodavanjeLijekova = new FrmRezervacijaDodavanjeLijekova();
            frmRezervacijaDodavanjeLijekova.Show();
            this.Close();
        }
        private void btnPromijeni_Click(object sender, EventArgs e)
        {

        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int idRezervacija = int.Parse(pregledRezervacija_LijekoviDataGridView.CurrentRow.Cells[0].ToString());
            rezervacijaTableAdapter.DeleteQuery(idRezervacija);
        }  
    }
}
