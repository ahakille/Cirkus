﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus
{
    public class Träningstillfälle
    {
        public string Plats { get; set; }
        public int Datum { get; set; }
        public string Tid { get; set; }
        public string Aktivitet { get; set; }
        public int AktivitetID { get; set; }
        public int Id { get; set; }
        public int antaldeltagare { get; set; }
        
        public void LaggTillTräningstillfälle(string plats, string datum, string tid, string aktivitet)
        {
            Plats = plats;
            Datum = Convert.ToInt32(datum);
            Tid = tid;
            Aktivitet = aktivitet;

            postgres m = new postgres();
            m.SqlAdmin4("insert into träningstyp (aktivitet) values (@par1); insert into träningstillfälle (plats, tid, aktivtetsid, datum) values (@par2, @par3, currval('träningstyp_id_seq'::regclass), @par4);",Aktivitet,Plats,Tid,datum);

        }

        public override string ToString()
        {
            return  " " + Aktivitet +"   "+ Datum+"    " + Tid +"  "+Plats+ " " + antaldeltagare ;
        }

    }

    
}
