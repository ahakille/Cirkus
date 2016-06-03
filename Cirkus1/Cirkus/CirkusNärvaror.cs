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
        private int _träningsgrupp;
        private bool _fleraträningsgrupper, _åter = false;
        private string _träningsgruppnamn;
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
            if ( _åter == true)
            {
                _fleraträningsgrupper = false;
            }
            if(_fleraträningsgrupper==true)
            {
                medlem = db.hämtanärvaro("select * from medlem where mednr in( select medlem from ingåri where träningsgrupp ='" + aktuellgrupp.Gruppid + "'or träningsgrupp ='" + _träningsgrupp + "') ");
                tränare = db2.hämtamedlem("select * from medlem where mednr in( select medlem from tränar where träningsgrupp ='" + aktuellgrupp.Gruppid + "'or träningsgrupp ='" + _träningsgrupp + "') ");
                LbGrupp.Text = aktuellgrupp.Gruppnamn + " och " + _träningsgruppnamn;
            }
            else
            {
                medlem = db.hämtanärvaro("select * from medlem where mednr in( select medlem from ingåri where träningsgrupp ='" + aktuellgrupp.Gruppid + "') ");
                tränare = db2.hämtamedlem("select * from medlem where mednr in( select medlem from tränar where träningsgrupp ='" + aktuellgrupp.Gruppid + "') ");
                LbGrupp.Text = aktuellgrupp.Gruppnamn;
            }
            Lbhuvud.Text = "Träningsgrupp";
             LboxMedlem.DataSource = medlem;
            LboxLedare.DataSource = tränare;
            LbLäggtillgrupp.Text = "Grupper";
            _åter = true;
            BtGruppLäggtill.Enabled = true;

            int i = 0;
            foreach(medlem m in medlem)
            {
                i++;
            }

            lbl_med.Text = "Antal deltagare: " + i;
        }

        private void CboxTräningsgrupp_SelectedIndexChanged(object sender, EventArgs e)
        {
            aktuellgrupp = (Träningsgrupp)CboxTräningsgrupp.SelectedItem;
         
        }

        private void LboxMedlem_SelectedIndexChanged(object sender, EventArgs e)
        {
            aktuellmedlem = (närvaro)LboxMedlem.SelectedItem;
            if (aktuellmedlem !=null)
            {
                postgres db = new postgres();
                
                if (_fleraträningsgrupper==true)
                {
                    
                    tillfälle = db.hämtaTräningslista("select t.id, t.plats, t.datum, t.tid, t.aktivtetsid, p.aktivitet from träningstillfälle t, träningstyp p where t.id in(select träningstillfalle from deltar where medlem= '" + aktuellmedlem.Medlemnr + "' and träningsgrupp='" + aktuellgrupp.Gruppid + "'or träningsgrupp = '" + _träningsgrupp + "') and t.aktivtetsid = p.id ");

                }
                else
                {
                    tillfälle = db.hämtaTräningslista("select t.id, t.plats, t.datum, t.tid, t.aktivtetsid, p.aktivitet from träningstillfälle t, träningstyp p where t.id in(select träningstillfalle from deltar where medlem= '" + aktuellmedlem.Medlemnr + "' and träningsgrupp='" + aktuellgrupp.Gruppid + "') and t.aktivtetsid = p.id ");
                }
      
                LboxAktivitet.DataSource = null;
                LboxAktivitet.DataSource = tillfälle;

                int i = 0;
                foreach (Träningstillfälle t in tillfälle)
                {
                    i++;
                }

                lbl_aktiv.Text = "Antal träningstillfällen: " + i;
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

        private void BtGruppLäggtill_Click(object sender, EventArgs e)
        {
            _träningsgrupp = aktuellgrupp.Gruppid;
            _träningsgruppnamn = aktuellgrupp.Gruppnamn;
            LbLäggtillgrupp.Text = _träningsgruppnamn;
            _fleraträningsgrupper = true;
            BtGruppLäggtill.Enabled = false;
        }

        private void BtSökdatum_Click(object sender, EventArgs e)
        {
            int tid1 = 0;
            int tid2 = 0;
            postgres db = new postgres();
            datum1= db.hämtaTräningslista("select t.id, t.plats, t.datum, t.tid, t.aktivtetsid, p.aktivitet from träningstillfälle t, träningstyp p where t.aktivtetsid = p.id");
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
            LboxAktivitet.DataSource = null;
            LboxAktivitet.DataSource = datum2;

            int i = 0;
            foreach (Träningstillfälle t in datum2)
            {
                i++;
            }

            lbl_aktiv.Text = "Antal träningstillfällen: " + i;
        }

        private void LboxAktivitet_SelectedIndexChanged(object sender, EventArgs e)
        {
            //aktuellträningstillfälle = (Träningstillfälle)LboxAktivitet.SelectedItem;
            //if (aktuellträningstillfälle != null)
            //{
                
            //    postgres db = new postgres();

            //    medlem = db.hämtanärvaro("select * from medlem where mednr in( select medlem from deltar where träningstillfalle ='"+aktuellträningstillfälle.Id+"')");
            //    LboxMedlem.DataSource = null;
            //    LboxMedlem.DataSource = medlem;

            //    int i = 0;
            //    foreach (medlem m in medlem)
            //    {
            //        i++;
            //    }

            //    lbl_med.Text = "Antal deltagare: " + i;
            //}
        }
    }
}
