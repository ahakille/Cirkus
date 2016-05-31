using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus
{
    class Träningsgrupp
    {
        public int Gruppid { get; set; }
        public string Gruppnamn { get; set; }

        public void LaggTillTräningsGrupp(int pgruppid, string pgruppnamn)
        {
            Gruppid = pgruppid;
            Gruppnamn = pgruppnamn;


            postgres m = new postgres();
            m.SqlAdmin("insert into träningsgrupp (namn) values ('" + Gruppnamn + "');");
            postgres t = new postgres();
            t.SqlAdmin("select max(gruppid) from träningsgrupp");
        }
        public void LäggTillTränare ()
        {
            postgres m = new postgres();
            m.SqlAdmin("");
        }
    }
}
