using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrarytest.Computer;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        GenericStack<string> stack = new GenericStack<string>();
        public Form2()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            button1.Click += display;
            button1.Click += button2_Click;
            button1.Click += display;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                stack.Push(textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stack.Pop();
        }

        private void display(object sender, EventArgs e)
        {
            label1.Text = stack.DisplayAll();
        }
    }
    }
}
