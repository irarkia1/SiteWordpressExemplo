namespace SQLITE
{
    partial class Cadastro
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
            this.TxBox_Name = new System.Windows.Forms.TextBox();
            this.TxBox_User = new System.Windows.Forms.TextBox();
            this.TxBox_Password = new System.Windows.Forms.TextBox();
            this.TxBox_Status = new System.Windows.Forms.TextBox();
            this.Lb_Nome = new System.Windows.Forms.Label();
            this.Lb_UserName = new System.Windows.Forms.Label();
            this.Lb_Senha = new System.Windows.Forms.Label();
            this.Lb_status = new System.Windows.Forms.Label();
            this.Lb_Nivel = new System.Windows.Forms.Label();
            this.NUB_Nivel = new System.Windows.Forms.NumericUpDown();
            this.Btn_Novo = new System.Windows.Forms.Button();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUB_Nivel)).BeginInit();
            this.SuspendLayout();
            // 
            // TxBox_Name
            // 
            this.TxBox_Name.Location = new System.Drawing.Point(12, 51);
            this.TxBox_Name.Name = "TxBox_Name";
            this.TxBox_Name.Size = new System.Drawing.Size(193, 20);
            this.TxBox_Name.TabIndex = 0;
            // 
            // TxBox_User
            // 
            this.TxBox_User.Location = new System.Drawing.Point(232, 51);
            this.TxBox_User.Name = "TxBox_User";
            this.TxBox_User.Size = new System.Drawing.Size(91, 20);
            this.TxBox_User.TabIndex = 1;
            // 
            // TxBox_Password
            // 
            this.TxBox_Password.Location = new System.Drawing.Point(345, 51);
            this.TxBox_Password.Name = "TxBox_Password";
            this.TxBox_Password.Size = new System.Drawing.Size(91, 20);
            this.TxBox_Password.TabIndex = 2;
            // 
            // TxBox_Status
            // 
            this.TxBox_Status.Location = new System.Drawing.Point(12, 137);
            this.TxBox_Status.Name = "TxBox_Status";
            this.TxBox_Status.Size = new System.Drawing.Size(91, 20);
            this.TxBox_Status.TabIndex = 3;
            // 
            // Lb_Nome
            // 
            this.Lb_Nome.AutoSize = true;
            this.Lb_Nome.Location = new System.Drawing.Point(39, 32);
            this.Lb_Nome.Name = "Lb_Nome";
            this.Lb_Nome.Size = new System.Drawing.Size(35, 13);
            this.Lb_Nome.TabIndex = 5;
            this.Lb_Nome.Text = "Nome";
            // 
            // Lb_UserName
            // 
            this.Lb_UserName.AutoSize = true;
            this.Lb_UserName.Location = new System.Drawing.Point(257, 32);
            this.Lb_UserName.Name = "Lb_UserName";
            this.Lb_UserName.Size = new System.Drawing.Size(57, 13);
            this.Lb_UserName.TabIndex = 6;
            this.Lb_UserName.Text = "UserName";
            // 
            // Lb_Senha
            // 
            this.Lb_Senha.AutoSize = true;
            this.Lb_Senha.Location = new System.Drawing.Point(383, 35);
            this.Lb_Senha.Name = "Lb_Senha";
            this.Lb_Senha.Size = new System.Drawing.Size(38, 13);
            this.Lb_Senha.TabIndex = 7;
            this.Lb_Senha.Text = "Senha";
            // 
            // Lb_status
            // 
            this.Lb_status.AutoSize = true;
            this.Lb_status.Location = new System.Drawing.Point(39, 112);
            this.Lb_status.Name = "Lb_status";
            this.Lb_status.Size = new System.Drawing.Size(35, 13);
            this.Lb_status.TabIndex = 8;
            this.Lb_status.Text = "status";
            // 
            // Lb_Nivel
            // 
            this.Lb_Nivel.AutoSize = true;
            this.Lb_Nivel.Location = new System.Drawing.Point(170, 112);
            this.Lb_Nivel.Name = "Lb_Nivel";
            this.Lb_Nivel.Size = new System.Drawing.Size(31, 13);
            this.Lb_Nivel.TabIndex = 9;
            this.Lb_Nivel.Text = "Nivel";
            // 
            // NUB_Nivel
            // 
            this.NUB_Nivel.Location = new System.Drawing.Point(133, 138);
            this.NUB_Nivel.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NUB_Nivel.Name = "NUB_Nivel";
            this.NUB_Nivel.Size = new System.Drawing.Size(120, 20);
            this.NUB_Nivel.TabIndex = 10;
            // 
            // Btn_Novo
            // 
            this.Btn_Novo.Location = new System.Drawing.Point(12, 234);
            this.Btn_Novo.Name = "Btn_Novo";
            this.Btn_Novo.Size = new System.Drawing.Size(75, 23);
            this.Btn_Novo.TabIndex = 11;
            this.Btn_Novo.Text = "Novo";
            this.Btn_Novo.UseVisualStyleBackColor = true;
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Location = new System.Drawing.Point(93, 234);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Salvar.TabIndex = 12;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(178, 234);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancelar.TabIndex = 13;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Salvar);
            this.Controls.Add(this.Btn_Novo);
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
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.NUB_Nivel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxBox_Name;
        private System.Windows.Forms.TextBox TxBox_User;
        private System.Windows.Forms.TextBox TxBox_Password;
        private System.Windows.Forms.TextBox TxBox_Status;
        private System.Windows.Forms.Label Lb_Nome;
        private System.Windows.Forms.Label Lb_UserName;
        private System.Windows.Forms.Label Lb_Senha;
        private System.Windows.Forms.Label Lb_status;
        private System.Windows.Forms.Label Lb_Nivel;
        private System.Windows.Forms.NumericUpDown NUB_Nivel;
        private System.Windows.Forms.Button Btn_Novo;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.Button Btn_Cancelar;
    }
}