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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            verificar();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox3.Visible = false;
            verificar();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            verificar();
        }
        int x, usuario = 0, computador = 0;
        public void verificar()
        {
            Random random = new Random();
            x = random.Next(0, 3);
            if (x == 0)
                pictureBox4.Visible = true;
            else if (x == 1)
                pictureBox5.Visible = true;
            else
                pictureBox6.Visible = true;
            if ((pictureBox1.Visible == true && pictureBox4.Visible == true) ||
               (pictureBox2.Visible == true && pictureBox5.Visible == true) ||
               (pictureBox3.Visible == true && pictureBox6.Visible == true))
                MessageBox.Show("Houve Empate Mizeravi!");
            else if ((pictureBox1.Visible == true && pictureBox5.Visible == true) ||
                (pictureBox2.Visible == true && pictureBox6.Visible == true) ||
                (pictureBox3.Visible == true && pictureBox4.Visible == true))
            {
                MessageBox.Show("Parabéns Mizeravi, quem ti ensinou ?");
                usuario++;
                label2.Text = "Total de pontos: " + Convert.ToString(usuario);
            }
            else
            {
                MessageBox.Show("Perdeu playboy !!!");
                computador++;
                label3.Text = "Total de pontos: " + Convert.ToString(computador);
                label3.Visible = true;


            }
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;



        }
            
        int tempo = 60;
        
         
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label4.Text = "Tempo: " + Convert.ToString(tempo);
            tempo--;
            if (tempo <= 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Tempo esgotado bobão...");
                label4.Text = "Tempo: em Espera";
            
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            usuario = 0; computador = 0; tempo = 20;
            label2.Text = "o total de pontos: ";
            label3.Visible = false;


            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            timer1.Enabled = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}