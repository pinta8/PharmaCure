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
        public int IDLijek { get; set; }
        public string ImePrezimeKlijenta { get; set; }
        public FrmRezervacija()
        {
            InitializeComponent();
        }
        private void FrmRezervacija_Load(object sender, EventArgs e)
        {
            PopuniPodatke();
        }
        private void PopuniPodatke()
        {
            IDRezervacija=int.Parse(rezervacijaTableAdapter.VratizadnjiID().ToString());
            this.pregledRezervacija_LijekoviTableAdapter.FillByRezervacijaID(this._17003_DBDataSet.PregledRezervacija_Lijekovi, IDRezervacija);
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
            int RezervacijaID = int.Parse(rezervacijaTableAdapter.VratizadnjiID().ToString());
            popisTableAdapter1.InsertQueryIDRezervacija(RezervacijaID, 1);
            FrmRezervacijaLijek frmRezervacijaLijek = new FrmRezervacijaLijek();
            frmRezervacijaLijek.Show();
            this.Close();
        }
        private void btnPromijeni_Click(object sender, EventArgs e)
        {
            int brojRedova = pregledRezervacija_LijekoviDataGridView.RowCount;
            if (brojRedova > 1)
            {
                FrmRezervacijaLijek odabraniLijek = new FrmRezervacijaLijek();
                odabraniLijek.NazivLijeka = pregledRezervacija_LijekoviDataGridView.CurrentRow.Cells[0].Value.ToString();
                odabraniLijek.Kolicina = int.Parse(pregledRezervacija_LijekoviDataGridView.CurrentRow.Cells[1].Value.ToString());
                odabraniLijek.IDLijek = int.Parse(pregledRezervacija_LijekoviDataGridView.CurrentRow.Cells[2].Value.ToString());
                odabraniLijek.NacinRada = 1;
                odabraniLijek.Show();
                this.Close();
            }
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            IDRezervacija = int.Parse(iD__rezervacijeTextBox.Text);
            IDLijek = int.Parse(pregledRezervacija_LijekoviDataGridView.CurrentRow.Cells[2].Value.ToString());
            popisTableAdapter1.DeleteQueryLijek(IDLijek, IDRezervacija);
            this.pregledRezervacija_LijekoviTableAdapter.FillByRezervacijaID(this._17003_DBDataSet.PregledRezervacija_Lijekovi, IDRezervacija);
        }  
    }
}
