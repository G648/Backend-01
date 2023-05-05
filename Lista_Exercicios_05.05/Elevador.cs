//     1. Crie uma classe denominada Elevador para armazenar as informações de um elevadordentro de um prédio. A classe deve armazenar o andar atual (térreo = 0),
// total de andares no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão presentes nele. A classe deve também disponibilizar os seguintes métodos:           

//Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de  andares no prédio (os elevadores sempre começam no térreo e vazio);
//  a- Entrar : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver espaço);
//  b- Sair : para remover uma pessoa do elevador (só deve remover se houver alguém dentro dele);
//  c- Subir : para subir um andar (não deve subir se já estiver no último andar);
//  d -Descer : para descer um andar (não deve descer se já estiver no térreo);
//  e- Encapsular todos os atributos da classe (criar os métodos set e get).    




using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista_Exercicios_05._05
{
    public class Elevador
    {
        public bool startOfLoop;
        public int escolhaMenu { get; set; }

        public int informeAndar { get; set; }

        public int andarAtual = 0;

        public int totalAndaresPredio = 26;

        public int capacidadeElevador = 8;

        public int pessoasPresentesNoElevador { get; set; }

        public void Inicializa()
        {

        }

        public void ElevadorPredio(int informeAndar)
        {

            for (andarAtual = 1; andarAtual <= informeAndar; andarAtual++)
            {

                Console.WriteLine($"\n o elevador está atualmento no {andarAtual}º andar");

                if (informeAndar == andarAtual)
                {
                    break;
                }

                Carregamento();
                Thread.Sleep(800);

            }
        }

        public void Carregamento()
        {
            Console.Write($"Elevador subindo");

            for (var i = 0; i < 5; i++)
            {
                Console.Write($"↑");
                Thread.Sleep(300);
            }

            // Console.Clear();
        }

        public void EntrarNoElevador(int pessoasPresentesNoElevador)
        {

            Console.WriteLine($"Ok, voce decidiu entrar no elevador. Por gentileza, informe se a quantidade de pessoas presentes no elevador:");

            pessoasPresentesNoElevador = int.Parse(Console.ReadLine());

            if (pessoasPresentesNoElevador > 0 && pessoasPresentesNoElevador < 8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Ok, a quantidade de pessoas está de acordo com a capacidade do elevador, que seria de {capacidadeElevador} pessoas");
                Console.ResetColor();

            }
            else
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"a capacidade do elevador está muito cheia, por gentileza, espere para que o elevador possa ficar vazio!");
                Console.ResetColor();

            }

        }

        public void SubirAndares(int informeAndar)
        {

            do
            {

                Console.WriteLine($"Boa tarde, o elevador se encontra atualmente no Térreo! ");

                Console.WriteLine($"Por favor, informe para qual andar voce deseja ir:");
                informeAndar = int.Parse(Console.ReadLine());

                if (informeAndar < totalAndaresPredio)
                {

                    Console.WriteLine($"Elevador indo em direção ao andar escolhido, um momento... ");

                    ElevadorPredio(informeAndar);

                }
                else if (informeAndar != totalAndaresPredio)
                {
                    Console.WriteLine($"A informação digitada não é valida para a quantidade de andares no prédio. Adeus!");
                    startOfLoop = false;
                }

            } while (startOfLoop == true);

        }
        public void DescerAndares(int informeAndar)
        {

            do
            {

                Console.WriteLine($"Boa tarde, o elevador se encontra atualmente no {andarAtual}º andar ");

                Console.WriteLine($"Por favor, informe para qual andar voce deseja ir:");
                informeAndar = int.Parse(Console.ReadLine());

                if (informeAndar < totalAndaresPredio)
                {

                    Console.WriteLine($"Elevador indo em direção ao andar escolhido, um momento... ");

                    for (andarAtual = 0; andarAtual <= informeAndar; andarAtual--)
                    {

                        Console.WriteLine($"\n o elevador está atualmento no {andarAtual}º andar");

                        if (informeAndar == andarAtual)
                        {
                            Carregamento();
                            break;
                        }

                        Thread.Sleep(800);

                    }

                }
                else if (informeAndar != totalAndaresPredio)
                {
                    Console.WriteLine($"A informação digitada não é valida para a quantidade de andares no prédio. Adeus!");
                    startOfLoop = false;
                }

            } while (startOfLoop == true);

        }


    }

}

