using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading; //importou o threading
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App18ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int valorAtual;
        int valorMaximo = 10000;

        private void button1_Click(object sender, EventArgs e)
        {
            valorAtual = 0;
            timer1.Start(); //iniciando o timer1
            new Thread(Executar).Start(); //executou a thread chamando a funçao Executar
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = 100 * valorAtual / valorMaximo;
            label1.Text = $"Processou {valorAtual} de {valorMaximo} dados! ({progressBar1.Value})%";  //$ consegue pegar o valor direto de uma variavel
        }
        public void Executar() //funçao que vai executar o processo
        {
             while(valorAtual < valorMaximo) //enquanto valorAtual for menor que valorMaximo
            {
                valorAtual+=10; //vai aumentar o em um valor
                Thread.Sleep(20);
                //Thread permite que um programa possa executar várias tarefas diferentes ao mesmo tempo
            }
        }
    }
}
