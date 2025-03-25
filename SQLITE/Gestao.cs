using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;


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

        private void Btn_SalvarRelatorio_Click(object sender, EventArgs e)
        {
            string path = Globais.path + @"\relatorios\";

            // Criar o diretório se não existir
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filePath = path + "Relatorio.pdf";

            FileStream fileStream = new FileStream(filePath, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fileStream);

            //imagem
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Globais.path + @"\..\..\img\off.jpeg");
            img.ScaleToFit(100f, 100f);
            img.Alignment = Element.ALIGN_CENTER;
            //fim

            string dados = "";

            Paragraph paragraph = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));
            paragraph.Alignment = Element.ALIGN_CENTER;
            paragraph.Add("Teste Matheus\n");

            paragraph.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold);
            paragraph.Alignment = Element.ALIGN_CENTER;
            paragraph.Add("Eita agora vai");

            string texto = "E lá vamos nos hage sistemas vou vitar socio ainda";
            paragraph.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold);
            paragraph.Alignment = Element.ALIGN_CENTER;
            paragraph.Add(texto + "Teste Matheus\n");

            //tabela
            PdfPTable template = new PdfPTable(3);
            template.WidthPercentage = 100;

            //PdfPCell cell = new PdfPCell(new Phrase("Tabela linha two"));
            //cell.Colspan = 3;
            //cell.Rotation = 90;
            //table.AddCell(cell);

            template.AddCell("Tabela linha three");
            template.AddCell("Tabela linha four");
            template.AddCell("Tabela linha five");

            template.AddCell("Tabela linha black");
            template.AddCell("Tabela linha blue");
            template.AddCell("Tabela linha red");

            template.AddCell("Tabela linha dog");
            template.AddCell("Tabela linha cat");
            template.AddCell("Tabela linha fish");


            PdfPTable table = new PdfPTable(3);
            table.WidthPercentage = 100;

            table.AddCell("nome");
            table.AddCell("senha");
            table.AddCell("status");

            DataTable dt = Db_Class.ObtAllUser();
            foreach (DataRow row in dt.Rows)
            {
                table.AddCell(row["S_NAMEUSER"]?.ToString() ?? "");
                table.AddCell(row["S_PASSWORD"]?.ToString() ?? "") ;
                table.AddCell(row["S_STATUSUSER"]?.ToString() ?? "");
            }

            //cell.Phrase.Add("Tabela linha six");
            //cell.Colspan = 3;
            //cell.Rotation = 40;
            //cell.HorizontalAlignment = Element.ALIGN_CENTER;
            //cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            //template.AddCell(cell2);

            //sair


            document.Open();
            document.Add(img);
            document.Add(paragraph);
            document.Add(table);
            document.Add(template);
            document.Close();
            fileStream.Close();

            DialogResult res = MessageBox.Show("Relatório gerado com sucesso", "Relatorio", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(filePath);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
