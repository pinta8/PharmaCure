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
            try
            {
                int pronadjeno = int.Parse(djelatnikTableAdapter1.SelectCountnadjidjelatnika(tbxKorisnickoIme.Text, tbxLozinka.Text).ToString());
                FrmMain m = new FrmMain();
                m.Show();
                this.Hide();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Neuspješna prijava");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
