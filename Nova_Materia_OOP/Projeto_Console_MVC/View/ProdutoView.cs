using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_Console_MVC.model;

namespace Projeto_Console_MVC.View
{
    public class ProdutoView
    {
        //métrodo para exibir os dados da lista de produtos
        public void Listar(List<Produto> produto)
        {
            //foreach para ler a lista passada como parâmetro do método
            foreach (var item in produto)
            {

                Console.WriteLine($"\nCódigo = {item.Codigo}");
                Console.WriteLine($"Nome = {item.Nome}");
                Console.WriteLine($"Preço = {item.Preco:C}");

            }
        }
    }
}