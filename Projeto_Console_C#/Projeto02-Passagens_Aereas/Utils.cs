using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto02_Passagens_Aereas
{
    public class Utils

    {
        
        string[] nomeProduto = new string[2];   //depois substituir esse valor por 10
        float[] precoProduto = new float[2];    //depois substituir esse valor por 10
        bool[] promocaoProduto = new bool[2];   //depois substituir esse valor por 10
        
        public static void CadastrarProduto()
        {
            Console.WriteLine($"Voce optou por realizar o cadastro de produtos, por gentileza, determine os seguintes valores:");

            Console.WriteLine($"[1] - Escreva o nome do produto que voce deseja comprar:");
            

            Console.WriteLine($"[2] - Escreva o valor do produto");
            float precoProduto = float.Parse(Console.ReadLine());

            Console.WriteLine($"[3] - o produto está em promoção? determine S - para sim e N - para não");
            char produtoPromocao = char.Parse(Console.ReadLine());

        }

        public static void ListagemProdutos()
        {
            Console.WriteLine($"Voce optrou por realizar a listagem de produtos comprados");


        }

        public static void Carregamento()
        {
            Console.Write($"Carregando");

            for (var i = 0; i < 5; i++)
            {
                Console.Write($".");
                Thread.Sleep(500);
            }

            Console.Clear();
        }
    }
}