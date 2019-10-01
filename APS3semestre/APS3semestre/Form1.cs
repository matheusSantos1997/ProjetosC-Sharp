using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS3semestre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //declaração do tipo double das variáveis
        double n1, n2, media;

        private void button2_Click(object sender, EventArgs e)
        {
            //limpar as caixas de textos  serve tanto texbox1.Text = string.Empty; ou textBox.Clear();
            textBox1.Text = string.Empty; 
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox1.Focus();
         //Focus vai pedir para digitar no primeiro textBox novamente assim que as caixas de textos forem limpadas

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //sair da aplicação após ser clicada
            Application.Exit();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 janela2 = new Form2(); //instanciou a form2
            janela2.Show(); //permiti mudar após clicar
            this.Hide();    //após mudar para próxima janela a anterior some
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) //foi adicionado o evento KeyPress
        {
            //aqui só aceita somente números e virgulas
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Somente números e vírgula!!");
            }
            
            //aqui só aceita somente uma vírgula
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente uma vírgula!!");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) //foi adicionado o evento KeyPress
        {
            //aqui só aceita somente números e virgulas
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Somente números e vírgula");
            }

            //aqui só aceita somente uma vírgula
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente uma vírgula!!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 4; //limitou a quantidade de caracteres 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 4; //limitou a quantidade de caracteres  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //condiçao se os textbox nao estiverem vazios ou nulos
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
                {
                    //executará o processamento de informaçao   

                    n1 = Convert.ToDouble(textBox1.Text);
                    n2 = Convert.ToDouble(textBox2.Text);
                
                    media = (n1 + n2) / 2;

                    //saída de informaçao

                    textBox3.Text = Convert.ToString(media);


                    

                    if (media >= 7)
                    {
                        MessageBox.Show("Você está Aprovado!! \n Sua Média final foi: " + media);
                    }
                    else
                    {
                        MessageBox.Show("Você está Reprovado!! \n Sua Média final foi: " + media);
                    }
                  
                }

                else
                {
                    MessageBox.Show("Os campos nota 1 e nota 2 precisam ser obrigatóriamente preenchidos!!", "media",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // na propriedade "enabled" tem que deixar = a false para desativar
        }

    }
}

