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
    public partial class Transfer : Form
    {
        private Initial Initial = null;
        Account ac;

        public Transfer(Initial form, Account ac)
        {
            InitializeComponent();
            this.Initial = form;
            this.ac = ac;
        }

        public void TransferMoney(string id,int money)
        {
            bool flage = false;
            foreach(Account account in this.Initial.accounts)
            {
                if (account.id == id)
                {
                    flage = true;
                    if (money <= 20000)
                    {
                        if (account.SaveMoney(money) && ac.WithdrawMoneny(money)) 
                            MessageBox.Show("转帐成功！您现在余额为：" + ac.money);
                        else
                            MessageBox.Show("转帐失败！！！");
                    }
                    else
                    {
                        MessageBox.Show("单次存入金额过大！！！");
                    }
                }
            }
            if (!flage) MessageBox.Show("账号不存在！！！");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money;
            try
            {
                money = int.Parse(textBox2.Text);
                TransferMoney(textBox1.Text, money);
                this.Close();
            }
            catch
            {
                MessageBox.Show("输入金额错误！！！");
            }
        }
    }
}
