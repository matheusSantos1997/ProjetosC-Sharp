using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            int a, b, c;
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.Write("Digite o lado [a]: ");
            x = System.Console.ReadLine();
            a = int.Parse(x);
            System.Console.Write("Digite o lado [b]: ");
            x = System.Console.ReadLine();
            b = int.Parse(x);
            System.Console.Write("Digite o lado [c]: ");
            x = System.Console.ReadLine();
            c = int.Parse(x);
            if (a == b && a == c && b == c)
                System.Console.WriteLine("O triângulo é equilátero, ");
            else if (a != b && a != c && b != c)
                System.Console.WriteLine("O triângulo é escaleno, ");
            else
                System.Console.WriteLine("O triângulo é isósceles, ");
            System.Console.WriteLine("Pressione <ENTER> para sair... ");
            System.Console.ReadKey();
        }
    }
}
