namespace aula_vs01
{
    partial class Form1
    {
        public int num = 0;
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
            this.TxBox_Add_InList = new System.Windows.Forms.TextBox();
            this.btn_Add_InList = new System.Windows.Forms.Button();
            this.LB_Env_Add = new System.Windows.Forms.Label();
            this.Btn_Cls_List = new System.Windows.Forms.Button();
            this.ListBox_List = new System.Windows.Forms.ListBox();
            this.Btn_Open_NewForm = new System.Windows.Forms.Button();
            this.Btn_Viwer_Num = new System.Windows.Forms.Button();
            this.MenuStrip_Form1 = new System.Windows.Forms.MenuStrip();
            this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chexkboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form02ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form04ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form05ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form06ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form07ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Ll_Youtube = new System.Windows.Forms.LinkLabel();
            this.Ll_Calculadora = new System.Windows.Forms.LinkLabel();
            this.HGYoDh = new System.Windows.Forms.LinkLabel();
            this.sQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Form1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxBox_Add_InList
            // 
            this.TxBox_Add_InList.Location = new System.Drawing.Point(12, 44);
            this.TxBox_Add_InList.Name = "TxBox_Add_InList";
            this.TxBox_Add_InList.Size = new System.Drawing.Size(100, 20);
            this.TxBox_Add_InList.TabIndex = 0;
            this.TxBox_Add_InList.TextChanged += new System.EventHandler(this.TxBox_Env_Name_TextChanged);
            // 
            // btn_Add_InList
            // 
            this.btn_Add_InList.Location = new System.Drawing.Point(118, 41);
            this.btn_Add_InList.Name = "btn_Add_InList";
            this.btn_Add_InList.Size = new System.Drawing.Size(75, 23);
            this.btn_Add_InList.TabIndex = 1;
            this.btn_Add_InList.Text = "Adicionar";
            this.btn_Add_InList.UseVisualStyleBackColor = true;
            this.btn_Add_InList.Click += new System.EventHandler(this.btn_Env_Name_Click);
            // 
            // LB_Env_Add
            // 
            this.LB_Env_Add.AutoSize = true;
            this.LB_Env_Add.Location = new System.Drawing.Point(9, 28);
            this.LB_Env_Add.Name = "LB_Env_Add";
            this.LB_Env_Add.Size = new System.Drawing.Size(92, 13);
            this.LB_Env_Add.TabIndex = 2;
            this.LB_Env_Add.Text = "Adicione produtos";
            this.LB_Env_Add.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btn_Cls_List
            // 
            this.Btn_Cls_List.Location = new System.Drawing.Point(58, 282);
            this.Btn_Cls_List.Name = "Btn_Cls_List";
            this.Btn_Cls_List.Size = new System.Drawing.Size(89, 30);
            this.Btn_Cls_List.TabIndex = 5;
            this.Btn_Cls_List.Text = "Limpar";
            this.Btn_Cls_List.UseVisualStyleBackColor = true;
            this.Btn_Cls_List.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListBox_List
            // 
            this.ListBox_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.ListBox_List.FormattingEnabled = true;
            this.ListBox_List.ItemHeight = 22;
            this.ListBox_List.Location = new System.Drawing.Point(12, 70);
            this.ListBox_List.Name = "ListBox_List";
            this.ListBox_List.Size = new System.Drawing.Size(181, 202);
            this.ListBox_List.TabIndex = 6;
            // 
            // Btn_Open_NewForm
            // 
            this.Btn_Open_NewForm.Location = new System.Drawing.Point(58, 332);
            this.Btn_Open_NewForm.Name = "Btn_Open_NewForm";
            this.Btn_Open_NewForm.Size = new System.Drawing.Size(89, 23);
            this.Btn_Open_NewForm.TabIndex = 7;
            this.Btn_Open_NewForm.Text = "Abri Formulario";
            this.Btn_Open_NewForm.UseVisualStyleBackColor = true;
            this.Btn_Open_NewForm.Click += new System.EventHandler(this.Btn_Open_NewForm_Click);
            // 
            // Btn_Viwer_Num
            // 
            this.Btn_Viwer_Num.Location = new System.Drawing.Point(58, 361);
            this.Btn_Viwer_Num.Name = "Btn_Viwer_Num";
            this.Btn_Viwer_Num.Size = new System.Drawing.Size(89, 23);
            this.Btn_Viwer_Num.TabIndex = 8;
            this.Btn_Viwer_Num.Text = "Ver num";
            this.Btn_Viwer_Num.UseVisualStyleBackColor = true;
            this.Btn_Viwer_Num.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MenuStrip_Form1
            // 
            this.MenuStrip_Form1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentesToolStripMenuItem});
            this.MenuStrip_Form1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_Form1.Name = "MenuStrip_Form1";
            this.MenuStrip_Form1.Size = new System.Drawing.Size(783, 24);
            this.MenuStrip_Form1.TabIndex = 9;
            this.MenuStrip_Form1.Text = "menuStrip1";
            // 
            // componentesToolStripMenuItem
            // 
            this.componentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chexkboxToolStripMenuItem,
            this.form04ToolStripMenuItem,
            this.form05ToolStripMenuItem,
            this.form06ToolStripMenuItem,
            this.form07ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sQLToolStripMenuItem});
            this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            this.componentesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.componentesToolStripMenuItem.Text = "Componentes";
            // 
            // chexkboxToolStripMenuItem
            // 
            this.chexkboxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form02ToolStripMenuItem});
            this.chexkboxToolStripMenuItem.Name = "chexkboxToolStripMenuItem";
            this.chexkboxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chexkboxToolStripMenuItem.Text = "Form03";
            this.chexkboxToolStripMenuItem.Click += new System.EventHandler(this.chexkboxToolStripMenuItem_Click);
            // 
            // form02ToolStripMenuItem
            // 
            this.form02ToolStripMenuItem.Name = "form02ToolStripMenuItem";
            this.form02ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.form02ToolStripMenuItem.Text = "Form02";
            this.form02ToolStripMenuItem.Click += new System.EventHandler(this.form02ToolStripMenuItem_Click);
            // 
            // form04ToolStripMenuItem
            // 
            this.form04ToolStripMenuItem.Name = "form04ToolStripMenuItem";
            this.form04ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.form04ToolStripMenuItem.Text = "Form04";
            this.form04ToolStripMenuItem.Click += new System.EventHandler(this.form04ToolStripMenuItem_Click);
            // 
            // form05ToolStripMenuItem
            // 
            this.form05ToolStripMenuItem.Name = "form05ToolStripMenuItem";
            this.form05ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.form05ToolStripMenuItem.Text = "Form05";
            this.form05ToolStripMenuItem.Click += new System.EventHandler(this.form05ToolStripMenuItem_Click);
            // 
            // form06ToolStripMenuItem
            // 
            this.form06ToolStripMenuItem.Name = "form06ToolStripMenuItem";
            this.form06ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.form06ToolStripMenuItem.Text = "Form06";
            this.form06ToolStripMenuItem.Click += new System.EventHandler(this.form06ToolStripMenuItem_Click);
            // 
            // form07ToolStripMenuItem
            // 
            this.form07ToolStripMenuItem.Name = "form07ToolStripMenuItem";
            this.form07ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.form07ToolStripMenuItem.Text = "Form07";
            this.form07ToolStripMenuItem.Click += new System.EventHandler(this.form07ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Form08";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Ll_Youtube
            // 
            this.Ll_Youtube.AutoSize = true;
            this.Ll_Youtube.Location = new System.Drawing.Point(309, 83);
            this.Ll_Youtube.Name = "Ll_Youtube";
            this.Ll_Youtube.Size = new System.Drawing.Size(47, 13);
            this.Ll_Youtube.TabIndex = 10;
            this.Ll_Youtube.TabStop = true;
            this.Ll_Youtube.Text = "Youtube";
            this.Ll_Youtube.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Ll_Youtube_LinkClicked);
            // 
            // Ll_Calculadora
            // 
            this.Ll_Calculadora.AutoSize = true;
            this.Ll_Calculadora.Location = new System.Drawing.Point(419, 83);
            this.Ll_Calculadora.Name = "Ll_Calculadora";
            this.Ll_Calculadora.Size = new System.Drawing.Size(63, 13);
            this.Ll_Calculadora.TabIndex = 11;
            this.Ll_Calculadora.TabStop = true;
            this.Ll_Calculadora.Text = "Calculadora";
            this.Ll_Calculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Ll_Calculadora_LinkClicked);
            // 
            // HGYoDh
            // 
            this.HGYoDh.AutoSize = true;
            this.HGYoDh.Location = new System.Drawing.Point(319, 146);
            this.HGYoDh.Name = "HGYoDh";
            this.HGYoDh.Size = new System.Drawing.Size(163, 13);
            this.HGYoDh.TabIndex = 12;
            this.HGYoDh.TabStop = true;
            this.HGYoDh.Text = "Hagelab  _  Youtube _  Dheanny";
            this.HGYoDh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HGYoDh_LinkClicked);
            // 
            // sQLToolStripMenuItem
            // 
            this.sQLToolStripMenuItem.Name = "sQLToolStripMenuItem";
            this.sQLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sQLToolStripMenuItem.Text = "SQL";
            this.sQLToolStripMenuItem.Click += new System.EventHandler(this.sQLToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 417);
            this.Controls.Add(this.HGYoDh);
            this.Controls.Add(this.Ll_Calculadora);
            this.Controls.Add(this.Ll_Youtube);
            this.Controls.Add(this.Btn_Viwer_Num);
            this.Controls.Add(this.Btn_Open_NewForm);
            this.Controls.Add(this.ListBox_List);
            this.Controls.Add(this.Btn_Cls_List);
            this.Controls.Add(this.LB_Env_Add);
            this.Controls.Add(this.btn_Add_InList);
            this.Controls.Add(this.TxBox_Add_InList);
            this.Controls.Add(this.MenuStrip_Form1);
            this.MainMenuStrip = this.MenuStrip_Form1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MenuStrip_Form1.ResumeLayout(false);
            this.MenuStrip_Form1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxBox_Add_InList;
        private System.Windows.Forms.Button btn_Add_InList;
        private System.Windows.Forms.Label LB_Env_Add;
        private System.Windows.Forms.Button Btn_Cls_List;
        public System.Windows.Forms.ListBox ListBox_List;
        private System.Windows.Forms.Button Btn_Open_NewForm;
        private System.Windows.Forms.Button Btn_Viwer_Num;
        private System.Windows.Forms.MenuStrip MenuStrip_Form1;
        private System.Windows.Forms.ToolStripMenuItem componentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chexkboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form02ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form04ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form05ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form06ToolStripMenuItem;
        private System.Windows.Forms.LinkLabel Ll_Youtube;
        private System.Windows.Forms.LinkLabel Ll_Calculadora;
        private System.Windows.Forms.LinkLabel HGYoDh;
        private System.Windows.Forms.ToolStripMenuItem form07ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sQLToolStripMenuItem;
    }
}

