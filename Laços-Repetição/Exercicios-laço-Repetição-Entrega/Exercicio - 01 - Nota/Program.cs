//faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo
//até que o usuário informe um valor válido!!

//entrada de dados
// = perguntar uma nota de 0 a 10 para um usuário.
// = se ele digitar errado o programa vai continuar perguntando até que ele digite um valor válido

//processamento de dados
// = cwl para perguntar um valor, se for valido, vai retornar o valor que o usuário digitou
// = se o valor que o usuário digitou não for valido, então ele vai repetir o número até que seja válido!

//saída de dados
// = exibir a saída do número que o usuário digitou 

Console.Clear();
Console.WriteLine($"Seja bem vindo ao meu programa!");

int numUsuario;

do
{

Console.WriteLine($"Por gentileza, digite um número de 0 a 10");
numUsuario = int.Parse(Console.ReadLine());

} while (numUsuario > 10 || numUsuario < 0);

Console.WriteLine($"Ok, o número digitado foi: {numUsuario}");
