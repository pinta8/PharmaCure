using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;

namespace PharmaCure
{
    public partial class FrmKlijent : Form
    {
        public List<Klijent> kl = new List<Klijent>();
        public List<Osiguranje> os = new List<Osiguranje>();
        public FrmKlijent()
        {
            InitializeComponent();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FrmMain m = new FrmMain();
            m.Show();
            this.Close();
        }
        public void OsvjeziListu()
        {
            kl = Klijent.DohvatiSveKlijente();
            dgvKlijenti.DataSource = kl;
            os = Osiguranje.DohvatiOsiguranja();
            cmbOsiguranje.DisplayMember = "naziv";
            cmbOsiguranje.ValueMember = "idOsiguranje";
            cmbOsiguranje.DataSource = os;
        }
        private void FrmKlijenti_Load(object sender, EventArgs e)
        {
            OsvjeziListu();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            Klijent.DodajKlijenta(txtIme.Text, txtPrezime.Text, int.Parse(cmbOsiguranje.SelectedValue.ToString()));
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            Klijent.IzbrisiKlijenta(int.Parse(dgvKlijenti.CurrentRow.Cells[0].Value.ToString()));
        }

        private void dgvKlijenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmKlijent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r17003/wiki/Korisnička-dokumentacija#27-dodavanje-klijenta");
            }
        }
    }
}
