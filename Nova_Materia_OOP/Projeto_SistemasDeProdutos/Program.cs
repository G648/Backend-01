
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

using Projeto_SistemasDeProdutos;



Produto P1 = new Produto();

do
{
startOfLoop:
    Console.WriteLine(@$"Seja bem vindo ao menu de produtos. Selecione uma opção do menu:
[1] - Cadastrar produto;
[2] - Listar produto;
[3] - Mostrar menu;
[0] - Sair do programa;
");

    string escolhaMenu = Console.ReadLine();

    switch (escolhaMenu)
    {
        case "1":
            P1.Carregamento("Redirecionando para o menu de cadastro");
            Console.WriteLine($"Bem vindo ao menu de cadastro de produtos!");
            P1.CadastrarProduto();
            P1.Carregamento("voltando para o menu");
            P1.loopBreak = true;

            break;
        case "2":
            P1.Carregamento("Redirecionando para o menu de listagem de produtos");
            Console.WriteLine($"");
            P1.ListarProdutos();
            P1.loopBreak = true;
            break;
        case "3":
            if (escolhaMenu == "3")
            {
                goto startOfLoop;
            }
            break;
        case "0":
            P1.Carregamento("Realizando o desligamento do programa");
            P1.loopBreak = false;
            break;
        default:
            Console.WriteLine($"Resposta incorreta, por getileza, informe uma opção válida!");
            goto startOfLoop;

    }
} while (P1.loopBreak == true);