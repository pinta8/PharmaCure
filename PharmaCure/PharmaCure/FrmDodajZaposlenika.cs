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

namespace PharmaCure
{
    public partial class FrmDodajZaposlenika : Form {
		private List<Zaposlenik> zaposlenici = new List<Zaposlenik>();
		private List<Poslovnica> poslovnice;

		public FrmDodajZaposlenika()
        {
            InitializeComponent();
            PostaviComboBox();
            OsvjeziZaposlenike();
			dgvZaposlenici.Columns[2].Visible = false;
			dgvZaposlenici.Columns[3].Visible = false;

		}
        //Postavlja izvor podataka za combobox
        public void PostaviComboBox() {
            cbxPoslovnice.DataSource = poslovnice = Poslovnica.DohvatiPoslovniceZaComboBox();
            cbxPoslovnice.ValueMember = "PoslovnicaId";
            cbxPoslovnice.DisplayMember = "Naziv";
        }
        //Postavlja izvor podataka za datagrid
        public void OsvjeziZaposlenike() {
            zaposlenici = Zaposlenik.VratiSveZaposlenike();
            dgvZaposlenici.DataSource = zaposlenici;
        }
        //Gumb za povratak na Main formu
        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FrmMain m = new FrmMain();
            m.Show();
            this.Close();
        }
        //Gumb za dodavanje novog Zaposlenika za neku poslovnicu
		private void btnDodaj_Click(object sender, EventArgs e) {
			
            if (tbxKorisnickoIme.Text == "" || tbxLozinka.Text == "") {
                MessageBox.Show("Unesite sve podatke!");
            }
            else {
                Poslovnica p = (Poslovnica)cbxPoslovnice.SelectedItem;
                Zaposlenik z = new Zaposlenik();
                z.KorisnickoIme = tbxKorisnickoIme.Text;
                z.Lozinka = tbxLozinka.Text;
                z.PoslovnicaId = p.PoslovnicaId;
                Zaposlenik.ZapisiZaposlenika(z);
                zaposlenici = Zaposlenik.VratiSveZaposlenike();
                dgvZaposlenici.DataSource = zaposlenici;
            }
		}
        //Gumb za brisanje Zaposlenika iz baze
		private void btnIzbrisi_Click(object sender, EventArgs e) {
			Zaposlenik.IzbrisiZaposlenikaIzBaze(zaposlenici[dgvZaposlenici.SelectedRows[0].Index]);
            OsvjeziZaposlenike();
		}
        //Gumb za ažuriranje Zaposlenika u bazi
		private void btnAzuriraj_Click(object sender, EventArgs e) {
			FrmAzurirajZaposlenika az = new FrmAzurirajZaposlenika(zaposlenici[dgvZaposlenici.SelectedRows[0].Index], poslovnice);
			az.ShowDialog();
            OsvjeziZaposlenike();
		}
		

	}
}
