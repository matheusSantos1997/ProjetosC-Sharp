using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabuada;
            int resultado;
            int resposta;
            do {

                Console.Write("Digite um número para tabuada desejado: ");
                tabuada = Convert.ToInt32(Console.ReadLine());

                for (int cont = 0; cont <= 10; cont++)
                {
                    resultado = tabuada * cont;
                    Console.WriteLine("{0} x {1} = {2}", tabuada, cont, resultado);
                    
                }
                Console.WriteLine("Pressione qualquer tecla para continuar!!!");
                Console.WriteLine("1.novo calculo ");
                Console.WriteLine("2.sair  ");
                resposta = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.Write("Aperte qualquer tecla para sair!!");

            }
            while (resposta != 2);

             
            Console.ReadKey();
        }
    }
}
