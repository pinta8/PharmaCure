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
    public partial class FrmOsiguranjeLijek : Form
    {
        public List<Lijek> ll = new List<Lijek>();
        public List<LijekOsiguranje> lo = new List<LijekOsiguranje>();
        public List<PopisOsiguranihLijekova> pol = new List<PopisOsiguranihLijekova>();
        public FrmOsiguranjeLijek()
        {
            InitializeComponent();
        }
        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FrmMain m = new FrmMain();
            m.Show();
            this.Close();
        }

        private void FrmOsiguraneLijek_Load(object sender, EventArgs e)
        {
            OsvjeziListu();
        }
        private void OsvjeziListu()
        {
            ll = Lijek.DohvatiSveLijekove();
            dgvLijekovi.DataSource = ll;
            pol = PopisOsiguranihLijekova.DohvatiSvaOsiguranja();
            dgvSviLijekoviRecept.DataSource = pol;
        }
        private void dgvLijekovi_SelectionChanged(object sender, EventArgs e)
        {
            lo = LijekOsiguranje.DohvatiOsiguranja(int.Parse(dgvLijekovi.CurrentRow.Cells[0].Value.ToString()));
            cmbOsiguranje.DisplayMember = "naziv";
            cmbOsiguranje.ValueMember = "idOsiguranje";
            cmbOsiguranje.DataSource = lo;
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            PopisOsiguranihLijekova.DodajOsiguranje(int.Parse(dgvLijekovi.CurrentRow.Cells[0].Value.ToString()), int.Parse(cmbOsiguranje.SelectedValue.ToString()));
            OsvjeziListu();
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            PopisOsiguranihLijekova.BrisiOsiguranje(int.Parse(dgvLijekovi.CurrentRow.Cells[0].Value.ToString()), int.Parse(cmbOsiguranje.SelectedValue.ToString()));
            OsvjeziListu();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
