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
        public List<ArtiklRacun> l = new List<ArtiklRacun>();
        public List<Stanje> st = new List<Stanje>();
        public List<Lijek> li = new List<Lijek>();
        public List<LijekRecept> rec = new List<LijekRecept>();
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
                foreach (ArtiklRacun al in l)
                {
                    if (al.Naziv == cmbLijek.Text)
                    {
                        dobro = false;
                        MessageBox.Show("Odabrani Lijek već postoji!");
                    }
                }
                if (dobro)
                {
                    ArtiklRacun.DodajArtikl(id, kolicina, idR);
                    OsvjeziListu();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ArtiklRacun.DostavljenRacun(int.Parse(txtKorisnik.Text), 2);
            MessageBox.Show("Lijekovi su uspješno dostavljeni!");
            OsvjeziListu();
        }
        private void OsvjeziListu()
        {
            rec = LijekRecept.DohvatiRecepte(korisnik);
            dgvRecepti.DataSource = rec;
            l = ArtiklRacun.DohvatiSveArtikleKorisnika(korisnik, 2);
            dgvArtikli.DataSource = l;
            double cij = 0;
            foreach (ArtiklRacun o in l)
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
            ArtiklRacun.DodajArtiklRecept(idLijekR, idR, kolicina, participacije);
            LijekRecept.IzbrisiRecept(idLijekR, int.Parse(dgvRecepti.CurrentRow.Cells[2].Value.ToString()));
            OsvjeziListu();
        }
        private void btnSve_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvRecepti.Rows)
            {
                int idLijekR = int.Parse(row.Cells[0].Value.ToString());
                int kolicina = int.Parse(row.Cells[3].Value.ToString());
                int participacije = int.Parse(row.Cells[4].Value.ToString());
                ArtiklRacun.DodajArtiklRecept(idLijekR, idR, kolicina, participacije);
                LijekRecept.IzbrisiRecept(idLijekR, int.Parse(dgvRecepti.CurrentRow.Cells[2].Value.ToString()));
            }
            OsvjeziListu();
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int idA = int.Parse(dgvArtikli.CurrentRow.Cells[0].Value.ToString());
            ArtiklRacun.IzbrisiArtikl(idA, idR);
            OsvjeziListu();
        }
        private void FrmDostava_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r17003/wiki/Korisni%C4%8Dka-dokumentacija#26-dostava-lijekova");
            }
        }
    }
}
