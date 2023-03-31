// Escreva     um     programa     que     verifique     a     validade     de     uma     senha     fornecida pelo     usuário. 
// A     senha     válida     é     o     número     1234. 
// Devem     ser    impressas     as    seguintes     mensagens:
// ACESSO    PERMITIDO    caso    a    senha    seja    válida.
// ACESSO    NEGADO    caso    a    senha    seja    inválida.


//entrada de dados
// = receber a entrada de dados do usuário

//processamento de dados
// = realizar a verificaçao da senha que o usuário digitou
// = a senha tem que ser igual a 1234

//saída de dados
// se o usuário digitou a senha correta, ele terá o acesso permitido
// se não, ele terá o acesso negado

int senha = 1234;
int senhaDigitada;

Console.WriteLine($"Digite aqui a senha para acesso à console de gerenciamento da AWS: ");
senhaDigitada = int.Parse(Console.ReadLine());

string validacao = (senhaDigitada == 1234) ? "Acesso permitido" : "Acesso negado";
Console.WriteLine(validacao);