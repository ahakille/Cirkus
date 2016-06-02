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
    public partial class Cirkusträningsgrupp : Form
    {
        List<Träningsgrupp> grupp = new List<Träningsgrupp>();
        Träningsgrupp aktuellgrupp = new Träningsgrupp();
        medlem aktuellmedlem = new medlem();
        medlem aktuelltränare = new medlem();
        List<medlem> medlem = new List<medlem>();
        List<medlem> tränare = new List<medlem>();
        public Cirkusträningsgrupp()
        {
            InitializeComponent();
            Fillcombo();
        }
        void Fillcombo()
        {
            
            postgres db = new postgres();
            grupp=db.hämtaträningsgrupp("select * from träningsgrupp");
            TräningsgruppCbox.DataSource = grupp;
            postgres db2 = new postgres();
            postgres db3 = new postgres();
            medlem = db2.hämtamedlem("select * from medlem");
            tränare = db3.hämtamedlem("select * from medlem");
            NymedlemCbox.DataSource = medlem;
            NytränareCbox.DataSource = tränare;
        }

        private void TräningsgruppCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            aktuellgrupp = (Träningsgrupp)TräningsgruppCbox.SelectedItem;
                if (aktuellgrupp != null)
            {
                postgres db = new postgres();
                postgres db2 = new postgres();
                medlem= db.hämtamedlem("select * from medlem where mednr in( select medlem from ingåri where träningsgrupp ='"+aktuellgrupp.Gruppid+"') ");
                MedlmLbox.DataSource = medlem;
                tränare= db2.hämtamedlem("select * from medlem where mednr in( select medlem from tränar where träningsgrupp ='" + aktuellgrupp.Gruppid + "') ");
                tränareLbox.DataSource = tränare;
            }
        }

        private void NyGruppBt_Click(object sender, EventArgs e)
        {

            Nyträningsgrupp läggtill = new Nyträningsgrupp(); // form för lägga till medlem
            läggtill.Owner = this; // Bestämmer huvudform
            läggtill.ShowDialog(); // Öppnar form Lägg till medlem
            Fillcombo();
        }

        private void nymedlemBt_Click(object sender, EventArgs e)
        {
            postgres db = new postgres();
            
            db.SqlAdmin("insert into ingåri(medlem,träningsgrupp) values('" + aktuellmedlem.Medlemnr + "','" + aktuellgrupp.Gruppid + "')");
        }

        private void NymedlemCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            aktuellmedlem = (medlem)NymedlemCbox.SelectedItem;
            if (aktuellmedlem != null)
            {
                
            }

        }

        private void abortBt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NytränareBt_Click(object sender, EventArgs e)
        {
            postgres db = new postgres();
            db.SqlAdmin("insert into tränar(medlem,träningsgrupp) values('" + aktuelltränare.Medlemnr + "','" + aktuellgrupp.Gruppid + "')");
        }

        private void NytränareCbox_SelectedIndexChanged(object sender, EventArgs e)
        {

            aktuelltränare = (medlem)NytränareCbox.SelectedItem;


        }

        private void förnamnLb_Click(object sender, EventArgs e)
        {
            medlem.Sort(delegate (medlem x, medlem y)
            {
                return x.Förnamn.CompareTo(y.Förnamn);

            });
            MedlmLbox.DataSource = null;
            MedlmLbox.DataSource = medlem;
        }

        private void MedlNrLb_Click(object sender, EventArgs e)
        {
            medlem.Sort(delegate (medlem x, medlem y)
            {
                return x.Medlemnr.CompareTo(y.Medlemnr);

            });
            MedlmLbox.DataSource = null;
            MedlmLbox.DataSource = medlem;
        }

        private void Mednr2Lb_Click(object sender, EventArgs e)
        {
            medlem.Sort(delegate (medlem x, medlem y)
            {
                return x.Medlemnr.CompareTo(y.Medlemnr);

            });
            tränareLbox.DataSource = null;
            tränareLbox.DataSource = medlem;
        }

        private void Förnamn2Lb_Click(object sender, EventArgs e)
        {
            medlem.Sort(delegate (medlem x, medlem y)
            {
                return x.Förnamn.CompareTo(y.Förnamn);

            });
            tränareLbox.DataSource = null;
            tränareLbox.DataSource = medlem;
        }
    }
}
