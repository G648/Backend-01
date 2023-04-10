// Uma certa empresa fez uma
// pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado
// produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:

// A.    
// O número de pessoas que responderam SIM.

// B.    
// O número de pessoas que responderam NÃO;

// C.   
// O número de mulheres que responderam SIM;

// D.   
// A porcentagem de homens que responderam NÃO entre todos

// E.    
// quantidade de homens que responderam não.


Console.Clear();

//variáveis
char sexoUsuario;
char gostouDoProduto;

int totalSim = 0;
int totalNao = 0;

int totalMulheresSim = 0;
int totalHomensSim = 0;

int totalHomenNao = 0;

int totalMulher = 0;
int totalHomen = 0;

double porcentagemHomensNao = 0;

Console.WriteLine($"Seja bem vindo ao meu programa de entrevistas:");


for (var i = 1; i <= 10; i++)
{
    Console.WriteLine($"Informe o seu sexo: M - para masculino e F - para feminino:");
    sexoUsuario = char.Parse(Console.ReadLine().ToUpper());

    if (sexoUsuario == 'f')
    {
        totalMulher++;
    }
    else if (sexoUsuario == 'm')
    {
        totalHomen++;
    }

    //entrada de dados

    Console.WriteLine($"A pessoa gostou da pesquisa ? S - sim e N - não");

    gostouDoProduto = char.Parse(Console.ReadLine());

    if (gostouDoProduto == 'S')
    {
        totalSim++;

        if (sexoUsuario == 'f')
        {
            totalMulheresSim++;
        }
    }
    else if (gostouDoProduto == 'N'){
        totalNao++;

        if (sexoUsuario == 'M')
        {
            totalHomenNao++;
        }
    }


}

//processamento

porcentagemHomensNao = Math.Round(((double)totalHomenNao/(double)totalHomen)*100);

//saida de dados

Console.WriteLine($"A quantidade de pessoas que responderam sim foi de: {totalSim}");

Console.WriteLine($"O total de pessoas que responderam não foi de: {totalNao}");

Console.WriteLine($"O total de mulheres que responderam sim foi de: {totalMulheresSim}");


Console.WriteLine($"A porcentagem de pessoas homens de responderam não, foi de: {porcentagemHomensNao}");
