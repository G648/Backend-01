using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_SistemasDeProdutos
{
    public class Produto
    {
        private bool validacao;
        public bool loopBreak;
        public string Nome { get; set; }
        public float Preço { get; set; }
        public bool promocao { get; set; }

        //precisamos criar a lista para armezar as informações
        List<Produto> listProducts = new List<Produto>();


        public void CadastrarProduto()
        {
            //aqui estou realizando o cadastro de 10 itens dentro do programa
            while (listProducts.Count < 3)
            {


                for (int i = 0; i < 3; i++)
                {
                    do
                    {
                        try
                        {
                            //precisamos criar um objeto para inserir os dados dentro da lista
                            Produto createProduct = new Produto();
                            
                            Console.WriteLine($"Por gentilza, informe o nome do {i + 1}° produto:");
                            createProduct.Nome = Console.ReadLine();


                            Console.WriteLine($"Por gentilza, informe o preço do produto:");
                            createProduct.Preço = float.Parse(Console.ReadLine());

                            listProducts.Add(createProduct);
                        }
                        catch (Exception error)
                        {
                            Console.WriteLine($"Informe um valor válido, ocorreu o seguinte erro: {error.Message}");
                            validacao = true;
                        }

                    } while (validacao == true);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Produto adicionado à lista");
                    Console.ResetColor();


                }
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"A sua sacola está cheia");
            Console.ResetColor();

        }

        public void ListarProdutos()
        {
            foreach (var item in listProducts)
            {
                Console.WriteLine(@$"
                O nome do produto cadastrado é: {item.Nome}
                O preço do produto cadastrado é de: {item.Preço:C}
                ");
            }

        }

        public void Carregamento(string valor)
        {
            Console.Write(valor);
            for (int i = 0; i < 5; i++)
            {
                Console.Write($".");
                Thread.Sleep(500);
            }
            Console.Clear();
        }
    }
}