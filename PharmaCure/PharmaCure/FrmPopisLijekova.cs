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
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FrmPopisLijekova_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r17003/wiki/Korisni%C4%8Dka-dokumentacija#21-popis-lijekova");
            }
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
        private void btnBrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int lijekID = int.Parse(dgvLijekovi.CurrentRow.Cells[0].Value.ToString());
                this.lijekoviTableAdapter.DeleteQuery(lijekID);
                MessageBox.Show("Lijek je uspješno izbrisan iz baze podataka!");
                OsvjeziListu();
            }
        }
        private void btnPromijeni_Click(object sender, EventArgs e)
        {
            int lijekID = int.Parse(dgvLijekovi.CurrentRow.Cells[0].Value.ToString());
            string nazivLijeka = dgvLijekovi.CurrentRow.Cells[1].Value.ToString();
            string kratkiOpis = dgvLijekovi.CurrentRow.Cells[2].Value.ToString();
            DateTime datumProizvodnje = DateTime.Parse(dgvLijekovi.CurrentRow.Cells[3].Value.ToString());
            DateTime datumIsteka = DateTime.Parse(dgvLijekovi.CurrentRow.Cells[4].Value.ToString());
            int cijena = int.Parse(dgvLijekovi.CurrentRow.Cells[5].Value.ToString());
            string zemljaPorijekla = dgvLijekovi.CurrentRow.Cells[6].Value.ToString();
            this.lijekoviTableAdapter.UpdateQuery(nazivLijeka, kratkiOpis, datumProizvodnje.ToString(), datumIsteka.ToString(), cijena, zemljaPorijekla, lijekID, lijekID);
            MessageBox.Show("Uspješno su promijenjeni podaci!");
        }
        private void btnNoviLijek_Click(object sender, EventArgs e)
        {
            FrmNoviLijek frmNoviLijek = new FrmNoviLijek();
            frmNoviLijek.Show();
            this.Close();
        }
    }
}