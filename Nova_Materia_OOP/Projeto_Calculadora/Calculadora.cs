using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Calculadora
{
    public class Calculadora
    {

        //Propriedades

        public void Carregamento()
        {
            Console.Write($"Carregando");

            for (var i = 0; i < 5; i++)
            {
                Console.Write($".");
                Thread.Sleep(800);
            }

            Console.Clear();
        }

        public float n1;
        public float n2;
        public float resultado;
        public bool loopBreak;
        public int respostaOperação;
        public string escolhaOperacaoMatematica;

        //Métodos
        public float Multiplicação(float n1, float n2)
        {
            return n1 * n2;
        }
        public float Divisão(float n1, float n2)
        {
            return n1 / n2;
        }
        public float Soma(float n1, float n2)
        {
            return n1 + n2;
        }
        public float Subtração(float n1, float n2)
        {
            return n1 - n2;
        }
    }
}


// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

namespace teste2
{
    public class Calculadora
    {
        public float adicao(float n1, float n2)
        {
            return n1 + n2;
        }
        public float subtracao(float n1, float n2)
        {
            return n1 - n2;
        }
        public float multiplicacao(float n1, float n2)
        {
            return n1 * n2;
        }
        public float divisao(float n1, float n2)
        {
            
            return n1 / n2;
        }
    }
}