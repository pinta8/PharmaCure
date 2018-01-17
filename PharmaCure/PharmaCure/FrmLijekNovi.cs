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
    public partial class FrmLijekNovi : Form
    {
        public int Cijena { get; set; }
        public int NacinRada { get; set; }
        public Business_Layer.Lijek OdabraniLijek { get; set; }
        public string NazivKategorije { get; set; }
        public FrmLijekNovi()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Forma ima 2 načina rada kao i kod rezervacija (unos novog lijeka ili izmjena podataka o postojećem lijeku). Ukoliko je 
        /// varijabla NacinRada !=0 tada se prikazuju u formi podaci od odabranog lijeka.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmNoviLijek_Load(object sender, EventArgs e)
        {
            int lijekID = int.Parse(this.lijekoviTableAdapter.VratiZadnjiID().ToString());
            this.kategorijaTableAdapter.Fill(this._17003_DBDataSet.Kategorija);
            this.lijekoviTableAdapter.Fill(this._17003_DBDataSet.Lijekovi);
            FrmLijekPopis frmPopisLijekova = new FrmLijekPopis();
            if (NacinRada != 0)
            {
                btnDodaj.Text = "Spremi";
                nazivTextBox.Text = OdabraniLijek.Naziv;
                kratki_opisTextBox.Text = OdabraniLijek.kratkiOpis;
                datum_proizvodnjeDateTimePicker.Value = OdabraniLijek.datumProizvodnje;
                datum_istekaDateTimePicker.Value = OdabraniLijek.datumIsteka;
                cijenaTextBox.Text = OdabraniLijek.cijena.ToString();
                zemlja_porijeklaTextBox.Text = OdabraniLijek.zemljaPorijekla;
                nazivComboBox.Text = NazivKategorije;
            }
            else
            {
                stanjeCheckBox.Visible = false;
                lblStanje.Visible = false;
            }
        }
        /// <summary>
        /// Dodavanje novog lijeka u bazu podataka. Sve pogreške u radu (npr. ukoliko se unese slovo umjesto brojke kod polja za 
        /// unos "Količina") jest rješeno pomoću iznimki.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (NacinRada == 0)
            {
                int lijekID = int.Parse(this.lijekoviTableAdapter.VratiZadnjiID().ToString()) + 1;
                if (nazivTextBox.Text != "" && kratki_opisTextBox.Text != "" && cijenaTextBox.Text != "" && zemlja_porijeklaTextBox.Text != "" && nazivComboBox.Text != "")
                {
                    string nazivLijeka = nazivTextBox.Text;
                    string kratkiOpis = kratki_opisTextBox.Text;
                    DateTime datumProizvodnje = datum_proizvodnjeDateTimePicker.Value;
                    DateTime datumIsteka = datum_istekaDateTimePicker.Value;
                    try
                    {
                        Cijena = int.Parse(cijenaTextBox.Text);
                    }

                    catch (System.FormatException)
                    {
                        MessageBox.Show("U polje cijena potrebno je upisati brojke!");
                    }
                    string zemljaPorijekla = zemlja_porijeklaTextBox.Text;
                    int kategorijaID = int.Parse(nazivComboBox.SelectedValue.ToString());
                    if (Cijena > 0)
                    {
                        this.lijekoviTableAdapter.InsertQuery(lijekID, nazivLijeka, kratkiOpis, datumProizvodnje.ToString(), datumIsteka.ToString(), Cijena, zemljaPorijekla, kategorijaID, true);
                        FrmLijekPopis frmPopisLijekova = new FrmLijekPopis();
                        frmPopisLijekova.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cijena lijeka mora biti pozitivan broj!");
                    }
                }
                else
                {
                    MessageBox.Show("Provjerite da li ste unijeli sve podatke!");
                }
            }
            else
            {
                bool stanje = false;
                if (stanjeCheckBox.Checked)
                {
                    stanje = true;
                }
                this.lijekoviTableAdapter.UpdateQuery(nazivTextBox.Text, kratki_opisTextBox.Text, datum_proizvodnjeDateTimePicker.Value.ToString(), datum_istekaDateTimePicker.Value.ToString(), int.Parse(cijenaTextBox.Text), zemlja_porijeklaTextBox.Text, int.Parse(nazivComboBox.SelectedValue.ToString()), stanje ,OdabraniLijek.ID, OdabraniLijek.ID);
                FrmLijekPopis frmPopisLijekova = new FrmLijekPopis();
                frmPopisLijekova.Show();
                this.Close();
            }
        }
        /// <summary>
        /// Izlaz iz aplikacije.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            FrmLijekPopis frmPopisLijekova = new FrmLijekPopis();
            frmPopisLijekova.Show();
            this.Close();
        }
    }
}
