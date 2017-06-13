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
        public string Naziv { get; set; }
        public string kratkiOpis { get; set; }
        public DateTime datumIsteka { get; set; }
        public double cijena { get; set; }
        public int kolicina { get; set; }
        public Racun racun { get; set; }

        public static List<ArtikliRacun> DohvatiSveArtikleKorisnika(int pom, int djela)
        {
            List<ArtikliRacun> ListaRasadnika = new List<ArtikliRacun>();
            SqlCommand Command = new SqlCommand();
            Command.CommandType = CommandType.Text;
            Command.CommandText = "SELECT a.ID_Lijek, l.Naziv, l.Kratki_opis, l.Datum_isteka, l.Cijena, a.Kolicina, r.Djelatnik, r.ID_Klijent FROM Racun r JOIN Artikli_Racun a ON r.ID_Racun = a.ID_Racun JOIN Lijekovi l ON a.ID_Lijek = l.ID_Lijek WHERE r.ID_Klijent = " + pom + "AND r.Djelatnik = " + djela;
            DBCon DB = new DBCon();
            DB.GetCon();
            DataTable DT = DB.DohvatiDT(Command);
            foreach (DataRow dr in DT.Rows)
            {
                ArtikliRacun r = new ArtikliRacun();
                ListaRasadnika.Add(r.MakeLijek(dr));
            }
            return ListaRasadnika;
        }
        public ArtikliRacun MakeLijek(DataRow row)
        {
            ArtikliRacun lije = new ArtikliRacun();
            lije.Naziv = row["Naziv"].ToString();
            lije.kratkiOpis = row["kratki_opis"].ToString();
            lije.datumIsteka = DateTime.Parse(row["Datum_isteka"].ToString());
            lije.kolicina = int.Parse(row["Kolicina"].ToString());
            lije.cijena = int.Parse(row["Cijena"].ToString());
            Racun r = new Racun();
            r.djelatnik = int.Parse(row["Djelatnik"].ToString());
            r.klijent = int.Parse(row["ID_Klijent"].ToString());
            lije.racun = r;
            return lije;
        }
    }
}
