using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Console_MVC.model
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; } //interrogação para remover o sublinhado da palavra;
        public float Preco { get; set; }

        //caminho da pasta e do arquivo definido;
        //definimos uma constante pois a nossa variável não vai mudar; private pois só vai ser acessada na classe
        private const string PATH = "Database/Produto.csv";
        // private const string PATH = "Database/Produção/Testes/GuilhermeOriginal.csv";
                                //   [0]        [1]     [2]         [3]-arquivo
        //persistencia de dados = mesmo fechando o programa, os nossos dados vão estar salvos no nosso arquivo Produto.csv


        public Produto()
        {

            //precisamos dividir o caminho do arquivo para criar a pasta e o arquivo separadamente
            //1- precisamos obter o caminho da pasta

            string pasta = PATH.Split("/")[0];

            //realizar a validação:
            //1- se o diretório não existir, vamos cria-lo

            if (!Directory.Exists(pasta))
            {
             Directory.CreateDirectory(pasta);   
            }
            
            //2- se não existir a pasta Produto.csv, vamos cria-la
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }

        }

        //criar o método de listagem dos produtos para o tipo lista
        public List<Produto> Ler()
        {
            //instanciar uma nova lista para recerber os valores
            List<Produto> produtos = new List<Produto>();

            //array de string que recebe cada linha do CSV
            //devemos declarar o caminho do nosso arquivo que está na PATH
            string[] linhas = File.ReadAllLines(PATH);

            //leitura de cada linha
            foreach (string item in linhas)
            {
                //separar os nossos dados por ;
                string[] atributos = item.Split(";");

                //após o split
                //atributo[0] = "001"
                //atributo[1] = "coca"
                //atributo[2] = "3,50"

                //instanciar o nosso objeto para colocar na nossa lista
                Produto p1 = new Produto();

                //atribuir os dados dentro de um objeto
                p1.Codigo = int.Parse(atributos[0]);
                p1.Nome = atributos[1];
                p1.Preco = float.Parse(atributos[2]);

                //adicionar os objetos dentro da lista
                produtos.Add(p1);
            }

            //retornando o nosso objeto
            return produtos;
        }

        //fazer um for para realizar a criação de pastas e subpastas 
    }
}