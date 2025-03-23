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
    public partial class Cadastro: Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.name = TxBox_Name.Text;
            user.password = TxBox_Password.Text;
            user.userName = TxBox_User.Text;
            user.nivel = Convert.ToInt32(Math.Round(NUB_Nivel.Value, 0));
            user.status = TxBox_Status.Text;

            Db_Class.novoUsuario(user);

        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
