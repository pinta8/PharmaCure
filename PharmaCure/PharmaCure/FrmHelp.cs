using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaCure
{
    public partial class FrmHelp : Form
    {
        public FrmHelp()
        {
            InitializeComponent();
        }
        //Gumb za izlazak sa Help Forme
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmHelp_Load(object sender, EventArgs e)
        {

        }
    }
}
