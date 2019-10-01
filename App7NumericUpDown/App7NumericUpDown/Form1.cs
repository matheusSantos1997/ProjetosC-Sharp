using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App7NumericUpDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal valor = numericUpDown1.Value;

            if(valor == 0)
            {
                button1.BackColor = Color.White;
            }
            if (valor == 25)
            {
                button1.BackColor = Color.LightGreen;
            }
            if(valor == 50)
            {
                button1.BackColor = Color.Green;
            }
            if (valor == 75)
            {
                button1.BackColor = Color.DarkGreen;
            }
            if (valor == 100)
            {
                button1.BackColor = Color.Black;
            }
        }
    }
}
