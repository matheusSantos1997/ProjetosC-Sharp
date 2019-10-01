using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App16TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) //evento TreeNodeMouseClick
        {

            var filhos = e.Node.Nodes;
            bool concluido = true;
            foreach(TreeNode filho in filhos)
            {
                if(filho.NodeFont == null || filho.NodeFont.Style != FontStyle.Strikeout) 
                    //se a fonte estiver nula ou filho nao for igual a strikeout
                {
                    concluido = false;
                }
            }


            if (e.Node.Nodes.Count == 0 || concluido) //se nao tiver filhos ou tiver concluido
            {
                if (e.Node.NodeFont != null) //se a fonte em questao do node nao for nula
                {
                    e.Node.NodeFont = new Font(e.Node.NodeFont.FontFamily, e.Node.NodeFont.Size, FontStyle.Strikeout);
                    //strikeout = texto com uma linha no meio
                }
                else
                {
                    e.Node.NodeFont = new Font(treeView1.Font.FontFamily, treeView1.Font.Size, FontStyle.Strikeout);
                    //caso nao dê para usar a fonte, utilizará a fonte padrão da treeview1
                }

            }
        }
    }
}
