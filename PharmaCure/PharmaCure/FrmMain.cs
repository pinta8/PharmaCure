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
    public partial class FrmMain : Form
    {
        public int djelatnik = Zaposlenik.ZapID;
        public int ulogaDjelatnika = Zaposlenik.TipPrijavljenog;
        public FrmMain()
        {
            InitializeComponent();
            this.KeyPreview = true;
            if (ulogaDjelatnika == 2) {
                btnDodajPoslovnicu.Hide();
                btnZaposlenici.Hide();
                lblTip.Text = "Prijavljeni ste kao ljekarnik";
                PomakniGumbe();
            }
            else lblTip.Text = "Prijavljeni ste kao administrator";
            NamjestiSlike();
            
        }
        //Log-out (povratak na formu login)
        private void btnIzlaz_Click_1(object sender, EventArgs e)
        {
            FrmLogin l = new FrmLogin();
            l.Show();
            this.Close();
            
        }
        //Gumb za odlazak na formu Zaposlenici
        private void btnZaposlenici_Click(object sender, EventArgs e)
        {
            FrmDodajZaposlenika z = new FrmDodajZaposlenika();
            z.Show();
            this.Close();
        }
        //Gumb za odlazak na formu Popisa Lijekova
        private void btnPopisL_Click(object sender, EventArgs e)
        {
            FrmPopisLijekova popis = new FrmPopisLijekova();
            popis.Show();
            this.Close();
        }
        //Gumb za odlazak na formu Količine lijekova
        private void btnKolicina_Click(object sender, EventArgs e)
        {
            FrmKolicine kol = new FrmKolicine();
            kol.Show();
            this.Close();
        }
        //Gumb za odlazak na formu Nabave
        private void btnNabava_Click(object sender, EventArgs e)
        {
            FrmStanje nab = new FrmStanje();
            nab.Show();
            this.Close();
        }
        //Gumb za odlazak na formu Dostave
        private void btnDostava_Click(object sender, EventArgs e)
        {
            FrmDostava dostava = new FrmDostava();
            dostava.Show();
            this.Close();
        }
        //Gumb za odlazak na formu Prodaje
        private void btnProdaja_Click(object sender, EventArgs e)
        {
            FrmProdaja prodaja = new FrmProdaja();
            prodaja.Show();
            this.Close();
        }
        //Gumb za odlazak na formu za dodavanje Recepta
        private void btnRecepti_Click(object sender, EventArgs e)
        {
            FrmRecepti recepti = new FrmRecepti();
            recepti.Show();
            this.Close();
        }
        //Gumb za odlazak na formu Dodavanje Poslovnice
        private void btnDodajPoslovnicu_Click(object sender, EventArgs e) {
			FrmDodajPoslovnicu posl = new FrmDodajPoslovnicu();
			posl.Show();
			this.Close();
		}
        //Akcija za prikazivanje Help-a na pritisak tipke "F1"
        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.F1)
            {
                FrmHelp h = new FrmHelp();
                h.Show();
            }
        }
        private void PomakniGumbe() {
            btnRecepti.Location = new Point(btnZaposlenici.Location.X , btnZaposlenici.Location.Y);
            this.Size = new Size(this.Size.Width,this.Size.Height - 40);
            lblTip.Location = new Point(btnDodajPoslovnicu.Location.X, lblTip.Location.Y-40);
        }
        private void NamjestiSlike() {
           
        }
    }
}
