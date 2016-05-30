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
        //public List<medlem> medlem = new List<Cirkus.medlem>();
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
            medlem m = new medlem();
            m.LaggTillMedlem("Erik", "Ö", 18791121, "Man", "1264654", "6468798", "afate@åskgf.dt", "gf", "87869", "sdgsd", "Prova-på", true);

        }
    }
}
