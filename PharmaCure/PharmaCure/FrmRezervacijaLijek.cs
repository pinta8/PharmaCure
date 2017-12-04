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
    public partial class FrmRezervacijaLijek : Form
    {
        public FrmRezervacijaLijek()
        {
            InitializeComponent();
        }
        private void FrmRezervacijaLijek_Load(object sender, EventArgs e)
        {
            this.lijekoviTableAdapter.Fill(this._17003_DBDataSet.Lijekovi);
        }
        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FrmRezervacija frmRezervacija = new FrmRezervacija();
            frmRezervacija.Show();
            this.Close();
        }
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            FrmRezervacija frmRezervacija = new FrmRezervacija();
            frmRezervacija.Show();
            this.Close();
        }
    }
}
