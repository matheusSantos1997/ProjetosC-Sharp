using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App12ListView_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Vingadores");
            listBox1.Items.Add("Vingadores 2 Era de Ultron");
            listBox1.Items.Add("Vingadores 3 Guerra Infinita");
            listBox1.Items.Add("Vingadores 4 Ultimato");
        }
    }
}
