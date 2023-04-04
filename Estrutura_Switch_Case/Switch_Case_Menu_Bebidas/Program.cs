// Crie um menu de opções de bebidas e peça para o usuário escolher uma das opções.
// A depender da opção, exiba uma mensagem se gostaria de acrescentar gelo.
// Se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo, caso contrário, a bebida é sem gelo adicional.


//entrada de dados
// = escolher as bebidas (opções de bebidas)
// = perguntar se ele gostaria de adicionar gelo

//processamento de dados
// = usar a estrutura condicional switch case para determinar a escolha da bebida do usuário
// = quando ele escolher uma determinada bebida, irá perguntar se ele deseja acrescentar gele 

//saída de dados
// = exibir o a bebida que o usuário escolheu e se ele decidiu acrescentar gelo ou não 


Console.Clear();




Console.WriteLine(@$"
----------------------------------------------------
|Bem vindo ao programa escolha de bebidas com gelo |
|Por gentileza, escolha uma opção de bebida:       |
|1- Fanta-uva                                      |
|2- Fanta-guaraná                                  |
|3- Sprite                                         |
|4- Coca-cola                                      |
|5- Água                                           |
----------------------------------------------------
");

int escolhaBebida;
string escolhaGelo;
string bebida;

escolhaBebida = int.Parse(Console.ReadLine());

{
switch (escolhaBebida)
{
    case 1:
        bebida = "fanta-uva";
        Console.WriteLine($"Ok, sua escolha de bebida é {bebida}. Voce deseja acrescentar gelo ou não ? Digite sim ou não");
        escolhaGelo = Console.ReadLine().ToLower();

        if (escolhaGelo == "sim")
        {
            Console.WriteLine($"ok, sua {bebida} terá gelo");
        }
        else
        {
            Console.WriteLine($"sua {bebida} é natural");
        }
        break;
    case 2:
    bebida = "Fanta-guraná";
        Console.WriteLine($"Ok, sua escolha de bebida é {bebida}. Voce deseja acrescentar gelo ou não ? Digite sim ou não");
        escolhaGelo = Console.ReadLine().ToLower();

        if (escolhaGelo == "sim")
        {
            Console.WriteLine($"ok, sua {bebida} terá gelo");
        }
        else
        {
            Console.WriteLine($"sua {bebida}é natural");
        }
        break;
    case 3:
    bebida = "Sprite";
        Console.WriteLine($"Ok, sua escolha de bebida é {bebida}. Voce deseja acrescentar gelo ou não ? Digite sim ou não");
        escolhaGelo = Console.ReadLine().ToLower();

        if (escolhaGelo == "sim")
        {
            Console.WriteLine($"ok, sua {bebida} terá gelo");
        }
        else
        {
            Console.WriteLine($"sua {bebida} é natural");
        }
        break;
    case 4:
        Console.WriteLine($"Ok, sua escolha de bebida é Coca-cola. Voce deseja acrescentar gelo ou não ? Digite sim ou não");
        escolhaGelo = Console.ReadLine().ToLower();

        if (escolhaGelo == "sim")
        {
            Console.WriteLine($"ok, sua Coca-cola terá gelo");
        }
        else
        {
            Console.WriteLine($"sua Coca-cola é natural");
        }
        break;
    case 5:
        Console.WriteLine($"Ok, sua escolha de bebida é Água. Voce deseja acrescentar gelo ou não ? Digite sim ou não");
        escolhaGelo = Console.ReadLine().ToLower();

        if (escolhaGelo == "sim")
        {
            Console.WriteLine($"ok, sua Água terá gelo");
        }
        else
        {
            Console.WriteLine($"sua Água é natural");
        }
        break;
    default:
        Console.WriteLine($"Nenhuma opção válida, por gentileza, digite os números corretos referentes às bebidas!");
        break;

}

Console.Clear();
    
}

// ------------------- Segunda maneira pra criar o prograrama ----------------------


//  Console.WriteLine($"voce quer gelo ?");
 
// escolhaGelo = Console.ReadLine();

// if (escolhaBebida == 1 && escolhaGelo == "sim")
// {
//    bebida = "Fanta-uva";  
//    Console.WriteLine($"ok, sua {bebida} terá gelo"); 
// }

// if (escolhaBebida == 2 && escolhaGelo == "sim")
// {
//    bebida = "Fanta-guraná";  
//    Console.WriteLine($"ok, sua {bebida} terá gelo"); 
// }

// if (escolhaBebida == 3 && escolhaGelo == "sim")
// {
//    bebida = "Sprite";  
//    Console.WriteLine($"ok, sua {bebida} terá gelo"); 
// }

// if (escolhaBebida == 4 && escolhaGelo == "sim")
// {
//    bebida = "Coca-cola";  
//    Console.WriteLine($"ok, sua {bebida} terá gelo"); 
// }

// if (escolhaBebida == 5 && escolhaGelo == "sim")
// {
//    bebida = "Água";  
//    Console.WriteLine($"ok, sua {bebida} terá gelo"); 
// }

// else{
//     Console.WriteLine($"OK, sua bebida não terá gelo!");
// }