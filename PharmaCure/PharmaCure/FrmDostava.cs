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
        public List<Stanje> st = new List<Stanje>();
        public List<Lijek> li = new List<Lijek>();
        public List<LijekoviRecept> rec = new List<LijekoviRecept>();
        public int idR = 0;
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
            st = Stanje.DohvatiStanja();
            li = Lijek.DohvatiSveLijekove();
            cmbStanje.DisplayMember = "naziv";
            cmbStanje.ValueMember = "id";
            cmbStanje.DataSource = st;
            cmbLijek.DisplayMember = "Naziv";
            cmbLijek.ValueMember = "ID";
            cmbLijek.DataSource = li;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtKolicina.Text) > 0)
            {
                int kolicina = int.Parse(txtKolicina.Text);
                int id = int.Parse(cmbLijek.SelectedValue.ToString());
                bool dobro = true;
                foreach (ArtikliRacun al in l)
                {
                    if (al.Naziv == cmbLijek.Text)
                    {
                        dobro = false;
                        MessageBox.Show("Odabrani Lijek već postoji!");
                    }
                }
                if (dobro)
                {
                    ArtikliRacun.DodajArtikl(id, kolicina, idR);
                    OsvjeziListu();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArtikliRacun.DostavljenRacun(int.Parse(txtKorisnik.Text), 2);
            MessageBox.Show("Lijekovi su uspješno dostavljeni!");
            OsvjeziListu();
        }
        private void OsvjeziListu()
        {
            rec = LijekoviRecept.DohvatiRecepte(korisnik);
            dgvRecepti.DataSource = rec;
            l = ArtikliRacun.DohvatiSveArtikleKorisnika(korisnik, 2);
            dgvArtikli.DataSource = l;
            double cij = 0;
            foreach (ArtikliRacun o in l)
            {
                double broj = double.Parse(o.participacija.ToString()) / 100;
                cij += (o.cijena * o.kolicina) * broj;
            }
            txtCijena.Text = cij.ToString() + " kn";
        }

        private void txtKorisnik_TextChanged(object sender, EventArgs e)
        {
            bool dane = Int32.TryParse((txtKorisnik.Text), out korisnik);
            if (dane)
            {
                OsvjeziListu();
            }
            if (txtKorisnik.Text != "")
            {
                idR = Racun.NadjiRacun(int.Parse(txtKorisnik.Text), 2).IDRacun;
            }
        }

        private void btnRacun_Click(object sender, EventArgs e)
        {
            if (txtKorisnik.Text != "")
            {
                Racun noviRacun = new Racun();
                noviRacun.vrijeme = DateTime.Now;
                noviRacun.djelatnik = djela;
                noviRacun.klijent = int.Parse(txtKorisnik.Text);
                noviRacun.stanje = int.Parse(cmbStanje.SelectedValue.ToString());
                Racun.DodajRacun(noviRacun);
            }
            else MessageBox.Show("Morate unijeti šifru klijenta!");
        }

        private void btnJedan_Click(object sender, EventArgs e)
        {
            int idLijekR = int.Parse(dgvRecepti.CurrentRow.Cells[0].Value.ToString());
            int kolicina = int.Parse(dgvRecepti.CurrentRow.Cells[3].Value.ToString());
            int participacije = int.Parse(dgvRecepti.CurrentRow.Cells[4].Value.ToString());
            ArtikliRacun.DodajArtiklRecept(idLijekR, idR, kolicina, participacije);
            LijekoviRecept.IzbrisiRecept(idLijekR, int.Parse(dgvRecepti.CurrentRow.Cells[2].Value.ToString()));
            OsvjeziListu();
        }

        private void btnSve_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvRecepti.Rows)
            {
                int idLijekR = int.Parse(row.Cells[0].Value.ToString());
                int kolicina = int.Parse(row.Cells[3].Value.ToString());
                int participacije = int.Parse(row.Cells[4].Value.ToString());
                ArtikliRacun.DodajArtiklRecept(idLijekR, idR, kolicina, participacije);
                LijekoviRecept.IzbrisiRecept(idLijekR, int.Parse(dgvRecepti.CurrentRow.Cells[2].Value.ToString()));
            }
            OsvjeziListu();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int idA = int.Parse(dgvArtikli.CurrentRow.Cells[0].Value.ToString());
            ArtikliRacun.IzbrisiArtikl(idA, idR);
            OsvjeziListu();
        }
    }
}
