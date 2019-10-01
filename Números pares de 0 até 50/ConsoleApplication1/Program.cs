using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            for (int c = 1; c <= 50; c++)
            {
                if (c % 2 == 0)
                    System.Console.Write("{0} ", c);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("\nPress. <ENTER> para sair");
            System.Console.ReadKey();
        }
    }
}
