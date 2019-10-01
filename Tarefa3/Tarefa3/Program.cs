using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa3
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            double a, b, c, r;
            System.Console.WriteLine("Calculo do Volume da Caixa");
            System.Console.Write("Digite o comprimento: ");
            x = System.Console.ReadLine();
            a = float.Parse(x);
            System.Console.Write("Digite a largura: ");
            x = System.Console.ReadLine();
            b = float.Parse(x);
            System.Console.Write("Digite a altura: ");
            x = System.Console.ReadLine();
            c = float.Parse(x);
            r = a * b * c;
            System.Console.WriteLine("O volume da caixa é: {0}",r);
            System.Console.WriteLine("Press <ENTER> para sair...");
            Console.ReadKey();
        }
    }
}
