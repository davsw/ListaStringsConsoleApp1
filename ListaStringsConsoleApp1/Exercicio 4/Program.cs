using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaStringsConsoleApp1.Exercicio_4
{
    internal class Program
    {
         
        static void Main(string[] args)
        {
            string sequencia = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900423242190226710556263211111093705442175069416589604007198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";

            int maiorProduto = ObterMaiorProduto(sequencia);

            Console.WriteLine("O maior produto é: " + maiorProduto);

            Console.ReadLine();
        }

        private static int ObterMaiorProduto(string sequencia)
        {
            int maiorProduto = 0;

            for (int i = 0; i < sequencia.Length; i += 5)
            {
                string numerosDaSequencia = sequencia.Substring(i, 5);

                int produtoDaSequencia = CalcularProduto(numerosDaSequencia);

                maiorProduto = ObterMaiorProduto(maiorProduto, produtoDaSequencia);

                string numerosParaMultiplicacao = string.Join("*", numerosDaSequencia.ToCharArray());

                Console.WriteLine($"Conjunto: {numerosDaSequencia} = {numerosParaMultiplicacao} = {produtoDaSequencia}");
            }

            return maiorProduto;
        }

        private static int ObterMaiorProduto(int maiorProduto, int produtoDaSequencia)
        {
            if (produtoDaSequencia > maiorProduto)
                maiorProduto = produtoDaSequencia;
            return maiorProduto;
        }

        private static int CalcularProduto(string numerosDaSequencia)
        {
            int produtoDaSequencia = 1;

            for (int j = 0; j < numerosDaSequencia.Length; j++)
            {
                string caractereSelecionado = numerosDaSequencia[j].ToString();

                produtoDaSequencia *= Convert.ToInt32(caractereSelecionado);
            }

            return produtoDaSequencia;
        }
    }
}
 