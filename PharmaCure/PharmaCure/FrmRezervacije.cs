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
    public partial class FrmRezervacije : Form
    {
        public DateTime Datum { get; set; }
        public int Kolicina { get; set; }
        public int Klijent_id { get; set; }
        public int Lijek_id { get; set; }
        public FrmRezervacije()
        {
            InitializeComponent();
        }
        private void FrmRezervacije_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_17003_DBDataSet.PregledRezervacija' table. You can move, or remove it, as needed.
            this.pregledRezervacijaTableAdapter.Fill(this._17003_DBDataSet.PregledRezervacija);
            // TODO: This line of code loads data into the '_17003_DBDataSet.Rezervacija' table. You can move, or remove it, as needed.
            this.rezervacijaTableAdapter.Fill(this._17003_DBDataSet.Rezervacija);
            // TODO: This line of code loads data into the '_17003_DBDataSet.Klijent' table. You can move, or remove it, as needed.
            this.klijentTableAdapter.Fill(this._17003_DBDataSet.Klijent);
            // TODO: This line of code loads data into the '_17003_DBDataSet.Lijekovi' table. You can move, or remove it, as needed.
            this.lijekoviTableAdapter.Fill(this._17003_DBDataSet.Lijekovi);
            // TODO: This line of code loads data into the '_17003_DBDataSet.Lijekovi' table. You can move, or remove it, as needed.
            this.lijekoviTableAdapter.Fill(this._17003_DBDataSet.Lijekovi);
        }
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void prezimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (prezimeComboBox.SelectedItem != null)
            {
                Klijent_id = int.Parse(prezimeComboBox.SelectedValue.ToString());
                this.pregledRezervacijaTableAdapter.FillById(this._17003_DBDataSet.PregledRezervacija, Klijent_id);
            }
        }
        private void nazivComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nazivComboBox.SelectedItem != null)
            {
                Klijent_id = int.Parse(prezimeComboBox.SelectedValue.ToString());
                this.pregledRezervacijaTableAdapter.FillById(this._17003_DBDataSet.PregledRezervacija,  Klijent_id);
            }
        }
        private void dodajRezervaciju_Click(object sender, EventArgs e)
        {
            Datum = DateTime.Now;
            Kolicina = int.Parse(txtKolicina.Text);
            Klijent_id = int.Parse(prezimeComboBox.SelectedValue.ToString());
            Lijek_id = int.Parse(nazivComboBox.SelectedValue.ToString());
            this.rezervacijaTableAdapter.InsertQuery(Datum, Kolicina, Klijent_id, Lijek_id);
            this.pregledRezervacijaTableAdapter.Fill(this._17003_DBDataSet.PregledRezervacija);
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Close();
        }
    }
}
