using System;

namespace aps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            
            int[] c = new int[10];
            int i, j, m;

            int cont = 0;
            int indice = 0;
            int pos = 1;

            float media = 0;
            float total = 0;
            float mediana = 0;


            //Entrada do usuario, do valor da amostra
            Console.Write("Determine o tamanho da amostra: ");
            indice = int.Parse(Console.ReadLine());

            float[] dados = new float[indice];

            //Entrada das informações e soma do total
            for (i = 0; i < indice; i++)
            {
                Console.Write("Posição {0} : ",pos++);
                dados[i]= float.Parse(Console.ReadLine());
                total += dados[i];
            }

            //Calculo da media
            media = total / indice;

            //Organização dos dados
            Array.Sort(dados);

            //Calculo da mediana
            if (indice % 2 == 0)
            {
                mediana = (dados[indice / 2] + dados[(indice / 2) - 1]) / 2;
            }
            else
            {
                mediana = dados[indice / 2];
            }

            //Dados organizados no prompt
            Console.WriteLine("\n i");

            for (i = 0; i < indice; i++)
            {
                Console.WriteLine(" " + dados[i]);
            }

            //Inicio do calculo da moda
            for (i = 1; i < indice; i++)
            {
                for (j = 1; j < indice; j++)
                {
                    

                    if ((dados[i] == dados[j]) && (i != j))
                    {
                        c[i] = c[i] + 1;
                    }
                    if ((c[i] == c[j]) && (i != j) && (dados[i] == dados[j]))
                    {
                        c[i] = 0;
                    }
                }
            }
            for (i = 1; i < indice; i++)
            {
                if (c[i] == 0)
                {
                    dados[i] = 0;
                }
            }
            for (i = 1; i < indice; i++)
            {
                if (dados[i] != 0)
                {
                    cont = cont + 1;
                }
            }
            for (m = 1; m < ((int)cont / 2); m++)
            {
                for (i = 1; i < indice; i++)
                {
                    for (j = 1; j < indice; j++)
                    {
                        if ((dados[i] == dados[j]) && (i != j))
                        {
                            c[i] = c[i] + 1;
                        }
                        if ((c[i] == c[j]) && (i != j) && (dados[i] == dados[j]))
                        {
                            c[i] = 0;
                        }
                    }
                    if (c[i] == 0)
                    {
                        dados[i] = 0;
                    }
                }
            }
            //fim do calculo da moda

            
            //Média, Mediana e Moda no prompt
            Console.WriteLine("\nMédia = {0}",media);
            Console.WriteLine("\nMediana = {0}", mediana);
            Console.Write("\nModa = ");
            for (i = 1; i < indice; i++)
            {
                if (dados[i] != 0)
                {
                    Console.Write(" "+dados[i]);
                }
            }


            Console.ReadKey();
        }
    }
}
