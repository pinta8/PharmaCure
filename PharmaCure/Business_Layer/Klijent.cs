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
    public class Klijent
    {
        public int idKlijent { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int osiguranje { get; set; }
        public static List<Klijent> DohvatiSveKlijente()
        {
            List<Klijent> ListaKlijenata = new List<Klijent>();
            SqlCommand Command = new SqlCommand();
            Command.CommandType = CommandType.Text;
            Command.CommandText = "SELECT * FROM Klijent;";
            DBCon DB = new DBCon();
            DB.GetCon();
            DataTable DT = DB.DohvatiDT(Command);
            foreach (DataRow dr in DT.Rows)
            {
                Klijent r = new Klijent();
                ListaKlijenata.Add(r.MakeKlijent(dr));
            }
            return ListaKlijenata;
        }
        static public void IzbrisiKlijenta(int id)
        {
            DBCon baza = new DBCon();
            SqlCommand command = new SqlCommand("DELETE FROM Klijent WHERE ID_Klijent = " + id);
            baza.IzvrsiUpit(command);
        }
        static public void DodajKlijenta(string ime, string prezime, int osiguranje)
        {
            DBCon baza = new DBCon();
            SqlCommand command = new SqlCommand("INSERT INTO Klijent ( Ime, Prezime, ID_Osiguranje) VALUES (" + ime + ", " + prezime + ", " + osiguranje + ")");
            baza.IzvrsiUpit(command);
        }
        public Klijent MakeKlijent(DataRow row)
        {
            Klijent klije = new Klijent();
            klije.idKlijent = int.Parse(row["ID_Klijent"].ToString());
            klije.Ime = row["Ime"].ToString();
            klije.Prezime = row["Prezime"].ToString();
            klije.osiguranje = int.Parse(row["ID_Osiguranje"].ToString());
            return klije;
        }
    }
}
