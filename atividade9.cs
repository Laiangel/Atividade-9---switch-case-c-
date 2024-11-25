using System;

namespace atividade9
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Digite a classificação etária do filme (G, PG, PG-13, R):");
            string classificacao = Console.ReadLine().ToUpper(); 

          
            switch (classificacao)
            {
                case "G":
                    Console.WriteLine("Faixa etária permitida: Livre (qualquer idade).");
                    break;
                case "PG":
                    Console.WriteLine("Faixa etária permitida: Maior de 10 anos.");
                    break;
                case "PG-13":
                    Console.WriteLine("Faixa etária permitida: Maior de 13 anos.");
                    break;
                case "R":
                    Console.WriteLine("Faixa etária permitida: Maior de 18 anos.");
                    break;
                default:
                    Console.WriteLine("Classificação inválida. Por favor, insira uma classificação válida (G, PG, PG-13, R).");
                    break;
            }
        }
    }
}
