using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kARRA_JADVAL2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\ny/x |  1\t2\t3\t4\t5\t6\t7\t8\t9");
            Console.Write("-------------------------------------------------------------------------------------");
            Console.WriteLine();
            for (int x = 1; x < 10; x++)
            {
                Console.Write(x + " | ");
                for (int y = 1; y < 10; y++)
                {
                    Console.Write("\t" + x*y);


                }

                Console.WriteLine();
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
