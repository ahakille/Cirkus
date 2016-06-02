using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus
{
       public class medlem
    {
        public int Medlemnr { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public int Födelsedata { get; set; }
        public string Kön { get; set; }
        public string Telefon { get; set; }
        public string Mobilnr { get; set; }
        public string Email { get; set; }
        public string Gata { get; set; }
        public string Postnr { get; set; }
        public string Ort { get; set; }
        public string Medlemstyp { get; set; }
        public bool Foto { get; set; }

        public void LaggTillMedlem(string förnamn, string efternamn, int födelsedata, string kön, string telefon, string mobilnr, string email, string gata, string postnr,
            string ort, string medlemstyp, bool foto)
        {
            Förnamn = förnamn;
            Efternamn = efternamn;
            Födelsedata = födelsedata;
            Kön = kön;
            Telefon = telefon;
            Mobilnr = mobilnr;
            Email = email;
            Gata = gata;
            Postnr = postnr;
            Ort = ort;
            Medlemstyp = medlemstyp;
            Foto = foto;

            postgres m = new postgres();
            m.SqlAdmin("insert into medlem (förnamn, efternamn, födelsedata, kön, telefon, mobilnr, email, gata, postnr, ort, medtyp, foto) values ('" 
            + förnamn + "', '" + efternamn + "', " + födelsedata + ", '" + kön + "', '" + telefon + "', '" + mobilnr + "', '" + email + "', '" + gata + "', '"
            + postnr + "', '" + ort + "', '" + medlemstyp + "', " + foto + ");");
        }

        public void Nygata(string gata)
        {
            Gata = gata;
            postgres m = new postgres();
            m.SqlAdmin("update medlem set gata = '" + gata + "' where mednr = " + Medlemnr + ";");
        }

        public void NyttPostNr(string postnr)
        {
            Postnr = postnr;
            postgres m = new postgres();
            m.SqlAdmin("update medlem set postnr = '" + postnr + "' where mednr = " + Medlemnr + ";");
            
        }

        public void NyOrt(string ort)
        {
            Ort = ort;
            postgres m = new postgres();
            m.SqlAdmin("update medlem set ort = '" + ort + "' where mednr = " + Medlemnr + ";");
        }

        public void NyTelefon(string telefon)
        {
            Telefon = telefon;
            postgres m = new postgres();
            m.SqlAdmin("update medlem set telefon = '" + telefon + "' where mednr = " + Medlemnr + ";");
        }

        public void NyMobil(string mobilnr)
        {
            Mobilnr = mobilnr;
            postgres m = new postgres();
            m.SqlAdmin("update medlem set mobilnr = '" + mobilnr + "' where mednr = " + Medlemnr + ";");
        }

        public void NyEmail(string email)
        {
            Email = email;
            postgres m = new postgres();
            m.SqlAdmin("update medlem set email = '" + email + "' where mednr = " + Medlemnr + ";");
        }

        public void NyMedlemstyp(string medlemstyp)
        {
            Medlemstyp = medlemstyp;
            postgres m = new postgres();
            m.SqlAdmin("update medlem set medtyp = '" + medlemstyp + "' where mednr = " + Medlemnr + ";");
        }

        public void NyttFotoval(bool foto)
        {
            Foto = foto;
            postgres m = new postgres();
            m.SqlAdmin("update medlem set foto = " + foto + " where mednr = " + Medlemnr + ";");
        }
        public void Nyttförnamn()
        {
            
            postgres m = new postgres();
            m.SqlAdmin("update medlem set förnamn = '" + Förnamn + "' where mednr = " + Medlemnr + ";");
        }
        public void Nyttefternamnn()
        {

            postgres m = new postgres();
            m.SqlAdmin("update medlem set efternamn = '" + Efternamn + "' where mednr = " + Medlemnr + ";");
        }

        public void RaderaMedlem(int medlemNr)
        {
            Medlemnr = medlemNr;
            postgres m = new postgres();
            m.SqlAdmin("delete from deltar where medlem = " + medlemNr + " ; " +
            "delete from ansvararöver where medlem = " + medlemNr + " ; " +
            "delete from ingåri where medlem = " + medlemNr + " ; " +
            "delete from leder where medlem = " + medlemNr + " ; " +
            "delete from målsmanför where målsman = " + medlemNr + " ; " + "or barn = " + medlemNr + " ; " +
            "delete from tränar where medlem = " + medlemNr + " ; " +
            "delete from medlem where mednr = " + medlemNr + ";");
        }

        public override string ToString()
        {
            return "  " + Medlemnr + ", " + " " + Förnamn + " " + Efternamn;
        }

        
    }

  
}
