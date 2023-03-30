// Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo     e    escreva    se    ele    é    Equilátero,    Isósceles    ou  Escaleno. 
// Sendo    que:    
// − Triângulo    Equilátero:    possui    os    3    lados    iguais.
// − Triângulo    Isóscele:    possui    2    lados    iguais.
// − Triângulo    Escaleno:    possui    3    lados    diferentes.


//entrada de dados
// = informar as 3 medidas de um triangulo

//processamento
// = verificar se o triangulo tem os 3 lados igual ou 2 lados iguais ou os 3 lados diferentes
// = para isso temos que utilizar os operadores lógicos && || ! 

//saida de dados
// = informar se o triangulo é equilátero, escaleno ou isócele
// = motrar a saída do programa na console

int lado1;
int lado2;
int lado3;


Console.WriteLine($"Bem vindo ao programa de verificação de trinângulos");

Console.WriteLine($"Por gentileza, informe a medida do primeiro lado do triangulo: ");
lado1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Por gentileza, informe a medida do segundo lado do triangulo: ");
lado2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Por gentileza, informe a medida do terceiro lado do triangulo: ");
lado3 = int.Parse(Console.ReadLine());

if (lado1 == lado2 && lado1 == lado3 && lado2 == lado3)
{
    Console.WriteLine($"Segundo as informações digitadas, o triangulo respectivo é o Equilátero");

}
else if(lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
{
    Console.WriteLine($"Segundo as informações digitadas, o triangulo respectivo é o Isóceles");
    
}
else
{
    Console.WriteLine($"Segundo as informações digitadas, o triangulo respectivo é o Escaleno");
    
}