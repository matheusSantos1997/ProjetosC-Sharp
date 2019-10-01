using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;

            Console.Write("Entre com o lado A do triângulo: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Entre com o lado B do triângulo: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Entre com o lado C do triângulo: ");
            c = float.Parse(Console.ReadLine());

            if ((a < b + c) && (b < a + c) && (c < a + b))
                if ((a == b) && (b == c))
                    Console.WriteLine("O triângulo é equilátero!!");  //quando todos os lados de um triângulo são iguais                 
                else if ((a == b) || (a == c) || (b == c))
                    Console.WriteLine("O triângulo é isósceles!!");  //quando dois lados de um triângulo são iguais
                else
                    Console.WriteLine("O triângulo é escaleno");  //quando todos os lados de um triângulo são diferentes            
                else
                    Console.WriteLine("Os lados fornecidos não correspondem a um triângulo");

            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
