using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_CadastroProdutos_16_05
{
    public class Produto
    {

        public int CodigoProduto { get; set; }
        public string NomeProduto { get; set; }
        public float PrecoProduto { get; set; }
        public string MarcaProduto { get; set; }
        public int CodigoMarca { get; set; }
        DateTime DataCadastro = DateTime.Now;
        public Usuario CadastradoPor = new Usuario();
        public Marca marca = new Marca();

        List<Produto> listaDeProdutos = new List<Produto>();

        public void CadastrarProduto()
        {

            Produto receberProduto = new Produto();


            Console.WriteLine($"Digite o código do produto para cadastro.");
            receberProduto.CodigoProduto = int.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o nome do produto para cadastro:");
            receberProduto.NomeProduto = Console.ReadLine();

            Console.WriteLine($"Informe a marca do produto:");
            receberProduto.MarcaProduto = Console.ReadLine();

            Console.WriteLine($"Informe o código da marca:");
            receberProduto.CodigoMarca = int.Parse(Console.ReadLine());


            Console.WriteLine($"informe o preço do produto:");
            receberProduto.PrecoProduto = float.Parse(Console.ReadLine());

            Console.WriteLine($"Data de cadastro : {DataCadastro}");
            receberProduto.CadastradoPor = CadastradoPor.CadastrarUsuario();


            // Console.WriteLine($"Digite seu email:");
            // string emailUser = Console.ReadLine();
            // cadastradoPor.UserLogado(emailUser, cadastradoPor);


            listaDeProdutos.Add(receberProduto);

        }

        public void ListarProduto()
        {

            foreach (var item in listaDeProdutos)
            {

                Console.WriteLine(@$"
                Dados do produto cadastrado:
                - Código do produto = {item.CodigoProduto}
                - Nome do produto = {item.NomeProduto}
                - Nome da marca = {item.MarcaProduto}
                - Preço do produto = {item.PrecoProduto:C}
                - Data de cadastro = {DataCadastro}
                - Cadastrado por = {item.CadastradoPor.NameUser}
                ");

            }
        }

        public void RemoverProduto()
        {

            Console.WriteLine($"Digite o nome do produto que voce deseja deletar");
            string deleteProduct = Console.ReadLine();

            Produto produtoEncontrado = listaDeProdutos.Find(x => x.NomeProduto == deleteProduct);

            //encontrar o índice do produto encontrado
            int index = listaDeProdutos.IndexOf(produtoEncontrado);

            //exibir o índice no console
            Console.WriteLine($"O índice do produto encontrado é o : {index}");

            //remover o item antigo da lista
            //aqui eu tenho que remover o que está no indice
            listaDeProdutos.RemoveAt(index);

            Console.WriteLine($"Valor depois de atualizado");

            foreach (var item in listaDeProdutos)
            {
                Console.WriteLine(@$"
                Dados do produto cadastrado:
                - Código do produto = {item.CodigoProduto}
                - Nome do produto = {item.NomeProduto}
                - Nome da marca = {item.MarcaProduto}
                - Preço do produto = {item.PrecoProduto:C}
                - Data de cadastro = {DataCadastro}
                ");
            }
        }

        //esses métodos vão cher chamados no login do usuário 
    }
}