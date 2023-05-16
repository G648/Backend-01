using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Projeto_CadastroProdutos_16_05
{
    public class Usuário
    {
        //aqui vamos ter os seguintes atributos:
        //código 
        //nome
        //email
        //senha
        //data de cadastro 
        //vamos utilizar apenas atributos privados!

        private Random CodigoUser = new Random();
        private string NameUser {get; set;}
        private string EmailUser {get; set;}
        private string SenhaUser {get; set;}
        // private DateTime DataDeCadastroUser;
        DateTime dataDeCadastroUser = DateTime.Now;
        
        public string CadastrarUsuario()
        {

            Console.WriteLine($"Bem vindo a tela de cadastro do usuário. ");

            Console.WriteLine($"Por gentileza, digite seu nome:");
            NameUser = Console.ReadLine();

            Console.WriteLine($"Informe seu email:");
            EmailUser = Console.ReadLine();

            Console.WriteLine($"Informe sua senha:");
            SenhaUser = Console.ReadLine();

            Console.WriteLine($"A data de cadastro do novo usuário é: {dataDeCadastroUser}");
            Console.WriteLine($"O código do usuário na plataforma é: {CodigoUser.Next(0000, 9999)}");

            return "";
            
        }

        // public string DeletarUsuario()
        // {

        // }
    }
}