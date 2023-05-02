// faça um programa que receba um número inteiro e mostre a sua tabuada

//entrada de dados
// = receber o número do usuário e mostrar a tabuada desse número

//processamento de dados
// = usar a estrutura for para criar o laço de repeticação para a criação da tabuada

//saida de dados
// = exibir a tabuada

Console.Clear();
Console.WriteLine($"Seja bem vindo ao meu programa de tabuada!!!");

int numTabuada;
int resultado;

Console.WriteLine($"Por gentileza, digite um número para saber qual a tabuada do mesmo:");
numTabuada = int.Parse(Console.ReadLine());

for (var i = 1; i <= 10; i++)
{
    resultado = numTabuada*i;
    Console.WriteLine($"A tabuada do {numTabuada} é de: {numTabuada} X {i} = {resultado} ");
    
}


