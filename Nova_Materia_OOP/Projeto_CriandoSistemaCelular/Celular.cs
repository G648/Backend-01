using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



// Faça em sua máquina utilizando os mesmos conceitos dado em aula.

//  Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
//  Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
//  Só será possível executar tais métodos se o celular estiver ligado.
//  Envie o link do repositório como entrega desta atividade.



namespace Projeto_CriandoSistemaCelular
{
    public class Celular
    {
        public string escolhaEstado;
        public string selecionarOpcao;
        public string cor;
        public string modelo;
        public string tamanho;
        public bool estadoCelular;
        public bool loopBreak;


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
        public void LigarCelular()
        {

            Console.WriteLine($"O celular está ligado...");
            Thread.Sleep(2000);
        }

        public void DesligarCelular()
        {

            Console.WriteLine($"O celular está desligando...");
            Thread.Sleep(2000);
            Console.WriteLine($"Celular desligado com sucesso!");

        }

        public void FazerLigacao()
        {

            Console.WriteLine($"Fazendo ligação!");
            Thread.Sleep(2000);
            Console.WriteLine($"Ligação realizada com sucesso!");
        }

        public void EnviarMensagem()
        {

            Console.WriteLine($"Enviando mensagem!");
            Thread.Sleep(2000);
            Console.WriteLine($"Mensagem enviada com sucesso!");

        }

        public void DetalhesTecnicos()
        {
           
            Console.WriteLine($"Por gentileza, informe a cor do seu smartphone: ");
            cor = Console.ReadLine();

            Console.WriteLine($"Por gentileza, informe o modelo do seu smartphone: ");
            modelo = Console.ReadLine();

            Console.WriteLine($"Por gentileza, informe o tamanho do seu smartphone: ");
            tamanho = Console.ReadLine();

            

        }
    }
}