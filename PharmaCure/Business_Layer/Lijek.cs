using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;
using System.Data.SqlClient;
using System.Data;

namespace Business_Layer
{
    //Klasa napravljena od strane Marina Bulić i Krešimir Zelenika
    public class Lijek
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public string kratkiOpis { get; set; }
        public string PuniOpis { get; set; }
        public DateTime datumProizvodnje { get; set; }
        public DateTime datumIsteka { get; set; }
        public int cijena { get; set; }
        public string zemljaPorijekla { get; set; }
        public int KategorijaID { get; set; }

        //Funkcija za vraćanje Liste svih lijekova
        public static List<Lijek> DohvatiSveLijekove()
        {
            List<Lijek> ListaLijekova = new List<Lijek>();
            SqlCommand Command = new SqlCommand();
            Command.CommandType = CommandType.Text;
            Command.CommandText = "SELECT * FROM Lijekovi";
            DBCon DB = new DBCon();
            DB.GetCon();
            DataTable DT = DB.DohvatiDT(Command);
            foreach (DataRow dr in DT.Rows)
            {
                Lijek r = new Lijek();
                ListaLijekova.Add(r.MakeLijek(dr));
            }
            return ListaLijekova;
        }

        //Datarow objekt sa podacima za Lijek
        public Lijek MakeLijek(DataRow row)
        {
            Lijek lije = new Lijek();
            lije.ID = int.Parse(row["ID_Lijek"].ToString());
            lije.Naziv = row["Naziv"].ToString();
            lije.kratkiOpis = row["Kratki_opis"].ToString();
            lije.datumProizvodnje = DateTime.Parse(row["Datum_proizvodnje"].ToString());
            lije.datumIsteka = DateTime.Parse(row["Datum_isteka"].ToString());
            lije.cijena = int.Parse(row["Cijena"].ToString());
            lije.zemljaPorijekla = row["Zemlja_porijekla"].ToString();
            return lije;
        }

        //Metoda koja vraća nazive i ID za sve Lijekove
        static public List<Lijek> VratiNaziveLijekova() {
            List<Lijek> lijekovi = new List<Lijek>();
            DBCon baza = new DBCon();
            SqlCommand command = new SqlCommand("SELECT Naziv,ID_Lijek FROM Lijekovi");
            DataTable dt = baza.DohvatiDT(command);
            if (dt.Rows.Count == 0) {
                return null;
            }
            else {
                foreach (DataRow row in dt.Rows) {
                    Lijek l = new Lijek();
                    lijekovi.Add(l.MakeLijek(row));
                    
                }
                return lijekovi;
            }
        }
    }
}
