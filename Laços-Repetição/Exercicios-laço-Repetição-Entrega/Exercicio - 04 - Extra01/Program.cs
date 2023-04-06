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
// os homens analisados.


Console.Clear();

//variáveis
char sexoUsuario;
int sexoUsuarioM = 0;
int sexoUsuarioF = 0;
string respostaUsuario;
bool respostaSexo = true;

Console.WriteLine($"Seja bem vindo ao meu programa de entrevistas:");


for (var i = 0; i <= 10; i++)
{
    Console.WriteLine($"Informe o seu sexo: M - para masculino e F - para feminino:");
    sexoUsuario = char.Parse(Console.ReadLine().ToUpper());

    switch (sexoUsuario)
    {
        case 'M':
            sexoUsuarioM++;

            Console.WriteLine($"Voce gostou no nosso produto ? Digite sim ou não para avaliar o nosso produto");
            respostaUsuario = Console.ReadLine();
            break;
        case 'F':
            sexoUsuarioF++;

            Console.WriteLine($"Voce gostou no nosso produto ? Digite sim ou não para avaliar o nosso produto");
            respostaUsuario = Console.ReadLine();
            break;
        default:
            Console.WriteLine($"digite um valor válido: M ou F");
            break;
    }

}

