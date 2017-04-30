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
	public partial class FrmDodajPoslovnicu : Form {
		public FrmDodajPoslovnicu() {
			InitializeComponent();
		}

        //Upisivanje Nove Poslovnice u Bazu
		private void btnDodaj_Click(object sender, EventArgs e) {
			Poslovnica p = new Poslovnica();
			p.Naziv = tbxNaziv.Text;
			p.Drzava = tbxDrzava.Text;
			p.Grad = tbxGrad.Text;
			p.Ulica = tbxUlica.Text;
			p.Broj = int.Parse(tbxBroj.Text);

			Poslovnica.ZapisiPoslovnicu(p);
		}
        //Povratak na glavnu formu
        private void btnPovratak_Click(object sender, EventArgs e) {
            FrmMain m = new FrmMain();
            m.Show();
            this.Close();
        }
    }
}
