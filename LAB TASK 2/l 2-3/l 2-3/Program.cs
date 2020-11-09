using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            for (x = 1; x <= 5; x++)
            {
                for (y = x; y <= 9; y++)
                {
                    Console.Write(" " + y);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
