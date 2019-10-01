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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int x,y,z;
        private void timer1_Tick(object sender, EventArgs e)
        {
           Random random = new Random();
            //Primeira coluna de imagens
            x = random.Next(0, 5);
            pictureBox1.Visible=false;pictureBox2.Visible=false;
            pictureBox3.Visible=false;pictureBox4.Visible=false;
            if (x==1)
              pictureBox1.Visible=true;
            else if(x==2)
             pictureBox2.Visible=true;
            else if (x==3)
             pictureBox3.Visible=true;
            else
              pictureBox4.Visible=true;
             //Segunda Coluna de imagens
             y = random.Next(0, 5);
            pictureBox5.Visible=false;pictureBox6.Visible=false;
            pictureBox7.Visible=false;pictureBox8.Visible=false;
            if (y==1)
              pictureBox5.Visible=true;
            else if(y==2)
             pictureBox6.Visible=true;
            else if (y==3)
             pictureBox7.Visible=true;
            else
              pictureBox8.Visible=true;
            //Terceira Coluna de imagens
             z = random.Next(0, 5);
            pictureBox9.Visible=false;pictureBox10.Visible=false;
            pictureBox11.Visible=false;pictureBox12.Visible=false;
            if (z==1)
              pictureBox9.Visible=true;
            else if(z==2)
             pictureBox10.Visible=true;
            else if (z==3)
             pictureBox11.Visible=true;
            else
              pictureBox12.Visible=true;

        }
        double aposta, credito;
        private void verificar()
        {
            aposta = float.Parse(textBox1.Text);
            credito = float.Parse(textBox2.Text);
            if ((x == 1 && y == 1 && z == 1) || (x == 2 && y == 2 && z == 2) || 
                (x == 3 && y == 3 && z == 3) || (x == 4 && y == 4 && z == 4))
            {

                label2.Text = "Mensagem";
                label2.Text = "Ganhou";
                credito = credito + aposta;
                textBox2.Text = credito.ToString();
            }
            else
            {
                label2.Text = "Mensagem";
                label2.Text = "Perdeu";
                credito = credito - aposta;
                textBox2.Text = credito.ToString();
            }
            if (credito <= 0)
            {
                MessageBox.Show("Seus créditos acabaram, favor recarregar");
                button2.Enabled = false;
                button1.Enabled = false;
                
            }
        }



        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            verificar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Mensagem";
            if (textBox1.Text == "" || float.Parse(textBox1.Text) < 0)
            {
                MessageBox.Show("Favor faça sua aposta !");
                textBox1.Clear();
                textBox1.Focus();
            }
            else if (float.Parse(textBox1.Text) > float.Parse(textBox2.Text))
            {
                MessageBox.Show("Sua aposta é maior do que seus Créditos !");
                textBox1.Clear();
                textBox1.Focus();
            }
            else
                timer1.Enabled = true;
            
          }

        private void Aposta_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
            
            
        }
    }

