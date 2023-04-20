namespace PassagensAereas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[5];
            string[] origens = new string[5];
            string[] destinos = new string[5];
            string[] datas = new string[5];
            int contador = 0;
            string resposta;
            string nome;


            Console.WriteLine("digite a senha: ");
            string senha = Console.ReadLine();//1234
            bool retornodaFuncao = ValidarSenha(senha);//falso

            while (!retornodaFuncao)
            {
                Console.WriteLine("senha invalida");
                Console.WriteLine("digite novamente a senha:");
                senha = Console.ReadLine();
                retornodaFuncao = ValidarSenha(senha);
            }//fim while

            //entramos no programa
            Console.WriteLine("|-------------------------------|;");
            Console.WriteLine("bem vindo a Guilherme's AirLines");
            Console.WriteLine("|-------------------------------|;");
            string opcao;

            do
            {

                Console.WriteLine("|----------Selecione uma Opção----------|");
                Console.WriteLine("1 - cadastrar passagem");
                Console.WriteLine("2 - listar passagens");
                Console.WriteLine("3 - busca de passageiros");
                Console.WriteLine("0 - sair");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("|------cadastro de passagens------|");
                        cadastroDePassagens();
                        break;
                    case "2":
                        Console.WriteLine("|------listagem de passagens------|");
                        ListarPassagens();
                        break;
                    case "3":
                        Console.WriteLine("|--------buscar passageiro--------|");
                        BuscasPassageiros();
                        break;
                    case "0":
                        Console.WriteLine("|------obrigado por usar a Guilherme's AirLines------|");
                        break;
                    default:
                        Console.WriteLine("---opção invalida---");
                        break;
                }


            } while (opcao != "0");

            //pode usar a funcao toda vez que voce quiser;
            // valor bool= true e false

            //funcao Senha;
            bool ValidarSenha(string senha)
            {
                if (senha == "123456")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }//fim validarsenha

            //funcao Cadastro;
            // void não retorna nenhum valo (apenas exibe na tela)
            void cadastroDePassagens()
            {
                do
                {
                    if (contador < 5)
                    {

                        Console.WriteLine("digite o nome do passageiro");
                        nomes[contador] = Console.ReadLine();
                        Console.WriteLine("digite a origem");
                        origens[contador] = Console.ReadLine();
                        Console.WriteLine("digite o destino");
                        destinos[contador] = Console.ReadLine();
                        Console.WriteLine("digite a data da viagem");
                        datas[contador] = Console.ReadLine();

                        Console.WriteLine("gostaria de cadastrar outra passagem?");
                        resposta = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("limite excedido");
                        break;
                    }

                    contador++;
                } while (resposta == "sim");


            }//fim do void01

            void ListarPassagens()
            {
                Console.WriteLine("---listagem dos dados---");
                for (var i = 0; i < contador; i++)
                {
                    Console.WriteLine($"{nomes[i]} data: {datas[i]} origem:{origens[i]} destino:{destinos[i]}");
                }
            }//fim void002
            //digitar um nome e ver o nome e a data desse voo;0
           
            void BuscasPassageiros()
            
            {
                Console.WriteLine("---consulta de passagens---");
                Console.WriteLine("digite o seu nome: ");
                nome = Console.ReadLine();

                for (var i = 0; i < contador; i++)
                {
                    if (nome == nomes[i])
                    {
                        Console.WriteLine($"{nomes[i]} data:  {datas[i]} destino {destinos[i]}");
                    }
                    else
                    {
                        Console.WriteLine("usuario nao cadastrado;");
                    }
                }
            }//fim do void03

        }//fim da main

        // valor bool= true e false
        //funcao começa com letra maiuscula
    }
}
