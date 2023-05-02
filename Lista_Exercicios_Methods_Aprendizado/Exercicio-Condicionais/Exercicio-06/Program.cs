// 6 - Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
// lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
// pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
// entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.

string[] nomes = new string[3];

bool encontrado = false;

for (var i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Informe o {i + 1}º nome: ");
    nomes[i] = Console.ReadLine();    
}

Console.WriteLine($"Informe um nome a ser buscado: ");
string nomeBuscado = Console.ReadLine();

//processamento
foreach (string nome in nomes)
{
   if (nome == nomeBuscado)
   {
        encontrado = true;
        break;
   } 
}

//saída
if (encontrado == true)
{
    Console.WriteLine($"ACHEIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII!!!!!!!!!!!!!");    
}
else
{
    Console.WriteLine($"NÃO  ACHEIIIIIIIIIIIIIIIIIIIIIIIII!");    
}

string resultadoPesquisa = encontrado == true ? "ACHEI" : "NÃO ACHEI";
Console.WriteLine(resultadoPesquisa);

Console.WriteLine(encontrado == true ? "ACHEI" : "NÃO ACHEI");