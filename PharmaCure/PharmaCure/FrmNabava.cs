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
        public List<Lijek> lijekovi;
        public FrmNabava() {
            InitializeComponent();
            PripremiCombo();
            tbxPoslovnciaId.Text = Zaposlenik.PoslovnicaPrijavljenog.ToString();
            tbxPoslovnciaId.Enabled = false;
        }
        public void PripremiCombo() {
            lijekovi = Lijek.DohvatiSveLijekove();
            cbxNaziv.DataSource = lijekovi;
            cbxNaziv.ValueMember = "ID";
            cbxNaziv.DisplayMember = "Naziv";
        }

        private void btnPosaljiNarudzbu_Click(object sender, EventArgs e) {
            if (tbxKolicina.Text == "") {
                MessageBox.Show("Morate unijeti količinu");
            }
            else {
                Narudzba nar = new Narudzba();
                nar.DjelatnikId = Zaposlenik.IdPrijavljenog;
                nar.PoslovnicaId = Zaposlenik.PoslovnicaPrijavljenog;
           
                nar.Kolicina = int.Parse(tbxKolicina.Text);
                Lijek lijek = (Lijek)cbxNaziv.SelectedItem;
                nar.LijekId = lijek.ID;
                nar.NazivLijeka = lijek.Naziv;
                Narudzba.ZapisiNarudzbu(nar);
                MessageBox.Show("Uspješna narudžba");
                this.Close();
            }
        }

        
    }
}
