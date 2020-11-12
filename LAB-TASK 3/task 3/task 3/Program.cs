using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Account obj = new Account();
            Console.WriteLine("Account name is :" + obj.AcName);
            Console.WriteLine("Account no is :" + obj.Aid);
            Console.WriteLine("Balance is :" + obj.Balance);

            obj.Deposit(500);
            obj.WithDraw(700);
            Console.WriteLine("New balance  is :" + obj.Balance);
        }
    }

    public class Account
    {
        private string acName = "hossain mosabbir";
        private string aid = "18386933";
        private int balance = 0;

        public string AcName
        {
            get { return acName; }

        }
        public string Aid
        {
            get { return aid; }

        }

        public int Balance
        {
            get { return balance; }

        }

        public void Deposit(int amount)
        {
            balance += amount;
        }
        public void WithDraw(int amount)
        {
            balance -= amount;
        }
    }


}

