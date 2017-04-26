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
        public List<Lijekovi> l = new List<Lijekovi>();
        public FrmPopisLijekova()
        {
            InitializeComponent();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FrmMain m = new FrmMain();
            m.Show();
            this.Close();
        }
        private void FrmPopisLijekova_Load(object sender, EventArgs e)
        {
            OsvjeziListu();
        }

        private void OsvjeziListu()
        {
            l = Lijekovi.DohvatiSveLijekove();
            dgvLijekovi.DataSource = l;
        }
    }
}
