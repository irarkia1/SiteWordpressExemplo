using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLITE
{
    public partial class Login: Form
    {
        Form1 form1;
        DataTable dt = new DataTable();
        public Login(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Connection_Click(object sender, EventArgs e)
        {
            string user = TxBox_Login.Text;
            string pass = TxBox_Password.Text;

            if (user == "")
            {
                MessageBox.Show("User is empty");
                TxBox_Login.Focus();

            }
            else if (pass == "")
            {
                MessageBox.Show("Password is empty");
                TxBox_Password.Focus();
                return;
            }

            string sql = "SELECT * FROM db_user WHERE S_USERNAME = '" + user + "' AND S_PASSWORD = '" + pass + "'";
            dt = Db_Class.obtUser(sql);

            if (dt.Rows.Count > 0)
            {
                form1.Label_User.Text = dt.Rows[0].ItemArray[1].ToString();
                form1.PinBox_OnOff.Image = Properties.Resources.on;
                Globais.nivel = Convert.ToInt32(dt.Rows[0]["I_NIVELUSER"]);
                Globais.nameUser = dt.Rows[0]["S_USERNAME"].ToString();
                Globais.logados = true;
                this.Close();
            }
            else
            {

                MessageBox.Show("User or password is incorrect");
            }
        }
    }
}
