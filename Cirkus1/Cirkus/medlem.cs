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
            string f = Convert.ToString(Födelsedata);
            string fo = Convert.ToString(Foto);

            postgres m = new postgres();
            m.SqlNonQuery2("insert into medlem (förnamn, efternamn, födelsedata, kön, telefon, mobilnr, email, gata, postnr, ort, medtyp, foto) values (@par1,@par2,@par3,@par4,@par5,@par6,@par7,par8,@par9, @par10,@par11,@par12);",förnamn,Efternamn,f,kön,telefon,mobilnr,Email,Gata,Postnr,Ort,Medlemstyp,fo);
        }

        public void Nygata(string gata,string n)
        {
            Gata = gata;
            postgres m = new postgres();
            m.SqlAdmin2("update medlem set gata = @par1 where mednr = @par2;", gata, n);
        }

        public void NyttPostNr(string postnr, string n)
        {
            Postnr = postnr;
            postgres m = new postgres();
            m.SqlAdmin2("update medlem set postnr = @par1 where mednr = @par2;", postnr, n);
            
        }

        public void NyOrt(string ort, string n)
        {
            Ort = ort;
            postgres m = new postgres();
            m.SqlAdmin2("update medlem set ort = @par1 where mednr = @par2;", ort, n);
        }

        public void NyTelefon(string telefon, string n)
        {
            Telefon = telefon;
            postgres m = new postgres();
            m.SqlAdmin2("update medlem set telefon = @par1 where mednr = @par2;", telefon, n);
        }

        public void NyMobil(string mobilnr, string n)
        {
            Mobilnr = mobilnr;
            postgres m = new postgres();
            m.SqlAdmin2("update medlem set mobilnr = @par1 where mednr = @par2; ",mobilnr, n);
        }

        public void NyEmail(string email, string n)
        {
            Email = email;
            postgres m = new postgres();
            m.SqlAdmin2("update medlem set email = @par1 where mednr = @par2;",email, n);
        }

        public void NyMedlemstyp(string medlemstyp, string n)
        {
            Medlemstyp = medlemstyp;
            postgres m = new postgres();
            m.SqlAdmin2("update medlem set medtyp = @par1 where mednr = @par2;",medlemstyp,n);
        }

        public void NyttFotoval(bool foto, string n)
        {
            Foto = foto;
            string f = Convert.ToString(foto);
            postgres m = new postgres();
            m.SqlAdmin2("update medlem set foto = @par1 where mednr = @par2; ",f,n);
        }
        public void Nyttförnamn(string namn, string n)
        {
            
            postgres m = new postgres();
            m.SqlAdmin2("update medlem set förnamn = @par1 where mednr = @par2; ",namn,n);
        }
        public void Nyttefternamnn(string namn, string n)
        {

            postgres m = new postgres();
            m.SqlAdmin2("update medlem set efternamn = @par1 where mednr = @par2;",namn , n);
        }

        public void RaderaMedlem(int medlemNr)
        {
            Medlemnr = medlemNr;
            string n = Convert.ToString(medlemNr);
            postgres m = new postgres();
            m.SqlAdmin1("delete from deltar where medlem = @par1 ; " +
            "delete from ansvararöver where medlem = @par1 ; " +
            "delete from ingåri where medlem = @par1 ; " +
            "delete from leder where medlem = @par1 ; " +
            "delete from målsmanför where målsman = @par1 " + "or barn = @par1 ; " +
            "delete from tränar where medlem = @par1 ; " +
            "delete from medlem where mednr = @par1; ",n);
        }

        public override string ToString()
        {
            return  Medlemnr + ", " + " " + Förnamn + " " + Efternamn;
        }

        
    }

  
}
