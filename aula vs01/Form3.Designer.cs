namespace aula_vs01
{
    partial class Form3
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
            this.Ckbox_Filho_Carro = new System.Windows.Forms.CheckBox();
            this.Ckbox_Filho_Moto = new System.Windows.Forms.CheckBox();
            this.Ckbox_Filho_Aviao = new System.Windows.Forms.CheckBox();
            this.Ckbox_Filho_Navio = new System.Windows.Forms.CheckBox();
            this.Cbb_01 = new System.Windows.Forms.ComboBox();
            this.Btn_01 = new System.Windows.Forms.Button();
            this.Btn_02 = new System.Windows.Forms.Button();
            this.Btn_03 = new System.Windows.Forms.Button();
            this.Txbox_01 = new System.Windows.Forms.TextBox();
            this.Btn_04 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ckbox_Filho_Carro
            // 
            this.Ckbox_Filho_Carro.AutoSize = true;
            this.Ckbox_Filho_Carro.Location = new System.Drawing.Point(12, 12);
            this.Ckbox_Filho_Carro.Name = "Ckbox_Filho_Carro";
            this.Ckbox_Filho_Carro.Size = new System.Drawing.Size(51, 17);
            this.Ckbox_Filho_Carro.TabIndex = 0;
            this.Ckbox_Filho_Carro.Text = "Carro";
            this.Ckbox_Filho_Carro.UseVisualStyleBackColor = true;
            this.Ckbox_Filho_Carro.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Ckbox_Filho_Moto
            // 
            this.Ckbox_Filho_Moto.AutoSize = true;
            this.Ckbox_Filho_Moto.Location = new System.Drawing.Point(12, 36);
            this.Ckbox_Filho_Moto.Name = "Ckbox_Filho_Moto";
            this.Ckbox_Filho_Moto.Size = new System.Drawing.Size(50, 17);
            this.Ckbox_Filho_Moto.TabIndex = 1;
            this.Ckbox_Filho_Moto.Text = "Moto";
            this.Ckbox_Filho_Moto.UseVisualStyleBackColor = true;
            this.Ckbox_Filho_Moto.CheckedChanged += new System.EventHandler(this.Ckbox_Filho_Moto_CheckedChanged);
            // 
            // Ckbox_Filho_Aviao
            // 
            this.Ckbox_Filho_Aviao.AutoSize = true;
            this.Ckbox_Filho_Aviao.Location = new System.Drawing.Point(12, 83);
            this.Ckbox_Filho_Aviao.Name = "Ckbox_Filho_Aviao";
            this.Ckbox_Filho_Aviao.Size = new System.Drawing.Size(53, 17);
            this.Ckbox_Filho_Aviao.TabIndex = 3;
            this.Ckbox_Filho_Aviao.Text = "Aviao";
            this.Ckbox_Filho_Aviao.UseVisualStyleBackColor = true;
            this.Ckbox_Filho_Aviao.CheckedChanged += new System.EventHandler(this.Ckbox_Filho_Aviao_CheckedChanged_1);
            // 
            // Ckbox_Filho_Navio
            // 
            this.Ckbox_Filho_Navio.AutoSize = true;
            this.Ckbox_Filho_Navio.Location = new System.Drawing.Point(12, 59);
            this.Ckbox_Filho_Navio.Name = "Ckbox_Filho_Navio";
            this.Ckbox_Filho_Navio.Size = new System.Drawing.Size(54, 17);
            this.Ckbox_Filho_Navio.TabIndex = 2;
            this.Ckbox_Filho_Navio.Text = "Navio";
            this.Ckbox_Filho_Navio.UseVisualStyleBackColor = true;
            this.Ckbox_Filho_Navio.CheckedChanged += new System.EventHandler(this.Ckbox_Filho_Navio_CheckedChanged);
            // 
            // Cbb_01
            // 
            this.Cbb_01.FormattingEnabled = true;
            this.Cbb_01.Items.AddRange(new object[] {
            "Nenha",
            "Mia",
            "Miyume",
            "beledefine"});
            this.Cbb_01.Location = new System.Drawing.Point(326, 13);
            this.Cbb_01.Name = "Cbb_01";
            this.Cbb_01.Size = new System.Drawing.Size(121, 21);
            this.Cbb_01.TabIndex = 4;
            // 
            // Btn_01
            // 
            this.Btn_01.Location = new System.Drawing.Point(462, 13);
            this.Btn_01.Name = "Btn_01";
            this.Btn_01.Size = new System.Drawing.Size(75, 23);
            this.Btn_01.TabIndex = 5;
            this.Btn_01.Text = "Btn_01";
            this.Btn_01.UseVisualStyleBackColor = true;
            this.Btn_01.Click += new System.EventHandler(this.Btn_01_Click);
            // 
            // Btn_02
            // 
            this.Btn_02.Location = new System.Drawing.Point(462, 42);
            this.Btn_02.Name = "Btn_02";
            this.Btn_02.Size = new System.Drawing.Size(75, 23);
            this.Btn_02.TabIndex = 6;
            this.Btn_02.Text = "Btn_02";
            this.Btn_02.UseVisualStyleBackColor = true;
            this.Btn_02.Click += new System.EventHandler(this.Btn_02_Click);
            // 
            // Btn_03
            // 
            this.Btn_03.Location = new System.Drawing.Point(462, 71);
            this.Btn_03.Name = "Btn_03";
            this.Btn_03.Size = new System.Drawing.Size(75, 23);
            this.Btn_03.TabIndex = 7;
            this.Btn_03.Text = "Btn_03";
            this.Btn_03.UseVisualStyleBackColor = true;
            this.Btn_03.Click += new System.EventHandler(this.Btn_03_Click);
            // 
            // Txbox_01
            // 
            this.Txbox_01.Location = new System.Drawing.Point(462, 101);
            this.Txbox_01.Name = "Txbox_01";
            this.Txbox_01.Size = new System.Drawing.Size(100, 20);
            this.Txbox_01.TabIndex = 8;
            this.Txbox_01.TextChanged += new System.EventHandler(this.Txbox_01_TextChanged);
            // 
            // Btn_04
            // 
            this.Btn_04.Location = new System.Drawing.Point(462, 127);
            this.Btn_04.Name = "Btn_04";
            this.Btn_04.Size = new System.Drawing.Size(75, 23);
            this.Btn_04.TabIndex = 9;
            this.Btn_04.Text = "Btn_04";
            this.Btn_04.UseVisualStyleBackColor = true;
            this.Btn_04.Click += new System.EventHandler(this.Btn_04_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_04);
            this.Controls.Add(this.Txbox_01);
            this.Controls.Add(this.Btn_03);
            this.Controls.Add(this.Btn_02);
            this.Controls.Add(this.Btn_01);
            this.Controls.Add(this.Cbb_01);
            this.Controls.Add(this.Ckbox_Filho_Aviao);
            this.Controls.Add(this.Ckbox_Filho_Navio);
            this.Controls.Add(this.Ckbox_Filho_Moto);
            this.Controls.Add(this.Ckbox_Filho_Carro);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Ckbox_Filho_Carro;
        private System.Windows.Forms.CheckBox Ckbox_Filho_Moto;
        private System.Windows.Forms.CheckBox Ckbox_Filho_Aviao;
        private System.Windows.Forms.CheckBox Ckbox_Filho_Navio;
        private System.Windows.Forms.ComboBox Cbb_01;
        private System.Windows.Forms.Button Btn_01;
        private System.Windows.Forms.Button Btn_02;
        private System.Windows.Forms.Button Btn_03;
        private System.Windows.Forms.TextBox Txbox_01;
        private System.Windows.Forms.Button Btn_04;
    }
}