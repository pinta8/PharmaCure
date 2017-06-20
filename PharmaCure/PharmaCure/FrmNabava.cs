﻿using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PharmaCure {
    public partial class FrmNabava : Form {
        public List<Lijek> lijekovi;
        public List<StavkaNarudzbe> stavke = new List<StavkaNarudzbe>();
        public FrmNabava() {
            InitializeComponent();
            lijekovi = Lijek.DohvatiSveLijekove();
        }
        
        //provjeravamo jel su popunjene sve količine, jesu li ID lijekova jedinstveni u kontrolama te na kraju zapisujemo narudžbu
        private void btnPosaljiNarudzbu_Click(object sender, EventArgs e) {
            stavke.Clear();
            for (int i=0;i<flpStavke.Controls.Count;i++) {
                StavkaNarudzbeUC sn = (StavkaNarudzbeUC)flpStavke.Controls[i];
                int id = sn.dajId();
                if(i!=flpStavke.Controls.Count-1)
                    for (int j = i+1; j < flpStavke.Controls.Count; j++) {
                        if (id == ((StavkaNarudzbeUC)flpStavke.Controls[j]).dajId()) {
                            MessageBox.Show("Ne možete isti lijek naručiti kao dvije različite stavke");
                            return;
                        }
                    }

                if (sn.JelNapisanaKolicina() == false) {
                    MessageBox.Show("Niste unijeli količinu na nekom mjestu!");
                    return;
                }
                else {
                    stavke.Add(sn.DajStavku());
                }
            }
            
            Narudzba nar = new Narudzba();
            nar.DjelatnikId = Zaposlenik.IdPrijavljenog;
            nar.PoslovnicaId = Zaposlenik.PoslovnicaPrijavljenog;
            nar.Stavke = this.stavke;
            Narudzba.ZapisiNarudzbu(nar);
            this.Close();
            
            
        }
        //dodajemo kntrolu u panel 
        private void btnDodaj_Click(object sender, EventArgs e) {
            StavkaNarudzbeUC kontrola = new StavkaNarudzbeUC(lijekovi, this);
            
            flpStavke.Controls.Add(kontrola);
        }
        //racunamo cijenu svih lijekova prolazeći kroz sve kontrole u panelu
        public void IzracunajCijenu() {
            tbxCijena.Text = "";
            float sum = 0;
            foreach(StavkaNarudzbeUC sn in flpStavke.Controls) {
                if (sn.JelNapisanaKolicina()) {
                    sum += sn.dajUkupnuCijenu();
                }
                else return;
            }
            tbxCijena.Text = sum + "";
        }

        //mičemo kontrolu sa panela
        public void MakniKontrolu(Control c) {
            this.flpStavke.Controls.Remove(c);
            IzracunajCijenu();
        }

    }
}
