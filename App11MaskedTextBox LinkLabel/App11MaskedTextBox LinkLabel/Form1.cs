﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App11MaskedTextBox_LinkLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            linkLabel1.Links.Add(0, 20, "https://www.google.com");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Chrome", e.Link.LinkData.ToString());
            //IExplore para abrir nos navegadores Explore
            //Chrome para abrir no navegador google chrome
            //Firefox para abrir no Firefox
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
