using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App8PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            OpenFileDialog trocarImagem = new OpenFileDialog();
            //aqui foi criado o método Trocar Imagem que irá abrir uma caixa de diálogo

            trocarImagem.Filter = "Bitmap|*.bmp|jpegs|*.jpg|pngs|*.png";
            //aqui foi filtrado os tipos de imagens que poderão ser usadas para o pictureBox1

            if (trocarImagem.ShowDialog() == DialogResult.OK)//se a imagem for escolhida então
            {
                pictureBox1.ImageLocation = trocarImagem.FileName;//será trocada a imagem no pictureBox1
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
