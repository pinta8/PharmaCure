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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnIzlaz_Click_1(object sender, EventArgs e)
        {
            FrmLogin l = new FrmLogin();
            l.Show();
            this.Close();
            
        }

        private void btnZaposlenici_Click(object sender, EventArgs e)
        {
            FrmDodajZaposlenika z = new FrmDodajZaposlenika();
            z.Show();
            this.Close();
        }

        private void btnPopisL_Click(object sender, EventArgs e)
        {
            FrmPopisLijekova popis = new FrmPopisLijekova();
            popis.Show();
            this.Close();
        }

        private void btnKolicina_Click(object sender, EventArgs e)
        {
            FrmKolicine kol = new FrmKolicine();
            kol.Show();
            this.Close();
        }

        private void btnNabava_Click(object sender, EventArgs e)
        {
            FrmNabava nab = new FrmNabava();
            nab.Show();
            this.Close();
        }

        private void btnDostava_Click(object sender, EventArgs e)
        {
            FrmDostava dostava = new FrmDostava();
            dostava.Show();
            this.Close();
        }

        private void btnProdaja_Click(object sender, EventArgs e)
        {
            FrmProdaja prodaja = new FrmProdaja();
            prodaja.Show();
            this.Close();
        }

        private void btnRecepti_Click(object sender, EventArgs e)
        {
            FrmRecepti recepti = new FrmRecepti();
            recepti.Show();
            this.Close();
        }
    }
}
