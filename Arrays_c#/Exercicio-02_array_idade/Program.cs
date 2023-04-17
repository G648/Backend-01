//escreva um programa que receba e imprima o nome e idade de 5 pessoas

//exemplo:
// nome: Guilherme
// Idade: 20 anos

//entrada de dados
// = perguntar nome e idade para o usuário

//processamento de dados
// = lista de arrays para receber o nome e a idade do usuário

//saída de dados
// = exibir o nome e idade do usuário


string[] nome = new string [5];
int[] idade = new int [5];

for (var i = 0; i < 4; i++)
{
    Console.WriteLine($"Por favor, digite aqui seu nome:");
    nome[i] = Console.ReadLine();

    Console.WriteLine($"Por gentileza, digite sua idade:");
    idade[i] = int.Parse(Console.ReadLine());

}

for (var i = 0; i < 4; i++)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"o nome do {i + 1} usuário é: {nome[i]}");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"a idade do {i + 1} usuário é: {idade[i]}");
    Console.ResetColor();

}
