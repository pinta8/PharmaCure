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
    public partial class FrmRezervacija2 : Form
    {
        public DateTime Datum { get; set; }
        public int Kolicina { get; set; }
        public int Klijent_id { get; set; }
        public int Lijek_id { get; set; }
        public FrmRezervacija2()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        private void FrmRezervacije_Load(object sender, EventArgs e)
        {
            this.lijekoviReceptTableAdapter.Fill(this._17003_DBDataSet.LijekoviRecept);
            this.rezervacijaTableAdapter.Fill(this._17003_DBDataSet.Rezervacija);
            this.klijentTableAdapter.Fill(this._17003_DBDataSet.Klijent);
            this.lijekoviTableAdapter.Fill(this._17003_DBDataSet.Lijekovi);
            prezimeComboBox.SelectedIndex = -1;
            nazivComboBox.SelectedIndex = -1;
        }
        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Close();
        }
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FrmRezervacija_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r17003/wiki/Korisni%C4%8Dka-dokumentacija#211-rezervacija-lijeka");
            }
        }
        private void prezimeComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (prezimeComboBox.SelectedItem != null)
            {
                Klijent_id = int.Parse(prezimeComboBox.SelectedValue.ToString());
                this.pregledRezervacijaTableAdapter.FillByKlijentiD(this._17003_DBDataSet.PregledRezervacija, Klijent_id);
                this.rezervacijaTableAdapter.FillById(this._17003_DBDataSet1.Rezervacija, Klijent_id);
            }
        }
        private void dodajRezervaciju_Click(object sender, EventArgs e)
        {
            bool pogreska = false;
            Datum = DateTime.Now;
            try
            {
                Klijent_id = int.Parse(prezimeComboBox.SelectedValue.ToString());
            }
            catch (System.NullReferenceException)
            {
                pogreska = true;
                MessageBox.Show("Niste odabrali klijenta!");
            }
            if (!(pogreska))
            {
                this.rezervacijaTableAdapter.InsertQuery(Datum, Klijent_id);
                MessageBox.Show("Uspješno ste dodali rezervaciju !");
                Klijent_id = int.Parse(prezimeComboBox.SelectedValue.ToString());
                this.pregledRezervacijaTableAdapter.FillByKlijentiD(this._17003_DBDataSet.PregledRezervacija, Klijent_id);
            }
        }
        private void btnDodajLijek_Click(object sender, EventArgs e)
        {
            bool pogreska = false;
            if (nazivComboBox.Text == "")
            {
                MessageBox.Show("Morate odabrati lijek kojeg želite dodati u rezervaciju!");
            }
            else
            {
                Lijek_id = int.Parse(nazivComboBox.SelectedValue.ToString());
                List<string> SelectedRows = new List<string>();
                for (int count = 0; count < pregledRezervacijaDataGridView.SelectedRows.Count; count++)
                {
                    SelectedRows.Add(pregledRezervacijaDataGridView.SelectedRows[count].Cells[0].Value.ToString());
                }
                int rezervacijaID = int.Parse((SelectedRows[0]));
                try
                {
                    Kolicina = int.Parse(txtKolicina.Text);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Morate unijeti količinu (pozitivan broj)!");
                    pogreska = true;
                }
                if (!(pogreska))
                {
                    this.popisTableAdapter.InsertQuery(Lijek_id, rezervacijaID, Kolicina);
                    this.pregledRezervacija_LijekoviTableAdapter.FillByRezervacijaID(this._17003_DBDataSet.PregledRezervacija_Lijekovi, rezervacijaID);
                    MessageBox.Show("Uspješno ste dodali lijek u rezervaciju!");
                    this.pregledRezervacijaTableAdapter.FillByKlijentiD(this._17003_DBDataSet1.PregledRezervacija, Klijent_id);
                    this.pregledRezervacija_LijekoviTableAdapter.FillByRezervacijaID(this._17003_DBDataSet1.PregledRezervacija_Lijekovi, rezervacijaID);
                }
            }
        }
        private void btnObrisiRezervaciju_Click(object sender, EventArgs e)
        {
            if (pregledRezervacijaDataGridView.SelectedRows.Count != 0)
            {
                if (prezimeComboBox.SelectedItem != null)
                {
                    Klijent_id = int.Parse(prezimeComboBox.SelectedValue.ToString());
                    this.rezervacijaTableAdapter.FillById(this._17003_DBDataSet1.Rezervacija, Klijent_id);
                }
                List<string> SelectedRows = new List<string>();
                for (int count = 0; count < pregledRezervacijaDataGridView.SelectedRows.Count; count++)
                {
                    SelectedRows.Add(pregledRezervacijaDataGridView.SelectedRows[count].Cells[0].Value.ToString());
                }
                int rezervacijaID = int.Parse((SelectedRows[0]));
                this.popisTableAdapter.Brisi(rezervacijaID);
                this.rezervacijaTableAdapter.brisi(rezervacijaID);
                this.Validate();
                this.pregledRezervacijaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this._17003_DBDataSet);
                pregledRezervacijaDataGridView.Refresh();
                MessageBox.Show("Uspješno ste obrisali rezervaciju");
                this.pregledRezervacijaTableAdapter.FillByKlijentiD(this._17003_DBDataSet.PregledRezervacija, Klijent_id);
                this.pregledRezervacija_LijekoviTableAdapter.FillByRezervacijaID(this._17003_DBDataSet1.PregledRezervacija_Lijekovi, rezervacijaID);
            }
        }
        private void btnObrisiLijek_Click(object sender, EventArgs e)
        {
            if (pregledRezervacija_LijekoviDataGridView.SelectedRows.Count != 0)
            {
                if (prezimeComboBox.SelectedItem != null)
                {
                    Klijent_id = int.Parse(prezimeComboBox.SelectedValue.ToString());
                    this.rezervacijaTableAdapter.FillById(this._17003_DBDataSet1.Rezervacija, Klijent_id);
                }
                int rezervacijaID = int.Parse(pregledRezervacija_LijekoviDataGridView.CurrentRow.Cells[0].Value.ToString());
                int lijekID = int.Parse(pregledRezervacija_LijekoviDataGridView.CurrentRow.Cells[2].Value.ToString());
                this.popisTableAdapter.brisiLijek(lijekID,  rezervacijaID);
                this.Validate();
                this.pregledRezervacijaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this._17003_DBDataSet);
                pregledRezervacijaDataGridView.Refresh();
                MessageBox.Show("Uspješno ste obrisali lijek iz rezervacije!");
                this.pregledRezervacijaTableAdapter.FillByKlijentiD(this._17003_DBDataSet.PregledRezervacija, Klijent_id);
                this.pregledRezervacija_LijekoviTableAdapter.FillByRezervacijaID(this._17003_DBDataSet1.PregledRezervacija_Lijekovi, rezervacijaID);
            }
        }
        private void pregledRezervacijaDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (nazivComboBox.Text != "")
            {
                Lijek_id = int.Parse(nazivComboBox.SelectedValue.ToString());
            }
            if (prezimeComboBox.Text != "")
            {
                List<string> SelectedRows = new List<string>();
                for (int count = 0; count < pregledRezervacijaDataGridView.SelectedRows.Count; count++)
                {
                    SelectedRows.Add(pregledRezervacijaDataGridView.SelectedRows[count].Cells[0].Value.ToString());
                }
                if (SelectedRows.Count != 0)
                {
                    int rezervacijaID = int.Parse((SelectedRows[0]));
                    this.pregledRezervacija_LijekoviTableAdapter.FillByRezervacijaID(this._17003_DBDataSet1.PregledRezervacija_Lijekovi, rezervacijaID);
                }
            }
        }
    }
}