//Faça um programa que leia e valide as seguintes informações:

// 1. Nome: diferente de vazio;

// 2. Idade: entre 0 e 100 anos;

// 3. Salário: maior que zero;

// 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a));

//entrada de dados
// = nome
// = idade 
// = salário 
// = estado civil 

//processamento de dados
// nome != de 0
// idade > 0 && idade < 100
// salário > 0 
// estado civil == s (solteiro), c (casado), v (viuvo), d (divorciado)

//saída de dados
//mostrar as saídas de dados validadas;


string nome;
int idade;
float salario;
char estadoCivil;
bool loopBreak = true;

Console.Clear();

Console.WriteLine($"Informe seu nome: ");
nome = Console.ReadLine();

while (nome == "")
{
    Console.WriteLine($"Por gentileza, informe um nome válido!!");
    nome = Console.ReadLine();
}

Console.WriteLine($"Informe sua idade: ");
idade = int.Parse(Console.ReadLine());

while (idade < 0 || idade > 100)
{
    Console.WriteLine($"Informe uma idade entre 0 e 100");
    idade = int.Parse(Console.ReadLine());

}

Console.WriteLine($"Informe seu salário:");
salario = float.Parse(Console.ReadLine());

while (salario < 0)
{
    Console.WriteLine($"Informe um salário maior do que 0");
    salario = float.Parse(Console.ReadLine());

}

do
{
    Console.WriteLine(@$"
Informe seu estado civil:
's' -> solteiro
'c' -> casado
'd' -> divorciado
'v' -> viuvo
 ");

    estadoCivil = char.Parse(Console.ReadLine());


    switch (estadoCivil)
    {
        case 's':
            Console.Clear();

            Console.WriteLine($"CARREGANDO...");

            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine($"O usuário {nome}, com {idade} anos, com a faixa salarial de: {salario} reais, está solteiro");
            loopBreak = false;
            break;
        case 'c':
            Console.Clear();

            Console.WriteLine($"CARREGANDO...");

            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine($"O usuário {nome}, com {idade} anos, com a faixa salarial de: {salario} reais, está casado");
            loopBreak = false;
            break;
        case 'd':
            Console.Clear();

            Console.WriteLine($"CARREGANDO...");

            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine($"O usuário {nome}, com {idade} anos, com a faixa salarial de: {salario} reais, está divorciado");
            loopBreak = false;
            break;
        case 'v':
            Console.Clear();

            Console.WriteLine($"CARREGANDO...");

            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine($"O usuário {nome}, com {idade} anos, com a faixa salarial de: {salario} reais, está viúvo");
            loopBreak = false;
            break;
        default:
            Console.Clear();
            Console.WriteLine($"Resposta inválida");
            loopBreak = true;
            break;
    }

}
while (loopBreak);



