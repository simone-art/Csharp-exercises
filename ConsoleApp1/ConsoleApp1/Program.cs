using System;

namespace ConsoleApp1
{
    class Program
    {

         public static int Calcular()
        {
            int A = 10;
            int B = 50;
            int C = A + B;
            return C;

        }

        static void Main (string[] args)
        {
            Console.WriteLine(Calcular());
            Console.Read();
        }
    }
}
