// faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações;


//entrada de dados
// = pedir o número de usuário 
// = pedir a senha do usuário

//processamento de dados
// = a senha deve ser diferente do nome do usuário
// = se for igual a senha deve mostrar um erro e pedir a senha novamente
// = 

//saída de dados
// = mostrar o usuário e a senha que o usuário digitou

string nome;
string senha;

Console.WriteLine($"Por gentileza, digite seu nome de usuário:");
nome = Console.ReadLine();

Console.WriteLine($"Por gentileza, digite sua senha do usuário:");
senha = Console.ReadLine();
 
while (senha == nome){

    Console.WriteLine($"a senha está incorreta e não deve ser igual ao nome de usuário, por favor, digite novamente: ");

    senha = Console.ReadLine();
    
}




