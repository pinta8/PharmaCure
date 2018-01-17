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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        /// <summary>
        /// Prijava u aplikaciju.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrijava(object sender, EventArgs e)
        {
            Zaposlenik z = Zaposlenik.DohvatiZaposlenika(tbxKorisnickoIme.Text, tbxLozinka.Text);
            //if (z == null)
            //{
            //    MessageBox.Show("Neuspješna prijava");
            //}
            //else
            //{
            FrmMain m = new FrmMain();
            m.Show();
            this.Hide();
            //}
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r17003/wiki/Korisnička-dokumentacija#11-korisni%C4%8Dki-podaci");
            }
        }
    }
}
