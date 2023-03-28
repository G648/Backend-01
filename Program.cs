//string nome = "Guilherme Amorim";
//Console.WriteLine(nome);

//int idade = 20;
//Console.WriteLine("a idade do " + nome + " é de " +  idade + " anos de idade");

//atribuição "="
int x = 15;

//operadores aritméticos
//soma

Console.WriteLine(5+5);
Console.WriteLine(5 + x);

//subtração
Console.WriteLine(15 - 5);

//multiplicação
Console.WriteLine(5*5);

//divisão
Console.WriteLine(5/5);


//operadores de comparação

//igual a 
Console.WriteLine(5 == 5);

//maior ou igual a 
Console.WriteLine(5 >= 4);

//menor ou igual a 
Console.WriteLine(5 <= 4);

//maior que
Console.WriteLine(5>4);

//menor que 
Console.WriteLine(5<4);

//diferente de
Console.WriteLine(5 != 6);


//operadores lógicos

//  && = e
// || = ou
// ! = não

//crie  um progrma para calcular o IMC de uma pessoa
//entrada: nome, idade, peso, altura
//processamento: peso dividido pela altura ao quadrado

//entrada
string nome = "Guilherme";
int idade = 20;
float peso = 74;
float altura = 1.85f;

//processamento

float imc = peso / (altura*altura);
Console.WriteLine("o imc do usuário "+nome +" é de: " + Math.Round(imc, 2)); //método usado para mostrar apenas algumas casas decimais após a virgula;
