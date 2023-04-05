Console.WriteLine($"digite seu nome: ");
string nome = Console.ReadLine();


Console.WriteLine($"digite sua senha: ");
string senha = Console.ReadLine();

while (senha.Length != 6)
{
    Console.WriteLine($"Senha digitada não atende aos requisitos! Digite novamente!");
    senha = Console.ReadLine();
}

Console.WriteLine($"Senha recebida com sucesso!");

