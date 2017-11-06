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
            //int sirinaUnosa = puni_opisTextBox.Width;
            this.kategorijaTableAdapter.Fill(this._17003_DBDataSet.Kategorija);
            //this.lijekoviTableAdapter.Fill(this._17003_DBDataSet.Lijekovi);
            //nazivComboBox.SelectedIndex = -1;
            OsvjeziListu();      
        }
        //funkcija za dohvat nove liste iz baze i ispis iste na datagridview
        private void OsvjeziListu()
        {
            l = Lijek.DohvatiSveLijekove();
            dgvLijekovi.DataSource = l;
        }
        private void puni_opisTextBox_TextChanged(object sender, EventArgs e)
        {
            //double sirinaUnosa = puni_opisTextBox.Width;
            //Size size = TextRenderer.MeasureText(puni_opisTextBox.Text, puni_opisTextBox.Font);
            //double trenutacnaSirinaUnosa = size.Width;
            //if (trenutacnaSirinaUnosa > sirinaUnosa)
            //{
            //    puni_opisTextBox.Width = size.Width;
            //}
        }
        //private void btnUnesi_Click(object sender, EventArgs e)
        //{
        //    int lijekID = int.Parse(this.lijekoviTableAdapter.VratiZadnjiID().ToString())+1;
        //    string nazivLijeka = nazivTextBox.Text;
        //    string kratkiOpis = kratki_opisTextBox.Text;
        //    string opis = puni_opisTextBox.Text;
        //    DateTime datumProizvodnje = datum_proizvodnjeDateTimePicker.Value;
        //    DateTime datumIsteka = datum_istekaDateTimePicker.Value;
        //    int cijena = int.Parse(cijenaTextBox.Text);
        //    string zemljaPorijekla = zemlja_porijeklaTextBox.Text;
        //    int kategorijaID = int.Parse(nazivComboBox.SelectedValue.ToString());
        //    this.lijekoviTableAdapter.InsertQuery(lijekID,  nazivLijeka, kratkiOpis, opis, datumProizvodnje.ToString(), datumIsteka.ToString(), cijena, zemljaPorijekla, kategorijaID);
        //    MessageBox.Show("Lijek je uspješno dodan u bazu podataka!");
        //    OsvjeziListu();
        //}

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            int lijekID = int.Parse(dgvLijekovi.CurrentRow.Cells[0].Value.ToString());
            this.lijekoviTableAdapter.DeleteQuery(lijekID);
            MessageBox.Show("Lijek je uspješno izbrisan iz baze podataka!");
            OsvjeziListu();
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