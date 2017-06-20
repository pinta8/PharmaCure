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
        //Funkcija za vraćanje svih Poslovnica iz baze za combobox
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
        //funkcija za vraćanje svih poslovnica iz baze
        static public List<Poslovnica> DohvatiPoslovnice() {
            List<Poslovnica> poslovnice = new List<Poslovnica>();
            DBCon baza = new DBCon();
            SqlCommand command = new SqlCommand("SELECT ID_Poslovnica,Naziv,Drzava,Grad,Ulica,Broj FROM Poslovnica");
            DataTable dt = baza.DohvatiDT(command);
            if (dt.Rows.Count == 0) {
                return null;
            }
            else {
                foreach (DataRow row in dt.Rows) {
                    Poslovnica p = new Poslovnica();
                    p.PoslovnicaId = (int)row["ID_Poslovnica"];
                    p.Naziv = (string)row["Naziv"];
                    p.Drzava = (string)row["Drzava"];
                    p.Grad = (string)row["Grad"];
                    p.Ulica = (string)row["Ulica"];
                    p.Broj = (int)row["Broj"];
                    poslovnice.Add(p);

                }
                return poslovnice;
            }

        }
        //funkcija za unos novih poslovnica u bazu
        static public void ZapisiPoslovnicu(Poslovnica poslovnicaUnos) {
			Poslovnica p = poslovnicaUnos;
			DBCon baza = new DBCon();
			SqlCommand command = new SqlCommand("INSERT INTO Poslovnica (Naziv,Drzava,Grad,Ulica,Broj) VALUES (@Naziv, @Drzava, @Grad, @Ulica, @Broj)");
			command.Parameters.AddWithValue("@Naziv", p.Naziv);
			command.Parameters.AddWithValue("@Drzava", p.Drzava);
			command.Parameters.AddWithValue("@Grad", p.Grad);
			command.Parameters.AddWithValue("@Ulica", p.Ulica);
			command.Parameters.AddWithValue("@Broj", p.Broj);
			baza.IzvrsiUpit(command);
		
	    }
        //funkcija za ažuriranje poslovnice
        static public void AzurirajPoslovnicu(Poslovnica poslovnicaUnos) {
            Poslovnica poslovnica = poslovnicaUnos;
            DBCon baza = new DBCon();
            SqlCommand command = new SqlCommand("UPDATE Poslovnica set Naziv=@Naziv, Drzava = @Drzava, Grad = @Grad, Ulica=@Ulica, Broj=@Broj where ID_Poslovnica = @ID_Poslovnica");
            command.Parameters.AddWithValue("@Naziv", poslovnica.Naziv);
            command.Parameters.AddWithValue("@Drzava", poslovnica.Drzava);
            command.Parameters.AddWithValue("@Grad", poslovnica.Grad);
            command.Parameters.AddWithValue("@Ulica", poslovnica.Ulica);
            command.Parameters.AddWithValue("@Broj", poslovnica.Broj);
            command.Parameters.AddWithValue("@ID_Poslovnica", poslovnica.PoslovnicaId);
            baza.IzvrsiUpit(command);

        }
        //funkcija za brisanje poslovnice
        static public void IzbrisiPoslovnicuIzBaze(Poslovnica poslovnicaUnos) {
            Poslovnica poslovnica = poslovnicaUnos;
            DBCon baza = new DBCon();
            SqlCommand command = new SqlCommand("DELETE FROM Poslovnica WHERE ID_Poslovnica=" + poslovnica.poslovnicaId);
            baza.IzvrsiUpit(command);
        }
    }
}
