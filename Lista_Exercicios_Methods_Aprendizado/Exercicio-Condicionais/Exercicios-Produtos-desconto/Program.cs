// 3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:

// - Se quantidade <= 5 o desconto será de 2%
// - Se quantidade > 5 e quantidade <=10 o desconto será de 3%
// - Se quantidade > 10 o desconto será de 5%

// Dica: utilize if / else if / else


//entrada de dados
// = criar variável para receber o nome do produto 
// = perguntar ao usuário qual vai ser a quantidade de produtos
// = perguntar o preço unitário do produto

//processamento de dados
// = realizar o calculo do total da quantidade do produto * valor unitário do produto 
// = realidar o calculo do desconto com base na quantidade de produtos que o usuário vai comprar

//saída de dados
// = mostrar a saída dos produtos que ela escolher e a quantidade e o preço de cada produto
// = mostrar também o desconto de cada produto


//variáveis
using System.Globalization;

CultureInfo reais = new CultureInfo("pt-BR");
string nomeProduto;
int quantidadeProduto;
float precoUnitario;
float totalPrecoProduto;
float totalPrecoDesconto;

Console.WriteLine($"Olá, seja bem vindo ao meu programa de calculo de produtos:");

Console.WriteLine($"digite o nome do produto que voce deseja comprar:");
nomeProduto = Console.ReadLine();

Console.WriteLine($"informa a quantidade de produtos que voce deseja comprar:");
quantidadeProduto = int.Parse(Console.ReadLine());


Console.WriteLine($"Qual o preço unitário de cada produto ?");
precoUnitario = float.Parse(Console.ReadLine());

if (quantidadeProduto <= 5)
{
    totalPrecoProduto = (quantidadeProduto * precoUnitario);
    Console.WriteLine($"o preço total da quantidade de produtos que voce determinou é de: {Math.Round(totalPrecoProduto, 2).ToString("C", reais)}");

    totalPrecoDesconto = totalPrecoProduto - (totalPrecoProduto * 0.02f);
    Console.WriteLine($"o preço com desconto dos produtos é de: {Math.Round(totalPrecoDesconto, 2).ToString("C", reais)}");

}
else if (quantidadeProduto > 5 || quantidadeProduto <= 10)
{
    totalPrecoProduto = (quantidadeProduto * precoUnitario);
    Console.WriteLine($"o preço total da quantidade de produtos que voce determinou é de: {Math.Round(totalPrecoProduto, 2).ToString("C", reais)}");

    totalPrecoDesconto = totalPrecoProduto - (totalPrecoProduto * 0.03f);
    Console.WriteLine($"o preço com desconto dos produtos é de: {Math.Round(totalPrecoDesconto, 2).ToString("C", reais)}");
}

else
{
    totalPrecoProduto = (quantidadeProduto * precoUnitario);
    Console.WriteLine($"o preço total da quantidade de produtos que voce determinou é de: {Math.Round(totalPrecoProduto, 2).ToString("C", reais)}");

    totalPrecoDesconto = totalPrecoProduto - (totalPrecoProduto * 0.05f);
    Console.WriteLine($"o preço com desconto dos produtos é de: {Math.Round(totalPrecoDesconto, 2).ToString("C", reais)}");
}




