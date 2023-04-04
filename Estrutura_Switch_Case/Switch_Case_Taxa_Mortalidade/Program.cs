// A taxa de natalidade e a taxa de mortalidade são indicadores estatísticos de fundamental importância por ajudar a compreender aquilo que os especialistas chamam de dinâmica populacional e a entender sua relação com variáveis que influenciam o desenvolvimento, como qualidade de vida, migrações, , fatores socioeconômicos e localização. Sabendo disso, crie um programa que calcule os dois indicadores utilizando o comando switch.

// Observação : A taxa de natalidade é calculada pela seguinte fórmula: taxa de natalidade = (número de crianças nascidas x 1000) / número de habitantes;
// Enquanto que, a taxa de mortalidade = (números de óbitos x 1000) /número de habitantes.



//entrada de dados
// verificar o que o usuario vai querer calcular (natalidade ou mortalidade)
// determinar o número de crianças nascidas e o número de habitantes para natalidade
// determinar o número de óbitos e o número de habitantes para mortalidade

//processamento de dados
// realizar o calculo de natalidade e mortalidade 
// determinar com switch case se o usuario vai querer calcular natalidade ou mortalidade

//saída de dados
// imprimir na tela a taxa de mortalidade ou natalidade

Console.Clear();
Console.WriteLine($"Seja bem vindo ao programa para calcular a natalidade e a mortalidade!!");

string resposta;
string cidade;
int numHabitantes;
int numCriancasNascidas;
int numObitos;

Console.WriteLine($"Por favor, informa o que voce deseja calcular, a taxa de mortalidade ou a taxa de natalidade ?");
resposta = Console.ReadLine();

switch (resposta)
{
    case "mortalidade":
        Console.WriteLine($"Digite a cidade na qual voce quer descobrir a taxa de mortalidade");
        cidade = Console.ReadLine();

        Console.WriteLine($"Digite a quantidade de habitantes:");
        numHabitantes = int.Parse(Console.ReadLine());

        Console.WriteLine($"Digite a quantidade de óbitos:");
        numObitos = int.Parse(Console.ReadLine());

        Console.WriteLine($"A cidade de {cidade} tem uma taxa de mortalidade de { (numObitos * 1000) / numHabitantes}");
        break;
    case "natalidade":
        Console.WriteLine($"Digite a cidade na qual voce quer descobrir a taxa de natalidade");
        cidade = Console.ReadLine();
        

        Console.WriteLine($"Digite a quantidade de habitantes:");
        numHabitantes = int.Parse(Console.ReadLine());

        Console.WriteLine($"Digite a quantidade de crianças nascidas:");
        numCriancasNascidas = int.Parse(Console.ReadLine());

        Console.WriteLine($"A cidade de {cidade} tem uma taxa de natalidade de { (numCriancasNascidas * 1000) / numHabitantes}");
        break;
    default:
        Console.WriteLine($"A resposta tem de ser natalidade ou mortalidade, o programa não aceitará outra além dessas!");
        break;
}

// Console.WriteLine($"Por favor, informe qual cidade voce pretende descobrir a taxa de mortalidade ou natalidade:");
// cidade = Console.ReadLine();



