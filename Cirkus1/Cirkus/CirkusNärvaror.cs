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
        List<närvaro> medlem = new List<närvaro>();
        List<medlem> tränare = new List<medlem>();
        List<medlem> tränare2 = new List<medlem>();
        List<Träningstillfälle> tillfälle = new List<Träningstillfälle>();
        List<Träningstillfälle> datum1 = new List<Träningstillfälle>();
        List<Träningstillfälle> datum2 = new List<Träningstillfälle>();
        närvaro aktuellmedlem = new närvaro();
        medlem aktuelltränare = new medlem();
        Träningstillfälle aktuellträningstillfälle = new Träningstillfälle();
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
            postgres db2 = new postgres();
            tränare2 = db2.hämtamedlem("select * from medlem where mednr in(select medlem from leder)");
            Cboxledare.DataSource = tränare2;
        }

        private void BtGruppsök_Click(object sender, EventArgs e)
        {         
            rensafält();
            postgres db = new postgres();
            postgres db2 = new postgres();

            tillfälle = db.hämtadeltagare("select t.tid, t.plats, t.aktivtetsid, t.datum, a.aktivitet, t.id, count(medlem) from  träningstillfälle t, träningstyp a, deltar d, träningsgrupp g where d.träningsgrupp ='" + aktuellgrupp.Gruppid + "' and g.gruppid ='" + aktuellgrupp.Gruppid + "' and t.id = d.träningstillfalle and t.aktivtetsid = a.id group by t.tid ,t.plats, t.aktivtetsid, t.datum, a.aktivitet, t.id ;");
            tränare = db2.hämtamedlem("select * from medlem where mednr in( select medlem from tränar where träningsgrupp ='" + aktuellgrupp.Gruppid + "') ");
            LbGrupp.Text = aktuellgrupp.Gruppnamn;

            Lbhuvud.Text = "Träningsgrupp";
            LboxMedlem.DataSource = tillfälle;
            LboxLedare.DataSource = tränare;

            Lbhuvud.Text = "Träningsgrupp";

            int i = 0;
            foreach(medlem m in medlem)
            {
                i++;
            }

            lbl_med.Text = "Antal deltagare: " + i;
            

            int x=0,y=0 ,d = 0;
            foreach (Träningstillfälle t in tillfälle)
            {
                y = tillfälle[x].antaldeltagare;
                x++;
                d=d + y;
            }
            
            lbl_med.Text = "Antal träningstillfällen: " + x +" och totalt antaldeltagare är " + d ;
        }

        private void CboxTräningsgrupp_SelectedIndexChanged(object sender, EventArgs e)
        {
            aktuellgrupp = (Träningsgrupp)CboxTräningsgrupp.SelectedItem;
         
        }

        private void LboxMedlem_SelectedIndexChanged(object sender, EventArgs e)
        {        
                aktuellträningstillfälle = (Träningstillfälle)LboxMedlem.SelectedItem;
                if (aktuellträningstillfälle != null)
                {

                    postgres db = new postgres();
                    postgres db2 = new postgres();

                    medlem = db.hämtanärvaro("select * from medlem where mednr in( select medlem from deltar where träningstillfalle ='" + aktuellträningstillfälle.Id + "')");
                    LboxAktivitet.DataSource = null;
                    LboxAktivitet.DataSource = medlem;


                    tränare = db2.hämtamedlem("select * from medlem where mednr in( select medlem from leder where träningstillfälle = " + aktuellträningstillfälle.Id + ");");
                    LboxLedare.DataSource = null;
                    LboxLedare.DataSource = tränare;

                    int i = 0;
                    foreach (medlem m in medlem)
                    {
                        i++;
                    }

                    lbl_aktiv.Text = "Antal medlemar: " + i;
                
            }

            
        }

        private void Btstäng_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtSökledare_Click(object sender, EventArgs e)
        {
            rensafält();
            Lbhuvud.Text = "Tränare";
            LbGrupp.Text = aktuelltränare.Förnamn +" "+ aktuelltränare.Efternamn;
        }

        private void Cboxledare_SelectedIndexChanged(object sender, EventArgs e)
        {
          aktuelltränare = (medlem)Cboxledare.SelectedItem;

        }
        private void rensafält()
        {
            LboxAktivitet.DataSource = null;
            LboxLedare.DataSource = null;
            LboxMedlem.DataSource = null;
        }

        private void BtSökdatum_Click(object sender, EventArgs e)
        {
            int tid1 = 0;
            int tid2 = 0;          
            postgres db = new postgres();
            rensafält();
            datum1 = db.hämtaTräningslista("select t.id, t.plats, t.datum, t.tid, t.aktivtetsid, p.aktivitet from träningstillfälle t, träningstyp p where t.aktivtetsid = p.id");
            try
            {
                tid1 = Convert.ToInt32(TxtBoxFrån.Text);
                tid2 = Convert.ToInt32(TxtboxTill.Text);
            }
            catch
            {

            }
            foreach (Träningstillfälle t in datum1)
            {
                if(tid1 <= t.Datum && tid2 >= t.Datum)
                {
                    datum2.Add(t);
                }
            }
            LboxMedlem.DataSource = datum2;
            LbGrupp.Text = TxtBoxFrån.Text + " till " + TxtboxTill.Text;
            Lbhuvud.Text = "Träningstillfällen";



            int i = 0;
            foreach (Träningstillfälle t in datum2)
            {
                i++;
            }

            lbl_med.Text = "Antal träningstillfällen: " + i;
        }
    }
}
