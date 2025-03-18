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

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void NumUpDown_ValueChanged(object sender, EventArgs e)
        {
            progressBar1.Value = (int)NumUpDown.Value;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            while (button1 != null)
            {

                if (NumUpDown.Value == progressBar1.Value)
                {
                    int v = (int)NumUpDown.Value;
                    progressBar1.Value = v;
                }
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
                
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
    }
