namespace SQLITE
{
    partial class Gestao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NUB_Nivel = new System.Windows.Forms.NumericUpDown();
            this.Lb_Nivel = new System.Windows.Forms.Label();
            this.Lb_status = new System.Windows.Forms.Label();
            this.Lb_Senha = new System.Windows.Forms.Label();
            this.Lb_UserName = new System.Windows.Forms.Label();
            this.Lb_Nome = new System.Windows.Forms.Label();
            this.TxBox_Status = new System.Windows.Forms.TextBox();
            this.TxBox_Password = new System.Windows.Forms.TextBox();
            this.TxBox_User = new System.Windows.Forms.TextBox();
            this.TxBox_Name = new System.Windows.Forms.TextBox();
            this.TxBox_Id = new System.Windows.Forms.TextBox();
            this.Lb_Id = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.Btn_Novo = new System.Windows.Forms.Button();
            this.Btn_Excluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUB_Nivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NUB_Nivel
            // 
            this.NUB_Nivel.Location = new System.Drawing.Point(133, 264);
            this.NUB_Nivel.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NUB_Nivel.Name = "NUB_Nivel";
            this.NUB_Nivel.Size = new System.Drawing.Size(83, 20);
            this.NUB_Nivel.TabIndex = 20;
            // 
            // Lb_Nivel
            // 
            this.Lb_Nivel.AutoSize = true;
            this.Lb_Nivel.Location = new System.Drawing.Point(170, 238);
            this.Lb_Nivel.Name = "Lb_Nivel";
            this.Lb_Nivel.Size = new System.Drawing.Size(31, 13);
            this.Lb_Nivel.TabIndex = 19;
            this.Lb_Nivel.Text = "Nivel";
            // 
            // Lb_status
            // 
            this.Lb_status.AutoSize = true;
            this.Lb_status.Location = new System.Drawing.Point(39, 238);
            this.Lb_status.Name = "Lb_status";
            this.Lb_status.Size = new System.Drawing.Size(35, 13);
            this.Lb_status.TabIndex = 18;
            this.Lb_status.Text = "status";
            // 
            // Lb_Senha
            // 
            this.Lb_Senha.AutoSize = true;
            this.Lb_Senha.Location = new System.Drawing.Point(163, 158);
            this.Lb_Senha.Name = "Lb_Senha";
            this.Lb_Senha.Size = new System.Drawing.Size(38, 13);
            this.Lb_Senha.TabIndex = 17;
            this.Lb_Senha.Text = "Senha";
            // 
            // Lb_UserName
            // 
            this.Lb_UserName.AutoSize = true;
            this.Lb_UserName.Location = new System.Drawing.Point(37, 155);
            this.Lb_UserName.Name = "Lb_UserName";
            this.Lb_UserName.Size = new System.Drawing.Size(57, 13);
            this.Lb_UserName.TabIndex = 16;
            this.Lb_UserName.Text = "UserName";
            // 
            // Lb_Nome
            // 
            this.Lb_Nome.AutoSize = true;
            this.Lb_Nome.Location = new System.Drawing.Point(39, 76);
            this.Lb_Nome.Name = "Lb_Nome";
            this.Lb_Nome.Size = new System.Drawing.Size(35, 13);
            this.Lb_Nome.TabIndex = 15;
            this.Lb_Nome.Text = "Nome";
            // 
            // TxBox_Status
            // 
            this.TxBox_Status.Location = new System.Drawing.Point(12, 263);
            this.TxBox_Status.Name = "TxBox_Status";
            this.TxBox_Status.Size = new System.Drawing.Size(91, 20);
            this.TxBox_Status.TabIndex = 14;
            // 
            // TxBox_Password
            // 
            this.TxBox_Password.Location = new System.Drawing.Point(125, 174);
            this.TxBox_Password.Name = "TxBox_Password";
            this.TxBox_Password.Size = new System.Drawing.Size(91, 20);
            this.TxBox_Password.TabIndex = 13;
            // 
            // TxBox_User
            // 
            this.TxBox_User.Location = new System.Drawing.Point(12, 174);
            this.TxBox_User.Name = "TxBox_User";
            this.TxBox_User.Size = new System.Drawing.Size(91, 20);
            this.TxBox_User.TabIndex = 12;
            // 
            // TxBox_Name
            // 
            this.TxBox_Name.Location = new System.Drawing.Point(12, 95);
            this.TxBox_Name.Name = "TxBox_Name";
            this.TxBox_Name.Size = new System.Drawing.Size(204, 20);
            this.TxBox_Name.TabIndex = 11;
            // 
            // TxBox_Id
            // 
            this.TxBox_Id.Location = new System.Drawing.Point(55, 37);
            this.TxBox_Id.Name = "TxBox_Id";
            this.TxBox_Id.ReadOnly = true;
            this.TxBox_Id.Size = new System.Drawing.Size(91, 20);
            this.TxBox_Id.TabIndex = 21;
            this.TxBox_Id.TabStop = false;
            // 
            // Lb_Id
            // 
            this.Lb_Id.AutoSize = true;
            this.Lb_Id.Location = new System.Drawing.Point(94, 21);
            this.Lb_Id.Name = "Lb_Id";
            this.Lb_Id.Size = new System.Drawing.Size(18, 13);
            this.Lb_Id.TabIndex = 22;
            this.Lb_Id.Text = "ID";
            this.Lb_Id.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(290, 37);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(270, 272);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Location = new System.Drawing.Point(85, 328);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Salvar.TabIndex = 25;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Btn_Novo
            // 
            this.Btn_Novo.Location = new System.Drawing.Point(4, 328);
            this.Btn_Novo.Name = "Btn_Novo";
            this.Btn_Novo.Size = new System.Drawing.Size(75, 23);
            this.Btn_Novo.TabIndex = 24;
            this.Btn_Novo.Text = "Novo";
            this.Btn_Novo.UseVisualStyleBackColor = true;
            this.Btn_Novo.Click += new System.EventHandler(this.Btn_Novo_Click);
            // 
            // Btn_Excluir
            // 
            this.Btn_Excluir.Location = new System.Drawing.Point(166, 328);
            this.Btn_Excluir.Name = "Btn_Excluir";
            this.Btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.Btn_Excluir.TabIndex = 27;
            this.Btn_Excluir.Text = "Excluir";
            this.Btn_Excluir.UseVisualStyleBackColor = true;
            this.Btn_Excluir.Click += new System.EventHandler(this.Btn_Excluir_Click);
            // 
            // Gestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 351);
            this.Controls.Add(this.Btn_Excluir);
            this.Controls.Add(this.Btn_Salvar);
            this.Controls.Add(this.Btn_Novo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Lb_Id);
            this.Controls.Add(this.TxBox_Id);
            this.Controls.Add(this.NUB_Nivel);
            this.Controls.Add(this.Lb_Nivel);
            this.Controls.Add(this.Lb_status);
            this.Controls.Add(this.Lb_Senha);
            this.Controls.Add(this.Lb_UserName);
            this.Controls.Add(this.Lb_Nome);
            this.Controls.Add(this.TxBox_Status);
            this.Controls.Add(this.TxBox_Password);
            this.Controls.Add(this.TxBox_User);
            this.Controls.Add(this.TxBox_Name);
            this.Name = "Gestao";
            this.Text = "Gestao";
            this.Load += new System.EventHandler(this.Gestao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUB_Nivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NUB_Nivel;
        private System.Windows.Forms.Label Lb_Nivel;
        private System.Windows.Forms.Label Lb_status;
        private System.Windows.Forms.Label Lb_Senha;
        private System.Windows.Forms.Label Lb_UserName;
        private System.Windows.Forms.Label Lb_Nome;
        private System.Windows.Forms.TextBox TxBox_Status;
        private System.Windows.Forms.TextBox TxBox_Password;
        private System.Windows.Forms.TextBox TxBox_User;
        private System.Windows.Forms.TextBox TxBox_Name;
        private System.Windows.Forms.TextBox TxBox_Id;
        private System.Windows.Forms.Label Lb_Id;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.Button Btn_Novo;
        private System.Windows.Forms.Button Btn_Excluir;
    }
}