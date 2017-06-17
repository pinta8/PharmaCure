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
            foreach (Stanje s in st)
            {
                cmbStanje.DisplayMember = "Text";
                cmbStanje.ValueMember = "Value";
                cmbStanje.Items.Add(new {Text = s.naziv, Value = s.id });
            }
            foreach (Lijek u in li)
            {
                cmbLijek.DisplayMember = "Text";
                cmbLijek.ValueMember = "Value";
                cmbLijek.Items.Add(new { Text = u.Naziv, Value = u.ID });
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtKolicina.Text) > 0)
            {
                int kolicina = int.Parse(txtKolicina.Text);
                int id = cmbLijek.SelectedIndex;
                int idR = 1;
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
            ArtikliRacun.DostavljenRacun(int.Parse(txtKorisnik.Text));
            MessageBox.Show("Lijekovi su uspješno dostavljeni!");
            OsvjeziListu();
        }
        private void OsvjeziListu()
        {
            rec = LijekoviRecept.DohvatiRecepte(korisnik);
            dgvRecepti.DataSource = rec;
            l = ArtikliRacun.DohvatiSveArtikleKorisnika(korisnik);
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
        }

        private void btnRacun_Click(object sender, EventArgs e)
        {
            Racun noviRacun = new Racun();
            noviRacun.vrijeme = DateTime.Now;
            noviRacun.djelatnik = djela;
            noviRacun.klijent = int.Parse(txtKorisnik.Text);
            noviRacun.stanje = int.Parse(cmbStanje.SelectedValue.ToString());
            Racun.DodajRacun(noviRacun);
        }

        private void btnJedan_Click(object sender, EventArgs e)
        {
            int idLijekR = int.Parse(dgvRecepti.CurrentRow.Cells[0].Value.ToString());
            int kolicina = int.Parse(dgvRecepti.CurrentRow.Cells[3].Value.ToString());
            int participacije = int.Parse(dgvRecepti.CurrentRow.Cells[4].Value.ToString());
            int idR = 1;
            ArtikliRacun.DodajArtiklRecept(idLijekR, idR, kolicina, participacije);
            OsvjeziListu();
        }

        private void btnSve_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvRecepti.Rows)
            {
                int idLijekR = int.Parse(row.Cells[0].Value.ToString());
                int kolicina = int.Parse(row.Cells[3].Value.ToString());
                int participacije = int.Parse(row.Cells[4].Value.ToString());
                int idR = 1;
                ArtikliRacun.DodajArtiklRecept(idLijekR, idR, kolicina, participacije);
            }
            OsvjeziListu();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int idA = int.Parse(dgvArtikli.CurrentRow.Cells[0].Value.ToString());
            ArtikliRacun.IzbrisiArtikl(idA);
            OsvjeziListu();
        }
    }
}
