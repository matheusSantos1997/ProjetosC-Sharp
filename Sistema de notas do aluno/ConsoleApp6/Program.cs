using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, notaexame;
            double media, mediaexame;
            string nome, RA;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite seu RA: ");
            RA = Console.ReadLine();

            Console.Write("Digite a sua primeira nota: ");
            nota1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a sua segunda nota: ");
            nota2 = Convert.ToInt32(Console.ReadLine());

            media = nota1 + nota2 / 2;
            Console.WriteLine("a sua média final é: " + media);

            if (media > 7)
            {
                Console.WriteLine("você foi aprovado!!!");
            }
            else
            {
                Console.WriteLine("Você foi reprovado!!!");

                Console.Write("Digite a nota do exame: ");
                notaexame = Convert.ToInt32(Console.ReadLine());

                mediaexame = nota1 + nota2 + notaexame / 2;
                Console.WriteLine("a média final do exame é: " + mediaexame);

                if(mediaexame > 5)
                {
                    Console.WriteLine("Você passou para o próximo semestre!!!");
                }
                else
                {
                    Console.WriteLine("Você não foi aprovado, estude mais!!!");
                }

            }
            Console.WriteLine("Pressione qualquer tecla para sair!!");
            Console.ReadKey();

        }
    }
}
