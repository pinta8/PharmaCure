using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer {
    public class StavkaNarudzbe {
        int idLijeka;
        int idNarudzbe;
        int kolicina;

        public int IdLijeka {
            get {
                return idLijeka;
            }

            set {
                idLijeka = value;
            }
        }

        public int IdNarudzbe {
            get {
                return idNarudzbe;
            }

            set {
                idNarudzbe = value;
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
    }
}
