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
            postgres db2 = new postgres();

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
            
        }

        private void AvbrytBt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
