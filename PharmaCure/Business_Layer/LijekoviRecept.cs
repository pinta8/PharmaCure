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
    public class LijekoviRecept
    {
        public int ID_Lijek { get; set; }
        public string Naziv { get; set; }
        public int ID_Klijent { get; set; }
        public int Kolicina { get; set; }

        public static List<LijekoviRecept> DohvatiRecepte(int pom)
        {
            List <LijekoviRecept> ListaRasadnika = new List<LijekoviRecept>();
            SqlCommand Command = new SqlCommand();
            Command.CommandType = CommandType.Text;
            Command.CommandText = "SELECT * FROM LijekoviRecept WHERE ID_Klijent = " + pom;
            DBCon DB = new DBCon();
            DB.GetCon();
            DataTable DT = DB.DohvatiDT(Command);
            foreach (DataRow dr in DT.Rows)
            {
                LijekoviRecept r = new LijekoviRecept();
                ListaRasadnika.Add(r.MakeLijekRecept(dr));
            }
            return ListaRasadnika;
        }

        public int DodajRecept()
        {
            SqlCommand Command = new SqlCommand();
            Command.CommandType = CommandType.Text;
            Command.CommandText = "INSERT INTO LijekoviRecept (ID_Lijeka, Naziv, ID_Klijent, Kolicina) values (@ID_Lijek, @naziv, @ID_Klijent, @kolicina)";
            Command.Parameters.AddWithValue("@ID_Lijek", ID_Lijek);
            Command.Parameters.AddWithValue("@naziv", Naziv);
            Command.Parameters.AddWithValue("@ID_Klijent", ID_Klijent);
            Command.Parameters.AddWithValue("@kolicina", Kolicina);
            DBCon DB = new DBCon();
            DB.GetCon();
            return DB.IzvrsiUpit(Command);
        }
        public LijekoviRecept MakeLijekRecept(DataRow row)
        {
            LijekoviRecept rec = new LijekoviRecept();
            rec.ID_Lijek = int.Parse(row["ID_Lijeka"].ToString());
            rec.Naziv = row["Naziv"].ToString();
            rec.ID_Klijent = int.Parse(row["ID_Klijent"].ToString());
            rec.Kolicina = int.Parse(row["Kolicina"].ToString());
            return rec;
        }
    }
}
