// Uma loja fornece 10% de desconto para funcionários e 5% de desconto para clientes vips. 
// Faça um programa que calcule o valor total a ser pago por uma pessoa. O programa deverá ler o
// valor total da compra efetuada e um código que identifique se o comprador é um cliente comum (1), funcionário (2) ou vip (3).



//entrada de dados
// = determinar se o cliente é 1- cliente, 2- funcionário e 3-vip
// = informar o total da compra 

//processamento de dados
// = usar a estrutura switch case para determinar se é cliente, funcionário ou vip

//saída de dados
// = se for cliente não haverá desconto
// = se for funcionário terá 10% de desconto
// = se for vip terá 5% de desconto

Console.Clear();
Console.WriteLine($"Seja bem vindo ao programa de calculo de desconto!!");

float totalCompra;
double calculo;

Console.WriteLine($"Por favor, informa o valor total de sua compra em Reais!");
totalCompra = float.Parse(Console.ReadLine());

Console.WriteLine($"informe 1 para cliente comum, 2 para funcionário e 3 para vip");
char numIdentificacao = char.Parse(Console.ReadLine());

switch (numIdentificacao)
{
    case '1':
    Console.WriteLine($"Usuário comum, não haverá desconto. O total de sua compra foi de R$:{totalCompra}");
        break;
    case '2':
    calculo = totalCompra - (totalCompra* 0.1);
    Console.WriteLine($"Funcionário, voce terá 10% de desconto. O total de sua compra foi de R${calculo}");
        break;
    case '3':
    calculo = totalCompra - (totalCompra * 0.05);
    Console.WriteLine($"Cliente VIP, voce terá 5% de desconto. O total de sua compra foi de R${calculo}");
        break;
    default:
    Console.WriteLine($"Insira um número de identificação válido");
        break;
}




