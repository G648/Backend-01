Console.BackgroundColor=ConsoleColor.DarkYellow;
Console.WriteLine(@$"
-------------------------
|    Programa para      |
|   calcular a idade    |
|                       |
-------------------------
");

Console.ResetColor();

// faça um programa para calcular a idade de uma pessoa em:
// - meses
// - Dias
// - Horas 
// - Minutos
int meses = 12;
int dias = 365;
int horas = 24 ;
int minutos = 60;


Console.WriteLine("informe sua idade: ");
int idade = int.Parse(Console.ReadLine());

int calculo_meses = idade * meses ;
int calculo_dias = idade * dias ;
float calculo_horas = calculo_dias * horas ;
float calculo_minutos = calculo_horas * minutos ;

Console.WriteLine($"O calculo da sua idade em meses é de {calculo_meses} meses");
Console.WriteLine($"O calculo da sua idade em dias é de {calculo_dias} dias");
Console.WriteLine($"O calculo da sua idade em Horas é de {calculo_horas} horas");
Console.WriteLine($"O calculo da sua idade em minutos é de {calculo_minutos} minutos");

// faça um algoritimo para calcular o tempo restante até o seu aniversário

