namespace 银行管理系统
{
    partial class Initial
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtid = new System.Windows.Forms.TextBox();
            this.labid = new System.Windows.Forms.Label();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.labpw = new System.Windows.Forms.Label();
            this.btnAdministrator = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(251, 130);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(317, 25);
            this.txtid.TabIndex = 3;
            // 
            // labid
            // 
            this.labid.AutoSize = true;
            this.labid.Location = new System.Drawing.Point(197, 133);
            this.labid.Name = "labid";
            this.labid.Size = new System.Drawing.Size(31, 15);
            this.labid.TabIndex = 5;
            this.labid.Text = "ID:";
            // 
            // txtpw
            // 
            this.txtpw.Location = new System.Drawing.Point(251, 203);
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(317, 25);
            this.txtpw.TabIndex = 6;
            // 
            // labpw
            // 
            this.labpw.AutoSize = true;
            this.labpw.Location = new System.Drawing.Point(166, 206);
            this.labpw.Name = "labpw";
            this.labpw.Size = new System.Drawing.Size(79, 15);
            this.labpw.TabIndex = 7;
            this.labpw.Text = "Password:";
            // 
            // btnAdministrator
            // 
            this.btnAdministrator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdministrator.Location = new System.Drawing.Point(142, 306);
            this.btnAdministrator.Name = "btnAdministrator";
            this.btnAdministrator.Size = new System.Drawing.Size(103, 47);
            this.btnAdministrator.TabIndex = 8;
            this.btnAdministrator.Text = "管理员登陆";
            this.btnAdministrator.UseVisualStyleBackColor = true;
            this.btnAdministrator.Click += new System.EventHandler(this.btnAdministrator_Click);
            // 
            // btnUser
            // 
            this.btnUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUser.Location = new System.Drawing.Point(583, 306);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(103, 47);
            this.btnUser.TabIndex = 9;
            this.btnUser.Text = "用户登陆";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // Initial
            // 
            this.AcceptButton = this.btnAdministrator;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnAdministrator);
            this.Controls.Add(this.labpw);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.labid);
            this.Controls.Add(this.txtid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Initial";
            this.Text = "系统登陆界面";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Button btnAdministrator;
        protected System.Windows.Forms.Button btnUser;
        public System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.Label labid;
        public System.Windows.Forms.TextBox txtpw;
        public System.Windows.Forms.Label labpw;
    }
}

