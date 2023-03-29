Console.BackgroundColor=ConsoleColor.DarkYellow;
Console.WriteLine(@$"
-------------------------
|    Programa para      |
|   calcular a média    |
|                       |
-------------------------
");

Console.ResetColor();

string nome = "guilherme";

Console.WriteLine($"Bem vindo ao programa de calculo de média de alunos; ");
Console.WriteLine($"Digite a primeira nota do aluno {nome}");
int nota01 = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite a segunda nota do aluno  {nome}");
int nota02 = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite a terceira nota do  aluno {nome}");
int nota03 = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite a quarta nota do aluno {nome}");
int nota04 = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite a quinta nota do aluno {nome}");
int nota05 = int.Parse(Console.ReadLine()); 

int media_final = (nota01 + nota02 + nota03 + nota04 + nota05) / 5;

Console.WriteLine($"A média final do aluno {nome} é de: {media_final}");


if (media_final >= 5)
{
    Console.WriteLine($"O aluno {nome} foi aprovado com sucesso!");
    
}
else{
    Console.WriteLine($"O aluno {nome} foi reprovado com sucesso!");
    
}





