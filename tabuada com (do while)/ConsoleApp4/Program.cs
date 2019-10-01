using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabuada;
            int cont=0;
            int resultado;

            Console.Write("Digite um número para a tabuada: ");
            tabuada = int.Parse(Console.ReadLine());

            do
            {
                resultado = tabuada * cont;
                Console.WriteLine("{0} x {1} = {2} ", tabuada, cont, resultado);
                cont++;
            }
            while (cont <=10);

            Console.WriteLine("Aperte <ENTER> para sair");
            Console.ReadKey();

        }
    }
}
