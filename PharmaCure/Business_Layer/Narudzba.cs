using Data_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class Narudzba
    {
        int poslovnicaId;
        int djelatnikId;
        string nazivLijeka;
        int kolicina;
        int lijekId;

        public int PoslovnicaId {
            get {
                return poslovnicaId;
            }

            set {
                poslovnicaId = value;
            }
        }

        public int DjelatnikId {
            get {
                return djelatnikId;
            }

            set {
                djelatnikId = value;
            }
        }

        public string NazivLijeka {
            get {
                return nazivLijeka;
            }

            set {
                nazivLijeka = value;
            }
        }

        public int Kolicina {
            get {
                return kolicina;
            }

            set {
                kolicina = value;
            }
        }

        public int LijekId {
            get {
                return lijekId;
            }

            set {
                lijekId = value;
            }
        }

        static public void ZapisiNarudzbu(Narudzba nar) {
       
            Narudzba narudzba = nar;
            DBCon baza = new DBCon();
            
            SqlCommand command = new SqlCommand("INSERT INTO Narudzba (ID_Narudzbe,ID_Poslovnice,ID_Djelatnika,NazivLijeka,Kolicina,ID_Lijek) VALUES (((SELECT TOP 1 ID_Narudzbe FROM Narudzba order by 1 desc)+1),@ID_Poslovnice, @ID_Djelatnika, @NazivLijeka, @Kolicina, @ID_Lijek)");
            
            command.Parameters.AddWithValue("@ID_Poslovnice", narudzba.poslovnicaId);
            command.Parameters.AddWithValue("@ID_Djelatnika", narudzba.djelatnikId);
            command.Parameters.AddWithValue("@NazivLijeka", narudzba.nazivLijeka);
            command.Parameters.AddWithValue("@Kolicina", narudzba.kolicina);
            command.Parameters.AddWithValue("@ID_Lijek", narudzba.lijekId);
            baza.IzvrsiUpit(command);
        }
    }
}
