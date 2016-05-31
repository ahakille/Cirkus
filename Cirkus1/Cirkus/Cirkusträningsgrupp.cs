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
    public partial class Cirkusträningsgrupp : Form
    {
        public Cirkusträningsgrupp()
        {
            InitializeComponent();
        }
        void Fillcombo()
        {
            List<Träningsgrupp> grupp = new List<Träningsgrupp>();
            postgres db = new postgres();
            grupp=db.hämtaträningsgrupp("select * from träningsgrupp");
            TräningsgruppCbox.DataSource = grupp;
        }
    }
}
