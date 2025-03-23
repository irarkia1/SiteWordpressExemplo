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
    public partial class Gestao: Form
    {
        public Gestao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Gestao_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db_Class.verUsuario();
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 200;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int cont = dgv.SelectedRows.Count;
            if (cont > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Db_Class.verSelecao(vid);

                TxBox_Id.Text = dt.Rows[0]["I_ID"].ToString();
                TxBox_Name.Text = dt.Rows[0]["S_NAMEUSER"].ToString();
                TxBox_Password.Text = dt.Rows[0]["S_PASSWORD"].ToString();
                TxBox_User.Text = dt.Rows[0]["S_USERNAME"].ToString();
                TxBox_Status.Text = dt.Rows[0]["S_STATUSUSER"].ToString();
                NUB_Nivel.Value = Convert.ToInt32(dt.Rows[0]["I_NIVELUSER"]);



            }
        }

        private void Btn_Novo_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
            dataGridView1.DataSource = Db_Class.verUsuario();
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();

            user.id = Convert.ToInt32(TxBox_Id.Text);
            user.name = TxBox_Name.Text;
            user.password = TxBox_Password.Text;
            user.userName = TxBox_User.Text;
            user.nivel = Convert.ToInt32(Math.Round(NUB_Nivel.Value, 0));
            user.status = TxBox_Status.Text;

            Db_Class.UpdateUser(user);
            dataGridView1.DataSource = Db_Class.verUsuario();
        }

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to delete this user?", "Delete", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Usuario user = new Usuario();
                user.id = Convert.ToInt32(TxBox_Id.Text);

                Db_Class.DeleteUser(user);

                dataGridView1.DataSource = Db_Class.verUsuario();
            }
        }
    }
}
