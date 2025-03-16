namespace aula_vs01
{
    partial class Form4
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
            this.Ckbox_Carro = new System.Windows.Forms.CheckBox();
            this.Ckbox_Moto = new System.Windows.Forms.CheckBox();
            this.Ckbox_Navio = new System.Windows.Forms.CheckBox();
            this.Ckbox_Aviao = new System.Windows.Forms.CheckBox();
            this.Btn_Ckbox = new System.Windows.Forms.Button();
            this.Btn_Form3_InForm4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Ckbox_Carro
            // 
            this.Ckbox_Carro.AutoSize = true;
            this.Ckbox_Carro.Location = new System.Drawing.Point(13, 13);
            this.Ckbox_Carro.Name = "Ckbox_Carro";
            this.Ckbox_Carro.Size = new System.Drawing.Size(51, 17);
            this.Ckbox_Carro.TabIndex = 0;
            this.Ckbox_Carro.Text = "Carro";
            this.Ckbox_Carro.UseVisualStyleBackColor = true;
            // 
            // Ckbox_Moto
            // 
            this.Ckbox_Moto.AutoSize = true;
            this.Ckbox_Moto.Location = new System.Drawing.Point(12, 36);
            this.Ckbox_Moto.Name = "Ckbox_Moto";
            this.Ckbox_Moto.Size = new System.Drawing.Size(50, 17);
            this.Ckbox_Moto.TabIndex = 1;
            this.Ckbox_Moto.Text = "Moto";
            this.Ckbox_Moto.UseVisualStyleBackColor = true;
            // 
            // Ckbox_Navio
            // 
            this.Ckbox_Navio.AutoSize = true;
            this.Ckbox_Navio.Location = new System.Drawing.Point(12, 59);
            this.Ckbox_Navio.Name = "Ckbox_Navio";
            this.Ckbox_Navio.Size = new System.Drawing.Size(54, 17);
            this.Ckbox_Navio.TabIndex = 2;
            this.Ckbox_Navio.Text = "Navio";
            this.Ckbox_Navio.UseVisualStyleBackColor = true;
            // 
            // Ckbox_Aviao
            // 
            this.Ckbox_Aviao.AutoSize = true;
            this.Ckbox_Aviao.Location = new System.Drawing.Point(12, 82);
            this.Ckbox_Aviao.Name = "Ckbox_Aviao";
            this.Ckbox_Aviao.Size = new System.Drawing.Size(53, 17);
            this.Ckbox_Aviao.TabIndex = 3;
            this.Ckbox_Aviao.Text = "Aviao";
            this.Ckbox_Aviao.UseVisualStyleBackColor = true;
            this.Ckbox_Aviao.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // Btn_Ckbox
            // 
            this.Btn_Ckbox.Location = new System.Drawing.Point(139, 13);
            this.Btn_Ckbox.Name = "Btn_Ckbox";
            this.Btn_Ckbox.Size = new System.Drawing.Size(94, 26);
            this.Btn_Ckbox.TabIndex = 4;
            this.Btn_Ckbox.Text = "Ver-Marcados";
            this.Btn_Ckbox.UseVisualStyleBackColor = true;
            this.Btn_Ckbox.Click += new System.EventHandler(this.Btn_Ckbox_Click);
            // 
            // Btn_Form3_InForm4
            // 
            this.Btn_Form3_InForm4.Location = new System.Drawing.Point(165, 59);
            this.Btn_Form3_InForm4.Name = "Btn_Form3_InForm4";
            this.Btn_Form3_InForm4.Size = new System.Drawing.Size(75, 23);
            this.Btn_Form3_InForm4.TabIndex = 5;
            this.Btn_Form3_InForm4.Text = "Form_3_open";
            this.Btn_Form3_InForm4.UseVisualStyleBackColor = true;
            this.Btn_Form3_InForm4.Click += new System.EventHandler(this.Btn_Form2_InForm4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 145);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 6;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 357);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Btn_Form3_InForm4);
            this.Controls.Add(this.Btn_Ckbox);
            this.Controls.Add(this.Ckbox_Aviao);
            this.Controls.Add(this.Ckbox_Navio);
            this.Controls.Add(this.Ckbox_Moto);
            this.Controls.Add(this.Ckbox_Carro);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox Ckbox_Carro;
        public System.Windows.Forms.CheckBox Ckbox_Moto;
        public System.Windows.Forms.CheckBox Ckbox_Navio;
        public System.Windows.Forms.CheckBox Ckbox_Aviao;
        private System.Windows.Forms.Button Btn_Ckbox;
        private System.Windows.Forms.Button Btn_Form3_InForm4;
        private System.Windows.Forms.ListBox listBox1;
    }
}