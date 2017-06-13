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
    public partial class FrmNabava : Form {
        
        public FrmNabava() {
            InitializeComponent();
            PripremiCombo();
            tbxPoslovnciaId.Text = Zaposlenik.PoslovnicaPrijavljenog.ToString();
            tbxPoslovnciaId.Enabled = false;
        }
        public void PripremiCombo() {
            cbxNaziv.DataSource = Lijek.VratiNaziveLijekova();
        }

        private void btnPosaljiNarudzbu_Click(object sender, EventArgs e) {
            Narudzba nar = new Narudzba();
            nar.DjelatnikId = Zaposlenik.IdPrijavljenog;
            nar.PoslovnicaId = Zaposlenik.PoslovnicaPrijavljenog;
            nar.NazivLijeka = (string)cbxNaziv.SelectedItem;
            nar.Kolicina = int.Parse(tbxKolicina.Text);
            Narudzba.ZapisiNarudzbu(nar);
            this.Close();
        }

        
    }
}
