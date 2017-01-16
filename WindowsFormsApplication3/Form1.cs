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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button1.DoubleClick += Button1_DoubleClick;
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label2.Text = count.ToString();
            if (count<1)
            {
                label2.Text = "STOP";
            } count--;
        }

        int count = 1;
        private void Button1_Click(object sender, EventArgs e)
        {
            label2.Text = count.ToString();
            count++;
        }

        private void Button1_DoubleClick(object sender, EventArgs e)
        {
            label1.Text = "double click";
            label2.Text =count.ToString();
            count++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text= "YES M HERE";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "I AM CLOSED";
        }
    }
}
