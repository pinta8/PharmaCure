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
    public partial class FrmRecepti : Form
    {
        public List<LijekoviRecept> lr = new List<LijekoviRecept>();
        public FrmRecepti()
        {
            InitializeComponent();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FrmMain m = new FrmMain();
            m.Show();
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            LijekoviRecept lijeR = new LijekoviRecept();
            lijeR.ID_Lijek = int.Parse(txtIDLijek.Text);
            lijeR.Naziv = txtNaziv.Text;
            lijeR.ID_Klijent = int.Parse(txtIDKlijent.Text);
            lijeR.Kolicina = int.Parse(txtKolicina.Text);
            lijeR.DodajRecept();
            OsvjeziListu();
        }
        private void OsvjeziListu()
        {
            lr = LijekoviRecept.DohvatiSveLijekove();
            dgvLijekoviRecept.DataSource = lr;
        }
        private void FrmRecepti_Load(object sender, EventArgs e)
        {
            OsvjeziListu();
        }
    }
}
