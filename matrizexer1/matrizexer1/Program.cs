using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrizexer1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] matriz = new int[4, 5];
            int i = 4, j = 5;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();


            Console.WriteLine("entrada de dados (via) teclado da matriz i = {0} x j = {1}", i, j);
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.Write("digite o elemento da posição: [" + i + " " + j + "] = ");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }


                Console.WriteLine("aperte uma tecla para mostrar a matriz normal e transposta!!");
                Console.ReadKey();
                

                Console.WriteLine("saída de dados (via) teclado da matriz = ({0} x {1}): ", i, j);

                for (i = 0; i < 4; i++)
                {

                    for (j = 0; j < 5; j++)
                    Console.Write("{0,5}", matriz[i, j]);
                    Console.WriteLine();
                }

                Console.WriteLine("Matriz transposta: ");
                for (i = 0; i < 5; i++)
                {

                    for (j = 0; j < 4; j++)
                    Console.Write("{0,5}", matriz[j, i]);
                    Console.WriteLine();
                }

                Console.WriteLine("Pressione qualquer <tecla> para sair!!!");
                Console.ReadKey();
            }
        }
    }


       
    

