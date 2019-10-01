using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string dia, semana;
            

            Console.Write("Digite uma letra desejada de (A a G): ");
            dia = Console.ReadLine();

            switch(dia)
            {
                case "a":
                    semana = "Domingo";
                break;
                case "b":
                    semana = "Segunda";
                    break;
                case "c":
                    semana = "Terça";
                    break;
                case "d":
                    semana = "Quarta";
                    break;
                case "e":
                    semana = "Quinta";
                    break;
                case "f":
                    semana = "Sexta";
                    break;
                case "g":
                    semana = "Sábado";
                    break;
                default:
                    semana = "caractere digitado inválido";
                    break;
            }
            Console.WriteLine("o caractere {0} corresponde a semana de {1}", dia, semana);
            Console.WriteLine("Aperte uma tecla para sair");
            Console.ReadKey();
        }
    }
}
