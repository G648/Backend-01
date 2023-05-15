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

//sempre precisamos chamar o namespace;

using Projeto_CadastroDeProdutos;

bool loopBreak = true;

Produtos Product = new Produtos();

do
{
startOfLoop:
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(@$"Seja bem vindo ao meu programa de cadastro de produtos. Por gentileza, selecione uma opção:
    [1] - Cadastrar Produto
    [2] - Listar Produto
    [3] - Sair do Programa
    ");
    Console.ResetColor();

    Product.escolhaMenu = Console.ReadLine();

    switch (Product.escolhaMenu)
    {
        case "1":
            Console.WriteLine($"Você decidiu cadastrar um produto, por gentileza, determine as seguintes características:");
            Product.CadastrarProduto();
            loopBreak = true;
            break;
        case "2":
            Console.WriteLine($"Você decidiu listar um produto:");

            List<Produtos> listarProdutos = new List<Produtos>();
            listarProdutos.Add(Product);

            foreach (var item in listarProdutos)
            {
                Console.WriteLine(@$"
                
            O nome do produto cadastrado é {item.nomeProduto}
            O preço do produto é de {Math.Round(item.precoProduto, 2).ToString("C")} reais

            ");

            }

            break;
        case "3":
            Console.WriteLine($"Foi bom te servir! até a proxima!");
            loopBreak = false;
            break;
        default:
            Console.WriteLine($"Opção inválida!");
            goto startOfLoop;

    }
} while (loopBreak == true);
