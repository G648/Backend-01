//Faça um programa que o usuário informe o salário recebido e o total gasto. Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.

//entrada de dados 
// = informe de salário e informe de orçamento

// processamento de dados
//= realizar o calculo de informe de salário - informe de orçamento

//saída de dados
// = realizar a estrutura condicional para validar se os gastos ficou dentro do orçamento ou se o orçamento foi estourado


float informeSalario;
int informeOrcamento;

Console.WriteLine($"Informe o seu salário mensal: ");
informeSalario = float.Parse(Console.ReadLine());

Console.WriteLine($"Informa o seu orçamento mensal: ");
informeOrcamento = int.Parse(Console.ReadLine());

if (informeSalario >= informeOrcamento)
{
    Console.WriteLine($"Os gastos estão dentro do orçamento mensal");
    
}
else
{
    Console.WriteLine($"Os gastos estão fora do orçamento mensal");
    
}
