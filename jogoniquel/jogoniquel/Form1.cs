using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogoniquel
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }
        int x, c;
        private void button1_Click(object sender, EventArgs e)
        {
            for (c = 0; c < 10; c++)
            {
                
                Random random = new Random();
                {
                    x = random.Next(0, 4);
                    if (x == 0)
                    {
                        pictureBox1.Visible = true;
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = false;
                        pictureBox4.Visible = false;
                    }
                    else if (x == 1)
                    {
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = true;
                        pictureBox3.Visible = false;
                        pictureBox4.Visible = false;
                    }
                    else if (x == 2)
                    {
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = true;
                        pictureBox4.Visible = false;
                    }
                    else
                    {
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = false;
                        pictureBox4.Visible = true;
                    }
                }
                Random random2 = new Random();
                {
                    x = random.Next(0, 4);
                    if (x == 0)
                    {
                        pictureBox5.Visible = true;
                        pictureBox6.Visible = false;
                        pictureBox7.Visible = false;
                        pictureBox8.Visible = false;
                    }
                    else if (x == 1)
                    {
                        pictureBox5.Visible = false;
                        pictureBox6.Visible = true;
                        pictureBox7.Visible = false;
                        pictureBox8.Visible = false;
                    }
                    else if (x == 2)
                    {
                        pictureBox5.Visible = false;
                        pictureBox6.Visible = false;
                        pictureBox7.Visible = true;
                        pictureBox8.Visible = false;
                    }
                    else
                    {
                        pictureBox5.Visible = false;
                        pictureBox6.Visible = false;
                        pictureBox7.Visible = false;
                        pictureBox8.Visible = true;
                    }
                }
                Random random3 = new Random();
                {
                    x = random.Next(0, 4);
                    if (x == 0)
                    {
                        pictureBox9.Visible = true;
                        pictureBox10.Visible = false;
                        pictureBox11.Visible = false;
                        pictureBox12.Visible = false;
                    }
                    else if (x == 1)
                    {
                        pictureBox9.Visible = false;
                        pictureBox10.Visible = true;
                        pictureBox11.Visible = false;
                        pictureBox12.Visible = false;
                    }
                    else if (x == 2)
                    {
                        pictureBox9.Visible = false;
                        pictureBox10.Visible = false;
                        pictureBox11.Visible = true;
                        pictureBox12.Visible = false;
                    }
                    else
                    {
                        pictureBox9.Visible = false;
                        pictureBox10.Visible = false;
                        pictureBox11.Visible = false;
                        pictureBox12.Visible = true;
                    }
                }
                 
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
