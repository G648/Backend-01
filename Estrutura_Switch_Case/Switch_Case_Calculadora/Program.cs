//criando uma calculadora com switch case

//lógica - ALGORITMO

//1. definir operação
//2. entrada do primeiro número
//3. entrada do segundo número
//4. processar os dados
//5. exibir o resultado

Console.Clear();
Console.WriteLine(@$"
 --------------------------------------------------
|            Progama Calculadora                  |
|Informe a operação matemática que deseja efetuar:|
|'+' para somar                                   |
|'-' para subtrair                                |
|'*' para multiplicar                             |
|'/' para dividir                                 |
--------------------------------------------------
 ");

//escolhendo a operação matemática
char operacao = char.Parse(Console.ReadLine());

//entrada dos números do usuário

Console.WriteLine($"Digite o primeiro número que voce deseja:");
float num1 = float.Parse(Console.ReadLine());


Console.WriteLine($"Digite o segundo número que voce deseja:");
float num2 = float.Parse(Console.ReadLine());

float resultado = 0;

//realizar o processamento da calculadora

switch (operacao)
{
    case '+':
        resultado = (num1+num2);
        Console.WriteLine($"O resultado da soma é de: {resultado}");
        break;
         case '-':
        resultado = (num1-num2);
        Console.WriteLine($"O resultado da subtração é de: {resultado}");
        break;
         case '*':
        resultado = (num1*num2);
        Console.WriteLine($"O resultado da multiplicação é de: {resultado}");
        break;
         case '/':
        resultado = (num1/num2);
        Console.WriteLine($"O resultado da divisão é de: {resultado}");
        break;
    default:
        break;
}
 
