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
    public partial class OpenAccount : Form
    {
        private Initial Initial = null;

        public OpenAccount(Initial form)
        {
            InitializeComponent();
            this.Initial = form;
        }

        public Account OpenAccounts(string id, int pw, string name, string IDcard)
        {
            if (pw < 100000 || pw > 999999)
            {
                MessageBox.Show("密码格式错误，请重新输入6位数密码！");
                return null;
            }
            foreach(Account ac in this.Initial.accounts)
            {
                if (ac.id == id)
                {
                    MessageBox.Show("账号已存在，请重新输入账号！！！");
                    textBox1.Text = "";
                    return null;
                }
            }
            foreach (char c in id)
            {
                if (c < 48 || c > 122 || (c > 57 && c < 65) || (c > 90 && c < 97))
                {
                    MessageBox.Show("账号格式错误，账号只能包含数字及字母，请重新输入！");
                    return null;
                }
            }
            Account account = new Account(id, pw, name, IDcard);
            account.money = 0;
            this.Initial.accounts.Add(account);
            MessageBox.Show("用户创建成功！");
            return account;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id, name, IDcard;
            int pw;
            id = textBox1.Text;
            name = textBox4.Text;
            IDcard = textBox5.Text;
            if (textBox2.Text == textBox3.Text && textBox3.Text != "") 
            {
                try
                {
                    pw = int.Parse(textBox3.Text);
                    if (OpenAccounts(id, pw, name, IDcard) != null) this.Close();
                }
                catch
                {
                    MessageBox.Show("密码格式错误，请重新输入！！！");
                    textBox2.Text = textBox3.Text = "";
                }
            }
        }
    }
}
