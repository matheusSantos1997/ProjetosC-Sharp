using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Janela2 : Form
    {
        public Janela2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Janela1 j1 = new Janela1(); //instanciou a janela1
            j1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Janela3 j3 = new Janela3();
            j3.Show();
            this.Hide();
        }
    }
}
