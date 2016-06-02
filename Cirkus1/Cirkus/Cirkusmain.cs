﻿using System;
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
        public List<medlem> Medlem = new List<medlem>();
        public List<Träningstillfälle> tillfälle = new List<Träningstillfälle>();
        medlem aktuellmedlem = new medlem();
        public Cirkusmain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            postgres t = new postgres();
            //DataTable _tabell = new DataTable();
            //   _tabell=test.sqlFrågaDr();
            // medlemLbox.DataSource = _tabell;
            // postgres test = new postgres();
            //test.sqlFråga("bajs");
            // medlem m = new medlem();
            // m.LaggTillMedlem("Erik", "Ö", 18791121, "Man", "1264654", "6468798", "afate@åskgf.dt", "gf", "87869", "sdgsd", "Prova-på", true);
          //  Träningstillfälle pt = new Träningstillfälle();
//            pt.LaggTillTräningstillfälle("Cirkustältet", "2016-05-30", "18:30", "Cykling");

            
            tillfälle = t.hämtaTräningslista("select t.id, t.plats, t.datum, t.tid, t.aktivtetsid, a.aktivitet from träningstillfälle t, träningstyp a where t.aktivtetsid = a.id; ");
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
