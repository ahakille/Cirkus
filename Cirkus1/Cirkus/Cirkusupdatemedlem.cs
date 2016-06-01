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

            //Hämtar medlemslistan
            postgres db = new postgres();
            Medlem = db.hämtamedlem("select * from medlem");
            medlemLbox.DataSource = Medlem;


        }
        
        private void abortBt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateBt_Click(object sender, EventArgs e)
        {
            

           
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
    }
}
