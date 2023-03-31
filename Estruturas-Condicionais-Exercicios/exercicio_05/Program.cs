// As    maçãs custam R$ 0,30 cada se forem compradas    menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor    total    da compra.

//entrada
// = determinar a quantidade de maçãs que um usuário vai comprar
// = cada maçã é r$0,30 cents se for comprar menos de uma dúzia 
// = cada maçã é R$0,25 cents

//processamento
// = se o usuário comprar maças por menos de uma dúzia então ele pagará 0,30 em cada
// = se o usuário comprar 12 maçãs então ele pagará por 0,25 em cada
// = realizar a multiplicação do valor das maçãs por 0,30 se o valor for menos de 12 maçãs
// = realizar a multiplicação do valor das maçãs por 0,25 se o valor for mais de 12 maçãs


//saida
// = mostrar a quantidade total do pagamento se for de 12 maçãs ou se for de menos


float cadaMaca = 0.30f;
float duziaMaca = 0.25f;
float quantidadeMaca;

Console.WriteLine($"Por favor, informe a quantidade de maçãs que voce deseja comprar: ");
quantidadeMaca = float.Parse(Console.ReadLine());

if (quantidadeMaca < 12 )
{
    float calculoCadaMaca = quantidadeMaca * cadaMaca;
    Console.WriteLine($"O total do pagamento para cada maça que voce desejou comprar foi de: {Math.Round(calculoCadaMaca,2)} Reais");
}
else if (quantidadeMaca >= 12)
{
    float calculoCadaMaca = quantidadeMaca * duziaMaca;
    Console.WriteLine($"O total do pagamento para a duzia da maça que voce desejou comprar foi de: {Math.Round(calculoCadaMaca, 2)} Reais");
}
