using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            string escolha = "";
            do
            {
                Console.WriteLine("Insira uma palavra para analisarmos se é um Palíndromo: ");
                var teste = Console.ReadLine();

                if (string.IsNullOrEmpty(teste.Trim()))
                {
                    do
                    {
                        Console.WriteLine("Escrita em Branco! Siga o passo Abaixo:");
                        Console.WriteLine("Insira uma palavra para analisarmos se é um Palíndromo: ");
                        teste = Console.ReadLine();
                    } while (teste == "");
                }

                string inverso = "";

                for (int i = teste.Length - 1; i >= 0; i--)
                {
                    inverso += teste[i];//Array troca = teste.ToArray(); //Array.Reverse(troca);
                }//foreach (char letra in teste) //inverso += Convert.ToString(letra);

                Console.WriteLine(inverso);

                if (teste == inverso)
                    Console.WriteLine("Sim, é um palindromo! \n"); //Console.ReadLine();
                else
                    Console.WriteLine("Não é um palindromo! \n");  //Console.ReadLine();

                Console.Write("Quer fazer outro teste? (S ou N)\n");
                escolha = Console.ReadLine();

                if (escolha.ToLower() != "s" && escolha.ToLower() != "n")
                {
                    do
                    {
                        Console.WriteLine("Opção Inválida!");
                        Console.WriteLine("Por gentileza, escolha S ou N para sua resposta");
                        Console.WriteLine("Quer fazer outro teste? (S ou N) \n");
                        escolha = Console.ReadLine();
                    } while (escolha.ToLower() != "s" && escolha.ToLower() != "n");
                }
            } while (escolha.ToLower() == "s");

            Console.WriteLine("Obrigado pela Preferência =)");
            Console.ReadKey();
        }
    }
}
