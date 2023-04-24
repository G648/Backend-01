using Projeto_Calculadora;

Calculadora Calc = new Calculadora();

Console.Clear();


Console.WriteLine($"Olá, seja bem vindo ao meu programa!");

Console.WriteLine($"por gentileza, digite dois numeros para realizarmos o calculo dos mesmos:");

Calc.n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"ok, agora digite o segundo número:");

Calc.n2 = float.Parse(Console.ReadLine());

Console.Clear();

do
{
    startOfLoop:
    Console.WriteLine(@$"Informe qual operação matemática voce deseja fazer:
[1] - Multiplicação
[2] - Divisão
[3] - Soma
[4] - Subtração
[0] - sair do programa
");

    Calc.escolhaOperacaoMatematica = Console.ReadLine();


    switch (Calc.escolhaOperacaoMatematica)
    {
        case "1":

            Calc.resultado = Calc.Multiplicação(Calc.n1, Calc.n2);
            Console.WriteLine($"voce decidiu realizar a operação multiplicação:");
            Console.Clear();
            Calc.Carregamento();
            Console.WriteLine($"O resultado da multiplicação é: {Calc.resultado}");

            Console.WriteLine(@$"Voce deseja realizar outra operação?
            [1] - SIM
            [2] - NÃO
            ");
            Calc.respostaOperação = int.Parse(Console.ReadLine());
            

            if (Calc.respostaOperação == 1)
            {
                Calc.Carregamento();
                goto startOfLoop;
            }
            else
            {
                Console.WriteLine($"Obrigado por utilizar o programa! Volte sempre!");
                Calc.loopBreak = false;
            }

            break;
        case "2":

            Calc.resultado = Calc.Divisão(Calc.n1, Calc.n2);
            Console.WriteLine($"Voce decidiu realizar a operação de divisão");
            Console.Clear();
            Calc.Carregamento();
            Console.WriteLine($"O resultado da divisão é: {Calc.resultado}");

            Console.WriteLine(@$"Voce deseja realizar outra operação?
            [1] - SIM
            [2] - NÃO
            ");
            Calc.respostaOperação = int.Parse(Console.ReadLine());
            

            if (Calc.respostaOperação == 1)
            {
                Calc.Carregamento();
                goto startOfLoop;
            }
            else
            {
                Console.WriteLine($"Obrigado por utilizar o programa! Volte sempre!");
                Calc.loopBreak = false;
            }

            break;
        case "3":

            Calc.resultado = Calc.Soma(Calc.n1, Calc.n2);
            Console.WriteLine($"Voce decidiu realizar a operação de divisão");
            Console.Clear();
            Calc.Carregamento();
            Console.WriteLine($"O resultado da divisão é: {Calc.resultado}");
            
            Console.WriteLine(@$"Voce deseja realizar outra operação?
            [1] - SIM
            [2] - NÃO
            ");
            Calc.respostaOperação = int.Parse(Console.ReadLine());
            

            if (Calc.respostaOperação == 1)
            {
                Calc.Carregamento();
                goto startOfLoop;
            }
            else
            {
                Console.WriteLine($"Obrigado por utilizar o programa! Volte sempre!");
                Calc.loopBreak = false;
            }

            break;
        case "4":

            Calc.resultado = Calc.Subtração(Calc.n1, Calc.n2);
            Console.WriteLine($"Voce decidiu realizar a operação de divisão");
            Console.Clear();
            Calc.Carregamento();
            Console.WriteLine($"O resultado da divisão é: {Calc.resultado}");

            Console.WriteLine(@$"Voce deseja realizar outra operação?
            [1] - SIM
            [2] - NÃO
            ");
            Calc.respostaOperação = int.Parse(Console.ReadLine());
            

            if (Calc.respostaOperação == 1)
            {
                Calc.Carregamento();
                goto startOfLoop;
            }
            else
            {
                Console.WriteLine($"Obrigado por utilizar o programa! Volte sempre!");
                Calc.loopBreak = false;
            }

            break;
        case "0":
            Console.WriteLine($"Obrigado por utilizar o programa! Volte sempre!");

            break;
        default:
            Console.WriteLine($"Opção inválida!");
            break;
    }
} while (Calc.loopBreak);




// using teste2;

// Calculadora operacao = new Calculadora();

// bool loopBreak = true;
// float n1;
// float n2;
// float resultado;
// string escolhaMenu;

// do
// {
//     startOfLoop:
//     Console.WriteLine(@$"

//     BEM VINDO A CALCULADORA v1.0

// Escolha uma operação que deseja realizar

//             1 - Adição
//             2 - Subtração
//             3 - Multiplicação
//             4 - Divisão

//             0 - Encerrar Programa

// ");

// escolhaMenu = Console.ReadLine();


// switch (escolhaMenu)
// {
//     case "1":
//     Console.WriteLine($"Digite o primeiro número da operação: ");
// n1 = float.Parse(Console.ReadLine());

// Console.WriteLine($"Digite o segundo número da operação: ");
// n2 = float.Parse(Console.ReadLine());

//     resultado = operacao.adicao(n1, n2);
//     Console.Clear();
//     Console.WriteLine($"O resultado da adição entre {n1} e {n2} é de {resultado}");
//     Console.WriteLine($"");
//     Console.WriteLine(@$"
//     Deseja fazer outra operação?

//         1 - SIM
//         2 - NÃO
//     ");
//     escolhaMenuAdicao:
// escolhaMenu = Console.ReadLine();

//     switch (escolhaMenu)
//     {
//         case "1":
//         Console.Clear();
//             goto startOfLoop;

//         case "2":
//         Console.Clear();
//         Console.WriteLine($"Encerrando Programa...");
//         Thread.Sleep(5000);
//         loopBreak = false;
//         break;

//         default:
//         Console.WriteLine($"Digite um número válido.");
//         goto escolhaMenuAdicao;

//     }
//         break;

//     case "2":
// Console.WriteLine($"Digite o primeiro número da operação: ");
// n1 = float.Parse(Console.ReadLine());

// Console.WriteLine($"Digite o segundo número da operação: ");
// n2 = float.Parse(Console.ReadLine());

//     resultado = operacao.subtracao(n1, n2);
//     Console.Clear();
//     Console.WriteLine($"O resultado da subtração entre {n1} e {n2} é de {resultado}");
//     Console.WriteLine($"");
//     Console.WriteLine(@$"
//     Deseja fazer outra operação?

//         1 - SIM
//         2 - NÃO
//     ");
//     escolhaMenuSubtracao:
// escolhaMenu = Console.ReadLine();

//     switch (escolhaMenu)
//     {
//         case "1":
//         Console.Clear();
//             goto startOfLoop;

//         case "2":
//         Console.Clear();
//         Console.WriteLine($"Encerrando Programa...");
//         Thread.Sleep(5000);
//         loopBreak = false;
//         break;

//         default:
//         Console.WriteLine($"Digite um número válido.");
//         goto escolhaMenuSubtracao;      
//     }
//         break;

//     case "3":
//     Console.WriteLine($"Digite o primeiro número da operação: ");
// n1 = float.Parse(Console.ReadLine());

// Console.WriteLine($"Digite o segundo número da operação: ");
// n2 = float.Parse(Console.ReadLine());

//     resultado = operacao.multiplicacao(n1, n2);
//     Console.Clear();
//     Console.WriteLine($"O resultado da multiplicação entre {n1} e {n2} é de {resultado}");
//     Console.WriteLine($"");
//     Console.WriteLine(@$"
//     Deseja fazer outra operação?

//         1 - SIM
//         2 - NÃO
//     ");
//     escolhaMenuMultiplicacao:
// escolhaMenu = Console.ReadLine();

//     switch (escolhaMenu)
//     {
//         case "1":
//         Console.Clear();
//             goto startOfLoop;

//         case "2":
//         Console.Clear();
//         Console.WriteLine($"Encerrando Programa...");
//         Thread.Sleep(5000);
//         loopBreak = false;
//         break;

//         default:
//         Console.WriteLine($"Digite um número válido.");
//         goto escolhaMenuMultiplicacao;      
//     }
//         break;

//     case "4":
//     escolhaDivisao:
//     Console.WriteLine($"Digite o primeiro número da operação: ");
// n1 = float.Parse(Console.ReadLine());

// Console.WriteLine($"Digite o segundo número da operação: ");
// n2 = float.Parse(Console.ReadLine());

//     if (n1 == 0 || n2 == 0)
//             {
//                 Console.WriteLine($"Não é possivel dividir por zero, por favor, escolha outro número.");
//                 goto escolhaDivisao;
//             }

//     resultado = operacao.divisao(n1, n2);
//     Console.Clear();
//     Console.WriteLine($"O resultado da divisão entre {n1} e {n2} é de {resultado}");
//     Console.WriteLine($"");
//     Console.WriteLine(@$"
//     Deseja fazer outra operação?

//         1 - SIM
//         2 - NÃO
//     ");
//     escolhaMenuDivisao:
// escolhaMenu = Console.ReadLine();

//     switch (escolhaMenu)
//     {
//         case "1":
//         Console.Clear();
//             goto startOfLoop;

//         case "2":
//         Console.Clear();
//         Console.WriteLine($"Encerrando Programa...");
//         Thread.Sleep(5000);
//         loopBreak = false;
//         break;

//         default:
//         Console.WriteLine($"Digite um número válido.");
//         goto escolhaMenuDivisao;      
//     }
//         break;

//     default:
//         Console.WriteLine($"Digite um número válido.");

//         goto startOfLoop;
// }

// } while (loopBreak);