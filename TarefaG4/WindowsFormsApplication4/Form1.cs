using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Convert.ToString(4 / 3);
            textBox2.Text = Convert.ToString(3.1415);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        double resultado, raio, altura, bas;
        private void button1_Click(object sender, EventArgs e)
        {
            raio = float.Parse(textBox3.Text);
            resultado = (4 / 3) * 3.1415 * raio;
            label6.Text = Convert.ToString(resultado);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            altura = float.Parse(textBox4.Text);
            bas = float.Parse(textBox5.Text);
            resultado = 2 * altura * 2 * bas;
            label16.Text = Convert.ToString(resultado);
        }
    }
}
