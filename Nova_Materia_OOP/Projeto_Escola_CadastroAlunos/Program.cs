// Nesta aula vamos fazer um pequeno sistema de cadastro de alunos, em um projeto de console no VsCode.

// Vamos desenvolver um programa que cadastre e mostre os dados de um aluno.

// Crie uma classe Aluno com as seguintes propriedades:

// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
// Também teremos os métodos: 

// VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.

// obs:
// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral
// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.

// Acrescente o que achar necessário.

using System.Text.RegularExpressions;
using Projeto_Escola_CadastroAlunos;

Aluno CadastroAluno = new Aluno();

Console.Clear();


Console.WriteLine(@$"Seja bem vindo ao programa de cadastro de aluno. Por gentileza, digite as seguintes informações:");

// Console.WriteLine($"[1] Digite o nome do aluno: ");
// CadastroAluno.nome = Console.ReadLine();

// Console.WriteLine($"[2] Digite o curso do aluno: ");
// CadastroAluno.nome = Console.ReadLine();

// Console.WriteLine($"[3] Digite a idade do aluno: ");
// CadastroAluno.nome = Console.ReadLine();

Console.WriteLine($"[4] Digite o RG do aluno: ");
var rg  = Console.ReadLine();

Regex regex = new Regex(@"([0-9]{2}.?[0-9]{3}.?[0-9]{3}-?[0-9]{1})", RegexOptions.IgnoreCase);
var combinou = regex.Match(rg);

if (combinou.Success)
{
    Console.WriteLine("RG no formato válido.");
    Console.WriteLine($"O RG do aluno é: {CadastroAluno.teste(rg)}");
}
else
{
    Console.WriteLine("RG inválido.");
}

Console.WriteLine($"[5] Digite o quinto valor: ");
CadastroAluno.nome = Console.ReadLine();

Console.WriteLine($"[6] Digite o sexto valor: ");
CadastroAluno.nome = Console.ReadLine();

Console.WriteLine($"[7] Digite o sétimo valor: ");
CadastroAluno.nome = Console.ReadLine();





