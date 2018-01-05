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
        CrtajGraf.FrmKolicine frmKolicine = new CrtajGraf.FrmKolicine();
        public int IDRezervacija { get; set; }
        public int IDLijek { get; set; }
        public int Kolicina { get; set; }
        public string ImePrezimeKlijenta { get; set; }
        public int NacinRada { get; set; }
        public FrmRezervacija()
        {
            InitializeComponent();
        } 
        private void FrmRezervacija_Load(object sender, EventArgs e)
        {
            if (NacinRada == 1)
            {
                iD__rezervacijeTextBox.Text = IDRezervacija.ToString();
                imePrezimeTextBox.Text = pregledRezervacijaTableAdapter.SelectVratiNaziv(IDRezervacija);
                this.pregledRezervacija_LijekoviTableAdapter.FillByRezervacijaID(this._17003_DBDataSet.PregledRezervacija_Lijekovi, IDRezervacija);
            }
            else
            {
                PopuniPodatke();
            }   
        }
        private void PopuniPodatke()
        {
            IDRezervacija = frmKolicine.VratiZadnjiID();
            this.pregledRezervacija_LijekoviTableAdapter.FillByRezervacijaID(this._17003_DBDataSet.PregledRezervacija_Lijekovi, IDRezervacija);
            iD__rezervacijeTextBox.Text = IDRezervacija.ToString();
            imePrezimeTextBox.Text = pregledRezervacijaTableAdapter.SelectVratiNaziv(IDRezervacija);
        }
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            FrmRezervacijaPopis frmRezervacijaPopis = new FrmRezervacijaPopis();
            frmRezervacijaPopis.Show();
            this.Close();
        }
        private void btnSpremiPromjene_Click(object sender, EventArgs e)
        {
            if (imePrezimeTextBox.Text !="")
            {
                FrmRezervacijaPopis frmRezervacijaPopis = new FrmRezervacijaPopis();
                frmRezervacijaPopis.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Niste odabrali klijenta!");
            }
        }
        private void btnOdaberiKlijenta_Click(object sender, EventArgs e)
        {
            FrmRezervacijaKlijent frmRezervacijaKlijent = new FrmRezervacijaKlijent();
            frmRezervacijaKlijent.IDRezervacija = int.Parse(iD__rezervacijeTextBox.Text);
            frmRezervacijaKlijent.Show();
            this.Close();
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmRezervacijaLijek frmRezervacijaLijek = new FrmRezervacijaLijek();
            frmRezervacijaLijek.IDRezervacija= int.Parse(iD__rezervacijeTextBox.Text);
            frmRezervacijaLijek.Show();
            this.Close();
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int brojRedova = pregledRezervacija_LijekoviDataGridView.RowCount;
            if (brojRedova > 1)
            {
                IDRezervacija = int.Parse(iD__rezervacijeTextBox.Text);
                IDLijek = int.Parse(pregledRezervacija_LijekoviDataGridView.CurrentRow.Cells[2].Value.ToString());
                popisTableAdapter1.DeleteQueryLijek(IDLijek, IDRezervacija);
                this.pregledRezervacija_LijekoviTableAdapter.FillByRezervacijaID(this._17003_DBDataSet.PregledRezervacija_Lijekovi, IDRezervacija);
            }
        }
       
    }
}
