using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus
{
    public class Ansvar
    {
        public int AnsvarsID { get; set; }
        public string Ansvarsområde { get; set; }

        public void LaggTillAnsvarsområde(string ansvarsområde)
        {
            Ansvarsområde = ansvarsområde;

            postgres a = new postgres();

            a.SqlAdmin("insert into ansvarsområde (ansvar) values ('" + ansvarsområde + "');");
        }
    }
}
