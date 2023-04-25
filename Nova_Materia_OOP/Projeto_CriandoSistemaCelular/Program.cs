// Faça em sua máquina utilizando os mesmos conceitos dado em aula.

//  Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
//  Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
//  Só será possível executar tais métodos se o celular estiver ligado.
//  Envie o link do repositório como entrega desta atividade.

using Projeto_CriandoSistemaCelular;

Celular celular01 = new Celular();

Console.WriteLine($"Olá, seja bem vindo ao meu programa!");

Console.WriteLine($"Por gentileza, informe a cor do seu smartphone: ");
celular01.cor = Console.ReadLine();

Console.WriteLine($"Por gentileza, informe o modelo do seu smartphone: ");
celular01.modelo = Console.ReadLine();

Console.WriteLine($"Por gentileza, informe o tamanho do seu smartphone: ");
celular01.tamanho = Console.ReadLine();

// Console.WriteLine($"Por gentileza, informe [1] para celular ligado e [2] para celular desligado: ");
// celular01.ligado = console.ReadLine();

Console.WriteLine(@$"O que voce deseja fazer agora ? selecione uma opção:
[1] - Ligar o celular 
[2] - Desligar o celular
[3] - Fazer uma ligação
[4] - Enviar uma mensagem
");

celular01.selecionarOpcao = Console.ReadLine();



do
{
    
Console.WriteLine($"O celular está bloqueado, por gentileza, informe a senha para desbloqueio:");

celular01.senhaCelular = Console.ReadLine();


} while (celular01.senhaCelular != "123456");


switch (celular01.selecionarOpcao)
{
    case "1":
        celular01.Ligar();
        break;
    case "2":
        celular01.Desligar();
        break;
    case "3":
        celular01.FazerLigacao();
        break;
    case "4":
        celular01.EnviarMensagem();
        break;
    default:
        Console.WriteLine($"Opção inválida!");
        break;
}
