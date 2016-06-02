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
        medlem aktuellmedlem = new medlem();
        Träningsgrupp aktuellgrupp = new Träningsgrupp();
        private string Plats, tid;


        public CirkusNytträningstillfälle()
        {
            InitializeComponent();
            fillcombo();
        }
        void fillcombo ()
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
                postgres db = new postgres();
                medlem = db.hämtamedlem("select * from medlem where mednr in( select medlem from ingåri where träningsgrupp ='" + aktuellgrupp.Gruppid + "') ");
                MedlmLbox.DataSource = medlem;
            }
        }

        private void NyttträningstillfälleBt_Click(object sender, EventArgs e)
        {
            läggtillmedlemBt.Enabled = true;
            NyttträningstillfälleBt.Enabled = false;
            Träningstillfälle pt = new Träningstillfälle();
            pt.LaggTillTräningstillfälle(CboxPlats.Text , "2016-06-22" ,TxtBox.Text , CboxTräningstyp.Text );
            postgres db = new postgres();
            db.SqlAdmin("insert into deltar (träningstillfalle, medlem, träningsgrupp) values (currval('träningstillfälle_id_seq'::regclass), " + aktuellmedlem.Medlemnr + ", " + aktuellgrupp.Gruppid + ");");           
            
        }

        private void AvbrytBt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void läggtillmedlemBt_Click(object sender, EventArgs e)
        {
            postgres db = new postgres();
            db.SqlAdmin("insert into deltar (träningstillfalle, medlem, träningsgrupp) values (currval('träningstillfälle_id_seq'::regclass), " + aktuellmedlem.Medlemnr + ", " + aktuellgrupp.Gruppid + ");");
        }

        private void MedlmLbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            aktuellmedlem = (medlem)CboxTräningsgrupper.SelectedItem;
            if (aktuellmedlem != null)
            {
            }
            }

        private void CboxPlats_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
