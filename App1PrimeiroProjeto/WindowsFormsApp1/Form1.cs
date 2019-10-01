using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor = 20;
            int valor2 = 2;
            int resultado;

            resultado = valor - valor2;

            label1.Text = ("no mínimo faltam: " + resultado);
            //transformar o label em mensagem
            label1.Visible = true; 
            //fazer com que apareça a nova mensagem no label1
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
