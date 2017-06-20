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
	public partial class FrmPoslovnice : Form {
        private List<Poslovnica> poslovnice = new List<Poslovnica>();
        public FrmPoslovnice() {
			InitializeComponent();
            OsvjeziPoslovnice();
            
        }

        //Upisivanje Nove Poslovnice u Bazu
		private void btnDodaj_Click(object sender, EventArgs e) {
            FrmAzurirajPoslovnicu az = new FrmAzurirajPoslovnicu();
            az.ShowDialog();
            OsvjeziPoslovnice();
        }
        //Povratak na glavnu formu
        private void btnPovratak_Click(object sender, EventArgs e) {
            FrmMain m = new FrmMain();
            m.Show();
            this.Close();
        }
        public void OsvjeziPoslovnice() {
            poslovnice = Poslovnica.DohvatiPoslovnice();
            dgvPoslovnice.DataSource = poslovnice;
        }
        private void btnAzuriraj_Click(object sender, EventArgs e) {
           FrmAzurirajPoslovnicu az = new FrmAzurirajPoslovnicu(poslovnice[dgvPoslovnice.SelectedRows[0].Index]);
           az.ShowDialog();
           OsvjeziPoslovnice();  
        }

        private void btnIzbrisi_Click(object sender, EventArgs e) {
            Poslovnica.IzbrisiPoslovnicuIzBaze(poslovnice[dgvPoslovnice.SelectedRows[0].Index]);
            OsvjeziPoslovnice();
        }
    }
}
