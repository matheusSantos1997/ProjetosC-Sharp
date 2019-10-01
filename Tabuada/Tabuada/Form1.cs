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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int t, c, r;
            listBox1.Items.Clear();
            t = int.Parse(textBox1.Text);
            for (c = 1; c <= 10; c++)
            {
                r = t * c;
                listBox1.Items.Add(Convert.ToString(t) + 
                    " X " + Convert.ToString(c) + " = " +
                    Convert.ToString(r));
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listBox1.Items.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
