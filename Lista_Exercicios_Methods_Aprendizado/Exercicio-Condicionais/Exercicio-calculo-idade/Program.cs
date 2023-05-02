// Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
// ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).


//entrada de dados
// = pedir para a pessoa digitar o ano de nascimento

//processamento de dados
// = verificar se a pessoa é maior de idade
// = se sim ela poderá votar, se não, ela não poderá votar

//saida de dados
// = exibir se ela poderá ou não votar

using System.Globalization;

int anoNascimento;
int anoAtual = DateTime.Now.Year;
int calculoIdade;

Console.WriteLine($"Por gentileza, digite aqui seu ano de nascimento:");
anoNascimento = int.Parse(Console.ReadLine());

calculoIdade = anoAtual - anoNascimento;

if (calculoIdade < 18)
{
    Console.WriteLine($"o usuário tem {calculoIdade} anos");
    Console.WriteLine($"o usuário não tem idade suficiente para votar!");

}
else
{
    Console.WriteLine($"o usuário tem {calculoIdade} anos");
    Console.WriteLine($"o usuário tem idade suficiente para votar!");
    
}

