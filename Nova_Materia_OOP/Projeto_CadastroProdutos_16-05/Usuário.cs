using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Projeto_CadastroProdutos_16_05
{
    public class Usuário
    {
        private Random CodigoUser = new Random();
        public string NameUser { get; set; }
        public string EmailUser { get; set; }
        public string SenhaUser { get; set; }
        // private DateTime DataDeCadastroUser;
        DateTime dataDeCadastroUser = DateTime.Now;

        public string CadastrarUsuario()
        {
            // Login loginUser = new Login();

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