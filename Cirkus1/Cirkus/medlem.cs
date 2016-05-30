using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus
{
    [Serializable]
    public class medlem
    {
        public int medlemnr { get; set; }
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
        }

        public void Nygata(string gata)
        {
            Gata = gata;
        }

        public void NyttPostNr(string postnr)
        {
            Postnr = postnr;
        }

        public void NyOrt(string ort)
        {
            Ort = ort;
        }

        public void NyTelefon(string telefon)
        {
            Telefon = telefon;
        }

        public void NyMobil(string mobilnr)
        {
            Mobilnr = mobilnr;
        }

        public void NyEmail(string email)
        {
            Email = email;
        }

        public void NyMedlemstyp(string medlemstyp)
        {
            Medlemstyp = medlemstyp;
        }

        public void NyttFotoval(bool foto)
        {
            Foto = foto;
        }


    }

  
}
