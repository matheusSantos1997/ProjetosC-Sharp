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
    public partial class Janela3 : Form
    {
        public Janela3()
        {
            InitializeComponent();
        }

        private void Janela3_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Paraéns! Chegamos na última janela!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Janela2 j2 = new Janela2();
            j2.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Janela1 j1 = new Janela1();
            j1.Show();
            this.Hide();
        }
    }
}
