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
    public partial class CirkusNärvaror : Form
    {
        List<Träningsgrupp> grupp = new List<Träningsgrupp>();
        List<medlem> medlem = new List<medlem>();
        List<medlem> tränare = new List<medlem>();
        List<Träningstillfälle> tillfälle = new List<Träningstillfälle>();
        medlem aktuellmedlem = new medlem();
        Träningsgrupp aktuellgrupp = new Träningsgrupp();
        public CirkusNärvaror()
        {
            InitializeComponent();
            fillcombo();
        }
        void fillcombo()
        {
            postgres db = new postgres();
            grupp = db.hämtaträningsgrupp("select * from träningsgrupp");
            CboxTräningsgrupp.DataSource = grupp;
        }

        private void BtGruppsök_Click(object sender, EventArgs e)
        {
            postgres db = new postgres();
            postgres db2 = new postgres();
            medlem = db.hämtamedlem("select * from medlem where mednr in( select medlem from ingåri where träningsgrupp ='" + aktuellgrupp.Gruppid + "') ");
            LboxMedlem.DataSource = medlem;
            tränare = db2.hämtamedlem("select * from medlem where mednr in( select medlem from tränar where träningsgrupp ='" + aktuellgrupp.Gruppid + "') ");
            LboxLedare.DataSource = tränare;
            LbGrupp.Text = aktuellgrupp.Gruppnamn;
        }

        private void CboxTräningsgrupp_SelectedIndexChanged(object sender, EventArgs e)
        {
            aktuellgrupp = (Träningsgrupp)CboxTräningsgrupp.SelectedItem;
         
        }

        private void LboxMedlem_SelectedIndexChanged(object sender, EventArgs e)
        {
            aktuellmedlem = (medlem)LboxMedlem.SelectedItem;
            if (aktuellmedlem !=null)
            {
                postgres db = new postgres();
                tillfälle = db.hämtaTräningslista("select t.id, t.plats, t.datum, t.tid, t.aktivtetsid, p.aktivitet from träningstillfälle t, träningstyp p where t.id in(select träningstillfalle from deltar where medlem= '"+aktuellmedlem.Medlemnr+"' and träningsgrupp='"+aktuellgrupp.Gruppid+"') and t.aktivtetsid = p.id ");
                LboxAktivitet.DataSource = null;
                LboxAktivitet.DataSource = tillfälle;
            }
        }
    }
}
