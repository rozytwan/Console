using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{ 
    public partial class Form2 : Form
    {
        public static string me;
        public string passvalue
        {
            get { return me; }
            set { me = value; }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = me;
            //Form2 form = new Form2();
            //form.passvalue = textBox1.Text;
            //form.Show();

        }

       private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = me;
        }
    }
}
