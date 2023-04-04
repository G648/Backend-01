// Escreva um programa utilizando o comando switch que imprima um mês de acordo com o número digitado pelo usuário


//entrada de dados
// = pedir para o usuário digitar o numero do mes entre 1 e 12

//processamento de dados
// = contruir estrutura switch case para armazenar todos os meses do ano

//saida de dados
// = mostrar qual foi o mes do ano

Console.Clear();

Console.WriteLine($"Por favor, informe o número do mes do ano que voce quer descobrir, sendo que: 1 = janeiro, 2 = fevereiro....");
int mes = int.Parse(Console.ReadLine());

if (mes >=1 || mes <=12)
{
    switch (mes)
    {
        case 1:
        Console.WriteLine($"Esse é o mês de Janeiro");
            break;
        case 2:
        Console.WriteLine($"Esse é o mês de Fevereiro");
            break;
        case 3:
        Console.WriteLine($"Esse é o mês de Março");
            break;
        case 4:
        Console.WriteLine($"Esse é o mês de Abriu");
            break;
        case 5:
        Console.WriteLine($"Esse é o mês de Maio");
            break;
        case 6:
        Console.WriteLine($"Esse é o mês de Junho");
            break;
        case 7:
        Console.WriteLine($"Esse é o mês de Julho");
            break;
        case 8:
        Console.WriteLine($"Esse é o mês de Agosto");
            break;
        case 9:
        Console.WriteLine($"Esse é o mês de Setembro");
            break;
        case 10:
        Console.WriteLine($"Esse é o mês de Outubro");
            break;
        case 11:
        Console.WriteLine($"Esse é o mês de Novembro");
            break;
        case 12:
        Console.WriteLine($"Esse é o mês de Dezembro");
            break;
        default:
        Console.WriteLine($"O número digitado não condiz com nenhum mês");
            break;
    }
    
}
