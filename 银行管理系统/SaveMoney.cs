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
    public partial class SaveMoney : Form
    {
        private Initial Initial = null;
        int money, pw;
        string id;

        public SaveMoney(Initial form, string id, int pw)
        {
            InitializeComponent();
            this.Initial = form;
            this.id = id;
            this.pw = pw;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                money = int.Parse(textBox1.Text);
                this.Initial.SaveMoney(id, pw, money);
                this.Close();
            }
            catch
            {
                MessageBox.Show("输入金额错误！！！");
            }
        }
    }
}
