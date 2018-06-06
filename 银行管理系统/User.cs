using System;
using System.Windows.Forms;

namespace 银行管理系统
{
    public partial class User : Form
    {
        private Initial Initial = null;
        Account ac;

        public User(Initial form,Account ac)
        {
            InitializeComponent();
            this.Initial = form;
            this.ac = ac;
        }

        private void User_Load(object sender, EventArgs e)
        {

        }       

        private void User_FormClosing(object sender, FormClosingEventArgs e)
        {
            Initial.txtid.Text = Initial.txtpw.Text = "";
            this.Initial.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WithdrawMoney withdrawmoney = new WithdrawMoney(this.Initial,ac.id,ac.pw);
            withdrawmoney.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveMoney savemoney = new SaveMoney(this.Initial, ac.id, ac.pw);
            savemoney.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("余额为：" + this.Initial.FindAccount(ac.id, ac.pw).money);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Transfer transfer = new Transfer(this.Initial, ac);
            transfer.ShowDialog();
        }
    }
}
