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

using System.Text.RegularExpressions;
using Projeto_Escola_CadastroAlunos;
using System.Globalization;
CultureInfo reais = new CultureInfo("pt-BR");
bool loopBreak = true;


Aluno CadastroAluno = new Aluno();

Console.Clear();

do
{
startOfLoop:
    Console.WriteLine(@$"Seja bem vindo ao programa de cadastro de aluno. Por gentileza, escolha uma das opções:
[1] - Inserir aluno
[2] - listar aluno
[3] - Ver média final 
[4] - Ver mensalidade
[0] - sair do programa
");

    CadastroAluno.escolhaMenu = int.Parse(Console.ReadLine());

    switch (CadastroAluno.escolhaMenu)
    {
        case 1: //inserir aluno
            Console.WriteLine($" Digite o nome do aluno: ");
            CadastroAluno.nome = Console.ReadLine();

            Console.WriteLine($" Digite o curso do aluno: ");
            CadastroAluno.curso = Console.ReadLine();

            Console.WriteLine($" Digite a idade do aluno: ");
            CadastroAluno.idade = int.Parse(Console.ReadLine());

            Console.WriteLine($" Digite o RG do aluno: ");
            var rg = Console.ReadLine();

            Regex regex = new Regex(@"([0-9]{2}.?[0-9]{3}.?[0-9]{3}-?[0-9]{1})", RegexOptions.IgnoreCase);
            var combinou = regex.Match(rg);

            if (combinou.Success)
            {
                Console.WriteLine("RG no formato válido.");
                Console.WriteLine($"O RG do aluno é: {CadastroAluno.teste(rg)}");
            }
            else
            {
                Console.WriteLine("RG inválido.");
            }

            Console.WriteLine(@$"Voce deseja cadastrar outro aluno ?
            [1] - Sim
            [2] - Não
            ");

            int cadastrarAluno = int.Parse(Console.ReadLine());

            if (cadastrarAluno == 1)
            {
                goto startOfLoop;
                CadastroAluno.Carregamento();
            }
            else if (cadastrarAluno == 2)
            {
                Console.WriteLine(@$"Voce deseja voltar para o menu de navegação ?
                [1] - Sim
                [2] - Não
                ");

                CadastroAluno.escolhaMenu = int.Parse(Console.ReadLine());

                if (CadastroAluno.escolhaMenu == 1)
                {
                    CadastroAluno.Carregamento();
                    goto startOfLoop;

                }
                else
                {

                    loopBreak = false;
                }

            }
            break;

        case 2: //listar aluno
            List<Aluno> listaAluno = new List<Aluno>();
            listaAluno.Add(CadastroAluno);

            foreach (var item in listaAluno)
            {
                Console.WriteLine(@$"
            O nome do aluno cadastrado é: {item.nome} 
            O nome do curso no qual o aluno está inscrito é: {item.curso}
            A idade do aluno é: {item.idade}
            ");
            }

            CadastroAluno.Carregamento();

            break;

        case 3: //ver média final
            Console.WriteLine(@$" O aluno é bolsista ? 
            [1] - Sim
            [2] - Não
            ");
            CadastroAluno.bolsista = int.Parse(Console.ReadLine());

            Console.WriteLine($" Qual a média final do aluno? ");
            CadastroAluno.mediaFinal = int.Parse(Console.ReadLine());

            Console.WriteLine($" Qual o valor da mensalidade ? ");
            CadastroAluno.valorMensalidade = float.Parse(Console.ReadLine());

            CadastroAluno.valorMensalidade = CadastroAluno.VerMensalidade(CadastroAluno.valorMensalidade);

            break;

        case 4: //ver mensalidade
            Console.WriteLine($" O aluno é bolsista ? ");
            CadastroAluno.bolsista = int.Parse(Console.ReadLine());

            Console.WriteLine($" Qual a média final do aluno? ");
            CadastroAluno.mediaFinal = int.Parse(Console.ReadLine());

            Console.WriteLine($" Qual o valor da mensalidade ? ");
            CadastroAluno.valorMensalidade = float.Parse(Console.ReadLine());
            break;

        case 0:
            loopBreak = false;
            CadastroAluno.Carregamento();
            Console.WriteLine($"Foi um prazer te servir! até mais!");
            break;

        default:
            break;
    }
} while (loopBreak);



