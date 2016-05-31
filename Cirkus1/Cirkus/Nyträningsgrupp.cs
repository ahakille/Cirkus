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
    public partial class Nyträningsgrupp : Form
    {
        public Nyträningsgrupp()
        {
            InitializeComponent();
        }

        private void AvbrytBt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void laggtillBt_Click(object sender, EventArgs e)
        {
            if (laggtillTxt.Text == "")
            {
                MessageBox.Show("Fyll i namnet", "Felmeddelande", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string namn = laggtillTxt.Text;
                postgres db = new postgres();
                db.SqlAdmin("insert into träningsgrupp(namn) values('" + namn + "')");
            }
            Close();

        }
    }
}
