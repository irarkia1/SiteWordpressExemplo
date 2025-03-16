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
    public partial class Form5: Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Tb_Add_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Btn_Viwer_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach (var valor in Clb_Form5.CheckedItems) {
                txt += valor+ "\n";
            }
            MessageBox.Show(txt);
        }

        private void Btn_Cls_Click(object sender, EventArgs e)
        {
            var itensParaRemover = Clb_Form5.CheckedItems.Cast<object>().ToList();
            foreach (var item in itensParaRemover)
            {
                Clb_Form5.Items.Remove(item);
            }

        }

        private void Btn_Rst_Click(object sender, EventArgs e)
        {
            Clb_Form5.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clb_Form5.Items.AddRange(new object[] {
            "Liao",
            "Tigre",
            "Mamaco",
            "Python",
            "Ai"});
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list.Add(Tb_Add.Text);
            Clb_Form5.Items.AddRange(list.ToArray());
            Tb_Add.Clear();
            Tb_Add.Focus();
        }

        private void TxBox_Begin_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Serch_Click(object sender, EventArgs e)
        {
            TxBox_Begin.Text = Mc_Calendario.SelectionStart.ToShortDateString();
            TxBox_End.Text = Mc_Calendario.SelectionEnd.ToShortDateString();
            TxBox_Now.Text = Mc_Calendario.TodayDate.ToShortDateString();
        }
    }
}
