using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus
{
    public class närvaro : medlem  
    {
        public int GruppID { get; set; }

        public void GetGrupptillfälle(int gruppID)
        {
            GruppID = gruppID;

            postgres n = new postgres();
            n.SqlAdmin("select g.namn,t.datum, t.tid, a.aktivitet, t.id from träningstillfälle t, deltar d, träningsgrupp g, träningstyp a where g.gruppid = " + 6 + " and d.träningsgrupp = g.gruppid and t.id = d.träningstillfalle and a.id = t.aktivtetsid; ");
        }

        public override string ToString()
        {
            return Medlemnr +", " + Förnamn + " " + Efternamn + ", " + Födelsedata;
        }
    }
}
