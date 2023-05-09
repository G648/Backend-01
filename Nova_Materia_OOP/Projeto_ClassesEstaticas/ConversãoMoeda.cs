using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_ClassesEstaticas
{
    public static class ConversãoMoeda
    {
        
        public static float dolar{ get; set; } = 5.00f;

        public static float real {get; set; } = 5.00f;

        

        public static float DolarParaReal ()
        {

            Console.WriteLine($"Digite um valor em dólar para ser convertido em Real:");
            float valorDolar = float.Parse(Console.ReadLine()!); 
            
            float Conversão = valorDolar * real;

            return Conversão;
             
        }

        public static float RealParaDolar ()
        {
            Console.WriteLine($"Digite um valor em Real para converter para dolar:");
            float valorReal = float.Parse(Console.ReadLine()!);

            float conversão = valorReal / real;

            return conversão;
            
        }
    }
   
}