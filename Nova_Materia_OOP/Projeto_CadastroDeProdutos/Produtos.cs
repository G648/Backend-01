using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using Projeto_CadastroDeProdutos;

// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

// Os produtos terão os seguintes atributos:

// string Nome
// float Preco
// bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:

// CadastrarProduto
// ListarProdutos
// MostrarMenu

// Crie função(ões) para otimizar o código.
// Incremente o que achar necessário. Utilize sua lógica e sua criatividade.

namespace Projeto_CadastroDeProdutos
{
    public class Produtos
    {

        public string escolhaMenu { get; set; }
        public string nomeProduto { get; set; }
        public float precoProduto { get; set; }
        public char promocao { get; set; }
        public bool produtoPromocao { get; set; }


        // função para cadastro de produtos
        public void CadastrarProduto()
        {
            Console.WriteLine($"Determine o nome do produto que voce deseja cadastrar:");
            nomeProduto = Console.ReadLine();

            Console.WriteLine($"Determine o preço do produto que voce deseja cadastrar:");
            precoProduto = float.Parse(Console.ReadLine());


        }

        public void ProdutoEmPromocao()
        {
            Console.WriteLine($"O produto está em promoção ?");
            promocao = char.Parse(Console.ReadLine().ToLower());

            if (promocao == 's')
            {
                produtoPromocao = true;
                Console.WriteLine($"Ok, o produto está com 50% de desconto, portanto, você pagará apenas: {Math.Round(precoProduto * 0.5f, 2).ToString("C")} reais");
                //usando o math.round para determinar o número de casas decimais após a vírgula. Converter para string usando o systemGlobalization para converter para R$
            }
            else if (promocao == 'n')
            {
                produtoPromocao = false;
                Console.WriteLine($"O produto permanecerá com o valor normal;");

            }

        }
        public void VoltarAoMenu()
        {

        }
    }
}