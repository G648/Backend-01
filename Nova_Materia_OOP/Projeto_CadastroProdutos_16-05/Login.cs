using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_CadastroProdutos_16_05
{
    public class Login : Utils
    {
        private bool logado { get; set; }

        //eu preciso criar um método construtor para poder chamar o meu método de login de usuário
        public Login()
        {
            Usuario user = new Usuario(); //aqui estou criando um objeto para a minha classe de usuário
            LogarUser(user); //aqui estou chamando o método para realizar o login do usuário

            if (logado)
            {
                MostrarMenu();
            }

        }
        public void LogarUser(Usuario usuário)
        {

            Usuario user = new Usuario(); //aqui estou criando um objeto para a minha classe de usuário
            Console.Clear();
            Carregamento();
        // startOfLoop:
            Console.WriteLine($"Por gentileza, informe seu email para realizar login na plataforma");
            string email = Console.ReadLine();

            Console.WriteLine($"Por gentileza, informe sua senha para realizar login na plataforma");
            string senha = Console.ReadLine();
            user.ValidacaoCadastro(email, senha);
            //validação para realizar o login do usuário



            if (user.ValidacaoCadastro(email, senha) == true )
            {
                Console.WriteLine($"Usuário logado com sucesso! Indo para as opções de menu");
                logado = true;
                MostrarMenu();

            }
            else
            {
                logado = false;
                Usuario cadastroUser = new Usuario();
                Console.WriteLine($"Usuário não cadastrado no sistema, Redirecionando para tela de cadastro.");
                Carregamento();

                cadastroUser.CadastrarUsuario(email, senha);
                Console.WriteLine($"Usuário cadastrado com sucesso!");
                Carregamento();
                cadastroUser.ListarUsuario();

                // MostrarMenu();
            }


        }

        public void DeslogarUser()
        {
            logado = false;
        }

        public void MostrarMenu()
        {

            Produto produto = new Produto();
            Marca marca = new Marca();

            Console.WriteLine($"Bem vindo à loja! Informe uma opção:");

            string opcaoMenu;
            do
            {
                Console.WriteLine(@$"
                Por gentileza, selecione uma das opções abaixo:
                [1] - Cadastrar produto
                [2] - Listar produto
                [3] - Deletar produto
                [4] - Cadastrar marca
                [5] - Listar marca
                [6] - Deletar marca
                ");
                opcaoMenu = Console.ReadLine();

                switch (opcaoMenu)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    default:
                        break;
                }

            } while (opcaoMenu == "0");
        }
    }
}