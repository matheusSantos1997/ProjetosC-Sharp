using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarefa3Visual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        double volume, altura, raio, pi = 3.14, largura, comprimento;
        private void button1_Click(object sender, EventArgs e)
        {
            comprimento = float.Parse(textBox1.Text);
            largura = float.Parse(textBox2.Text);
            altura = float.Parse(textBox3.Text);
            volume = comprimento * largura * altura;
            textBox4.Text = Convert.ToString(volume);
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            raio = float.Parse(textBox5.Text);
            altura = float.Parse(textBox6.Text);
            volume = pi * (raio * raio) * altura;
            textBox7.Text = Convert.ToString(volume);
        }
    }
}
