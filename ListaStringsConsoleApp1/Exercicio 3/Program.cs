using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaStringsConsoleApp1.Exercicio_3
{
    internal class Program
    {
        
           // Desenvolva uma aplicação troque cada letra de um texto por outra do alfabeto X posições a frente, onde X pode
           // ser escolhido por você (cifra de César)
           // a. Exemplo com X=2:
           // b. “DIEGO” passará a ser “FKGIQ”
         
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha qual vai ser a cifra: ");
            int cifra = Convert.ToInt32(Console.ReadLine());

            Criptografar(cifra);
        }

        private static void Criptografar(int cifra)
        {
            string frase = "DIEGO";

            char[] caracteres = frase.ToCharArray();

            for (int i = 0; i < caracteres.Length; i++)
            {
                caracteres[i] = Convert.ToChar(frase[i] + cifra);
            }

            Console.WriteLine(caracteres);

            Console.ReadLine();
        }
    }
}
