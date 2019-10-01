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
            string[] nome;
            double[] med;
            nome = new string[10];
            med = new double[10];
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Nome: "); s = Console.ReadLine(); nome[i] = s;
                Console.Write("Media: "); s = Console.ReadLine(); med[i] = float.Parse(s);
            }
            for (int i = 1; i <= 5; i++)
            {
                if (med[i] >= 5)
                    Console.WriteLine("\n aluno: (0) aprovado\n", nome[i]);
                if (med[i] <= 5)
                    Console.WriteLine("\n aluno: (0) reprovado\n", nome[i]);
               
            }
            Console.WriteLine("Press <ENTER> para sair...");
            Console.ReadKey();

        }

    }

}


