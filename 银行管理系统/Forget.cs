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
    public partial class Forget : Form
    {
        Account ac;

        public Forget(Account account)
        {
            InitializeComponent();
            this.ac = account;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ac.name && textBox2.Text == ac.IDcard) MessageBox.Show("您的密码为：" + ac.pw);
            else MessageBox.Show("身份信息错误！！！");
        }

        private void Forget_Load(object sender, EventArgs e)
        {

        }
    }
}
