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
        public Cirkusmain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            postgres test = new postgres();
            //DataTable _tabell = new DataTable();
            //   _tabell=test.sqlFrågaDr();
            // medlemLbox.DataSource = _tabell;
            // postgres test = new postgres();
            //test.sqlFråga("bajs");
            // medlem m = new medlem();
            // m.LaggTillMedlem("Erik", "Ö", 18791121, "Man", "1264654", "6468798", "afate@åskgf.dt", "gf", "87869", "sdgsd", "Prova-på", true);
            Träningstillfälle t = new Träningstillfälle();
            t.LaggTillTräningstillfälle("Cirkustältet", "2016-05-30", "18:30", "Cykling");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            postgres test = new postgres();
            //DataTable _tabell = new DataTable();
             Medlem=test.hämtamedlem("select * from medlem");
            medlemLbox.DataSource = Medlem;
            
            //test.sqlFråga("bajs");
        }

        private void laggmedlemBt_Click(object sender, EventArgs e)
        {
            Cirkusmedlem läggtill = new Cirkusmedlem(); // form för lägga till medlem
            läggtill.Owner = this; // Bestämmer huvudform
            läggtill.ShowDialog(); // Öppnar form Lägg till medlem
        }

        private void MedlNrLb_Click(object sender, EventArgs e)
        {
            Medlem.Sort(delegate (medlem x, medlem y)
            {
                 return x.Medlemnr.CompareTo(y.Medlemnr);

            });
            medlemLbox.DataSource = null;
            medlemLbox.DataSource = Medlem;
        }
    }
}
