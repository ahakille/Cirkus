using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus
{
    public class Träningstillfälle
    {
        public string Plats { get; set; }
        public string Datum { get; set; }
        public string Tid { get; set; }
        public string Aktivitet { get; set; }
        public int AktivitetID { get; set; }
        public int Id { get; set; }
        public int IdTräningstyp { get; set; }

        public void LaggTillTräningstillfälle(string plats, string datum, string tid, string aktivitet)
        {
            Plats = plats;
            Datum = datum;
            Tid = tid;
            Aktivitet = aktivitet;

            postgres m = new postgres();
            m.SqlAdmin("insert into träningstyp (aktivitet) values ('" + aktivitet + "'); insert into träningstillfälle (plats, tid, aktivtetsid, datum) values ('"
            + plats + "', '" + tid + "', currval('träningstyp_id_seq'::regclass), '" + datum + "');");

        }

        public override string ToString()
        {
            return "Plats: " + Plats + " Aktivitet: " + Aktivitet;
        }

    }

    
}
