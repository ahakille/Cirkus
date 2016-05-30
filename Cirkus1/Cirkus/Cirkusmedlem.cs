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
    public partial class Cirkusmedlem : Form
    {
        public Cirkusmedlem()
        {
            InitializeComponent();
        }

        private void abortBt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void laggtillBt_Click(object sender, EventArgs e)
        {
            medlem läggtill = new medlem();
            if (födelsedataTxt.Text == "" || enamnTxt.Text == "")
            {
                MessageBox.Show("Du måste fylla i Förnamn och Efternamn", "Felmeddelande", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool test = födelsedataTxt.Text.All(char.IsNumber);
                int leng = födelsedataTxt.Text.Length;
                if (test == false || leng != 8)
                {
                    MessageBox.Show("Åtta siffor i födelsedatumet utan bindestrek tex. 19940225", "Felmeddelande", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    läggtill.Förnamn = fnamnTxt.Text;
                    läggtill.Efternamn = enamnTxt.Text;
                    läggtill.Email = emailTxt.Text;
                    läggtill.Foto = fotoCbox.Checked;
                    läggtill.Födelsedata = Convert.ToInt32(födelsedataTxt.Text);
                    läggtill.Gata = gataTxt.Text;
                    läggtill.Kön = könCbox.Text;
                    läggtill.Medlemstyp = MedlemstypCbox.Text;
                    läggtill.Mobilnr = mobilTxt.Text;
                    läggtill.Ort = ortTxt.Text;
                    läggtill.Postnr = postTxt.Text;
                    läggtill.Telefon = telefonTxt.Text;
                    läggtill.LaggTillMedlem(läggtill.Förnamn, läggtill.Efternamn, läggtill.Födelsedata, läggtill.Kön, läggtill.Telefon, läggtill.Mobilnr, läggtill.Email, läggtill.Gata, läggtill.Postnr, läggtill.Ort, läggtill.Medlemstyp, läggtill.Foto);
                    Close();
                }
            }
        }
    }
}
