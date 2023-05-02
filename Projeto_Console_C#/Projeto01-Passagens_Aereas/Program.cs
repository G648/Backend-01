// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair


// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).


//entrada de dados


//processamento de dados

//saida de dados

using System;
using Projeto01_Passagens_Aereas;

Console.Clear();
Console.WriteLine(@$"Programa de cadastro de passagens
---------------------------------------------------
|             Selecione um valor:                  |
|       1- Cadastrar Passagem Aerea;               |
|       2- Listagem de passagem Aerea;             |
|       3- Sair do programa de passgens;           |
---------------------------------------------------
");

//realizando o processamento de dados:

//variáveis
int escolhaUsuario;
string senhaDeAcesso;

//validação de senha
Console.WriteLine($"Primeiramente, digite a sua senha de acesso ao programa;");
senhaDeAcesso = Console.ReadLine();

do
{
    Console.WriteLine($"Senha inválida, por gentileza, digite a senha novamente");
    senhaDeAcesso = Console.ReadLine();

} while (senhaDeAcesso != "123456");

//escolhendo as opções do menu

Console.WriteLine($"Autenticação realizada com sucesso!");

//linkando com meu arquivo de métodos (método carregamento)
Utils.Carregamento();

Console.Clear();
Console.WriteLine(@$"seja bem vindo ao programa de cadastro de passagens

---------------------------------------------------
|             Selecione um valor:                  |
|       1- Cadastrar Passagem Aerea;               |
|       2- Listagem de passagem Aerea;             |
|       3- Sair do programa de passgens;           |
---------------------------------------------------
");


Console.WriteLine($"Por gentileza, informe opção 1 - Cadastrar passagens, 2 - Listagem de passagem ou 3 - sair do programa");
escolhaUsuario = int.Parse(Console.ReadLine());

Utils.Carregamento();

switch (escolhaUsuario)
{
    case 1:
             
        do
        {
            Utils.CadastroPassagens();

            
        } while (escolhaUsuario != 1);

        Console.WriteLine(@$"Selecione o que deseja fazer agora:
        [1] - Cadastrar mais passagens aereas;
        [2] - Voltar para Menu
        ");

        int respostaUsuario = int.Parse(Console.ReadLine());
        
        if (respostaUsuario == 1)
        {
            Utils.Carregamento();
            Utils.CadastroPassagens();
        }

        break;
    case '2':
        Console.WriteLine(@$"Voce decidiu realizar a listagem de passagem Aerea. Por favor, informe o ID da passagem:");
        Console.ReadLine();
        
        
        break;
    case '3':
        Console.WriteLine($"Voce decidiu sair do progama. Bye Bye!");
        
        break;
    default:
        break;
    }

