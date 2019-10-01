using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App9RichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] texto = { "Eu", "sou", "um", "teste", "de", "rich", "box" }; //array[] conjunto de caracteres ou variaveis

            Color[] cores = { Color.AliceBlue, Color.AntiqueWhite, Color.Aqua, Color.Aquamarine,
                Color.Azure, Color.Beige, Color.Bisque, Color.Black };

            Color[] cores2 = { Color.BlanchedAlmond, Color.Blue, Color.BlueViolet, Color.Brown,
                Color.BurlyWood, Color.CadetBlue, Color.Chartreuse, Color.Chocolate };

            for (int i = 0; i < texto.Length; i++)
            {
                richTextBox1.SelectionColor = cores[i]; //mudar cor da seleçao
                richTextBox1.SelectionBackColor = cores2[i]; //mudar a cor de fundo
                richTextBox1.AppendText(texto[i]);
                richTextBox1.AppendText("\n");

                if (i % 2 == 0)
                {
                    richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
                }
                else
                {
                    richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
                }
            }
        }
    }
}
