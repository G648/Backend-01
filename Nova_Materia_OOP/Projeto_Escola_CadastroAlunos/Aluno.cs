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
        public string nome;
        public string curso;
        public int idade;
        // public var rg;
        public bool bolsista;
        public int mediaFinal;
        public float valorMensalidade;

        public int VerMediaFinal(int mediaFinal){

            return mediaFinal;
            
        }
       
     public string teste(string rg)
{
    return Convert.ToUInt64(rg).ToString(@"00\.000\.000\-0");
}

    }
}