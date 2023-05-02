// Faça em sua máquina utilizando os mesmos conceitos dado em aula.

//  Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
//  Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
//  Só será possível executar tais métodos se o celular estiver ligado.
//  Envie o link do repositório como entrega desta atividade.

using Projeto_CriandoSistemaCelular;


Console.Clear();

Celular celular01 = new Celular();

Console.WriteLine($"Olá, seja bem vindo ao meu programa!");
celular01.DetalhesTecnicos();

do
{
startOfLoop:
    Console.WriteLine(@$"Por gentileza, informe o estado do celular:
    [1] - Para celular ligado
    [2] - Para celular desligado
    ");
    ConsoleKeyInfo escolhaEstado = Console.ReadKey(true);

    switch (escolhaEstado.Key)
    {
        case ConsoleKey.D1:
            celular01.LigarCelular();
            celular01.estadoCelular = true;

            do
            {
            celularLigado:
                Console.WriteLine(@$"Por gentileza, informe qual operação voce deseja realizar:
            [1] - Fazer ligação
            [2] - Enviar mensagem 
            [3] - Ver detalhes técnicos do aparelho
            [4] - Desligar o celular
            ");

               ConsoleKeyInfo selecionarOpcao = Console.ReadKey(true);

                switch (selecionarOpcao.Key)
                {
                    case ConsoleKey.D1:

                        Console.WriteLine($"Você decidiu realizar uma ligação...");
                        celular01.FazerLigacao();
                        celular01.Carregamento();
                        celular01.loopBreak = true;

                        break;
                    case ConsoleKey.D2:

                        Console.WriteLine($"Voce decidiu enviar uma mensagem...");
                        celular01.EnviarMensagem();
                        celular01.Carregamento();
                        celular01.loopBreak = true;

                        break;
                    case ConsoleKey.D3:

                        Console.WriteLine($"Você decidiu olhar as especificações técnicas do aparelho... ");

                        celular01.Carregamento();

                        List<Celular> listaDetalhesCelular = new List<Celular>();
                        listaDetalhesCelular.Add(celular01);

                        foreach (var item in listaDetalhesCelular)
                        {

                            Console.WriteLine($"A cor do celular é: {celular01.cor}");
                            Console.WriteLine($"O modelo do celular é: {celular01.modelo}");
                            Console.WriteLine($"O tamanho do celular é: {celular01.tamanho} Polegadas");

                        }
                        celular01.Carregamento();
                        goto celularLigado;
                    case ConsoleKey.D4:

                        Console.WriteLine($"Voce decidiu desligar o celular...");
                        celular01.Carregamento();
                        celular01.DesligarCelular();
                        celular01.loopBreak = false;

                        break;
                    default:

                        Console.WriteLine($"Opção inválida! Informe uma opção declarada no menu");
                        celular01.loopBreak = false;
                        goto celularLigado;

                }
            } while (celular01.loopBreak == true);


            break;
        case ConsoleKey.D2:

            Console.WriteLine($"Foi um prazer te servir! Até mais... ");
            celular01.Carregamento();
            celular01.DesligarCelular();
            celular01.estadoCelular = false;
            break;
        default:

            Console.WriteLine($"Opção inválida, por gentileza, informe a opção correspondente!");
            goto startOfLoop;
           
    }


} while (celular01.estadoCelular == true);



// Console.WriteLine($"Por gentileza, informe [1] para celular ligado e [2] para celular desligado: ");
// celular01.ligado = console.ReadLine();

// escolhaEstadoCelular:
// Console.WriteLine(@$"O celular está ligado ou está desligado? Determine:
// [1] - celular ligado
// [2] - celular desligado
// ");

// celular01.escolhaEstado = Console.ReadLine();

// switch (celular01.escolhaEstado)
// {
//     case "1":
//         celular01.estadoCelular = true;
//         break;
//     case "2":
//         celular01.estadoCelular = false;
//         break;
//     default:
//         Console.WriteLine($"Opção inválida, por gentileza, selecione uma opção válida");
//         goto escolhaEstadoCelular;
// }
// do
// {
//     Console.WriteLine(@$"Qual operação voce deseja realizar ?
//             [1] - Ligar o celular
//             [2] - Desligar o celular
//             [3] - Fazer ligação
//             [4] - Enviar mensagem
//          ");

//     celular01.selecionarOpcao = Console.ReadLine();

//     switch (celular01.selecionarOpcao)
//     {
//         case "1":
//             celular01.LigarCelular();
//             celular01.estadoCelular = true;

//             // if (celular01.estadoCelular = true;)
//             // {

//             // }
//             break;
//         case "2":
//             celular01.DesligarCelular();
//             celular01.estadoCelular = true;
//             break;
//         case "3":
//             celular01.FazerLigacao();
//             break;
//         case "4":
//             celular01.EnviarMensagem();
//             break;
//         default:
//             break;
//     }


// } while (celular01.estadoCelular == true);