namespace aula_vs01
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "mouse",
            "20",
            "79.90"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "teclado",
            "30",
            "29.90"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "Gabinete",
            "10",
            "209.90"}, -1);
            this.Lv_Form = new System.Windows.Forms.ListView();
            this.col_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_qtd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TxBox_Id = new System.Windows.Forms.TextBox();
            this.TxBox_Produto = new System.Windows.Forms.TextBox();
            this.TxBox_Descrition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxBox_Qd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxBox_preco = new System.Windows.Forms.TextBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Get = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Del = new System.Windows.Forms.Button();
            this.MTB_Pass = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.Btn_Ver_Senha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lv_Form
            // 
            this.Lv_Form.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Id,
            this.col_Product,
            this.col_qtd,
            this.col_preco});
            this.Lv_Form.FullRowSelect = true;
            this.Lv_Form.HideSelection = false;
            this.Lv_Form.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.Lv_Form.Location = new System.Drawing.Point(12, 12);
            this.Lv_Form.MultiSelect = false;
            this.Lv_Form.Name = "Lv_Form";
            this.Lv_Form.Size = new System.Drawing.Size(326, 216);
            this.Lv_Form.TabIndex = 0;
            this.Lv_Form.UseCompatibleStateImageBehavior = false;
            this.Lv_Form.View = System.Windows.Forms.View.Details;
            // 
            // col_Id
            // 
            this.col_Id.Text = "id";
            this.col_Id.Width = 20;
            // 
            // col_Product
            // 
            this.col_Product.Text = "produto";
            this.col_Product.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_Product.Width = 150;
            // 
            // col_qtd
            // 
            this.col_qtd.Text = "quantidade";
            this.col_qtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // col_preco
            // 
            this.col_preco.Text = "preco";
            this.col_preco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxBox_Id
            // 
            this.TxBox_Id.Location = new System.Drawing.Point(24, 133);
            this.TxBox_Id.Name = "TxBox_Id";
            this.TxBox_Id.Size = new System.Drawing.Size(49, 20);
            this.TxBox_Id.TabIndex = 1;
            // 
            // TxBox_Produto
            // 
            this.TxBox_Produto.Location = new System.Drawing.Point(79, 136);
            this.TxBox_Produto.Name = "TxBox_Produto";
            this.TxBox_Produto.Size = new System.Drawing.Size(100, 20);
            this.TxBox_Produto.TabIndex = 2;
            // 
            // TxBox_Descrition
            // 
            this.TxBox_Descrition.Location = new System.Drawing.Point(57, 190);
            this.TxBox_Descrition.Name = "TxBox_Descrition";
            this.TxBox_Descrition.Size = new System.Drawing.Size(192, 20);
            this.TxBox_Descrition.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descricão";
            // 
            // TxBox_Qd
            // 
            this.TxBox_Qd.Location = new System.Drawing.Point(194, 136);
            this.TxBox_Qd.Name = "TxBox_Qd";
            this.TxBox_Qd.Size = new System.Drawing.Size(55, 20);
            this.TxBox_Qd.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantidade";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "preço";
            // 
            // TxBox_preco
            // 
            this.TxBox_preco.Location = new System.Drawing.Point(255, 136);
            this.TxBox_preco.Name = "TxBox_preco";
            this.TxBox_preco.Size = new System.Drawing.Size(66, 20);
            this.TxBox_preco.TabIndex = 10;
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(24, 235);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(75, 23);
            this.Btn_Add.TabIndex = 11;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Get
            // 
            this.Btn_Get.Location = new System.Drawing.Point(278, 235);
            this.Btn_Get.Name = "Btn_Get";
            this.Btn_Get.Size = new System.Drawing.Size(75, 23);
            this.Btn_Get.TabIndex = 12;
            this.Btn_Get.Text = "Get";
            this.Btn_Get.UseVisualStyleBackColor = true;
            this.Btn_Get.Click += new System.EventHandler(this.Btn_Get_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Location = new System.Drawing.Point(197, 235);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Edit.TabIndex = 13;
            this.Btn_Edit.Text = "Edit";
            this.Btn_Edit.UseVisualStyleBackColor = true;
            // 
            // Btn_Del
            // 
            this.Btn_Del.Location = new System.Drawing.Point(116, 235);
            this.Btn_Del.Name = "Btn_Del";
            this.Btn_Del.Size = new System.Drawing.Size(75, 23);
            this.Btn_Del.TabIndex = 14;
            this.Btn_Del.Text = "Del";
            this.Btn_Del.UseVisualStyleBackColor = true;
            this.Btn_Del.Click += new System.EventHandler(this.Btn_Del_Click);
            // 
            // MTB_Pass
            // 
            this.MTB_Pass.Location = new System.Drawing.Point(457, 95);
            this.MTB_Pass.Name = "MTB_Pass";
            this.MTB_Pass.PasswordChar = '*';
            this.MTB_Pass.Size = new System.Drawing.Size(100, 20);
            this.MTB_Pass.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(477, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Senha";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(457, 135);
            this.maskedTextBox1.Mask = "+00 (00) 00000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 17;
            // 
            // Btn_Ver_Senha
            // 
            this.Btn_Ver_Senha.Location = new System.Drawing.Point(613, 91);
            this.Btn_Ver_Senha.Name = "Btn_Ver_Senha";
            this.Btn_Ver_Senha.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ver_Senha.TabIndex = 18;
            this.Btn_Ver_Senha.Text = "Ver senha";
            this.Btn_Ver_Senha.UseVisualStyleBackColor = true;
            this.Btn_Ver_Senha.Click += new System.EventHandler(this.Btn_Ver_Senha_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Ver_Senha);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MTB_Pass);
            this.Controls.Add(this.Btn_Del);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.Btn_Get);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.TxBox_preco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxBox_Qd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxBox_Descrition);
            this.Controls.Add(this.TxBox_Produto);
            this.Controls.Add(this.TxBox_Id);
            this.Controls.Add(this.Lv_Form);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Lv_Form;
        private System.Windows.Forms.ColumnHeader col_Id;
        private System.Windows.Forms.ColumnHeader col_Product;
        private System.Windows.Forms.ColumnHeader col_qtd;
        private System.Windows.Forms.ColumnHeader col_preco;
        private System.Windows.Forms.TextBox TxBox_Id;
        private System.Windows.Forms.TextBox TxBox_Produto;
        private System.Windows.Forms.TextBox TxBox_Descrition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxBox_Qd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxBox_preco;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Get;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_Del;
        private System.Windows.Forms.MaskedTextBox MTB_Pass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button Btn_Ver_Senha;
    }
}