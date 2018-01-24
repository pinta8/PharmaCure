using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    class Akcija
    {
        public int ID { get; set; }
        public string Naziv  { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZavrsetka { get; set; }
        public double PostotakSnizenja { get; set; }
        public int LijekID { get; set; }
    }
}
