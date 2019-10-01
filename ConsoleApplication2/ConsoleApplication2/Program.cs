using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int[] num;
            num = new int[10];
            int maior=0, menor=0;
            for (int c = 1; c <=8; c++)
            {
                Console.Write("Por favor, digite o {0} valor: ", c);
                s = Console.ReadLine();
                num[c] = int.Parse(s);
            }
            menor = num[1];
            for (int c = 1; c <= 8;  c++)
            {
                if (menor > num[c])
                    menor = num[c];
                if (maior < num[c])
                    maior = num[c];
            }
            Console.WriteLine("\n0 Menor numero é: {0}", menor);
            Console.WriteLine("\n0 Maior numero é: {0}", maior);
            Console.WriteLine("Press <ENTER> Para sair...");
            Console.ReadKey();

        }

    }
}
