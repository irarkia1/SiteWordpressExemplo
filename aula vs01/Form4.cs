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
    public partial class Form4: Form
    {
            List<CheckBox> CkBox = new List<CheckBox>();
        public Form4()
        {
            InitializeComponent();
            CkBox.Add(Ckbox_Carro);
            CkBox.Add(Ckbox_Aviao);
            CkBox.Add(Ckbox_Moto);
            CkBox.Add(Ckbox_Navio);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Ckbox_Click(object sender, EventArgs e)
        {
            string txt = "";

            foreach (var item in CkBox)
            {
                if (item.Checked)
                {
                   txt += item.Text + "\n";
                }
            }

            MessageBox.Show(txt);
        }

        private void Btn_Form2_InForm4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
