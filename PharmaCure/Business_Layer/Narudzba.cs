using Data_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_Layer
{
    public class Narudzba
    {
        int poslovnicaId;
        int djelatnikId;

        int lijekId;

        List<StavkaNarudzbe> stavke;
        
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


        public int LijekId {
            get {
                return lijekId;
            }

            set {
                lijekId = value;
            }
        }

        public List<StavkaNarudzbe> Stavke {
            get {
                return stavke;
            }

            set {
                stavke = value;
            }
        }
        //zapisujemo narudžbu i stavke narudžbe u bazu
        static public void ZapisiNarudzbu(Narudzba nar) {
       
            Narudzba narudzba = nar;
            DBCon baza = new DBCon();
            
            SqlCommand command = new SqlCommand("INSERT INTO Narudzba  (ID_Narudzbe,ID_Poslovnice,ID_Djelatnika) OUTPUT INSERTED.ID_Narudzbe VALUES (((SELECT TOP 1 ID_Narudzbe FROM Narudzba order by 1 desc)+1),@ID_Poslovnice, @ID_Djelatnika)");
            
            command.Parameters.AddWithValue("@ID_Poslovnice", narudzba.poslovnicaId);
            command.Parameters.AddWithValue("@ID_Djelatnika", narudzba.djelatnikId);
           
            int nar_id = (int)baza.DohvatiVrijednost(command);

            SqlCommand naredba = new SqlCommand("INSERT INTO StavkeNarudzbe (ID_Lijek, ID_Narudzbe, kolicina) VALUES ");
            for(int i=0; i<nar.Stavke.Count; i++) {
                StavkaNarudzbe sn = nar.Stavke[i];
                naredba.CommandText += "(";
                naredba.CommandText += "@ID_Lijek" + i+",";
                naredba.CommandText += "@ID_Narudzbe" + i + ",";
                naredba.CommandText += "@kolicina" + i + ")";
                naredba.Parameters.AddWithValue("@ID_Lijek" + i, sn.IdLijeka);
                naredba.Parameters.AddWithValue("@ID_Narudzbe" + i, nar_id);
                naredba.Parameters.AddWithValue("@kolicina" + i, sn.Kolicina);
                if (i != nar.Stavke.Count - 1)
                    naredba.CommandText += ",";

            }
            baza.IzvrsiUpit(naredba);

        }
    }
}
