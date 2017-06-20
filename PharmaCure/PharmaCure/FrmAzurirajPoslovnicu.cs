using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaCure {
    public partial class FrmAzurirajPoslovnicu : Form {
        Poslovnica p;
        public FrmAzurirajPoslovnicu(Poslovnica posl) {
            InitializeComponent();
            p = posl;
            PostaviVrijednosti();
        }
        public FrmAzurirajPoslovnicu() {
            InitializeComponent();
            
        }
        //postavljamo stare vrijednosti u textboxove
        private void PostaviVrijednosti() {
            tbxNaziv.Text = p.Naziv;
            tbxDrzava.Text = p.Drzava;
            tbxGrad.Text = p.Grad;
            tbxUlica.Text = p.Ulica;
            tbxBroj.Text = p.Broj.ToString();
            
        }
        //ako je sve u redu ( nemamo praznih textboxova) ažuriramo podatke poslovnice ili dodajemo novi zapis
        private void btnSpremiPromjene_Click(object sender, EventArgs e) {
            if (tbxNaziv.Text == "" || tbxDrzava.Text == "" || tbxGrad.Text == "" || tbxUlica.Text == "" || tbxBroj.Text == "") {
                MessageBox.Show("Niste unijeli sve podatke!");
                return;
            }
            if (p == null) {
                p = new Poslovnica();
                PostaviPodatke(p);
                Poslovnica.ZapisiPoslovnicu(p);
                this.Close();

            }
            else {
                PostaviPodatke(p);
                Poslovnica.AzurirajPoslovnicu(p);
                this.Close();
            }
        }

        private void PostaviPodatke(Poslovnica p) {
            p.Naziv = tbxNaziv.Text;
            p.Drzava = tbxDrzava.Text;
            p.Grad = tbxGrad.Text;
            p.Ulica = tbxUlica.Text;
            p.Broj = int.Parse(tbxBroj.Text);
        }
    }
}
