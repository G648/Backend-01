// 1.Crie uma classe abstrata para representar um jogador de futebol, com os atributos 
// nome, data de nascimento, nacionalidade, altura e peso. 
// Crie um método para imprimir todos os dados do jogador. 
// Crie um método para calcular a idade do jogador e outro método para mostrar quanto tempo falta para o jogador se aposentar. 
// Para isso, crie outras 3 subclasses, JOGADORDEFESA, JOGADORATAQUE e JOGADORMEIO-CAMPO 
// considere que os jogadores da posição de defesa se aposentam em média aos 40 anos, os jogadores de meio-campo aos 38 e os atacantes aos 35.

using Projeto_AtividadeExtra;

Jogador j1 = new Jogador();

Console.Clear();

Console.WriteLine($"Olá, seja muito bem vindo ao meu programa!");
Console.WriteLine(@$"Por favor, nos informe alguns dados, tais como:
[1] - cadastrar jogador
[2] - listar jogador
[3] - Sair do programa
");

j1.InserirValorMenu = Console.ReadLine();

switch (j1.InserirValorMenu)
{
    case "1":
        Console.WriteLine(@$"Voce decidiu cadastrar jogador, por gentileza, informe alguns dados:
        [1] - nome
        [2] - data de nascimento
        [3] - nacionalidade
        [4] - altura
        [5] - peso
        ");
        
        j1.Nome = Console.ReadLine();
        j1.DataNascimento = int.Parse(Console.ReadLine());
        j1.Nacionalidade = Console.ReadLine();
        j1.Altura = float.Parse(Console.ReadLine());
        j1.Peso = float.Parse(Console.ReadLine());
        
        break;
    case "2":

        List<Jogador> dadosJogador = new List<Jogador>();

        dadosJogador.Insert (j1.Nome, j1.DataNascimento, j1.Nacionalidade, j1.Altura, j1.Peso);

        foreach (var item in dadosJogador)
        {
            Console.WriteLine(@$"
            nome: {j1.Nome}
            data de nascimento: {j1.DataNascimento}
            ");
            
        }

        Console.WriteLine($"Ok, voce deseja listar os dados do jogador, só um momento...");
        Console.WriteLine($"Seus dados são:");

        break;
    case "3":
        break;
    default:
        break;
}
