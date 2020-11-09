using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l_2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the num : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int i;
            int fact = 1;
            for (i = 1; i <= num1; i++)
            {
                fact = fact * i;

                Console.WriteLine("Fractional number  " + num1);
                Console.WriteLine("is : " + fact);


            }

            Console.ReadLine();
        }
    }
}
