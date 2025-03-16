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
    public partial class Form2: Form
    {
        private Form1 form1;
        public Form2(Form1 form1Principal, List<string> DataList)
        {
            InitializeComponent();

            this.form1 = form1Principal;

            foreach(string item in DataList)
            {
                ListBox_List_Report.Items.Add(item);
            }
            form1 = form1Principal;
             
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void listBox_List_Report_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.ListBox_List.Items.Add("Seila");
        }
    }
}
