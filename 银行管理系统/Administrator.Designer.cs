namespace 银行管理系统
{
    partial class Administrator
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
            this.labpw = new System.Windows.Forms.Label();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.labid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnForget = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labpw
            // 
            this.labpw.AutoSize = true;
            this.labpw.Location = new System.Drawing.Point(180, 198);
            this.labpw.Name = "labpw";
            this.labpw.Size = new System.Drawing.Size(79, 15);
            this.labpw.TabIndex = 11;
            this.labpw.Text = "Password:";
            // 
            // txtpw
            // 
            this.txtpw.Location = new System.Drawing.Point(265, 195);
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(317, 25);
            this.txtpw.TabIndex = 10;
            // 
            // labid
            // 
            this.labid.AutoSize = true;
            this.labid.Location = new System.Drawing.Point(211, 125);
            this.labid.Name = "labid";
            this.labid.Size = new System.Drawing.Size(31, 15);
            this.labid.TabIndex = 9;
            this.labid.Text = "ID:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(265, 122);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(317, 25);
            this.txtid.TabIndex = 8;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(66, 353);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(117, 46);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "登陆";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(596, 353);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(117, 46);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnForget
            // 
            this.btnForget.Location = new System.Drawing.Point(336, 353);
            this.btnForget.Name = "btnForget";
            this.btnForget.Size = new System.Drawing.Size(117, 46);
            this.btnForget.TabIndex = 14;
            this.btnForget.Text = "忘记密码";
            this.btnForget.UseVisualStyleBackColor = true;
            this.btnForget.Click += new System.EventHandler(this.btnForget_Click);
            // 
            // Administrator
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnForget);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.labpw);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.labid);
            this.Controls.Add(this.txtid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Administrator";
            this.Text = "管理员操作界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Administrator_FormClosing);
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labpw;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.Label labid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnForget;
    }
}