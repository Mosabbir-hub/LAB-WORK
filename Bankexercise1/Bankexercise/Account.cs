using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankexercise
{
    // abstract class 'Account'
    public abstract class Account
    {

        // abstract method 'gfg()' 
        public abstract void gfg();

    }

    // class 'Account' inherit 
    // in child class 'Savings 
    public class Savings : Account
    {

        // abstract method 'gfg()'  
        // declare here with  
        // 'override' keyword 
        public override void gfg()
        {
            Console.WriteLine("class Savings");
        }
    }
    // class 'Account' inherit 
    // in child class 'Fixed' 
    public class Fixed : Account
    {

        // abstract method 'gfg()'  
        // declare here with  
        // 'override' keyword 
        public override void gfg()
        {
            Console.WriteLine("class Fixed");
        }
    }
    // class 'Account' inherit 
    // in child class 'SpecialSavings' 
    public class SpacialSavings : Account
    {

        // abstract method 'gfg()'  
        // declare here with  
        // 'override' keyword 
        public override void gfg()
        {
            Console.WriteLine("class SpacialSavings");
        }
    }
    // class 'Account' inherit in  
    // another child class 'Overdraft' 
    public class Overdraft : Account
    {

        // same as the previous class 
        public override void gfg()
        {
            Console.WriteLine("class Overdraft");
        }
    }

    // Driver Class 
    public class main_method
    {

        // Main Method 
        public static void Main()
        {

            // 'g' is object of class 
            // 'Account' class ' 
            // Account' cannot 
            // be instantiate 
            Account a;

            // instantiate class 'Savings' 
            a = new Savings();

            // call 'gfg()' of class 'savings' 
            a.gfg();

            // instantiate class 'Fixed'   

            a = new Fixed();

            // call 'gfg()' of class 'Fixed' 
            a.gfg();

            // instantiate class 'SpacialSavings' 
            a = new SpacialSavings();

            // call 'gfg()' of class 'SpacialSavings' 
            a.gfg();

            // instantiate class 'Overdraft' 
            a = new Overdraft();

            // call 'gfg()' of class 'overdraft' 
            a.gfg();

        }


    }
}