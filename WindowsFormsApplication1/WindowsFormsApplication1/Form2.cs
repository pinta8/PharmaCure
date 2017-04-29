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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static List<Dvorane> das = new List<Dvorane>();
        private void button1_Click(object sender, EventArgs e)
        {
            Dvorane d = new Dvorane();
            d.id = int.Parse(textBox1.Text);
            d.ime = textBox2.Text;
            das.Add(d);
            this.Close();
        }
    }
}
