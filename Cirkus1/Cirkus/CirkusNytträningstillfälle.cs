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
    public partial class CirkusNytträningstillfälle : Form
    {
        List<Träningsgrupp> grupp = new List<Träningsgrupp>();
        List<medlem> medlem = new List<medlem>();
        List<medlem> tillagda = new List<medlem>();
        List<medlem> tränare = new List<medlem>();
        List<medlem> tränarecbox = new List<medlem>();
        medlem aktuelltränare = new medlem();
        medlem aktuellmedlem = new medlem();
        Träningsgrupp aktuellgrupp = new Träningsgrupp();

        public CirkusNytträningstillfälle()
        {
            InitializeComponent();
            fillcombo();
        }
        void fillcombo()
        {
            postgres db = new postgres();
            grupp = db.hämtaträningsgrupp("select * from träningsgrupp");
            CboxTräningsgrupper.DataSource = grupp;


        }

        private void CboxTräningsgrupper_SelectedIndexChanged(object sender, EventArgs e)
        {
            aktuellgrupp = (Träningsgrupp)CboxTräningsgrupper.SelectedItem;
            if (aktuellgrupp != null)
            {
                
            }
        }

        private void NyttträningstillfälleBt_Click(object sender, EventArgs e)
        {
            bool test = TxtBdatum.Text.All(char.IsNumber);
            int leng = TxtBdatum.Text.Length;
            if (test== false||leng !=8 || TxtBox.Text == "HH-MM")
            {
                MessageBox.Show("Du måste fylla i datum och tid korrekt", "Felmeddelande", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtTypav.Text == "" || CboxPlats.Text == "")
            {
                MessageBox.Show("Du måste fylla i träningsplats och träningstyp ", "Felmeddelande", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                läggtillmedlemBt.Enabled = true;
                NyttträningstillfälleBt.Enabled = false;
                Träningstillfälle pt = new Träningstillfälle();
                pt.LaggTillTräningstillfälle(CboxPlats.Text, TxtBdatum.Text, TxtBox.Text, TxtTypav.Text);
                Cboxtränare.Enabled = true;
                BtNytrännare.Enabled = true;
                postgres db = new postgres();
                tränarecbox = db.hämtamedlem("select * from medlem where mednr in( select medlem from tränar where träningsgrupp ='" + aktuellgrupp.Gruppid + "')");
                Cboxtränare.DataSource = tränarecbox;
                postgres db2 = new postgres();
                medlem = db2.hämtamedlem("select * from medlem where mednr in( select medlem from ingåri where träningsgrupp ='" + aktuellgrupp.Gruppid + "') ");
                MedlmLbox.DataSource = medlem;
            }



        }

        private void AvbrytBt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void läggtillmedlemBt_Click(object sender, EventArgs e)
        {
            int t = tillagda.Count;
            bool f = false;
            for (int n = 0; n < t; n++)
            {
                if (aktuellmedlem == tillagda[n])
                {
                    f = true;
                }
            }
            if (f == false)
            {
                tillagda.Add(aktuellmedlem);
                LboxDeltagit.DataSource = null;
                LboxDeltagit.DataSource = tillagda;
                postgres db = new postgres();
                db.SqlAdmin2("insert into deltar (träningstillfalle, medlem, träningsgrupp) values (currval('träningstillfälle_id_seq'::regclass), @par1, @par2);",Convert.ToString(aktuellmedlem.Medlemnr),Convert.ToString(aktuellgrupp.Gruppid));
            }

        }

        private void MedlmLbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            aktuellmedlem = (medlem)MedlmLbox.SelectedItem;
        }

        private void BtNytrännare_Click(object sender, EventArgs e)
        {
            postgres db = new postgres();
            tränare.Add(aktuelltränare);
            LboxTränare.DataSource = null;
            LboxTränare.DataSource = tränare;
            db.SqlAdmin2("insert into leder(medlem,träningstillfälle) values(@par1, @par2)", Convert.ToString(aktuelltränare.Medlemnr), Convert.ToString(aktuellgrupp.Gruppid));
            
        }

        private void Cboxtränare_SelectedIndexChanged(object sender, EventArgs e)
        {
            aktuelltränare = (medlem)Cboxtränare.SelectedItem;
        }

        private void BtFinish_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
