// fazer um programa em c# que receba 5 números inteiros e ao final
// exiba o seu dobro (*2)

// voce deve utilizar a estrutura array com tamanho 5 para o armazenamento dos números
// utilizar a estrutura for para a leitura dos números e a estrutura foreach para exibi-los


//entrada de dados
// = criar o array com o tamanho 5

//processamento de dados
// = receber os números 

//saida de dados 
// = mostrar os valores dos números multiplicados 


int[] num = new int [5];

for (var i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite 5 números para fazermos o calculo dos mesmos:");
    num[i] = int.Parse(Console.ReadLine());
}

foreach (var item in num)
{
    Console.WriteLine($"O dobro do valor do numero {item} é de: {item *2}");
    
}