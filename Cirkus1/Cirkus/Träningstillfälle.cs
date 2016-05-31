using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus
{
    class Träningstillfälle
    {
        public string Plats { get; set; }
        public string Datum { get; set; }
        public string Tid { get; set; }
        public string Aktivitet { get; set; }

        public void LaggTillTräningstillfälle(string plats, string datum, string tid, string aktivitet)
        {
            Plats = plats;
            Datum = datum;
            Tid = tid;
            Aktivitet = aktivitet;

            postgres m = new postgres();
            m.SqlAdmin("insert into träningstyp (aktivitet) values ('" + aktivitet + "');");
            postgres t = new postgres();
            t.SqlAdmin("select max(id) from tränin");
        }
    }
}
