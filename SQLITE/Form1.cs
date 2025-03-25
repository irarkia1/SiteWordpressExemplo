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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();

            Login login = new Login(this);
            login.ShowDialog();
        }

        private void PinBox_OnOff_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Panel_Bottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logados)
            {
                if(Globais.nivel >= 0)
                {

                }
                else {
                    MessageBox.Show("User without permission");
                }
            }
            else
            {
                MessageBox.Show("User not logged in");
            }
        }

        private void manutençãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logados)
            {
                if (Globais.nivel >= 2)
                {

                }
                else
                {
                    MessageBox.Show("User without permission");
                }
            }
            else
            {
                MessageBox.Show("User not logged in");
            }
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logados)
            {
                if (Globais.nivel >= 1)
                {

                }
                else
                {
                    MessageBox.Show("User without permission");
                }
            }
            else
            {
                MessageBox.Show("User not logged in");
            }
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logados)
            {
                if (Globais.nivel >= 1)
                {

                }
                else
                {
                    MessageBox.Show("User without permission");
                }
            }
            else
            {
                MessageBox.Show("User not logged in");
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logados)
            {
                if (Globais.nivel >= 0)
                {

                }
                else
                {
                    MessageBox.Show("User without permission");
                }
            }
            else
            {
                MessageBox.Show("User not logged in");
            }

            Login login = new Login(this);
            login.ShowDialog();
            this.Close();
        }

        private void bancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logados)
            {
                if (Globais.nivel >= 2)
                {

                }
                else
                {
                    MessageBox.Show("User without permission");
                }
            }
            else
            {
                MessageBox.Show("User not logged in");
            }
        }

        private void novoUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logados)
            {
                if (Globais.nivel >= 1)
                {
                    Cadastro cad = new Cadastro();
                    cad.ShowDialog();
                }
                else
                {
                    MessageBox.Show("User without permission");
                }
            }
            else
            {
                MessageBox.Show("User not logged in");
            }
        }

        private void gerstãoUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logados)
            {
                if (Globais.nivel >= 1)
                {

                }
                else
                {
                    MessageBox.Show("User without permission");
                }
            }
            else
            {
                MessageBox.Show("User not logged in");
            }

            Gestao gestao = new Gestao();
            gestao.ShowDialog();
        }

        private void alunosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = Db_Class.verUsuario();
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 200;

        }
    }
}
