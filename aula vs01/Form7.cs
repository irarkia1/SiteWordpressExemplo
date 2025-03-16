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
    public partial class Form7: Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TxBox_Clear()
        {
            TxBox_Id.Clear();
            TxBox_Produto.Clear();
            TxBox_preco.Clear();
            TxBox_Qd.Clear();
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            string[] add = new string[4];

            add[0] = TxBox_Id.Text;
            add[1] = TxBox_Produto.Text;
            add[2] = TxBox_preco.Text;
            add[3] = TxBox_Qd.Text;

            ListViewItem lvi = new ListViewItem(add);
            Lv_Form.Items.Add(lvi);

            TxBox_Clear();
        }

        private void Btn_Del_Click(object sender, EventArgs e)
        { 
            Lv_Form.Items.Remove(Lv_Form.SelectedItems[0]);
        }

        private void Btn_Get_Click(object sender, EventArgs e)
        {
            if (e is null)
            {
                throw new ArgumentNullException(nameof(e));
            }

            TxBox_Id.Text = Lv_Form.SelectedItems[0].SubItems[0].Text;
            TxBox_Produto.Text = Lv_Form.SelectedItems[0].SubItems[1].Text;
            TxBox_preco.Text = Lv_Form.SelectedItems[0].SubItems[2].Text;
            TxBox_Qd.Text = Lv_Form.SelectedItems[0].SubItems[3].Text;
        }

        private void Btn_Ver_Senha_Click(object sender, EventArgs e)
        {
            MTB_Pass.PasswordChar = '\0';
        }
    }
}
