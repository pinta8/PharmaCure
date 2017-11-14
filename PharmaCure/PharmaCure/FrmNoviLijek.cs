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
        public FrmNoviLijek()
        {
            InitializeComponent();
        }
        private void FrmNoviLijek_Load(object sender, EventArgs e)
        {
            this.kategorijaTableAdapter.Fill(this._17003_DBDataSet.Kategorija);      
            this.lijekoviTableAdapter.Fill(this._17003_DBDataSet.Lijekovi);
            nazivComboBox.SelectedIndex = -1;
        }
        private void puni_opisTextBox_TextChanged(object sender, EventArgs e)
        {
            double sirinaUnosa = puni_opisTextBox.Width;
            Size size = TextRenderer.MeasureText(puni_opisTextBox.Text, puni_opisTextBox.Font);
            double trenutacnaSirinaUnosa = size.Width;
            if (trenutacnaSirinaUnosa > sirinaUnosa)
            {
                puni_opisTextBox.Width = size.Width;
            }
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            
            int lijekID = int.Parse(this.lijekoviTableAdapter.VratiZadnjiID().ToString()) + 1;
           if(nazivTextBox.Text!="" && kratki_opisTextBox.Text!="" && puni_opisTextBox.Text!="" && cijenaTextBox.Text!="" && zemlja_porijeklaTextBox.Text != "" && nazivComboBox.Text!="")
            {
                string nazivLijeka = nazivTextBox.Text;
                string kratkiOpis = kratki_opisTextBox.Text;
                string opis = puni_opisTextBox.Text;
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
                        this.lijekoviTableAdapter.InsertQuery(lijekID, nazivLijeka, kratkiOpis, opis, datumProizvodnje.ToString(), datumIsteka.ToString(), Cijena, zemljaPorijekla, kategorijaID);
                        MessageBox.Show("Lijek je uspješno dodan u bazu podataka!");
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
                MessageBox.Show("Molimo provjerite da li ste unijeli sve podatke!");
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
