using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            double[] a,b,c; 
            a = new double[4];
            b = new double[4];
            c = new double[4];
            Console.WriteLine("Valores do Vetor {a}");
            for (int i=0;i<=3;i++)
            {
                System.Console.Write("Digite o {0}° número: ",i);
                s=Console.ReadLine();
                a[i]=float.Parse(s);
            }
            System.Console.WriteLine("\nValores do Vetor {b}"); 
            for (int i = 0; i <=3; i++)
            {
                System.Console.Write("Digite o {0}° número: ",i);
                s=Console.ReadLine();
                b[i]=float.Parse(s);
            }
            Console.WriteLine("\n #### Calculos ####");
            c[0] = a[0] + b[0];
            Console.WriteLine("Soma: {0}", c[1]);
            c[1] = a[1] - c[1];
            Console.WriteLine("Subtraçao: {0}", c[1]);
            c[2] = a[2] * b[2];
            Console.WriteLine("Multiplicaçao: {0}", c[2]);
            c[3] = a[3] / b[3];
            Console.WriteLine("Divisao: {0}", c[3]);
            Console.WriteLine("\nPress. <ENTER> para Encerrar ...");
            System.Console.ReadKey();
        }
    }
}
        
        
    

