using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int t;
            int cont=0;
            int r;

            Console.Write("Digite o número da tabuada desejado: ");
            t = int.Parse(Console.ReadLine());

            while(cont <= 10)
            {
                r = t * cont;
                Console.WriteLine("{0} x {1} = {2}: ", t, cont, r);
                cont++;
            }
            Console.WriteLine("Aperte qualquer tecla para sair!!!");
            Console.ReadKey();
        }
    }
}
