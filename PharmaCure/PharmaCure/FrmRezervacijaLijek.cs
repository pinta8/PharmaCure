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
    public partial class FrmRezervacijaLijek : Form
    {
        public FrmRezervacijaLijek()
        {
            InitializeComponent();
        }
        private void FrmRezervacijaLijek_Load(object sender, EventArgs e)
        {
            this.lijekoviTableAdapter.Fill(this._17003_DBDataSet.Lijekovi);
        }
        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FrmRezervacija frmRezervacija = new FrmRezervacija();
            frmRezervacija.Show();
            this.Close();
        }
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            int RezervacijaID = int.Parse(rezervacijaTableAdapter1.VratizadnjiID().ToString());
            try
            {
                popisTableAdapter.UpdateQueryLijek(int.Parse(comboBoxNaziv.SelectedValue.ToString()), int.Parse(textBoxKolicina.Text), RezervacijaID);
                FrmRezervacija frmRezervacija = new FrmRezervacija();
                frmRezervacija.Show();
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Provjerite da li je količina unešena te da li je unešena brojka!");
            }
        }
    }
}
