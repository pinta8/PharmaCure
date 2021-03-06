﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;
using System.Data.SqlClient;
using System.Data;

namespace Business_Layer
{
    //klasa napravljena od strane Krešimir Zelenika
    public class LijekRecept
    {
        public int IDLijek { get; set; }
        public string Naziv { get; set; }
        public int Kolicina { get; set; }
        public int Participacija { get; set; }
        public int KlijentID { get; set; }

        //Metoda koja vraća listu svih recepata a za parametar prima id klijenta
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
        //metoda koja sluzi za brisanje recepta, prima parametre id lijeka i id klijenta
        static public void IzbrisiRecept(int id, int idK)
        {
            DBCon baza = new DBCon();
            SqlCommand command = new SqlCommand("DELETE FROM LijekoviRecept WHERE ID_Lijeka=" + id + "AND ID_Klijent = " + idK);
            baza.IzvrsiUpit(command);
        }

        //metoda za unos recepata
        public int DodajRecept()
        {
            SqlCommand Command = new SqlCommand();
            Command.CommandType = CommandType.Text;
            Command.CommandText = "INSERT INTO LijekoviRecept (ID_Lijeka, Naziv, ID_Klijent, Kolicina, Participacija) values (@ID_Lijek, @naziv, @ID_Klijent, @kolicina, @participacija)";
            Command.Parameters.AddWithValue("@ID_Lijek", IDLijek);
            Command.Parameters.AddWithValue("@naziv", Naziv);
            Command.Parameters.AddWithValue("@ID_Klijent", KlijentID);
            Command.Parameters.AddWithValue("@kolicina", Kolicina);
            Command.Parameters.AddWithValue("@participacija", Participacija);
            DBCon DB = new DBCon();
            DB.GetCon();
            return DB.IzvrsiUpit(Command);
        }

        //datarow objekt sa podacima za LijekRecept
        public LijekRecept MakeLijekRecept(DataRow row)
        {
            LijekRecept rec = new LijekRecept();
            rec.IDLijek = int.Parse(row["ID_Lijeka"].ToString());
            rec.Naziv = row["Naziv"].ToString();
            rec.KlijentID = int.Parse(row["ID_Klijent"].ToString());
            rec.Kolicina = int.Parse(row["Kolicina"].ToString());
            rec.Participacija = int.Parse(row["Participacija"].ToString());
            return rec;
        }
    }
}
