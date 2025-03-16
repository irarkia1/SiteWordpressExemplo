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
    public partial class Form6: Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Txbox_All.Text = DTP_01.Value.ToString();
        }

        private void Txbox_All_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_DMY_Click(object sender, EventArgs e)
        {
            Txbox_D.Text = DTP_01.Value.Day.ToString();
            Txbox_M.Text = DTP_01.Value.Month.ToString();
            Txbox_Y.Text = DTP_01.Value.Year.ToString();
        }

        private void Btn_Mudar_Click(object sender, EventArgs e)
        {
            DateTime dtp = new DateTime(int.Parse(Txbox_Y.Text), int.Parse(Txbox_M.Text), int.Parse(Txbox_D.Text));
            DTP_01.Value = dtp;
        }

        private void CMS_Notificacao_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void CMS_Notificacao_Click(object sender, EventArgs e)
        {

        }

        private void CMS_Notificacao_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "aiai")
            {
                MessageBox.Show("aiai");
            }
            else if (e.ClickedItem.Text == "fechar")
            {
                this.Close();
            }
        }

        private void CMS_Notificacao_Opening(object sender, CancelEventArgs e)
        {

        }
    }
    }
