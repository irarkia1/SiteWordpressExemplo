using System;
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
    public partial class Form3: Form
    {
        public Form4 form4;
        public Form3()
        {
            InitializeComponent();
            form4 = Application.OpenForms["Form4"] as Form4;
            try
            {
                form4 = Application.OpenForms["Form4"] as Form4;
                Ckbox_Filho_Carro.Checked = form4.Ckbox_Carro.Checked;  
                Ckbox_Filho_Aviao.Checked = form4.Ckbox_Aviao.Checked;
                Ckbox_Filho_Moto.Checked = form4.Ckbox_Moto.Checked;
                Ckbox_Filho_Navio.Checked = form4.Ckbox_Navio.Checked;

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao tentar acessar o Form4");
             }  
         }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            form4.Ckbox_Carro.Checked = Ckbox_Filho_Carro.Checked;
        }

        private void Ckbox_Filho_Navio_CheckedChanged(object sender, EventArgs e)
        {
            form4.Ckbox_Navio.Checked = Ckbox_Filho_Navio.Checked;
        }

        private void Ckbox_Filho_Moto_CheckedChanged(object sender, EventArgs e)
        {
            form4.Ckbox_Moto.Checked = Ckbox_Filho_Moto.Checked;
        }

        private void Ckbox_Filho_Aviao_CheckedChanged_1(object sender, EventArgs e)
        {
            form4.Ckbox_Aviao.Checked = Ckbox_Filho_Aviao.Checked;

        }

        private void Btn_01_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Cbb_01.Text);
        }

        private void Btn_02_Click(object sender, EventArgs e)
        {
            Cbb_01.Items.Clear();
        }

        private void Btn_03_Click(object sender, EventArgs e)
        {
            Cbb_01.Items.AddRange(new object[]
            {
                "Liao",
                "Tigre",
                "Mamaco",
                "Python",
                "Ai"});
        }

        private void Txbox_01_TextChanged(object sender, EventArgs e)
        {
            Txbox_01.Text = Cbb_01.Text;
        }

        private void Btn_04_Click(object sender, EventArgs e)
        {
            Cbb_01.Items.Add(Txbox_01.Text);
        }
    }
}
