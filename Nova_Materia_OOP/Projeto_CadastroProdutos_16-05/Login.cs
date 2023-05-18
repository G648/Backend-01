using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_CadastroProdutos_16_05
{
    public class Login : Utils //a classe login está herdando da classe de utils,  mesmo sem usar uma classeabstrata em utils;
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
            Carregamento(500, 5, "carregando");
            // startOfLoop:
            Console.WriteLine($"Por gentileza, informe seu email para realizar login na plataforma");
            string email = Console.ReadLine();

            Console.WriteLine($"Por gentileza, informe sua senha para realizar login na plataforma");
            string senha = Console.ReadLine();
            user.ValidacaoCadastro(email, senha);
            //validação para realizar o login do usuário



            if (user.ValidacaoCadastro(email, senha) == true)
            {
                Console.WriteLine($"Usuário logado com sucesso! Indo para as opções de menu");
                logado = true;
                MostrarMenu();

            }
            else
            {
                logado = false;
                Usuario cadastroUser = new Usuario();
                Console.WriteLine($"Usuário não cadastrado no sistema.");
                Carregamento(500, 5 , "Redirecionando para tela de cadastro");

                cadastroUser.CadastrarUsuario(email, senha);
                Console.WriteLine($"Usuário cadastrado com sucesso!");
                Carregamento(500, 5, "carregando");
                cadastroUser.ListarUsuario();

                MostrarMenu();
            }


        }

        public void DeslogarUser()
        {
            logado = false;
        }

        public void MostrarMenu()
        {

            Produto produto = new Produto(); //criando um objeto para receber os métodos da classe produto
            Marca marca = new Marca(); //criando um objeto para receber os métodos da classe marca

            Console.WriteLine($"Bem vindo à loja! Informe uma opção:");

            string opcaoMenu;
            do
            {
                Console.WriteLine(@$"
                Por gentileza, selecione uma das opções abaixo:
                [1] - Cadastrar produto;
                [2] - Listar produto;
                [3] - Deletar produto;
                [4] - Cadastrar marca;
                [5] - Listar marca;
                [6] - Deletar marca;
                [0] - Sair do programa;
                ");
                opcaoMenu = Console.ReadLine();

                switch (opcaoMenu)
                {
                    case "1":
                        //cadastro de produto
        
                        Carregamento(500, 5, "redirecionando para tela de cadastro");

                        produto.CadastrarProduto();

                        break;
                    case "2":
                      
                        Carregamento(500, 5, "Redirecionando para a tela de listagem de produtos");
                        //listagem de produto

                        produto.ListarProduto();

                        break;
                    case "3":
                      
                        Carregamento(500, 5, "Redirecionando para realizar o delete dos produtos");
                        //deletar produto 

                        produto.RemoverProduto();

                        break;
                    case "4":

                        Carregamento(500, 5, "Redirecionando para a tela de cadastro de marcas");
                        //cadastro de marca
                        break;
                    case "5":
                        
                        Carregamento(500, 5, "Redirecionando para a tela de listagem de marcas");
                        //listagem de marca
                        break;
                    case "6":
                       
                        Carregamento(500, 5, "Redirecionando para a tela de delete de marcas");
                        //deletar marca
                        break;
                    case "0":
                        Carregamento(500, 5, "Saindo do programa");
                        //sair do programa
                        break;
                    default:
                        Console.WriteLine($"Opção incorreta, por gentileza, informe uma opção válida!");
                        break;
                }

            } while (opcaoMenu != "0");
        }
    }
}