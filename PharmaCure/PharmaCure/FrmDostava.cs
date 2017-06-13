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
    public partial class FrmDostava : Form
    {
        public List<ArtikliRacun> l = new List<ArtikliRacun>();
        public FrmDostava()
        {
            InitializeComponent();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FrmMain m = new FrmMain();
            m.Show();
            this.Close();
        }
        public int korisnik;
        public int djela;
        private void FrmDostava_Load(object sender, EventArgs e)
        {
            FrmMain main = new FrmMain();
            djela = main.djelatnik;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void OsvjeziListu()
        {
            
            l = ArtikliRacun.DohvatiSveArtikleKorisnika(korisnik, djela);
            dgvArtikli.DataSource = l;
        }

        private void txtKorisnik_TextChanged(object sender, EventArgs e)
        {
            bool dane = Int32.TryParse((txtKorisnik.Text), out korisnik);
            if (dane)
            {
                OsvjeziListu();
            }
        }
    }
}
