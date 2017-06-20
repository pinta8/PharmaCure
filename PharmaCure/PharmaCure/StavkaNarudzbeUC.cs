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
        public StavkaNarudzbeUC() {
            InitializeComponent();
        }

        public StavkaNarudzbeUC(List<Lijek> lijekovi) {
            InitializeComponent();
            cbxNaziv.DataSource = lijekovi;
            cbxNaziv.ValueMember = "ID";
            cbxNaziv.DisplayMember = "Naziv";
        }

        public bool JelNapisanaKolicina() {
            if ((tbxKolicina.Text == "") || int.Parse(tbxKolicina.Text)<=0) return false;
            else return true;
        }
        
        public StavkaNarudzbe DajStavku() {
            stavka = new StavkaNarudzbe();
            Lijek lijek = (Lijek)cbxNaziv.SelectedItem;
            stavka.IdLijeka = lijek.ID;
            stavka.Kolicina = int.Parse(tbxKolicina.Text);
            return stavka;
        }

        public int dajId() {
            return ((Lijek)cbxNaziv.SelectedItem).ID;
        }

    }
}
