namespace Projeto_CadastroProdutos_16_05
{


    public class Usuario
    {

        private Random CodigoUser = new Random();
        public string NameUser { get; set; }
        public string EmailUser { get; set; }
        public string SenhaUser { get; set; }
        // private DateTime DataDeCadastroUser;
        DateTime dataDeCadastroUser = DateTime.Now;
        public static List<Usuario> listUsers = new List<Usuario>();

        // public Usuario()
        // {
        //     CadastrarUsuario();
        // }

        public Usuario CadastrarUsuario()
        {
            // Login loginUser = new Login();

            Usuario cadastradoUser = new Usuario();

            Console.WriteLine($"Bem vindo a tela de cadastro do usuário. ");

            Console.WriteLine($"Por gentileza, digite seu nome:");
            cadastradoUser.NameUser = Console.ReadLine();

            Console.WriteLine($"Informe seu email:");
            cadastradoUser.EmailUser = Console.ReadLine();

            Console.WriteLine($"Informe sua senha:");
            cadastradoUser.SenhaUser = Console.ReadLine();

            Console.WriteLine($"A data de cadastro do novo usuário é: {dataDeCadastroUser}");
            Console.WriteLine($"O código do usuário na plataforma é: {CodigoUser.Next(0000, 9999)}");

            listUsers.Add(cadastradoUser);
            //aqui eu to colocando os objetod criados dentro de uma lista

            return cadastradoUser;

        }

        public void ListarUsuario()
        {
            foreach (var item in listUsers)
            {

                Console.WriteLine($"email {item.EmailUser}, senha: {item.SenhaUser}");

            }
        }

        // public void UserLogado(string  _userName, Usuario user)
        // {

        //     user = listUsers.Find(x => x.NameUser == _userName);

        //     Console.WriteLine($"Cadastrado por: {user.NameUser}");

        // }

        public bool ValidacaoCadastro(string email, string senha)
        {

            Usuario validacaoEmail = listUsers.Find(x => x.EmailUser == email);


            if (validacaoEmail == null)
            {

                return false;

            }

            if (validacaoEmail.EmailUser == email && validacaoEmail.EmailUser != null)
            {
                Console.WriteLine($"Usuário cadastrado com sucesso!");
                return true;
            }
            else
            {
                Console.WriteLine($"Usuário não cadastrado ");
                return false;
            }


            // }

            // public string DeletarUsuario()
            // {

            // }
        }
    }
}