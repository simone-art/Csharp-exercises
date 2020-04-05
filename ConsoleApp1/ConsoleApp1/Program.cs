using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {

         static void Main (string[] args)
        {
            var nome = new List<string>();
            nome.Add("Simone");
            nome.Add("Silene");
            nome.Add("Shirley");

            Console.WriteLine(nome[2]);
        }
    }
}
