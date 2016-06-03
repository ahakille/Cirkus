using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cirkus
{
    public partial class Cirkusupdatemedlem : Form
    {
        public List<medlem> Medlem = new List<medlem>();
        medlem aktuellmedlem = new medlem();
        public Cirkusupdatemedlem()
        {
            InitializeComponent();
            hämtalistan();


        }
        private void hämtalistan()
        {
            //Hämtar medlemslistan
            postgres db = new postgres();
            Medlem = db.hämtamedlem("select * from medlem");
            medlemLbox.DataSource = null;
            medlemLbox.DataSource = Medlem;
        }
        private void abortBt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateBt_Click(object sender, EventArgs e)
        {
            string n = Convert.ToString(aktuellmedlem.Medlemnr);
            if (aktuellmedlem.Förnamn != fnamnTxt.Text)
            {
                aktuellmedlem.Förnamn = fnamnTxt.Text;
                aktuellmedlem.Nyttförnamn(aktuellmedlem.Förnamn, n);
            }
            if (aktuellmedlem.Efternamn != enamnTxt.Text)
            {
                aktuellmedlem.Efternamn = enamnTxt.Text;
                aktuellmedlem.Nyttefternamnn(aktuellmedlem.Efternamn, n);
            }
            if (aktuellmedlem.Telefon != telefonTxt.Text)
            {
                aktuellmedlem.Telefon = telefonTxt.Text;
                aktuellmedlem.NyTelefon(aktuellmedlem.Telefon,n);
            }
            if (aktuellmedlem.Mobilnr != mobilTxt.Text)
            {
                aktuellmedlem.Mobilnr = mobilTxt.Text;
                aktuellmedlem.NyMobil(aktuellmedlem.Mobilnr,n);
            }
            if (aktuellmedlem.Gata != gataTxt.Text)
            {
                aktuellmedlem.Gata = gataTxt.Text;
                aktuellmedlem.Nygata(aktuellmedlem.Gata, n);
            }
            if (aktuellmedlem.Postnr != postTxt.Text)
            {
                aktuellmedlem.Postnr = postTxt.Text;
                aktuellmedlem.NyttPostNr(aktuellmedlem.Postnr, n);
            }
            if (aktuellmedlem.Ort != ortTxt.Text)
            {
                aktuellmedlem.Ort = ortTxt.Text;
                aktuellmedlem.Nygata(aktuellmedlem.Ort, n);
            }
            if (aktuellmedlem.Email != emailTxt.Text)
            {
                aktuellmedlem.Email = emailTxt.Text;
                aktuellmedlem.NyEmail(aktuellmedlem.Email,n);
            }
            if (aktuellmedlem.Medlemstyp != MedlemstypCbox.Text)
            {
                aktuellmedlem.Medlemstyp = MedlemstypCbox.Text;
                aktuellmedlem.NyMedlemstyp(aktuellmedlem.Medlemstyp,n);
            }
            if (aktuellmedlem.Foto != fotoCbox.Checked)
            {
                aktuellmedlem.Foto = fotoCbox.Checked;
                aktuellmedlem.NyttFotoval(aktuellmedlem.Foto,n);
            }
            

            hämtalistan();
        }

        private void laggmedlemBt_Click(object sender, EventArgs e)
        {
            Cirkusmedlem läggtill = new Cirkusmedlem(); // form för lägga till medlem
            läggtill.Owner = this; // Bestämmer huvudform
            läggtill.ShowDialog(); // Öppnar form Lägg till medlem
        }

        private void medlemLbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            aktuellmedlem = (medlem)medlemLbox.SelectedItem;
            if (aktuellmedlem != null)
            {
                fnamnTxt.Text = aktuellmedlem.Förnamn;
                enamnTxt.Text = aktuellmedlem.Efternamn;
                födelsedataTxt.Text = Convert.ToString(aktuellmedlem.Födelsedata);
                telefonTxt.Text = aktuellmedlem.Telefon;
                mobilTxt.Text = aktuellmedlem.Mobilnr;
                gataTxt.Text = aktuellmedlem.Gata;
                postTxt.Text = aktuellmedlem.Postnr;
                ortTxt.Text = aktuellmedlem.Ort;
                emailTxt.Text = aktuellmedlem.Email;
                könCbox.Text = aktuellmedlem.Kön;
                MedlemstypCbox.Text = aktuellmedlem.Medlemstyp;
                fotoCbox.Checked = aktuellmedlem.Foto;
            }
        }

        private void Bttabort_Click(object sender, EventArgs e)
        {
            aktuellmedlem.RaderaMedlem(aktuellmedlem.Medlemnr);
            hämtalistan();
        }
    }
}
