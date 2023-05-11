using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaStringsConsoleApp1.Exercicio_2
{
    internal class Program
    {     
         // Dada uma string contendo uma frase, escreva um programa em C# que conte o número de palavras na frase e
         // imprima o resultado.
         

        static void Main(string[] args)
        {
            string frase = "fala galera da academia";

            ContarLetras(frase);
        }

        private static void ContarLetras(string frase)
        {
            string[] palavras = frase.Split(' ');

            Console.WriteLine(palavras.Length);

            Console.ReadLine();
        }
    }
}
    
