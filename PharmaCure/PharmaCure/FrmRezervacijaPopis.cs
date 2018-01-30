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
    public partial class FrmRezervacijaPopis : Form
    {
        public int IDRezervacija { get; set; }
        public FrmRezervacijaPopis()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        private void FrmPopisRezervacija_Load(object sender, EventArgs e)
        {
            comboBoxPretraga.SelectedIndex = 0;
            OsvjeziPrikaz();
        }
        /// <summary>
        /// Metoda za osvježivanje prikaza u dgv-u.
        /// </summary>
        private void OsvjeziPrikaz()
        {
            this.pregledRezervacijaTableAdapter.SelectByStanje(this._17003_DBDataSet.PregledRezervacija);
            pregledRezervacijaDataGridView.Columns[3].Visible = false;
        }
        /// <summary>
        /// Metoda za povratak u prijašnju formu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Close();
        }
        /// <summary>
        /// Metoda za izlaz iz programa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Dodavanje nove rezervacije u bazu podataka.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            rezervacijaTableAdapter.InsertNovaRezervacija(DateTime.Now, true);
            FrmRezervacija frmRezervacijaNova = new FrmRezervacija();
            frmRezervacijaNova.Show();
            this.Close();
        }
        /// <summary>
        /// Metoda za izmjenu podataka o određenoj rezervaciji.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzmijeniPodatke_Click(object sender, EventArgs e)
        {
            FrmRezervacija odabranaRezervacija = new FrmRezervacija();
            odabranaRezervacija.IDRezervacija = int.Parse(pregledRezervacijaDataGridView.CurrentRow.Cells[0].Value.ToString());
            odabranaRezervacija.ImePrezimeKlijenta = pregledRezervacijaDataGridView.CurrentRow.Cells[1].Value.ToString();
            odabranaRezervacija.NacinRada = 1;
            odabranaRezervacija.Show();
            this.Close();
        }
        /// <summary>
        /// Metoda za arhiviranje određene rezervacije.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPromijeni_Click(object sender, EventArgs e)
        {
            IDRezervacija =int.Parse(pregledRezervacijaDataGridView.CurrentRow.Cells[0].Value.ToString());
            bool stanje = bool.Parse(pregledRezervacijaDataGridView.CurrentRow.Cells[3].Value.ToString());
            bool stanjeUnos = true; 
            if (stanje)
            {
                stanjeUnos = false;
            }
            this.rezervacijaTableAdapter.UpdateStanje(stanjeUnos, IDRezervacija, IDRezervacija);
            OsvjeziPrikaz();
        }
        /// <summary>
        /// Pretraživanje rezervacija po ID-u ili imenu i prezimenu klijenta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            if (txtBoxPretrazi.Text =="")
            {
                MessageBox.Show("Nikakva vrijednost nije upisana!");
                pregledRezervacijaTableAdapter.SelectByStanje(this._17003_DBDataSet.PregledRezervacija);
            }
            else
            {
                if (comboBoxPretraga.SelectedIndex == 0)
                {
                    try
                    {
                        IDRezervacija = int.Parse(txtBoxPretrazi.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Upisana vrijednost mora biti broj!");
                        pregledRezervacijaTableAdapter.SelectByStanje(this._17003_DBDataSet.PregledRezervacija);
                    }
                    pregledRezervacijaTableAdapter.SelectPretraziIByIDRezervacije(this._17003_DBDataSet.PregledRezervacija, IDRezervacija);
                    pregledRezervacijaDataGridView.Columns[3].Visible = true;
                }
                else
                {
                    pregledRezervacijaTableAdapter.SelectPretraziByNaziv(this._17003_DBDataSet.PregledRezervacija, txtBoxPretrazi.Text);
                    pregledRezervacijaDataGridView.Columns[3].Visible = true;
                }
            }
        }
        public int TestStanje()
        {
            return int.Parse(pregledRezervacijaTableAdapter.SelectCountStanje().ToString());
        }

        private void FrmRezervacijaPopis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r17003/wiki/Korisnička-dokumentacija#211-rezervacija-lijeka");
            }
        }
    }
}
