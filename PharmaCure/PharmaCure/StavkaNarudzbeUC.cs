using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;

namespace PharmaCure {
    public partial class StavkaNarudzbeUC : UserControl {
        StavkaNarudzbe stavka;
        FrmNabava frm;
        public StavkaNarudzbeUC() {
            InitializeComponent();
        }

        
        public StavkaNarudzbeUC(List<Lijek> lijekovi, FrmNabava forma) {
            InitializeComponent();
            cbxNaziv.DataSource = lijekovi;
            cbxNaziv.ValueMember = "ID";
            cbxNaziv.DisplayMember = "Naziv";
            this.frm = forma;
        }
        //provjerava se jel popunjena količina
        public bool JelNapisanaKolicina() {
            if ((tbxKolicina.Text == "") || int.Parse(tbxKolicina.Text)<=0) return false;
            else return true;
        }
        //pravimo objekt StavkaNarudzbe i vraćamo je(formi)
        public StavkaNarudzbe DajStavku() {
            stavka = new StavkaNarudzbe();
            Lijek lijek = (Lijek)cbxNaziv.SelectedItem;
            stavka.IdLijeka = lijek.ID;
            stavka.Kolicina = int.Parse(tbxKolicina.Text);
            return stavka;
        }
        //funkcija koja vraća ID lijeka
        public int dajId() {
            return ((Lijek)cbxNaziv.SelectedItem).ID;
        }
        //računamo cijenu lijeka kojeg želimo kupiti
        public float dajUkupnuCijenu() {
            return int.Parse(tbxKolicina.Text) * ((Lijek)cbxNaziv.SelectedItem).cijena;
        }

       //kada izađemo van fokusa tbxKolicina, pozivamo IzracunajCijenu()
        private void tbxKolicina_Leave(object sender, EventArgs e) {
            frm.IzracunajCijenu();
        }
        //mičemo kontrolu sa panela ako kliknemo gumb Izbaci
        private void btnIzbaci_Click(object sender, EventArgs e) {
            frm.MakniKontrolu(this);
        }
        //kada mijenjamo ista u polju za kolicinu, pozivamo IzracunajCijenu()
        private void tbxKolicina_TextChanged(object sender, EventArgs e) {
            frm.IzracunajCijenu();
        }
        

    }
}
