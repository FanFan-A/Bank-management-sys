using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 银行管理系统
{
    public partial class Initial : Form
    {
        string id;
        int pw;
        public List<Account> accounts = new List<Account>();
        List<string> ID = new List<string>(), name = new List<string>(), IDcard = new List<string>(), PW = new List<string>(), Money = new List<string>();

        public void ReadFile()
        {
            StreamReader ac = new StreamReader(@"\0.txt", Encoding.Default);
            string content = ac.ReadToEnd();
            string[] lines = content.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                string[] words = lines[i].Trim().Split('\t');
                if (words.Length < 5) continue;
                ID.Add(words[0]);
                PW.Add(words[1]);
                name.Add(words[2]);
                IDcard.Add(words[3]);
                Money.Add(words[4]);
            }
        }

        public Initial()
        {
            InitializeComponent();
            ReadFile();
            string[] Id = { }, na = { }, Ic = { }, Pw = { }, money = { };
            Id = ID.ToArray();
            na = name.ToArray();
            Ic = IDcard.ToArray();
            Pw = PW.ToArray();
            money = Money.ToArray();
            for (int i = 0; i < Id.Length; i++)
            {
                Account account = new Account(Id[i], int.Parse(Pw[i]), na[i], Ic[i]);
                account.money = int.Parse(money[i]);
                accounts.Add(account);
            }
        }

        virtual public void Func()
        {

        }

        public Account FindAccount(string id, int pw)
        {
            foreach (Account account in accounts)
                if (account.IsMatch(id, pw))
                    return account;

            return null;
        }

        public void SaveMoney(string id, int pw, int money)
        {
            Account account = FindAccount(id, pw);
            if (money <= 20000)
            {
                if (account.SaveMoney(money))
                    MessageBox.Show("存入成功！现在余额为：" + account.money);
                else
                    MessageBox.Show("存入金额错误！！！");
            }
            else
            {
                MessageBox.Show("单次存入金额过大！！！");
            }
        }
        public void WithdrawMoney(string id, int pw, int money)
        {
            Account account = FindAccount(id, pw);
            if (money <= 20000)
            {
                if (account.WithdrawMoneny(money))
                    MessageBox.Show("取出成功！现在余额为：" + account.money);
                else
                    MessageBox.Show("取出金额错误，您现在的余额为：" + account.money);
            }
            else
            {
                MessageBox.Show("单次取出金额过大！！！");
            }
        }

        virtual protected void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdministrator_Click(object sender, EventArgs e)
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
                    Account account = FindAccount(id, pw);
                    if (account != null)
                    {
                        if (account.name == "Administrator")
                        {
                            Administrator administrator = new Administrator(this);
                            this.Visible = false;
                            administrator.Show();
                            MessageBox.Show("登陆成功！！！");
                        }
                        else
                        {
                            MessageBox.Show("此用户并非管理员用户，即将转到用户界面！");
                            User user = new User(this, account);
                            this.Visible = false;
                            user.Show();
                        }
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

        private void btnUser_Click(object sender, EventArgs e)
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
                    Account account = FindAccount(id, pw);
                    if (account != null)
                    {
                        User user = new User(this,account);
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
    }
}
