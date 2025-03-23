namespace SQLITE
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel_Bottom = new System.Windows.Forms.Panel();
            this.Label_User = new System.Windows.Forms.Label();
            this.Label_User_Pont = new System.Windows.Forms.Label();
            this.PinBox_OnOff = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerstãoUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PinBox_OnOff)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Bottom
            // 
            this.Panel_Bottom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel_Bottom.Controls.Add(this.Label_User);
            this.Panel_Bottom.Controls.Add(this.Label_User_Pont);
            this.Panel_Bottom.Controls.Add(this.PinBox_OnOff);
            this.Panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Bottom.Location = new System.Drawing.Point(0, 348);
            this.Panel_Bottom.Name = "Panel_Bottom";
            this.Panel_Bottom.Size = new System.Drawing.Size(800, 45);
            this.Panel_Bottom.TabIndex = 0;
            this.Panel_Bottom.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Bottom_Paint);
            // 
            // Label_User
            // 
            this.Label_User.AutoSize = true;
            this.Label_User.Location = new System.Drawing.Point(89, 23);
            this.Label_User.Name = "Label_User";
            this.Label_User.Size = new System.Drawing.Size(16, 13);
            this.Label_User.TabIndex = 2;
            this.Label_User.Text = "...";
            // 
            // Label_User_Pont
            // 
            this.Label_User_Pont.AutoSize = true;
            this.Label_User_Pont.Location = new System.Drawing.Point(60, 23);
            this.Label_User_Pont.Name = "Label_User_Pont";
            this.Label_User_Pont.Size = new System.Drawing.Size(32, 13);
            this.Label_User_Pont.TabIndex = 1;
            this.Label_User_Pont.Text = "User:";
            // 
            // PinBox_OnOff
            // 
            this.PinBox_OnOff.Image = global::SQLITE.Properties.Resources.off;
            this.PinBox_OnOff.Location = new System.Drawing.Point(12, 17);
            this.PinBox_OnOff.Name = "PinBox_OnOff";
            this.PinBox_OnOff.Size = new System.Drawing.Size(28, 19);
            this.PinBox_OnOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PinBox_OnOff.TabIndex = 0;
            this.PinBox_OnOff.TabStop = false;
            this.PinBox_OnOff.Click += new System.EventHandler(this.PinBox_OnOff_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.manutençãoToolStripMenuItem,
            this.lOGINToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lOGINToolStripMenuItem
            // 
            this.lOGINToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            this.lOGINToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.lOGINToolStripMenuItem.Text = "LOGIN";
            this.lOGINToolStripMenuItem.Click += new System.EventHandler(this.lOGINToolStripMenuItem_Click);
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bancoToolStripMenuItem});
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.manutençãoToolStripMenuItem.Text = "Manutenção";
            this.manutençãoToolStripMenuItem.Click += new System.EventHandler(this.manutençãoToolStripMenuItem_Click);
            // 
            // bancoToolStripMenuItem
            // 
            this.bancoToolStripMenuItem.Name = "bancoToolStripMenuItem";
            this.bancoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bancoToolStripMenuItem.Text = "Banco";
            this.bancoToolStripMenuItem.Click += new System.EventHandler(this.bancoToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoUserToolStripMenuItem,
            this.gerstãoUserToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // novoUserToolStripMenuItem
            // 
            this.novoUserToolStripMenuItem.Name = "novoUserToolStripMenuItem";
            this.novoUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoUserToolStripMenuItem.Text = "Novo user";
            this.novoUserToolStripMenuItem.Click += new System.EventHandler(this.novoUserToolStripMenuItem_Click);
            // 
            // gerstãoUserToolStripMenuItem
            // 
            this.gerstãoUserToolStripMenuItem.Name = "gerstãoUserToolStripMenuItem";
            this.gerstãoUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gerstãoUserToolStripMenuItem.Text = "Gerstão user";
            this.gerstãoUserToolStripMenuItem.Click += new System.EventHandler(this.gerstãoUserToolStripMenuItem_Click);
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.alunosToolStripMenuItem.Text = "Alunos";
            this.alunosToolStripMenuItem.Click += new System.EventHandler(this.alunosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 393);
            this.Controls.Add(this.Panel_Bottom);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Login V 1.0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel_Bottom.ResumeLayout(false);
            this.Panel_Bottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PinBox_OnOff)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Bottom;
        public System.Windows.Forms.PictureBox PinBox_OnOff;
        private System.Windows.Forms.Label Label_User_Pont;
        public System.Windows.Forms.Label Label_User;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerstãoUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

