using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
         
             string n;

              double trab, exer, prova, med;
              System.Console.Write("Digite a nota de trabalho: ");
              n = System.Console.ReadLine(); 
              trab = float.Parse(n);
              System.Console.Write("Digite a nota de exercício: ");
              n = System.Console.ReadLine();
              exer=float.Parse(n);
              System.Console.Write("Digite a nota de Prova: ");
              n = System.Console.ReadLine();
              prova = float.Parse(n);
              med = (trab + exer + prova) / 3;
              System.Console.WriteLine("Média: {0}", med);
              if (med >=6)
                  System.Console.WriteLine("parabéns, você passou!");
              else if (med < 3)
                  System.Console.WriteLine("Aluno Reprovado");
              else
                  System.Console.WriteLine("Aluno de Recuperação");
              System.Console.WriteLine("Press. <ENTER> para sair");
              System.Console.ReadKey();
        
        }
    }
}
