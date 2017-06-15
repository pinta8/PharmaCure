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
    public class Racun
    {
        public DateTime vrijeme { get; set; }
        public int djelatnik { get; set; }
        public int klijent { get; set; }
        public int stanje { get; set; }

        static public void DodajRacun(Racun noviRacun)
        {
            Racun rac = noviRacun;
            DBCon baza = new DBCon();
            SqlCommand command = new SqlCommand("INSERT INTO Racun ( Vrijeme, Djelatnik, Klijent, Stanje) VALUES (@vrijeme, @djelatnik, @klijent, @stanje)");
            command.Parameters.AddWithValue("@vrijeme", rac.vrijeme);
            command.Parameters.AddWithValue("@djelatnik", rac.djelatnik);
            command.Parameters.AddWithValue("@klijent", rac.klijent);
            command.Parameters.AddWithValue("@stanje", rac.stanje);
            baza.IzvrsiUpit(command);
        }
    }
}

