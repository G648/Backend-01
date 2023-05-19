using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_CadastroProdutos_16_05
{
    public class Utils
    {
        public void Carregamento(int tempo, int pontos, string texto)
        {
            Console.Write(texto);

            for (var i = 0; i < pontos; i++)
            {
                Console.Write($".");
                Thread.Sleep(tempo);
            }
            Console.Clear();
        }
    }
}