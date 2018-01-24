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
    //Klasa napravljena od strane Krešimir Zelenika
    public class PopisOsiguranihLijekova
    {
        public int LijekID { get; set; }
        public int OsiguranjeID { get; set; }

        //Metoda koja vraća listu svih lijekova i osiguranja
        public static List<PopisOsiguranihLijekova> DohvatiSvaOsiguranja()
        {
            List<PopisOsiguranihLijekova> ListaOsiguranja = new List<PopisOsiguranihLijekova>();
            SqlCommand Command = new SqlCommand();
            Command.CommandType = CommandType.Text;
            Command.CommandText = "SELECT l.Naziv, o.Naziv as Osiguranje FROM Lijekovi l JOIN PopisOsiguranihLijekova p ON l.ID_Lijek = p.ID_Lijek JOIN LijekoviOsiguranje o ON p.ID_Osiguranje = o.ID_Osiguranje ORDER BY 1,2;";
            DBCon DB = new DBCon();
            DB.GetCon();
            DataTable DT = DB.DohvatiDT(Command);
            foreach (DataRow dr in DT.Rows)
            {
                PopisOsiguranihLijekova r = new PopisOsiguranihLijekova();
                ListaOsiguranja.Add(r.MakeOsiguranje(dr));
            }
            return ListaOsiguranja;
        }

        //Metoda za dodavanje osiguranja, za parametar prima id lijeka i id osiguranja
        static public void DodajOsiguranje(int lijID, int idO)
        {
            DBCon baza = new DBCon();
            SqlCommand command = new SqlCommand("INSERT INTO PopisOsiguranihLijekova (ID_Lijek, ID_Osiguranje) VALUES (" + lijID + ", " + idO + ");");
            baza.IzvrsiUpit(command);
        }

        //metoda za brisanje osiguranja, za parametre prima id lijeka i id osiguranja
        static public void BrisiOsiguranje(int lijID, int idO)
        {
            DBCon baza = new DBCon();
            SqlCommand command = new SqlCommand("DELETE FROM PopisOsiguranihLijekova  WHERE ID_Lijek = " + lijID + " AND ID_Osiguranje = " + idO + ";");
            baza.IzvrsiUpit(command);
        }

        //datarow objekt sa podacima za PopisOsiguranihLijekova
        public PopisOsiguranihLijekova MakeOsiguranje(DataRow row)
        {
            PopisOsiguranihLijekova lije = new PopisOsiguranihLijekova();
            lije.LijekID =int.Parse( row["Naziv"].ToString());
            lije.OsiguranjeID = int.Parse(row["Osiguranje"].ToString());
            return lije;
        }
    }
}
