using System;
using System.Collections.Generic;
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
	}
}
