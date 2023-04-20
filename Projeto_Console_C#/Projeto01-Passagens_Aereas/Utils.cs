using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Projeto01_Passagens_Aereas
{
    public class Utils
    {
        public static void Carregamento()
        {
            Console.Write($"Carregando");

            for (var i = 0; i < 5; i++)
            {
                Console.Write($".");
                Thread.Sleep(800);
            }

            Console.Clear();
        }

    int escolhaUsuario;

       public static void CadastroPassagens(){
         Console.WriteLine($"Voce decidiu realizar o cadastro de passagens. Por favor, informe as seguintes informações:");
    
            Console.WriteLine($"[1] - Origem da viagem");
            string escolhaOrigem = (Console.ReadLine());

            Console.WriteLine($"[2] - Destino da viagem");
            string escolhaDestino = (Console.ReadLine());

            Console.WriteLine($"[3] - Companhia Aerea");
            string escolhaCompanhia = (Console.ReadLine());

            Console.WriteLine($"[4] - Classe de voo (Economica ou Primeira classe)");
            string escolhaClasseVoo = (Console.ReadLine());   
        
       }
    }
}