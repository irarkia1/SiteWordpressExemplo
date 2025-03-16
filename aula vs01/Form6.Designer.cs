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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.CMS_Notificacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(379, 192);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 9;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 347);
            this.Controls.Add(this.numericUpDown1);
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
            this.CMS_Notificacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}