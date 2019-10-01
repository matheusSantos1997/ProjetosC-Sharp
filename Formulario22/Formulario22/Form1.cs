using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double ht, vh, sb, inss, sl, boni, ing, esp, outros;
        private void Button1_Click(object sender, EventArgs e)
        {
            ing = 0; esp = 0; outros = 0;
            ht = float.Parse(TextBox5.Text);
            vh = float.Parse(TextBox6.Text);
            sb = ht * vh;
            TextBox7.Text = Convert.ToString(sb);
            inss = sb * 0.11;
            TextBox8.Text = Convert.ToString(inss);
            if (CheckBox1.Checked == true)
            ing = 500;
            if (CheckBox2.Checked == true)
            ing = 450;
            if (CheckBox3.Checked == true)
            ing = 250;
            boni = ing + esp + outros;
            TextBox9.Text = Convert.ToString(boni);
            sl = sb - inss + boni;
            TextBox10.Text = Convert.ToString(sl);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Clear();
            TextBox2.Clear();
            TextBox3.Clear();
            TextBox4.Clear();
            TextBox5.Clear();
            TextBox6.Clear();
            TextBox7.Clear();
            TextBox8.Clear();
            TextBox9.Clear();
            TextBox10.Clear();
            ComboBox1.Text = "Selecione...";
            ComboBox2.Text = "Selecione...";
            CheckBox1.Checked = false;
            CheckBox2.Checked = false;
            CheckBox3.Checked = false;
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            TextBox1.Focus();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form2 frsobre = new Form2();
            frsobre.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
