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

char sexoUser;
string respostaPesquisa;
int contadorM = 0;
int contadorSM = 0;
int contadorNM = 0;
int contadorF = 0;
int contadorSF = 0;
int contadorNF = 0;
bool loopBreak = true;

for (int i = 0; i < 2; i++)
{
    do
    {

        Console.WriteLine($"Por gentileza, digite aqui o seu sexo: F para feminino e M para masculino;");
        sexoUser = char.Parse(Console.ReadLine().ToUpper());

        switch (sexoUser)
        {
            case 'F':
                contadorF++;
                // loopBreak = false;
                do
                {
                    Console.WriteLine($"Voce gostou do produto perguntado na pesquisa? digite S para sim e N para não!");
                    respostaPesquisa = Console.ReadLine().ToUpper();

                    switch (respostaPesquisa)
                    {
                        case "S":
                            contadorSF++;
                            
                            break;
                        case "N":
                            contadorNF++;
                            
                            break;
                        default:
                            Console.WriteLine($"digite um valor válido de S para sim e N para não");
                        
                            break;
                    }


                } while (loopBreak);

                break;

            case 'M':
                contadorM++;
                // loopBreak = false;
                if (sexoUser == 'M')
                {
                    do
                    {
                        Console.WriteLine($"Voce gostou do produto perguntado na pesquisa? digite S para sim e N para não!");
                        respostaPesquisa = (Console.ReadLine().ToUpper());

                        switch (respostaPesquisa)
                        {
                            case "S":
                                contadorSM++;
                                loopBreak = false;
                                break;
                            case "N":
                                contadorNM++;
                                loopBreak = false;
                                break;
                            default:
                                Console.WriteLine($"digite um valor válido de S para sim e N para não");
                                loopBreak = true;
                                break;
                        }


                    } while (loopBreak);
                }
                break;

            default:
                Console.WriteLine($"Letra invalida, digite apenas F para feminino e M para masculino;");
                break;
        }

    } while (loopBreak);


}

