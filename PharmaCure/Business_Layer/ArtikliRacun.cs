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
    public class ArtikliRacun
    {
        public int id { get; set; }
        public string Naziv { get; set; }
        public string kratkiOpis { get; set; }
        public DateTime datumIsteka { get; set; }
        public double cijena { get; set; }
        public int kolicina { get; set; }
        public int participacija { get; set; }

        public static List<ArtikliRacun> DohvatiSveArtikleKorisnika(int pom, int radnja)
        {
            List<ArtikliRacun> ListaArtikala = new List<ArtikliRacun>();
            SqlCommand Command = new SqlCommand();
            Command.CommandType = CommandType.Text;
            Command.CommandText = "SELECT a.ID_Lijek, l.Naziv, l.Kratki_opis, l.Datum_isteka, l.Cijena, a.Kolicina, a.Participacija FROM Racun r JOIN Artikli_Racun a ON r.ID_Racun = a.ID_Racun JOIN Lijekovi l ON a.ID_Lijek = l.ID_Lijek WHERE r.ID_Klijent = " + pom + "AND r.ID_Stanje = " + radnja + ";";
            DBCon DB = new DBCon();
            DB.GetCon();
            DataTable DT = DB.DohvatiDT(Command);
            foreach (DataRow dr in DT.Rows)
            {
                ArtikliRacun r = new ArtikliRacun();
                ListaArtikala.Add(r.MakeLijek(dr));
            }
            return ListaArtikala;
        }
        static public void IzbrisiArtikl(int id)
        {
            DBCon baza = new DBCon();
            SqlCommand command = new SqlCommand("DELETE FROM Artikli_Racun WHERE ID_Lijek=" + id);
            baza.IzvrsiUpit(command);
        }
        static public void DostavljenRacun(int klije, int stanje)
        {
            DBCon baza = new DBCon();
            SqlCommand command = new SqlCommand("UPDATE Racun set ID_Stanje = 3 WHERE ID_Klijent = " + klije + " AND ID_Stanje = " + stanje);
            baza.IzvrsiUpit(command);

        }
        static public void DodajArtikl(int kol, int lijID, int idR)
        {
            DBCon baza = new DBCon();
            SqlCommand command = new SqlCommand("INSERT INTO Artikli_Racun ( ID_Racun, ID_Lijek, Kolicina, Participacija) VALUES ("+idR+", "+lijID+", "+kol+", 100)");
            baza.IzvrsiUpit(command);
        }
        static public void DodajArtiklRecept(int lijID, int idR, int kol, int part)
        {
            DBCon baza = new DBCon();
            SqlCommand command = new SqlCommand("INSERT INTO Artikli_Racun ( ID_Racun, ID_Lijek, Kolicina, Participacija) VALUES (" + idR + ", " + lijID + ", " + kol + ", "+ part +");");
            baza.IzvrsiUpit(command);
        }
        public ArtikliRacun MakeLijek(DataRow row)
        {
            ArtikliRacun lije = new ArtikliRacun();
            lije.id = int.Parse(row["ID_Lijek"].ToString());
            lije.Naziv = row["Naziv"].ToString();
            lije.kratkiOpis = row["kratki_opis"].ToString();
            lije.datumIsteka = DateTime.Parse(row["Datum_isteka"].ToString());
            lije.kolicina = int.Parse(row["Kolicina"].ToString());
            lije.cijena = int.Parse(row["Cijena"].ToString());
            lije.participacija = int.Parse(row["Participacija"].ToString());
            return lije;
        }
    }
}
