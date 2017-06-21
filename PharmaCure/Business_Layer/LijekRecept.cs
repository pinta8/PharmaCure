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
    public class LijekRecept
    {
        public int ID_Lijek { get; set; }
        public string Naziv { get; set; }
        public int ID_Klijent { get; set; }
        public int Kolicina { get; set; }
        public int Participacija { get; set; }

        public static List<LijekRecept> DohvatiRecepte(int pom)
        {
            List <LijekRecept> ListaLijekova = new List<LijekRecept>();
            SqlCommand Command = new SqlCommand();
            Command.CommandType = CommandType.Text;
            Command.CommandText = "SELECT * FROM LijekoviRecept WHERE ID_Klijent = " + pom;
            DBCon DB = new DBCon();
            DB.GetCon();
            DataTable DT = DB.DohvatiDT(Command);
            foreach (DataRow dr in DT.Rows)
            {
                LijekRecept r = new LijekRecept();
                ListaLijekova.Add(r.MakeLijekRecept(dr));
            }
            return ListaLijekova;
        }

        static public void IzbrisiRecept(int id, int idK)
        {
            DBCon baza = new DBCon();
            SqlCommand command = new SqlCommand("DELETE FROM LijekoviRecept WHERE ID_Lijeka=" + id + "AND ID_Klijent = " + idK);
            baza.IzvrsiUpit(command);
        }

        public int DodajRecept()
        {
            SqlCommand Command = new SqlCommand();
            Command.CommandType = CommandType.Text;
            Command.CommandText = "INSERT INTO LijekoviRecept (ID_Lijeka, Naziv, ID_Klijent, Kolicina, Participacija) values (@ID_Lijek, @naziv, @ID_Klijent, @kolicina, @participacija)";
            Command.Parameters.AddWithValue("@ID_Lijek", ID_Lijek);
            Command.Parameters.AddWithValue("@naziv", Naziv);
            Command.Parameters.AddWithValue("@ID_Klijent", ID_Klijent);
            Command.Parameters.AddWithValue("@kolicina", Kolicina);
            Command.Parameters.AddWithValue("@participacija", Participacija);
            DBCon DB = new DBCon();
            DB.GetCon();
            return DB.IzvrsiUpit(Command);
        }
        public LijekRecept MakeLijekRecept(DataRow row)
        {
            LijekRecept rec = new LijekRecept();
            rec.ID_Lijek = int.Parse(row["ID_Lijeka"].ToString());
            rec.Naziv = row["Naziv"].ToString();
            rec.ID_Klijent = int.Parse(row["ID_Klijent"].ToString());
            rec.Kolicina = int.Parse(row["Kolicina"].ToString());
            rec.Participacija = int.Parse(row["Participacija"].ToString());
            return rec;
        }
    }
}
