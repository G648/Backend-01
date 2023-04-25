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
        public string senhaCelular = "123456";
        public string selecionarOpcao;
        public string cor;
        public string modelo;
        public string tamanho;
        // public bool estadoCelular;


        public void Ligar(){

            Console.WriteLine($"O celular está ligado");

        }

        public void Desligar(){

            Console.WriteLine($"O celular está desligado");
            
        }

        public void FazerLigacao(){

            Console.WriteLine($"Você decidiu fazer ligação!");
            
        }

        public void EnviarMensagem(){

            Console.WriteLine($"Você decidiu enviar uma mensagem!");
            
        }
    }
}