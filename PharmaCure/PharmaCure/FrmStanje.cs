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
    public partial class FrmStanje : Form
    {
        List<Dostupnost> dostupnost;
        
        public FrmStanje()
        {
            InitializeComponent();
            
            
        }
        
        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FrmMain m = new FrmMain();
            m.Show();
            this.Close();
        }
        //postavljamo izvor podataka za datagrid
        public void PripremiDgvLijek() {
            dostupnost = Dostupnost.DohvatiLijekovePoslovnice(Zaposlenik.PoslovnicaPrijavljenog);
            dgvLijekovi.DataSource = dostupnost;
        }
        //u poseban textbox stavljamo lijekova čija je količina manja od 10
        public void PripremiKolicineManjeOdDeset() {
            tbxMinLijekovi.Text = "";
            dostupnost = Dostupnost.DohvatiLijekovePoslovnice(Zaposlenik.PoslovnicaPrijavljenog);
            var min = (from d in dostupnost where d.Kolicina < 10 select d);
            foreach(Dostupnost d in min) {
                tbxMinLijekovi.Text += d.ToString();
            }
        }
        private void FrmStanje_Load(object sender, EventArgs e) {
            PripremiDgvLijek();
            PripremiKolicineManjeOdDeset();
        }

        private void btnNaruci_Click(object sender, EventArgs e) {
            FrmNabava f = new FrmNabava();
            f.ShowDialog();
            PripremiDgvLijek();
            PripremiKolicineManjeOdDeset();
        }
    }
}
