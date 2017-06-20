using Data_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class Dostupnost
    {
       
        string naziv;
        string opis;
       
        int kolicina;

     
        public string Opis {
            get {
                return opis;
            }

            set {
                opis = value;
            }
        }


        public int Kolicina {
            get {
                return kolicina;
            }

            set {
                kolicina = value;
            }
        }

        public string Naziv {
            get {
                return naziv;
            }

            set {
                naziv = value;
            }
        }
        //pravimo objekt klase Dostupnost
        public Dostupnost NapraviLijek(DataRow row) {
            Dostupnost dostupnost = new Dostupnost();
            dostupnost.naziv = row["Naziv"].ToString();
            dostupnost.opis = row["Kratki_opis"].ToString();
            dostupnost.kolicina = int.Parse(row["Kolicina_skladiste"].ToString());
            return dostupnost;
        }
        //dohvacamo sve dostupne lijekove odabrane poslovnice
        public static List<Dostupnost> DohvatiLijekovePoslovnice(int idPoslovnice) {
            List<Dostupnost> listaLijekova = new List<Dostupnost>();
            SqlCommand Command = new SqlCommand();
            Command.CommandType = CommandType.Text;
            Command.CommandText = "SELECT l.Naziv,l.Kratki_opis,d.Kolicina_skladiste FROM Lijekovi l, Dostupnost d WHERE l.ID_Lijek=d.Lijekovi_ID AND d.Poslovnica_ID=" + idPoslovnice;
            DBCon DB = new DBCon();
            DB.GetCon();
            DataTable DT = DB.DohvatiDT(Command);
            foreach (DataRow dr in DT.Rows) {
                Dostupnost r = new Dostupnost();
                listaLijekova.Add(r.NapraviLijek(dr));
            }
            return listaLijekova;
        }
        //definiramo kako ce nam se ispisivat podaci u textboxu kada pozove ToString
        public override string ToString() {
            return "Naziv: "+naziv +Environment.NewLine +"Kolicina: " + kolicina + Environment.NewLine+Environment.NewLine;
        }
    }
}
