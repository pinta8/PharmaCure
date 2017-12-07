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
    public partial class FrmRezervacijaKlijent : Form
    {
        public FrmRezervacijaKlijent()
        {
            InitializeComponent();
        }
        private void FrmRezervacijaKlijent_Load(object sender, EventArgs e)
        {
            this.rezervacijaTableAdapter.Fill(this._17003_DBDataSet.Rezervacija);
            this.pregledKlijenataTableAdapter.Fill(this._17003_DBDataSet.PregledKlijenata);
            this.klijentTableAdapter.Fill(this._17003_DBDataSet.Klijent);
            comboBoxPretraga.SelectedIndex = 0;
        }
        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FrmRezervacijaPopis frmRezervacijaPopis = new FrmRezervacijaPopis();
            frmRezervacijaPopis.Show();
            this.Close();
        }
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            if (comboBoxPretraga.SelectedIndex == 0)
            {
                this.pregledKlijenataTableAdapter.SelectById(this._17003_DBDataSet.PregledKlijenata, int.Parse(txtBoxPretrazi.Text));
            }
            else
            {
                this.pregledKlijenataTableAdapter.SelectByImePrezime(this._17003_DBDataSet.PregledKlijenata, txtBoxPretrazi.Text);
            }

        }
        private void btnDodajKlijenta_Click(object sender, EventArgs e)
        {
            int idRezervacija = int.Parse(rezervacijaTableAdapter.VratizadnjiID().ToString()) ;
            int idKlijent= int.Parse(pregledKlijenataDataGridView.CurrentRow.Cells[0].Value.ToString());
            rezervacijaTableAdapter.DodajKlijenta(idKlijent,idRezervacija);
            FrmRezervacija frmRezervacija = new FrmRezervacija();
            frmRezervacija.Show();
            this.Close();
        }
    }
}
