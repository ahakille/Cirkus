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
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public int Födelsedata { get; set; }
        public string Kön { get; set; }
        public string Telefon { get; set; }
        public string Mobilnr { get; set; }
        public string Email { get; set; }
        public string Gata { get; set; }
        public string Postnr { get; set; }
        public string Ort { get; set; }
        public string Medlemstyp { get; set; }
        public bool Foto { get; set; }
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
              
            emailTxt.Text = mednr;
        }
    }
}
