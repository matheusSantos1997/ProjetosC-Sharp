using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
           //verificaçao se os campos nao estiverem vazios -- !string.IsNullOrEmpty(string)
            if (string.IsNullOrEmpty(textBox2.Text) == false && string.IsNullOrEmpty(textBox3.Text) == false && string.IsNullOrEmpty(textBox1.Text) == false) {

                label4.Text = "Olá: " + textBox2.Text + " seu sobrenome é: " + textBox3.Text + " e " + " sua idade é: " + textBox1.Text;
                //jogando as informaçoes digitadas dos campos no label4

                //limpando a caixa de texto após a insersão dos dados
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Clear();
            } else
            {
                label4.Text = "por favor complete todos os campos!";
            }

        }

        private void validarInt(object sender, KeyPressEventArgs e) //evento KeyPress
        {   //verificar se foi digitado numeros no campo idade
            char teclaDigitada = e.KeyChar;

            if(!char.IsDigit(e.KeyChar)) { 
                e.Handled = true; //só vai validar se for o caso
            }
        }

        private void validarTexto(object sender, EventArgs e) //evento TextChanged
        {   
            //ignorando letras digitadas e substituindo por 0 a idade
            int resultado;
            bool sucesso = Int32.TryParse(textBox1.Text, out resultado);

            //vai ver se o valor digitado no campo idade pode ser convertido para inteiro
            //caso ele consiga, ele irá retornar resultado

            //variavel booleana = sucesso "true || false"

             if(!sucesso)
               {
                textBox1.Text = "0";
             }
        }
    }
}
