namespace aula_vs01
{
    partial class Form6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.DTP_01 = new System.Windows.Forms.DateTimePicker();
            this.Txbox_All = new System.Windows.Forms.TextBox();
            this.Txbox_D = new System.Windows.Forms.TextBox();
            this.Txbox_M = new System.Windows.Forms.TextBox();
            this.Txbox_Y = new System.Windows.Forms.TextBox();
            this.Btn_AllDate = new System.Windows.Forms.Button();
            this.Btn_DMY = new System.Windows.Forms.Button();
            this.Btn_Mudar = new System.Windows.Forms.Button();
            this.Notificacao = new System.Windows.Forms.NotifyIcon(this.components);
            this.CMS_Notificacao = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aiai = new System.Windows.Forms.ToolStripMenuItem();
            this.fechar = new System.Windows.Forms.ToolStripMenuItem();
            this.NumUpDown = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CMS_Notificacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DTP_01
            // 
            this.DTP_01.Location = new System.Drawing.Point(12, 12);
            this.DTP_01.Name = "DTP_01";
            this.DTP_01.Size = new System.Drawing.Size(331, 20);
            this.DTP_01.TabIndex = 0;
            // 
            // Txbox_All
            // 
            this.Txbox_All.Location = new System.Drawing.Point(13, 51);
            this.Txbox_All.Name = "Txbox_All";
            this.Txbox_All.Size = new System.Drawing.Size(330, 20);
            this.Txbox_All.TabIndex = 1;
            this.Txbox_All.TextChanged += new System.EventHandler(this.Txbox_All_TextChanged);
            // 
            // Txbox_D
            // 
            this.Txbox_D.Location = new System.Drawing.Point(12, 92);
            this.Txbox_D.Name = "Txbox_D";
            this.Txbox_D.Size = new System.Drawing.Size(100, 20);
            this.Txbox_D.TabIndex = 2;
            // 
            // Txbox_M
            // 
            this.Txbox_M.Location = new System.Drawing.Point(128, 92);
            this.Txbox_M.Name = "Txbox_M";
            this.Txbox_M.Size = new System.Drawing.Size(100, 20);
            this.Txbox_M.TabIndex = 3;
            // 
            // Txbox_Y
            // 
            this.Txbox_Y.Location = new System.Drawing.Point(243, 92);
            this.Txbox_Y.Name = "Txbox_Y";
            this.Txbox_Y.Size = new System.Drawing.Size(100, 20);
            this.Txbox_Y.TabIndex = 4;
            // 
            // Btn_AllDate
            // 
            this.Btn_AllDate.Location = new System.Drawing.Point(388, 48);
            this.Btn_AllDate.Name = "Btn_AllDate";
            this.Btn_AllDate.Size = new System.Drawing.Size(75, 23);
            this.Btn_AllDate.TabIndex = 5;
            this.Btn_AllDate.Text = "aqui";
            this.Btn_AllDate.UseVisualStyleBackColor = true;
            this.Btn_AllDate.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_DMY
            // 
            this.Btn_DMY.Location = new System.Drawing.Point(388, 92);
            this.Btn_DMY.Name = "Btn_DMY";
            this.Btn_DMY.Size = new System.Drawing.Size(75, 23);
            this.Btn_DMY.TabIndex = 6;
            this.Btn_DMY.Text = "aqui";
            this.Btn_DMY.UseVisualStyleBackColor = true;
            this.Btn_DMY.Click += new System.EventHandler(this.Btn_DMY_Click);
            // 
            // Btn_Mudar
            // 
            this.Btn_Mudar.Location = new System.Drawing.Point(13, 146);
            this.Btn_Mudar.Name = "Btn_Mudar";
            this.Btn_Mudar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Mudar.TabIndex = 7;
            this.Btn_Mudar.Text = "Escolha";
            this.Btn_Mudar.UseVisualStyleBackColor = true;
            this.Btn_Mudar.Click += new System.EventHandler(this.Btn_Mudar_Click);
            // 
            // Notificacao
            // 
            this.Notificacao.ContextMenuStrip = this.CMS_Notificacao;
            this.Notificacao.Icon = ((System.Drawing.Icon)(resources.GetObject("Notificacao.Icon")));
            this.Notificacao.Text = "notifyIcon1";
            this.Notificacao.Visible = true;
            // 
            // CMS_Notificacao
            // 
            this.CMS_Notificacao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aiai,
            this.fechar});
            this.CMS_Notificacao.Name = "CMS_Notificacao";
            this.CMS_Notificacao.Size = new System.Drawing.Size(110, 48);
            this.CMS_Notificacao.Opening += new System.ComponentModel.CancelEventHandler(this.CMS_Notificacao_Opening);
            this.CMS_Notificacao.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.CMS_Notificacao_ItemClicked);
            this.CMS_Notificacao.Click += new System.EventHandler(this.CMS_Notificacao_Click);
            this.CMS_Notificacao.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CMS_Notificacao_MouseClick);
            // 
            // aiai
            // 
            this.aiai.Name = "aiai";
            this.aiai.Size = new System.Drawing.Size(109, 22);
            this.aiai.Text = "aiaiai";
            // 
            // fechar
            // 
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(109, 22);
            this.fechar.Text = "Fechar";
            // 
            // NumUpDown
            // 
            this.NumUpDown.Location = new System.Drawing.Point(343, 216);
            this.NumUpDown.Name = "NumUpDown";
            this.NumUpDown.Size = new System.Drawing.Size(120, 20);
            this.NumUpDown.TabIndex = 9;
            this.NumUpDown.ValueChanged += new System.EventHandler(this.NumUpDown_ValueChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(28, 269);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(760, 23);
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Homem";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 52);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(57, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Mulher";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(526, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 96);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Location = new System.Drawing.Point(532, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(113, 96);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 52);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(58, 17);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "UIUIUI";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 29);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(55, 17);
            this.radioButton4.TabIndex = 12;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "AIAIAI";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 347);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.NumUpDown);
            this.Controls.Add(this.Btn_Mudar);
            this.Controls.Add(this.Btn_DMY);
            this.Controls.Add(this.Btn_AllDate);
            this.Controls.Add(this.Txbox_Y);
            this.Controls.Add(this.Txbox_M);
            this.Controls.Add(this.Txbox_D);
            this.Controls.Add(this.Txbox_All);
            this.Controls.Add(this.DTP_01);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.CMS_Notificacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTP_01;
        private System.Windows.Forms.TextBox Txbox_All;
        private System.Windows.Forms.TextBox Txbox_D;
        private System.Windows.Forms.TextBox Txbox_M;
        private System.Windows.Forms.TextBox Txbox_Y;
        private System.Windows.Forms.Button Btn_AllDate;
        private System.Windows.Forms.Button Btn_DMY;
        private System.Windows.Forms.Button Btn_Mudar;
        private System.Windows.Forms.NotifyIcon Notificacao;
        private System.Windows.Forms.ContextMenuStrip CMS_Notificacao;
        private System.Windows.Forms.ToolStripMenuItem aiai;
        private System.Windows.Forms.ToolStripMenuItem fechar;
        private System.Windows.Forms.NumericUpDown NumUpDown;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Timer timer1;
    }
}