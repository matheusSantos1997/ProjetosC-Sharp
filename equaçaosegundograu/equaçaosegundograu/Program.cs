using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equaçaosegundograu
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            float x1, x2, delta;

            Console.Write("Entre com o valor de A: ");
            a = float.Parse(Console.ReadLine());

            Console.Write("Entre com o valor de B: ");
            b = float.Parse(Console.ReadLine());
            
            Console.Write("Entre com o valor de C: ");
            c = float.Parse(Console.ReadLine());

            if (a != 0)
            {
                delta = (b * b) - (4 * a * c);
                if (delta >= 0)
                {
                    x1 = (-b + delta ) / (2 * a);
                    x2 = (-b - delta) / (2 * a);
                    Console.WriteLine("as raízes da equação são:{0} {1}", x1, x2);
                }
                else
                    Console.WriteLine("não existem raízes reais!! ");
                }
            
            else
                Console.WriteLine("os valores fornecidos não correspondem a uma equação do segundo grau!! ");

            Console.WriteLine("Pressione uma tecla para sair!!! ");
            Console.ReadKey();
        }

    }
}
