using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public static void calculaMedia(int i, int qtd)
        {
            if (i > qtd) return;
            Console.WriteLine($"{qtd}");
            calculaMedia(i + 1, qtd);
        }


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n\n\n");
                Console.WriteLine("*************************************");
                Console.WriteLine("Digite uma das opções abaixo");
                Console.WriteLine("2) Execute o programa");
                Console.WriteLine("3) Calcule a media de suas notas");
                Console.WriteLine("4) Calcule a media da suas notas");
                Console.WriteLine("10) Sair do programa");
                Console.WriteLine("*************************************");
                var n = Convert.ToInt16(Console.ReadLine());

                var sair = false;
                switch (n)
                {
                    case 1:
                        Program.calculaMedia(0, 3);
                        break;
                    case 2:
                        Program.calculaMediaRecursiva();
                        break;
                    case 3:
                        Program.calculaMediaNotas();
                        break;
                    case 10:
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                if (sair) break;
            }
        }

        private static void calculaMediaRecursiva()
        {
            Console.WriteLine("Digite a quantidade de notas");
            var qtd = Convert.ToInt16(Console.ReadLine());

            var notas = new List<int>();
            notas = preencheNotasAluno(1, qtd, notas);

        }

        
        private static List<int> preencheNotasAluno(int i, int qtd, List<int> notas)
        {
            if (i > qtd) return notas;

            Console.WriteLine($"Digite a {i}º nota do aluno");
            var nota = Convert.ToInt16(Console.ReadLine());
            notas.Add(nota);
            return preencheNotasAluno(i + 1, qtd, notas);
        }

        private static void calculaMediaNotas()
        {
            int n1, n2, qtd, media;
            n1 = Convert.ToInt16(Console.ReadLine());
            n2 = Convert.ToInt16(Console.ReadLine());
            qtd = Convert.ToInt16(Console.ReadLine());
            media = (n1 + n2) / qtd;
            Console.WriteLine("A media das suas notas é " + media);
            
           

        }
        

 
    }

}

