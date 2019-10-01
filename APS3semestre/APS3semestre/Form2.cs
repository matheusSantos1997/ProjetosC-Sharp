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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 janela1 = new Form1(); //instanciou a form1
            janela1.Show(); //permiti mudar após clicar
            this.Hide();    //após mudar para próxima janela a anterior some
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "JAVA é lixo, C# é God";
        }
    }
}
