﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_vs01
{
    public partial class Form8: Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        public void Pesquisar()
        {
            webBrowser1.Navigate(textBox1.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
           Pesquisar();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Pesquisar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
    }
}
