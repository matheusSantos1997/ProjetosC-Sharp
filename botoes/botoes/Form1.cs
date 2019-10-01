using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace botoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Width = 60;
            pictureBox1.Height = 60;
            this.Text = "Google Chrome";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = "Aplicativos";
            pictureBox1.Width = 50;
            pictureBox1.Height = 50;
            pictureBox2.Width = 50;
            pictureBox2.Height = 50;
            pictureBox3.Width = 50;
            pictureBox3.Height = 50;
            pictureBox4.Width = 50;
            pictureBox4.Height = 50;
            
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Width = 60;
            pictureBox2.Height = 60;
            this.Text = "Calculadora";
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.Width = 60;
            pictureBox3.Height = 60;
            this.Text = "Bloco de Notas";
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.Width = 60;
            pictureBox4.Height = 60;
            this.Text = "Fechar";
        
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Chrome.exe");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
