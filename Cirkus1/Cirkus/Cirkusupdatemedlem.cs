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
    public partial class Cirkusupdatemedlem : Form
    {
        
        public string mednr { get; set; }
        public Cirkusupdatemedlem()
        {
            InitializeComponent();
            postgres db = new postgres();
            
            
        }
        
        private void abortBt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateBt_Click(object sender, EventArgs e)
        {
              
            emailTxt.Text = test2;
        }
    }
}
