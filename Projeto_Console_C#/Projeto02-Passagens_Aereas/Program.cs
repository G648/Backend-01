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


using Projeto02_Passagens_Aereas;
string opcaoUsuarioMenu;
int contador = 0;

string[] nomeProduto = new string[2];   //depois substituir esse valor por 10
float[] precoProduto = new float[2];    //depois substituir esse valor por 10
bool[] promocaoProduto = new bool[2];   //depois substituir esse valor por 10

 static void CadastrarProduto(string[] nomeProduto, float[] precoProduto, bool[] promocaoProduto, char respostaPromocao)
        {
            for (var i = 0; i < 2; i++)
            {
                
            Console.WriteLine($"Voce optou por realizar o cadastro de produtos, por gentileza, determine os seguintes valores:");

            Console.WriteLine($"[1] - Escreva o nome do produto que voce deseja comprar:");
            nomeProduto[i] = Console.ReadLine();

            Console.WriteLine($"[2] - Escreva o valor do produto");
            precoProduto[i] = float.Parse(Console.ReadLine());

            Console.WriteLine($"[3] - o produto está em promoção? determine S - para sim e N - para não");
            respostaPromocao = char.Parse(Console.ReadLine());

            if (respostaPromocao == 's')
            {
                promocaoProduto[i] = true;
            }else{
                promocaoProduto[i] = false;
            }

            }
        }

        static void ListagemProdutos()
        {
            Console.WriteLine($"Voce optrou por realizar a listagem de produtos comprados");


        }

        static void Carregamento()
        {
            Console.Write($"Carregando");

            for (var i = 0; i < 5; i++)
            {
                Console.Write($".");
                Thread.Sleep(500);
            }

            Console.Clear();
        }

// bool loopBreak = true;

Console.Clear();
Utils.Carregamento();

do
{
    Console.WriteLine(@$"
        Seja bem vindo ao meu programa de cadastro de produtos;
        Por gentileza, escolha uma opção abaixo:
        [1] - Cadastrar Produto
        [2] - Listar produto
        [3] - Mostrar menu
        [0] - Sair do programa
    ");

    opcaoUsuarioMenu = Console.ReadLine();

    switch (opcaoUsuarioMenu)
    {
        case "1":
            Utils.Carregamento();
            CadastrarProduto();
            break;
        case "2":

            break;
        case "3":
            break;
        default:
            break;
    }


} while (opcaoUsuarioMenu != "0");