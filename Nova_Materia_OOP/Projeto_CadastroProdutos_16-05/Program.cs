// aqui vamos utilizar a seguinte lógica:
// vamos precisar ter um usuário cadastrado no sistema antes de ele conseguir ver o menu de opções e conseguir também cadastrar algum produto

using System;
using Projeto_CadastroProdutos_16_05;

string escolhaMenu;

Usuário cadastroUser = new Usuário();

Console.Clear();

Console.WriteLine(@$"
------------------------------------------------
|Bem vindo ao programa de cadastro de produtos!|
|Aqui voce encontra opções para cadastro de    |
|produtos!                                     |
------------------------------------------------
");

Console.WriteLine(@$"
Por gentileza, escolha uma opção abaixo:
[1] - Cadastrar produto 
[2] - Cadastrar usuário
[3] - Sair do programa
");

escolhaMenu = Console.ReadLine();

switch (escolhaMenu)
{
    case "1":
        Console.WriteLine($"Você resolveu cadastrar um produto, por gentileza, realize o login antes de prosseguir:");
        cadastroUser.CadastrarUsuario();
        
        break;
    case "2":
        break;
    case "3":
        break;
    default:
        break;
}
