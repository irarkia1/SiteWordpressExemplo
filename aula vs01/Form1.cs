using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace aula_vs01
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            
            HGYoDh.Links.Add(0, 7, "https://hagelab.com.br/access/login");   // "HageLab"
            HGYoDh.Links.Add(10, 8, "https://creago.org.br/servico/view/180"); // "CREA"
            HGYoDh.Links.Add(20, 7, "https://api.crea-go.org.br/usuario/login"); // "Servico"

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Env_Name_Click(object sender, EventArgs e)
        {
            if (TxBox_Add_InList.Text != "")
            {
                ListBox_List.Items.Add(TxBox_Add_InList.Text);
                TxBox_Add_InList.Clear();
                TxBox_Add_InList.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Digite algo em 'Adicionar'");
                TxBox_Add_InList.Focus();
                return;
            }
        }

        private void TxBox_Env_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListBox_List.Items.Clear();
           
            return;
        }

        private void Btn_Open_NewForm_Click(object sender, EventArgs e)
        {
            List<string> listDate = ListBox_List.Items.Cast<string>().ToList();
            Form2 form2 = new Form2(this, listDate);
            form2.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("O numero é: " + num);
        }

        private void ListBox_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chexkboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void form02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            lista.Add("nada");
            Form2 form2 = new Form2(this, lista);
            form2.Show();
        }

        private void form04ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void form05ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void form06ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void Ll_Youtube_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://hagelab.com.br/access/login");
        }

        private void Ll_Calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
            Ll_Calculadora.LinkVisited = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
         
        }

        private void Ll_Mult_Link_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void HGYoDh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void form07ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void sQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.ShowDialog();
        }
    }
}
