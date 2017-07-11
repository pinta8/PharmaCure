using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;

namespace PharmaCure
{
    public partial class FrmPopisLijekova : Form
    {
        //Nova lista lijekova za ispisivanje
        public List<Lijek> l = new List<Lijek>();
        public FrmPopisLijekova()
        {
            InitializeComponent();
        }
        //Gumb za povratak na Main Formu
        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FrmMain m = new FrmMain();
            m.Show();
            this.Close();
        }
        //na form loadu poziva Osvježi listu popisa lijekova (ispisuje na datagridview)
        private void FrmPopisLijekova_Load(object sender, EventArgs e)
        {
            OsvjeziListu();
        }
        //funkcija za dohvat nove liste iz baze i ispis iste na datagridview
        private void OsvjeziListu()
        {
            l = Lijek.DohvatiSveLijekove();
            dgvLijekovi.DataSource = l;
        }
        private void dgvLijekovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmPopisLijekova_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r17003/wiki/Korisni%C4%8Dka-dokumentacija#21-popis-lijekova");
            }
        }
    }
}
