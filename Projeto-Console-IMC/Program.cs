Console.BackgroundColor=ConsoleColor.DarkYellow;
Console.WriteLine(@$"
-------------------------
|    Programa para      |
|    calcular o IMC     |
|                       |
-------------------------
");

Console.ResetColor();


Console.WriteLine($"informe o nome do paciente: ");
string nome = Console.ReadLine();

Console.WriteLine($"informe o peso do paciente: ");
float peso = float.Parse(Console.ReadLine());

Console.WriteLine($"informe a altura do paciente: ");
float altura = float.Parse(Console.ReadLine());

float imc = peso / ((float) Math.Pow (altura, 2)); //método Math.Pow é usado para conversão de string para double, porém colocamos o (Float) para especificar que estamos usando a variável float

Console.WriteLine($"o paciente {nome} tem o imc de: {imc}"); //$ representa interpolação
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Obrigado por utilizar nosso sitema!");

Console.ResetColor();


