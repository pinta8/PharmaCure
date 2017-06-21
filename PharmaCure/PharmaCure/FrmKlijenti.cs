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
    public partial class FrmKlijenti : Form
    {
        public List<Klijent> kl = new List<Klijent>();
        public FrmKlijenti()
        {
            InitializeComponent();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FrmMain m = new FrmMain();
            m.Show();
            this.Close();
        }
        private void OsvjeziListu()
        {
            kl = Klijent.DohvatiSveKlijente();
            dgvKlijenti.DataSource = kl;
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
    }
}
