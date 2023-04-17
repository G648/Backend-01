//faça um método para calcular imposto sobre a renda

//regras de negócio
//tabela de imposto vs renda
//até $1500 - isento
//de $1501 até $3500 - 20% de imposto
//de $3501 até $6000 - 25% de imposto
//acima de $6000 - 35% de imposto


//receber o renda via console
//chamar o método passando a renda como parâmetro
//exibir o valor do imposto referente á renda 

//entrada de dados
// = digitar o salário do usuário

//processamento de dados
//

//saída de dados

using System.Globalization;

static float LeaoFaminto( float a )
{//aqui o parâmetro a sera o nosso salario
    if( a <= 1500 )
    {
        return 0;
    } 
    else if( a >1500 && a <= 3500 )
    {
        return (a / 100) * 20; 
    } 
    else if( a >= 3501 && a <= 6000 ) 
    {
        return (a / 100) * 25;
    } 
    else 
    {
        return (a / 100) * 35;
    }
    
}

Console.WriteLine($"Olá, informe o salário");
float salario = float.Parse(Console.ReadLine() ) ;

float impostoDevido = LeaoFaminto(salario);

Console.WriteLine(@$"
Salário: {Math.Round(salario, 2).ToString("C", new CultureInfo("se-SE"))}
Valor do Imposto: {Math.Round(impostoDevido, 2)}");     