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

internal class Program

{
    private static void Main(string[] args)
    {
        // realizar a contrução do menu:
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

        Console.Write($"Carregando");

        for (var i = 0; i < 5; i++)
        {
            Console.Write($".");
            Thread.Sleep(800);
        }

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

        switch (escolhaUsuario)
        {
            case 1:
                Console.WriteLine(@$"Voce decidiu realizar o cadastro de passagem Aerea. Por favor, informe:
        1- Origem;
        2- Destino;
        3- Data/hora de saída;
        4- Tipo de voo (classe economica ou primeira classe);
        5- Determine qual é a companhia aerea que deseja viajar;
        ");

                break;
            case '2':
                break;
            case '3':
                break;
            default:
                break;
        }
    }
}