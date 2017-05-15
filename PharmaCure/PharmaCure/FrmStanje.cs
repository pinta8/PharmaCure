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
        public void PripremiDgvLijek() {
            dostupnost = Dostupnost.DohvatiLijekovePoslovnice(Zaposlenik.PoslovnicaPrijavljenog);
            dgvLijekovi.DataSource = dostupnost;
        }
        private void FrmStanje_Load(object sender, EventArgs e) {
            PripremiDgvLijek();
        }
    }
}
