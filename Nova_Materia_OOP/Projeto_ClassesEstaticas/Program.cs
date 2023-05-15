// Faça um programa de conversão de moedas(câmbio) usando classe, membro e métodos estáticos.


// Menu de opções : dólar para real, real para dólar, sair
// Personalizar a resposta, usando recursos da linguagem(Bibliotecas)

using System.Globalization;
using Projeto_ClassesEstaticas;
bool loopBreak = true;

Console.Clear();


Console.WriteLine($"Olá, seja bem vindo ao meu programa!");
do
{

startOfLoop:
    Console.WriteLine(@$"Por gentileza, informa uma opção do menu abaixo:
    [1] - Conversão de dólar para real
    [2] - Conversão de real para dólar
    [3] - Sair do programa
");

    string escolhaMenu = Console.ReadLine()!;


    switch (escolhaMenu)
    {
        case "1":
            Console.WriteLine($"Você escolher a conversão de dólar para real");
            Console.WriteLine($"O valor da conversão é de:{ConversãoMoeda.DolarParaReal().ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))}");
            loopBreak = true;
            break;
        case "2":
            Console.WriteLine($"Você escolher a conversão de real para dólar");
            Console.WriteLine($"O valor da conversão é de:{ConversãoMoeda.RealParaDolar().ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");
            loopBreak = true;
            break;
        case "3":
            Console.WriteLine($"Você decidiu sair do programa, até mais!");
            loopBreak = false;
            break;
        default:
            Console.WriteLine($"opção inválida! ");
            goto startOfLoop;

    }
} while (loopBreak);


