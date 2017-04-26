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
    public partial class FrmDodajZaposlenika : Form
    {
        public FrmDodajZaposlenika()
        {
            InitializeComponent();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FrmMain m = new FrmMain();
            m.Show();
            this.Close();
        }

		private void btnDodaj_Click(object sender, EventArgs e) {
			Poslovnica p = (Poslovnica)cbxPoslovnice.SelectedItem;
			Zaposlenik z = new Zaposlenik();
			z.KorisnickoIme = tbxKorisnickoIme.Text;
			z.Lozinka = tbxLozinka.Text;
			z.PoslovnicaId = p.PoslovnicaId;
			
			Zaposlenik.ZapisiZaposlenika(z);
 		}
	}
}
