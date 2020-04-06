using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {

         static void Main (string[] args)
        {
            Console.WriteLine("Digite a quantidade de notas");
            var qtd = Convert.ToInt16(Console.ReadLine());
            int[] notas = new int[qtd];

            int i = 0;
            var somaNotas = 0;

            while (i<qtd)
            {
                Console.WriteLine("Digite a nota " +  (i + 1)  + " do aluno ");
                notas[i] = Convert.ToInt16(Console.ReadLine());
                somaNotas += notas[i]; 
                i++;
     
            }

            var media = somaNotas / notas.Length;
            Console.WriteLine("A media do aluno é " + media);

            switch (media)
            {
                case 5:
                    Console.WriteLine("Você foi reprovado");
                    break;
                case 6:
                    Console.WriteLine("Você foi aprovado mas precisa melhorar");
                    break;
                case 7:
                    Console.WriteLine("Você foi aprovado. Parabéns!");
                    break;
                default:
                    
                    if (media < 5)
                    {
                        Console.WriteLine("Voçê foi reprovado");
                    }
                    else
                    {
                        Console.WriteLine("Voçê foi aprovado com louvor");
                        
                    }
                    break;

            }
        }
    }
}
