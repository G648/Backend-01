using Criando_Classes_OOP;

Personagens personagem01 = new Personagens();

Console.WriteLine($"Digite o nome do seu usuário:");
personagem01.nome = Console.ReadLine();

Console.WriteLine($"Digite a idade do seu personagem:");
personagem01.idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite a armadura do seu objeto:");
personagem01.armadura = Console.ReadLine();

Console.WriteLine($"Digite a IA:");
personagem01.IA = Console.ReadLine();

// Console.WriteLine($"o nome do usuário é: {personagem01.nome}, a idade é de: {personagem01.idade}, a armadura é: {personagem01.armadura} e sua IA é: {personagem01.IA}");

List <Personagens> listaPersona = new List<Personagens>();
listaPersona.Add(personagem01);

foreach (var item in listaPersona)
{
Console.WriteLine(@$"
{item.nome} 
{item.idade }
{item.armadura }
{item.IA}");
}



// personagem01.Atacar();

// personagem01.Defender();

// personagem01.RestaurarArmadura();