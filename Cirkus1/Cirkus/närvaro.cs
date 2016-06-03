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
            string g = Convert.ToString(GruppID);

            postgres n = new postgres();
            n.SqlAdmin1("select g.namn,t.datum, t.tid, a.aktivitet, t.id from träningstillfälle t, deltar d, träningsgrupp g, träningstyp a where g.gruppid = @par1 and d.träningsgrupp = g.gruppid and t.id = d.träningstillfalle and a.id = t.aktivtetsid; ", g);
        }

        public override string ToString()
        {
            return Medlemnr +", " + Förnamn + " " + Efternamn + ", " + Födelsedata;
        }
    }
}
