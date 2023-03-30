
//crie um programa que receba o ano do nascimento de uma 
//pessoa e calcule a idade dessa pessoa em anos

//obs: obter a data atual do sistema

int anoNascimento;
int idade;
int idadeEmSemanas;
int anoAtual = DateTime.Now.Year; //obtendo a data atual do sistema

Console.WriteLine($"Digite o ano do seu nascimento: ");
anoNascimento = int.Parse(Console.ReadLine());

idade = (anoAtual - anoNascimento);
idadeEmSemanas = (idade * 52);

Console.WriteLine($"A idade é de {idade} anos e a idade em semanas é de {idadeEmSemanas} semanas");
