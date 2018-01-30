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
    public partial class FrmLijekPopis : Form
    {
        public FrmLijekPopis()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        /// <summary>
        /// Metoda za pozivanje F1 pomoći
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPopisLijekova_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r17003/wiki/Korisni%C4%8Dka-dokumentacija#21-popis-lijekova");
            }
        }
        private void FrmPopisLijekova_Load(object sender, EventArgs e)
        {
            comboBoxPretraga.SelectedIndex = 0;
            OsvjeziListu();
        }
        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FrmMain m = new FrmMain();
            m.Show();
            this.Close();
        }
        /// <summary>
        /// Izlaz iz programa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Metoda za osvježivanje liste lijekova.
        /// </summary>
        private void OsvjeziListu()
        {
            this.pregledLijekovaKategorijaTableAdapter.SelectVazeci(this._17003_DBDataSet.PregledLijekovaKategorija);
            dgvLijekovi.Sort(dgvLijekovi.Columns[0], ListSortDirection.Ascending);
            dgvLijekovi.Columns[8].Visible = false;
        }/// <summary>
        /// Promjena podataka o određenom lijeku.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnPromijeni_Click(object sender, EventArgs e)
        {
            FrmLijekNovi frmNoviLijek = new FrmLijekNovi();
            frmNoviLijek.OdabraniLijek = new Lijek();
            frmNoviLijek.OdabraniLijek.ID = int.Parse(dgvLijekovi.CurrentRow.Cells[0].Value.ToString());
            frmNoviLijek.OdabraniLijek.Naziv = dgvLijekovi.CurrentRow.Cells[1].Value.ToString();
            frmNoviLijek.OdabraniLijek.kratkiOpis = dgvLijekovi.CurrentRow.Cells[2].Value.ToString();
            frmNoviLijek.OdabraniLijek.datumProizvodnje = DateTime.Parse(dgvLijekovi.CurrentRow.Cells[3].Value.ToString());
            frmNoviLijek.OdabraniLijek.datumIsteka = DateTime.Parse(dgvLijekovi.CurrentRow.Cells[4].Value.ToString());
            frmNoviLijek.OdabraniLijek.cijena = int.Parse(dgvLijekovi.CurrentRow.Cells[5].Value.ToString());
            frmNoviLijek.OdabraniLijek.zemljaPorijekla = dgvLijekovi.CurrentRow.Cells[6].Value.ToString();
            frmNoviLijek.NazivKategorije = dgvLijekovi.CurrentRow.Cells[7].Value.ToString();
            frmNoviLijek.NacinRada = 1;
            frmNoviLijek.Show();
            this.Close();
        }
        /// <summary>
        /// Metoda za otvaranje forme za unos novog lijeka.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNoviLijek_Click(object sender, EventArgs e)
        {
            FrmLijekNovi frmNoviLijek = new FrmLijekNovi();
            frmNoviLijek.Show();
            this.Close();
        }
        /// <summary>
        /// Pretraga lijeka prema nazivu lijeka ili ID-u.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            string pogreska = "";
            if (comboBoxPretraga.Text == "")
            {
                pogreska += "Morate označiti prema čemu ćete pretraživati!";
            }
            if (txtBoxPretrazi.Text == "")
            {
                pogreska += " Morate unijeti tekst pretrage!";
            }
            if (pogreska == "")
            {
                if (comboBoxPretraga.SelectedIndex == 0)
                {
                    try
                    {
                        dgvLijekovi.Columns[8].Visible = true;
                        this.pregledLijekovaKategorijaTableAdapter.SelectPretraziID(this._17003_DBDataSet.PregledLijekovaKategorija, int.Parse(txtBoxPretrazi.Text));
                    }
                    catch (System.FormatException)
                    {
                        MessageBox.Show("Prilikom pretrage prema ID-u potrebno je upisivati isključivo brojke!");
                    }
                }
                else
                {
                    dgvLijekovi.Columns[8].Visible = true;
                    this.pregledLijekovaKategorijaTableAdapter.SelectPretraziPremaNaziv(this._17003_DBDataSet.PregledLijekovaKategorija, txtBoxPretrazi.Text);
                }
            }
            else
            {
                MessageBox.Show(pogreska);
            }
        }
    }
}