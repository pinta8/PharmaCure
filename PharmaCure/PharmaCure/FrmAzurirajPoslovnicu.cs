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
        private void PostaviVrijednosti() {
            tbxNaziv.Text = p.Naziv;
            tbxDrzava.Text = p.Drzava;
            tbxGrad.Text = p.Grad;
            tbxUlica.Text = p.Ulica;
            tbxBroj.Text = p.Broj.ToString();
            
        }

        private void btnSpremiPromjene_Click(object sender, EventArgs e) {
            p.Naziv = tbxNaziv.Text;
            p.Drzava = tbxDrzava.Text;
            p.Grad = tbxGrad.Text;
            p.Ulica = tbxUlica.Text;
            p.Broj = int.Parse(tbxBroj.Text);
            
            Poslovnica.AzurirajPoslovnicu(p);
            this.Close();
        }
    }
}
