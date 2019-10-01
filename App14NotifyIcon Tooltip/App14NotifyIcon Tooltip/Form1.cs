using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App14NotifyIcon_Tooltip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show(textBox1.Text + " \n" + textBox2.Text);
        }

        private void opção1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eu sou a opção 1");
        }

        private void config2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você configurou no modo 2");
        }

        private void config1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você configurou no modo 1");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false; //fechar o icone de notificaçao
            Application.Exit(); //fechar o aplicativo

            //mudar o ToolytipIcon para Info
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
