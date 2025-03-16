namespace aula_vs01
{
    partial class Form5
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
            this.Clb_Form5 = new System.Windows.Forms.CheckedListBox();
            this.Btn_Viwer = new System.Windows.Forms.Button();
            this.Btn_Cls = new System.Windows.Forms.Button();
            this.Tb_Add = new System.Windows.Forms.TextBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Rst = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Mc_Calendario = new System.Windows.Forms.MonthCalendar();
            this.TxBox_Begin = new System.Windows.Forms.TextBox();
            this.TxBox_End = new System.Windows.Forms.TextBox();
            this.TxBox_Now = new System.Windows.Forms.TextBox();
            this.Btn_Serch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Clb_Form5
            // 
            this.Clb_Form5.FormattingEnabled = true;
            this.Clb_Form5.Items.AddRange(new object[] {
            "Liao",
            "Tigre",
            "Mamaco",
            "Python",
            "Ai"});
            this.Clb_Form5.Location = new System.Drawing.Point(12, 12);
            this.Clb_Form5.Name = "Clb_Form5";
            this.Clb_Form5.Size = new System.Drawing.Size(120, 154);
            this.Clb_Form5.TabIndex = 0;
            // 
            // Btn_Viwer
            // 
            this.Btn_Viwer.Location = new System.Drawing.Point(173, 12);
            this.Btn_Viwer.Name = "Btn_Viwer";
            this.Btn_Viwer.Size = new System.Drawing.Size(75, 23);
            this.Btn_Viwer.TabIndex = 1;
            this.Btn_Viwer.Text = "Mostrar";
            this.Btn_Viwer.UseVisualStyleBackColor = true;
            this.Btn_Viwer.Click += new System.EventHandler(this.Btn_Viwer_Click);
            // 
            // Btn_Cls
            // 
            this.Btn_Cls.Location = new System.Drawing.Point(173, 41);
            this.Btn_Cls.Name = "Btn_Cls";
            this.Btn_Cls.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cls.TabIndex = 2;
            this.Btn_Cls.Text = "LImpar_Selec";
            this.Btn_Cls.UseVisualStyleBackColor = true;
            this.Btn_Cls.Click += new System.EventHandler(this.Btn_Cls_Click);
            // 
            // Tb_Add
            // 
            this.Tb_Add.Location = new System.Drawing.Point(173, 111);
            this.Tb_Add.Name = "Tb_Add";
            this.Tb_Add.Size = new System.Drawing.Size(100, 20);
            this.Tb_Add.TabIndex = 3;
            this.Tb_Add.TextChanged += new System.EventHandler(this.Tb_Add_TextChanged);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(173, 138);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(75, 23);
            this.Btn_Add.TabIndex = 4;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Rst
            // 
            this.Btn_Rst.Location = new System.Drawing.Point(173, 71);
            this.Btn_Rst.Name = "Btn_Rst";
            this.Btn_Rst.Size = new System.Drawing.Size(75, 23);
            this.Btn_Rst.TabIndex = 5;
            this.Btn_Rst.Text = "Limpar Tudo";
            this.Btn_Rst.UseVisualStyleBackColor = true;
            this.Btn_Rst.Click += new System.EventHandler(this.Btn_Rst_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Resetar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mc_Calendario
            // 
            this.Mc_Calendario.Location = new System.Drawing.Point(387, 41);
            this.Mc_Calendario.Name = "Mc_Calendario";
            this.Mc_Calendario.TabIndex = 7;
            // 
            // TxBox_Begin
            // 
            this.TxBox_Begin.Location = new System.Drawing.Point(357, 247);
            this.TxBox_Begin.Name = "TxBox_Begin";
            this.TxBox_Begin.Size = new System.Drawing.Size(100, 20);
            this.TxBox_Begin.TabIndex = 8;
            this.TxBox_Begin.TextChanged += new System.EventHandler(this.TxBox_Begin_TextChanged);
            // 
            // TxBox_End
            // 
            this.TxBox_End.Location = new System.Drawing.Point(499, 247);
            this.TxBox_End.Name = "TxBox_End";
            this.TxBox_End.Size = new System.Drawing.Size(100, 20);
            this.TxBox_End.TabIndex = 9;
            // 
            // TxBox_Now
            // 
            this.TxBox_Now.Location = new System.Drawing.Point(413, 293);
            this.TxBox_Now.Name = "TxBox_Now";
            this.TxBox_Now.Size = new System.Drawing.Size(100, 20);
            this.TxBox_Now.TabIndex = 10;
            // 
            // Btn_Serch
            // 
            this.Btn_Serch.Location = new System.Drawing.Point(523, 289);
            this.Btn_Serch.Name = "Btn_Serch";
            this.Btn_Serch.Size = new System.Drawing.Size(75, 23);
            this.Btn_Serch.TabIndex = 11;
            this.Btn_Serch.Text = "button2";
            this.Btn_Serch.UseVisualStyleBackColor = true;
            this.Btn_Serch.Click += new System.EventHandler(this.Btn_Serch_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Serch);
            this.Controls.Add(this.TxBox_Now);
            this.Controls.Add(this.TxBox_End);
            this.Controls.Add(this.TxBox_Begin);
            this.Controls.Add(this.Mc_Calendario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Rst);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Tb_Add);
            this.Controls.Add(this.Btn_Cls);
            this.Controls.Add(this.Btn_Viwer);
            this.Controls.Add(this.Clb_Form5);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox Clb_Form5;
        private System.Windows.Forms.Button Btn_Viwer;
        private System.Windows.Forms.Button Btn_Cls;
        private System.Windows.Forms.TextBox Tb_Add;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Rst;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar Mc_Calendario;
        private System.Windows.Forms.TextBox TxBox_Begin;
        private System.Windows.Forms.TextBox TxBox_End;
        private System.Windows.Forms.TextBox TxBox_Now;
        private System.Windows.Forms.Button Btn_Serch;
    }
}