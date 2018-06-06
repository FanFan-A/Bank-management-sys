using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 银行管理系统
{
    public partial class Administrator : Form
    {
        private Initial Initial = null;
        int pw;
        string id;

        public Administrator(Initial form)
        {
            InitializeComponent();
            this.Initial = form;
        }

        private void Administrator_Load(object sender, EventArgs e)
        {

        }       

        private void Administrator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Initial.txtid.Text = Initial.txtpw.Text = "";
            this.Initial.Visible = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            OpenAccount account = new OpenAccount(this.Initial);
            account.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            id = txtid.Text;
            try
            {
                pw = int.Parse(txtpw.Text);
                if (pw < 100000 || pw > 999999)
                {
                    MessageBox.Show("密码错误，请输入6位数密码！！！");
                    txtpw.Text = "";
                }
                else if (id == "")
                {
                    MessageBox.Show("账号不能为空，请输入真确的账号信息！！！");
                }
                else
                {
                    Account account = this.Initial.FindAccount(id, pw);
                    if (account != null)
                    {
                        User user = new User(this.Initial, account);
                        this.Visible = false;
                        user.Show();
                        MessageBox.Show("登陆成功！！！");
                    }
                    else
                    {
                        txtid.Text = txtpw.Text = "";
                        MessageBox.Show("账号不存在或密码错误！！！");
                    }
                }
            }
            catch//(Exception e)
            {
                MessageBox.Show("密码格式错误，请输入6位数密码！！！");
            }
        }

        private void btnForget_Click(object sender, EventArgs e)
        {
            id = txtid.Text;
            foreach (Account ac in this.Initial.accounts)
            {
                if (ac.id == id)
                {
                    Forget forget = new Forget(ac);
                    forget.ShowDialog();
                }
            }
        }
    }
}
