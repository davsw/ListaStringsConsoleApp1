using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ListaStringsConsoleApp1
{
    internal class Program
    {
        // Escreva um programa que receba uma frase do usuário e converta todas as palavras para o formato &quot;Title Case&quot;, ou
        // seja, todas as primeiras letras das palavras devem ser maiúsculas.
     
            static void Main(string[] args)
            {
                Console.WriteLine("Digite a frase que deseja ser convertida: ");
                string frase = Console.ReadLine();

                ConverterParaTitleCase(frase);
            }

            private static void ConverterParaTitleCase(string frase)
            {
                string[] palavrasSeparadas = frase.Split(' ');

                for (int i = 0; i < palavrasSeparadas.Length; i++)
                {
                    char[] letrasDaPalavra = palavrasSeparadas[i].ToCharArray();

                    char primeiraLetra = letrasDaPalavra[0];

                    letrasDaPalavra[0] = primeiraLetra > 96 ? Convert.ToChar(primeiraLetra - 32) : letrasDaPalavra[0];

                    palavrasSeparadas[i] = new string(letrasDaPalavra);
                }

                string fraseTitleCase = string.Join(" ", palavrasSeparadas);

                Console.WriteLine(fraseTitleCase);

                Console.ReadLine();
            }
        }
    }
