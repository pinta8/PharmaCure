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
	public partial class FrmAzurirajZaposlenika : Form {
		private List<Poslovnica> poslovnice;
        //postavlja se datasource comboboxu i postavljalju se postojeće vrijednosti u kontrole za unos
		public FrmAzurirajZaposlenika(Zaposlenik zaposlenik, List<Poslovnica> pos) {
			InitializeComponent();
			z = zaposlenik;
			this.poslovnice = pos;
			cbxPoslovnice.DataSource = poslovnice;
			cbxPoslovnice.ValueMember = "PoslovnicaId";
			cbxPoslovnice.DisplayMember = "Naziv";
			PostaviVrijednosti();
		}
        public FrmAzurirajZaposlenika() {
            InitializeComponent();
            PostaviComboBox();
        }
        //postavljamo izvor podataka za combobox
        public void PostaviComboBox() {
            cbxPoslovnice.DataSource = poslovnice = Poslovnica.DohvatiPoslovniceZaComboBox();
            cbxPoslovnice.ValueMember = "PoslovnicaId";
            cbxPoslovnice.DisplayMember = "Naziv";
        }
        //ako se radi o ažuriranju, prvo trebamo ispuniti textboxove sa podacima koje želimo promijeniti
        private void PostaviVrijednosti() {
			tbxKorisnickoIme.Text = z.KorisnickoIme;
			tbxLozinka.Text = z.Lozinka;
			for(int i=0; i<poslovnice.Count; i++) {
				if(poslovnice[i].PoslovnicaId == z.PoslovnicaId) {
					cbxPoslovnice.SelectedIndex = i;
					break;
				}
			}
		}

		Zaposlenik z;
        //na klik se ažurira ili dodaje korisnik i forma se zatvara
		private void btnSpremi_Click(object sender, EventArgs e) {
            if (tbxKorisnickoIme.Text == "" || tbxLozinka.Text == "") {
                MessageBox.Show("Unesite sve podatke!");
                return;
            }
            if (z == null) {
                z = new Zaposlenik();
                PostaviPodatke(z);
                Zaposlenik.ZapisiZaposlenika(z);
                this.Close();
            }
            else {
                PostaviPodatke(z);
                Zaposlenik.AzurirajZaposlenika(z);
                this.Close();
            }
		}
        //postavljamo podatke objektu klase Zaposlenik
        public void PostaviPodatke(Zaposlenik z) {
            z.KorisnickoIme = tbxKorisnickoIme.Text;
            z.Lozinka = tbxLozinka.Text;
            z.PoslovnicaId = ((Poslovnica)cbxPoslovnice.SelectedItem).PoslovnicaId;
            z.NazivPoslovnice = ((Poslovnica)cbxPoslovnice.SelectedItem).Naziv;
        }
	}
}
