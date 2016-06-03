using System;
using Npgsql;
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
    public partial class Cirkusmain : Form
    {
        public List<Träningstillfälle> tillfälle = new List<Träningstillfälle>();
        postgres t = new postgres();
        public Cirkusmain()
        {
            InitializeComponent();
            tillfälle = t.hämtaTräningslista("select t.id, t.plats, t.datum, t.tid, t.aktivtetsid, a.aktivitet from träningstillfälle t, träningstyp a where t.aktivtetsid = a.id order by t.datum DESC ");
            tillfälleBox.DataSource = tillfälle;
        }

        private void träningsgruppBT_Click(object sender, EventArgs e)
        {
            Cirkusträningsgrupp läggtill = new Cirkusträningsgrupp(); // form för lägga till medlem
            läggtill.Owner = this; // Bestämmer huvudform
            läggtill.ShowDialog(); // Öppnar form Lägg till medlem
        }

 
        private void narvaroBt_Click(object sender, EventArgs e)
        {
            CirkusNärvaror laggtill = new CirkusNärvaror();
            laggtill.Owner = this;
            laggtill.ShowDialog();
        }

        private void updateMedlemBt_Click(object sender, EventArgs e)
        {
          
            Cirkusupdatemedlem läggtill = new Cirkusupdatemedlem(); // form för lägga till medlem        
            läggtill.Owner = this; // Bestämmer huvudform
            läggtill.ShowDialog(); // Öppnar form Lägg till medlem
         }

        private void NyttTräningstillfälleBt_Click(object sender, EventArgs e)
        {
            CirkusNytträningstillfälle läggtill = new CirkusNytträningstillfälle();
            läggtill.Owner = this;
            läggtill.ShowDialog();
        }
    }
}
