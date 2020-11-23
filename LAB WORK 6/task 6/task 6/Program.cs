using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                static void Main(string[] args)
                {
                    Account obj = new Account();
                    Console.WriteLine("Account name is :" + obj.AccName);
                    Console.WriteLine("Account no is :" + obj.Acid);
                    Console.WriteLine("Balance is :" + obj.Balance);

                    obj.Deposit(1000);
                    obj.WithDraw(550);
                    Console.WriteLine("New balance  is :" + obj.Balance);
                }
            }


            public class Account
        {
            private string accName;
            private string acid;
            private int balance;

            public string AccName
            {
                get { return accName; }
                set { accName = value; }

            }
            public string Acid
            {
                get { return acid; }
                set { acid = value; }
            }

            public int Balance
            {
                get { return balance; }
                set { balance = value; }
            }


            public void Deposit(int amount)
            {
                balance += amount;
            }
            public void WithDraw(int amount)
            {
                balance -= amount;
            }
            public void Transfer(int amount)
            {
                balance += amount;
            }
            public Account()
            {
                accName = "HOSSAIN MOISABBIR";
                acid = "19-40432-1";
                balance = 1000;
            }
            public Account(string accName, string acid, int balance)
            {
                this.accName = accName;
                this.acid = acid;
                this.balance = balance;
            }
        }
    }
    }
}
