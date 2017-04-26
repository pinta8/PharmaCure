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
    public class Zaposlenik
    {
		int zaposlenikId;
		string korisnickoIme;
		string lozinka;
		int poslovnicaId;

		public string KorisnickoIme {
			get {
				return korisnickoIme;
			}

			set {
				korisnickoIme = value;
			}
		}

		public string Lozinka {
			get {
				return lozinka;
			}

			set {
				lozinka = value;
			}
		}

		public int PoslovnicaId {
			get {
				return poslovnicaId;
			}

			set {
				poslovnicaId = value;
			}
		}

		public int ZaposlenikId {
			get {
				return zaposlenikId;
			}

			set {
				zaposlenikId = value;
			}
		}
		
		static public Zaposlenik DohvatiZaposlenika(string korisnickoIme, string lozinka) {
			DBCon baza = new DBCon();
			SqlCommand command = new SqlCommand("SELECT ID_Djelatnika,Ime,Lozinka,ID_Poslovnice FROM Djelatnik WHERE Ime='" + korisnickoIme+"' AND Lozinka = '"+lozinka+"'");
			DataTable dt = baza.DohvatiDT(command);
			if(dt.Rows.Count == 0) {
				return null;
			}
			else {
				Zaposlenik z = new Zaposlenik();
				z.zaposlenikId = (int)dt.Rows[0]["ID_Djelatnika"];
				z.korisnickoIme = (string)dt.Rows[0]["Ime"];
				z.lozinka = (string)dt.Rows[0]["Lozinka"];
				z.poslovnicaId = (int)dt.Rows[0]["ID_Poslovnice"];
				return z;
			}		
		}
		static public void ZapisiZaposlenika(Zaposlenik zaposlenikUnos) {
			Zaposlenik zaposlenik = zaposlenikUnos;
			DBCon baza = new DBCon();
			SqlCommand command=new SqlCommand("INSERT INTO Djelatnik (Ime,Lozinka,ID_Poslovnice) VALUES (@Ime, @Lozinka, @ID_Poslovnice)");
			command.Parameters.AddWithValue("@Ime", zaposlenik.KorisnickoIme);
			command.Parameters.AddWithValue("@Lozinka", zaposlenik.Lozinka);
			command.Parameters.AddWithValue("@ID_Poslovnice", zaposlenik.PoslovnicaId);
			baza.IzvrsiUpit(command);
		}
	}
}
