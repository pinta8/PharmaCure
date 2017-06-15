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
    public class Stanje
    {
        public int id { get; set; }
        public string naziv { get; set; }

        public static List<Stanje> DohvatiStanja()
        {
            List<Stanje> ListaStanja = new List<Stanje>();
            SqlCommand Command = new SqlCommand();
            Command.CommandType = CommandType.Text;
            Command.CommandText = "SELECT * FROM Stanja";
            DBCon DB = new DBCon();
            DB.GetCon();
            DataTable DT = DB.DohvatiDT(Command);
            foreach (DataRow dr in DT.Rows)
            {
                Stanje r = new Stanje();
                ListaStanja.Add(r.MakeStanje(dr));
            }
            return ListaStanja;
        }
        public Stanje MakeStanje(DataRow row)
        {
            Stanje lije = new Stanje();
            lije.id = int.Parse(row["ID_Stanje"].ToString());
            lije.naziv = row["Naziv"].ToString();
            return lije;
        }
    }
}
