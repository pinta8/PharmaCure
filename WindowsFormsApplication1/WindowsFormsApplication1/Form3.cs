using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public static List<Predavanja> asd = new List<Predavanja>();
        public Dvorane da;
        public Form3(Dvorane d)
        {
            da = d;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Predavanja p = new Predavanja();
            p.a = int.Parse(textBox1.Text);
            p.n = textBox2.Text;
            p.d = da;
            asd.Add(p);
            this.Close();
        }
    }
}
