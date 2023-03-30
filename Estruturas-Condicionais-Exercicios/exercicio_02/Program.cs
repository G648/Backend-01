// Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.

//entrada de dados
// = informar os dois times de futebol
// = informar o placar do jogo

//processamento
// = realizar a validação através das estruturas condicionais
// = verificar se os times ganharam, perderam ou empataram

//saida
// = informar o resultado do jogo de futebol

string time1;
string time2;
int placarTime1;
int placarTime2;

Console.WriteLine($"Informe o primeiro time de futebol: ");
time1 = Console.ReadLine();

Console.WriteLine($"Informe o segundo time de futebol: ");
time2 = Console.ReadLine();

Console.WriteLine($"Informe o placar do primeiro time: ");
placarTime1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe o placar do segundo time: ");
placarTime2 = int.Parse(Console.ReadLine());

if (placarTime1 > placarTime2)
{
    Console.WriteLine($"O time {time1} ganhou do time {time2}");   
}
else if (placarTime1 < placarTime2)
{
    Console.WriteLine($"O time {time2} ganhou do time {time1}"); 
}
else
{
    Console.WriteLine($"O resultado entre o jogo dos times {time1} e {time2} foi empate!");
    
}