namespace SQLITE
{
    partial class Login
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
            this.Lb_Login = new System.Windows.Forms.Label();
            this.TxBox_Login = new System.Windows.Forms.TextBox();
            this.TxBox_Password = new System.Windows.Forms.TextBox();
            this.Lb_Password = new System.Windows.Forms.Label();
            this.Btn_Connection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lb_Login
            // 
            this.Lb_Login.AutoSize = true;
            this.Lb_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Login.Location = new System.Drawing.Point(119, 50);
            this.Lb_Login.Name = "Lb_Login";
            this.Lb_Login.Size = new System.Drawing.Size(65, 25);
            this.Lb_Login.TabIndex = 0;
            this.Lb_Login.Text = "Login";
            // 
            // TxBox_Login
            // 
            this.TxBox_Login.Location = new System.Drawing.Point(101, 78);
            this.TxBox_Login.Name = "TxBox_Login";
            this.TxBox_Login.Size = new System.Drawing.Size(100, 20);
            this.TxBox_Login.TabIndex = 1;
            // 
            // TxBox_Password
            // 
            this.TxBox_Password.Location = new System.Drawing.Point(101, 139);
            this.TxBox_Password.Name = "TxBox_Password";
            this.TxBox_Password.Size = new System.Drawing.Size(100, 20);
            this.TxBox_Password.TabIndex = 3;
            this.TxBox_Password.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Lb_Password
            // 
            this.Lb_Password.AutoSize = true;
            this.Lb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Password.Location = new System.Drawing.Point(96, 111);
            this.Lb_Password.Name = "Lb_Password";
            this.Lb_Password.Size = new System.Drawing.Size(106, 25);
            this.Lb_Password.TabIndex = 2;
            this.Lb_Password.Text = "Password";
            // 
            // Btn_Connection
            // 
            this.Btn_Connection.Location = new System.Drawing.Point(124, 165);
            this.Btn_Connection.Name = "Btn_Connection";
            this.Btn_Connection.Size = new System.Drawing.Size(77, 23);
            this.Btn_Connection.TabIndex = 4;
            this.Btn_Connection.Text = "Connection";
            this.Btn_Connection.UseVisualStyleBackColor = true;
            this.Btn_Connection.Click += new System.EventHandler(this.Btn_Connection_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 270);
            this.Controls.Add(this.Btn_Connection);
            this.Controls.Add(this.TxBox_Password);
            this.Controls.Add(this.Lb_Password);
            this.Controls.Add(this.TxBox_Login);
            this.Controls.Add(this.Lb_Login);
            this.Name = "Login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Login;
        private System.Windows.Forms.TextBox TxBox_Login;
        private System.Windows.Forms.TextBox TxBox_Password;
        private System.Windows.Forms.Label Lb_Password;
        private System.Windows.Forms.Button Btn_Connection;
    }
}