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
    public class Racun
    {
        public int IDRacun { get; set; }
        public DateTime vrijeme { get; set; }
        public int djelatnik { get; set; }
        public int klijent { get; set; }
        public int stanje { get; set; }

        //Metoda koja vraća listu računa, za parametre prima id klijenta i id stanja
        static public Racun NadjiRacun(int klijent, int stanje)
        {
            Racun r = new Racun();
            SqlCommand Command = new SqlCommand();
            Command.CommandType = CommandType.Text;
            Command.CommandText = "SELECT * FROM Racun WHERE ID_Klijent = " + klijent + " AND ID_Stanje = "+ stanje +";";
            DBCon DB = new DBCon();
            DB.GetCon();
            DataTable DT = DB.DohvatiDT(Command);
            foreach (DataRow dr in DT.Rows)
            {
                Racun ra = new Racun();
                r = ra.MakeRacun(dr);
            }
            return r;
        }

        //metoda za dodavanje novog računa, za parametar prima objekt Racun
        static public void DodajRacun(Racun noviRacun)
        {
            Racun rac = noviRacun;
            DBCon baza = new DBCon();
            SqlCommand command = new SqlCommand("INSERT INTO Racun ( Vrijeme, Djelatnik, ID_Klijent, ID_Stanje) VALUES (@vrijeme, @djelatnik, @klijent, @stanje)");
            command.Parameters.AddWithValue("@vrijeme", rac.vrijeme);
            command.Parameters.AddWithValue("@djelatnik", rac.djelatnik);
            command.Parameters.AddWithValue("@klijent", rac.klijent);
            command.Parameters.AddWithValue("@stanje", rac.stanje);
            baza.IzvrsiUpit(command);
        }

        //datarow objekt sa podacima za Racun
        public Racun MakeRacun(DataRow row)
        {
            Racun racu = new Racun();
            racu.IDRacun = int.Parse(row["ID_Racun"].ToString());
            racu.vrijeme = DateTime.Parse(row["Vrijeme"].ToString());
            racu.djelatnik = int.Parse(row["Djelatnik"].ToString());
            racu.klijent = int.Parse(row["ID_Klijent"].ToString());
            racu.stanje = int.Parse(row["ID_Stanje"].ToString());
            return racu;
        }
    }
}

