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
        private void FrmPopisLijekova_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r17003/wiki/Korisni%C4%8Dka-dokumentacija#21-popis-lijekova");
            }
        }
        //na form loadu poziva Osvježi listu popisa lijekova (ispisuje na datagridview i sortira)
        private void FrmPopisLijekova_Load(object sender, EventArgs e)
        {
            OsvjeziListu();
        }
        //funkcija za dohvat nove liste iz baze i ispis iste na datagridview 
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
        private void OsvjeziListu()
        {
            this.pregledLijekovaKategorijaTableAdapter.Fill(this._17003_DBDataSet.PregledLijekovaKategorija);
            dgvLijekovi.Sort(dgvLijekovi.Columns[0], ListSortDirection.Ascending);
        }
         public void btnPromijeni_Click(object sender, EventArgs e)
        {
            FrmNoviLijek frmNoviLijek = new FrmNoviLijek();
            frmNoviLijek.OdabraniLijek = new Lijek();
            frmNoviLijek.OdabraniLijek.ID = int.Parse(dgvLijekovi.CurrentRow.Cells[0].Value.ToString());
            frmNoviLijek.OdabraniLijek.Naziv= dgvLijekovi.CurrentRow.Cells[1].Value.ToString();
            frmNoviLijek.OdabraniLijek.kratkiOpis= dgvLijekovi.CurrentRow.Cells[2].Value.ToString();
            frmNoviLijek.OdabraniLijek.datumProizvodnje = DateTime.Parse(dgvLijekovi.CurrentRow.Cells[3].Value.ToString());
            frmNoviLijek.OdabraniLijek.datumProizvodnje = DateTime.Parse(dgvLijekovi.CurrentRow.Cells[4].Value.ToString());
            frmNoviLijek.OdabraniLijek.cijena = int.Parse(dgvLijekovi.CurrentRow.Cells[5].Value.ToString());
            frmNoviLijek.OdabraniLijek.zemljaPorijekla = dgvLijekovi.CurrentRow.Cells[6].Value.ToString();
            frmNoviLijek.NazivKategorije = dgvLijekovi.CurrentRow.Cells[7].Value.ToString();
            frmNoviLijek.NacinRada = 1;
            frmNoviLijek.Show();
            this.Close();
        }
        private void btnNoviLijek_Click(object sender, EventArgs e)
        {
            FrmNoviLijek frmNoviLijek = new FrmNoviLijek();
            frmNoviLijek.Show();
            this.Close();
        }
    }
}