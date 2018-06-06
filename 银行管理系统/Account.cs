using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 银行管理系统
{
    public class Account
    {
        public double money;
        public string id;
        public int pw;
        public string name, IDcard;

        public Account(string id, int pw, string name, string IDcard)
        {
            this.id = id;
            this.pw = pw;
            this.name = name;
            this.IDcard = IDcard;
        }

        public Account(string id, int pw)
        {
            this.id = id;
            this.pw = pw;
        }

        public string getId()
        {
            return id;
        }

        public void setId(string id)
        {
            this.id = id;
        }

        public int getpw()
        {
            return pw;
        }

        public void setPw(int pw)
        {
            this.pw = pw;
        }

        public bool SaveMoney(int money)
        {
            if (money < 0 || money % 100 != 0) return false;

            this.money += money;
            return true;
        }


        public bool WithdrawMoneny(int money)
        {
            if (this.money >= money && money > 0 && money % 100 == 0)
            {
                this.money -= money;
                return true;
            }

            return false;
        }

        //用于被查找
        public bool IsMatch(string id, int pw)
        {
            return id == this.id && pw == this.pw;
        }
    }

}
