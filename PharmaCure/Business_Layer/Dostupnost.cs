using Data_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    //Klasa napravljena od strane Marina Bulić
    public class Dostupnost
    {
        public int PoslovnicaID { get; set; }
        public int LijekID { get; set; }
        public int Kolicina { get; set; }
        //pravimo objekt klase Dostupnost
        //public Dostupnost NapraviLijek(DataRow row) {
        //    Dostupnost dostupnost = new Dostupnost();
        //    dostupnost.PoslovnicaID = row["Poslovnica"].ToString();
        //    dostupnost.LijekID = row["LijekID"].ToString();
        //    dostupnost.Kolicina = int.Parse(row["Kolicina_skladiste"].ToString());
        //    return dostupnost;
        //}
        ////dohvacamo sve dostupne lijekove odabrane poslovnice
        //public static List<Dostupnost> DohvatiLijekovePoslovnice(int idPoslovnice) {
        //    List<Dostupnost> listaLijekova = new List<Dostupnost>();
        //    SqlCommand Command = new SqlCommand();
        //    Command.CommandType = CommandType.Text;
        //    Command.CommandText = "SELECT l.Naziv,l.Kratki_opis,d.Kolicina_skladiste FROM Lijekovi l, Dostupnost d WHERE l.ID_Lijek=d.Lijekovi_ID AND d.Poslovnica_ID=" + idPoslovnice;
        //    DBCon DB = new DBCon();
        //    DB.GetCon();
        //    DataTable DT = DB.DohvatiDT(Command);
        //    foreach (DataRow dr in DT.Rows) {
        //        Dostupnost r = new Dostupnost();
        //        listaLijekova.Add(r.NapraviLijek(dr));
        //    }
        //    return listaLijekova;
        //}
        ////definiramo kako ce nam se ispisivat podaci u textboxu kada pozove ToString
        //public override string ToString() {
        //    return "Naziv: "+naziv +Environment.NewLine +"Kolicina: " + kolicina + Environment.NewLine+Environment.NewLine;
        //}
    }
}
