// Nesta aula vamos fazer um pequeno sistema de cadastro de alunos, em um projeto de console no VsCode.

// Vamos desenvolver um programa que cadastre e mostre os dados de um aluno.

// Crie uma classe Aluno com as seguintes propriedades:

// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
// Também teremos os métodos: 

// VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.

// obs:
// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral
// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.

// Acrescente o que achar necessário.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Projeto_Escola_CadastroAlunos
{
    public class Aluno
    {
       
        public int escolhaMenu;
        public string nome;
        public string curso;
        public int idade;
        public int rg;
        public int bolsista;
        public int mediaFinal;
        public float valorMensalidade;
        public float calculoMensalidade;

        public float VerMensalidade(float valorMensalidade)
        {

            if (bolsista == 1 && mediaFinal >= 8)
            {
                calculoMensalidade = valorMensalidade * 0.5f;

                Console.WriteLine($"O aluno passou com média {mediaFinal}, portanto o valor da mensalidade é de : {Math.Round(calculoMensalidade, 2).ToString("C")} reais");

            }
            else if (bolsista == 1 && mediaFinal >= 6 )
            {
                calculoMensalidade = valorMensalidade - (valorMensalidade * 0.3f) ;
                Console.WriteLine($"O aluno passou com média {mediaFinal}, portanto o valor da mensalidade é de : {Math.Round(calculoMensalidade, 2).ToString("C")} reais");
                
            }

            return valorMensalidade;
        }


        List<Aluno> listaAluno = new List<Aluno>();

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

        public string teste(string rg)
        {
            return Convert.ToUInt64(rg).ToString(@"00\.000\.000\-0");
        }

    }
}