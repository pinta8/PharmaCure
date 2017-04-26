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
    public class Poslovnica
    {
		int poslovnicaId;
		string naziv;
		string drzava;
		string grad;
		string ulica;
		int broj;

		public int PoslovnicaId {
			get {
				return poslovnicaId;
			}

			set {
				poslovnicaId = value;
			}
		}

		public string Naziv {
			get {
				return naziv;
			}

			set {
				naziv = value;
			}
		}

		public string Drzava {
			get {
				return drzava;
			}

			set {
				drzava = value;
			}
		}

		public string Grad {
			get {
				return grad;
			}

			set {
				grad = value;
			}
		}

		public string Ulica {
			get {
				return ulica;
			}

			set {
				ulica = value;
			}
		}

		public int Broj {
			get {
				return broj;
			}

			set {
				broj = value;
			}
		}
		static public List<Poslovnica> DohvatiPoslovniceZaComboBox() {
			List<Poslovnica> poslovnice = new List<Poslovnica>();
			DBCon baza = new DBCon();
			SqlCommand command = new SqlCommand("SELECT ID_Poslovnica,Naziv FROM Poslovnica");
			DataTable dt = baza.DohvatiDT(command);
			if (dt.Rows.Count == 0) {
				return null;
			}
			else {
				foreach (DataRow row in dt.Rows) {
					Poslovnica p = new Poslovnica();
					p.PoslovnicaId = (int)row["ID_Poslovnica"];
					p.Naziv = (string)row["Naziv"];
					poslovnice.Add(p);
					
				}
				return poslovnice;
			}
			
		}
	}
}
