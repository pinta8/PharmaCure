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
    public class LijekOsiguranje
    {
        public int idOsiguranje { get; set; }
        public string naziv { get; set; }
        public int participacija { get; set; }
        public static List<LijekOsiguranje> DohvatiOsiguranjaLijeka(int idL)
        {
            List<LijekOsiguranje> ListaArtikala = new List<LijekOsiguranje>();
            SqlCommand Command = new SqlCommand();
            Command.CommandType = CommandType.Text;
            Command.CommandText = "SELECT p.ID_Lijek, l.Naziv, l.Participacija FROM PopisOsiguranihLijekova p LEFT JOIN LijekoviOsiguranje l ON p.ID_Osiguranje = l.ID_Osiguranje WHERE p.ID_Lijek = " + idL + ";";
            DBCon DB = new DBCon();
            DB.GetCon();
            DataTable DT = DB.DohvatiDT(Command);
            foreach (DataRow dr in DT.Rows)
            {
                LijekOsiguranje r = new LijekOsiguranje();
                ListaArtikala.Add(r.MakeLijek(dr));
            }
            return ListaArtikala;
        }

        public static List<LijekOsiguranje> DohvatiOsiguranja(int idL)
        {
            List<LijekOsiguranje> ListaArtikala = new List<LijekOsiguranje>();
            SqlCommand Command = new SqlCommand();
            Command.CommandType = CommandType.Text;
            Command.CommandText = "SELECT l.ID_Osiguranje as ID_Lijek, l.Naziv, l.Participacija FROM PopisOsiguranihLijekova p LEFT JOIN LijekoviOsiguranje l ON p.ID_Osiguranje = l.ID_Osiguranje WHERE l.Naziv NOT IN (SELECT l.Naziv FROM PopisOsiguranihLijekova p LEFT JOIN LijekoviOsiguranje l ON p.ID_Osiguranje = l.ID_Osiguranje WHERE p.ID_Lijek = " + idL + ");";
            DBCon DB = new DBCon();
            DB.GetCon();
            DataTable DT = DB.DohvatiDT(Command);
            foreach (DataRow dr in DT.Rows)
            {
                LijekOsiguranje r = new LijekOsiguranje();
                ListaArtikala.Add(r.MakeLijek(dr));
            }
            return ListaArtikala;
        }

        static public void DodajOsiguranje(int lijID, int idO)
        {
            DBCon baza = new DBCon();
            SqlCommand command = new SqlCommand("INSERT INTO PopisOsiguranihLijekova (ID_Lijek, ID_Osiguranje) VALUES (" + lijID + ", " + idO + ");");
            baza.IzvrsiUpit(command);
        }
        static public void BrisiOsiguranje(int lijID, int idO)
        {
            DBCon baza = new DBCon();
            SqlCommand command = new SqlCommand("DELETE FROM PopisOsiguranihLijekova  WHERE ID_Lijek = " + lijID + " AND ID_Osiguranje = " + idO + ";");
            baza.IzvrsiUpit(command);
        }

        public LijekOsiguranje MakeLijek(DataRow row)
        {
            LijekOsiguranje lije = new LijekOsiguranje();
            lije.idOsiguranje = int.Parse(row["ID_Lijek"].ToString());
            lije.naziv = row["Naziv"].ToString();
            lije.participacija = int.Parse(row["Participacija"].ToString());
            return lije;
        }
    }
}
