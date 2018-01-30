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
            this.KeyPreview = true;
        } 
        /// <summary>
        /// Forma radi na 2 načina, ukoliko je NacinRada==1 tada to znači da smo u prijašnjoj formi odabrali neku postojeću rezervaciju 
        /// te nam se podaci pune prema toj postojećoj rezervaciji.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Spremanje promjena te otvaranje prijašnje forme za odabir rezervacija.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Metoda za otvaranje forme za odabir klijenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdaberiKlijenta_Click(object sender, EventArgs e)
        {
            FrmRezervacijaKlijent frmRezervacijaKlijent = new FrmRezervacijaKlijent();
            frmRezervacijaKlijent.IDRezervacija = int.Parse(iD__rezervacijeTextBox.Text);
            frmRezervacijaKlijent.Show();
            this.Close();
        }
        /// <summary>
        /// Otvaranje forme za dodavanje lijeka za određenu rezervaciju.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmRezervacijaLijek frmRezervacijaLijek = new FrmRezervacijaLijek();
            frmRezervacijaLijek.IDRezervacija= int.Parse(iD__rezervacijeTextBox.Text);
            frmRezervacijaLijek.Show();
            this.Close();
        }
        /// <summary>
        /// Metoda za brisanje lijeka iz rezervacije.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int brojRedova = pregledRezervacija_LijekoviDataGridView.RowCount;
            if (brojRedova > 1)
            {
                IDRezervacija = int.Parse(iD__rezervacijeTextBox.Text);
                IDLijek = int.Parse(pregledRezervacija_LijekoviDataGridView.CurrentRow.Cells[2].Value.ToString());
                ObrisiLijek(IDLijek, IDRezervacija);
                this.pregledRezervacija_LijekoviTableAdapter.FillByRezervacijaID(this._17003_DBDataSet.PregledRezervacija_Lijekovi, IDRezervacija);
            }
        }
        /// <summary>
        /// Brisanje lijeka iz određene rezervacije.
        /// </summary>
        /// <param name="IDLijek"></param>
        /// <param name="IDRezervacija"></param>
       public void ObrisiLijek(int IDLijek, int IDRezervacija)
        {
            popisTableAdapter1.DeleteQueryLijek(IDLijek, IDRezervacija);
        }

        private void FrmRezervacija_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r17003/wiki/Korisnička-dokumentacija#2112-odre%C4%91ena-rezervacija");
            }
        }
    }
}
