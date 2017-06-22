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
    public class Osiguranje
    {
        public int idOsiguranje { get; set; }
        public string naziv { get; set; }

        //Metoda koja vraća listu Osiguranja
        public static List<Osiguranje> DohvatiOsiguranja()
        {
            List<Osiguranje> ListaOsiguranja = new List<Osiguranje>();
            SqlCommand Command = new SqlCommand();
            Command.CommandType = CommandType.Text;
            Command.CommandText = "SELECT * FROM Osiguranje;";
            DBCon DB = new DBCon();
            DB.GetCon();
            DataTable DT = DB.DohvatiDT(Command);
            foreach (DataRow dr in DT.Rows)
            {
                Osiguranje r = new Osiguranje();
                ListaOsiguranja.Add(r.MakeOsiguranje(dr));
            }
            return ListaOsiguranja;
        }

        //DataRow Objekt sa podacima za Osiguranje
        public Osiguranje MakeOsiguranje(DataRow row)
        {
            Osiguranje lije = new Osiguranje();
            lije.idOsiguranje = int.Parse(row["ID_Osiguranje"].ToString());
            lije.naziv = row["Naziv"].ToString();
            return lije;
        }
    }
}
