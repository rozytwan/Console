using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.DoubleClick += Button1_DoubleClick;
            button1.Click += Button1_Click;
            button1.Click += Button1_Click1;
            
        }

     

        private void Button1_Click1(object sender, EventArgs e)
        {
            label3.Text = (count * 3).ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            count++;
            label2.Text = count.ToString();
        }

        int count = 0;
        private void Button1_DoubleClick(object sender, EventArgs e)
        {
            label1.Text = "double clicked";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "ok button clicked";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "canceled";
        }
    }
}
