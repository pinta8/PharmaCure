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
    public partial class FrmNoviLijek : Form
    {
        public int Cijena { get; set; }
        public int NacinRada { get; set; }
        public Business_Layer.Lijek OdabraniLijek { get; set; }
        public string NazivKategorije { get; set; }
        public FrmNoviLijek()
        {
            InitializeComponent();
        }
        private void FrmNoviLijek_Load(object sender, EventArgs e)
        {
            this.kategorijaTableAdapter.Fill(this._17003_DBDataSet.Kategorija);
            this.lijekoviTableAdapter.Fill(this._17003_DBDataSet.Lijekovi);
            FrmPopisLijekova frmPopisLijekova = new FrmPopisLijekova();
            nazivComboBox.SelectedIndex = -1;
            if (NacinRada != 0)
            {
                MessageBox.Show(OdabraniLijek.datumProizvodnje.ToString());
                btnDodaj.Text = "Spremi";
                nazivTextBox.Text = OdabraniLijek.Naziv;
                kratki_opisTextBox.Text = OdabraniLijek.kratkiOpis;
                datum_proizvodnjeDateTimePicker.Value = OdabraniLijek.datumProizvodnje;
                datum_istekaDateTimePicker.Value = OdabraniLijek.datumIsteka;
                cijenaTextBox.Text = OdabraniLijek.cijena.ToString();
                zemlja_porijeklaTextBox.Text = OdabraniLijek.zemljaPorijekla;
                nazivComboBox.Text = NazivKategorije;
            }
        }
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
                        this.lijekoviTableAdapter.InsertQuery(lijekID, nazivLijeka, kratkiOpis, datumProizvodnje.ToString(), datumIsteka.ToString(), Cijena, zemljaPorijekla, kategorijaID);
                        FrmPopisLijekova frmPopisLijekova = new FrmPopisLijekova();
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
                FrmPopisLijekova frmPopisLijekova = new FrmPopisLijekova();
                frmPopisLijekova.Show();
                this.Close();
            }
        }
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            FrmPopisLijekova frmPopisLijekova = new FrmPopisLijekova();
            frmPopisLijekova.Show();
            this.Close();
        }
    }
}
