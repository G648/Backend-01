// Um posto está vendendo combustíveis com a seguinte tabela de descontos:

// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro

// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.

// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.



//entrada de dados
// = selecionar se deseja abastecer com alcool ou com gasolina;
// = selecionar a quantidade de litros que o usuário deseja;

//processamento de dados
// = switch case para gasolina ou alcool

//saida de dados
// = mostrar a porcentagem de desconto se for alcool ou se for gasolina


using System.Globalization;

CultureInfo reais = new CultureInfo("pt-BR");
char escolhaCombustivel;
int quantidadeLitros;
// double precoGasolina = 5.30;
// double precoAlcool = 5.90;

static double CalculoCombustivelGasolina(double gasolina)
{
    if (gasolina <= 20)
    {
        return (5.30 * gasolina) * 0.96;
    }
    else
    {
        return (5.30 * gasolina) * 0.94;

    }
}

static double CalculoCombustivelAlcool(double alcool)
{
    if (alcool <= 20)
    {
        return (4.90 * alcool) * 0.03;
    }
    else
    {
        return (4.90 * alcool) * 0.95;

    }
}

Console.WriteLine(@$"Seja bem vindo ao posto de gasolina do Mario. Estamos com uma super promoção!
Por favor, selecione o tipo de combustivel que voce deseja colocar no seu carro: 
A - Para alcool
G - Para gasolina
");

escolhaCombustivel = char.Parse(Console.ReadLine().ToUpper());


switch (escolhaCombustivel)
{
    case 'G':
        Console.WriteLine($"Escolha a quantidade de litros que voce deseja colocar:");
        quantidadeLitros = int.Parse(Console.ReadLine().ToUpper());

        double gasolinaCalculo = CalculoCombustivelGasolina(quantidadeLitros);
        Console.WriteLine($"O total de desconto por litro é de: {Math.Round(gasolinaCalculo, 2).ToString("C", reais)}");

        break;
    case 'A':
        Console.WriteLine($"Escolha a quantidade de litros que voce deseja colocar:");
        quantidadeLitros = int.Parse(Console.ReadLine().ToUpper());

        double alcoolCalculo = CalculoCombustivelAlcool(quantidadeLitros);

        Console.WriteLine($"O total de desconto por litro é de: {Math.Round(alcoolCalculo, 2).ToString("C", reais)}");
        break;
    default:
        Console.WriteLine($"digite um valor válido");

        break;
}

