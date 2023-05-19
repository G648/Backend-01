using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_CadastroProdutos_16_05
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        DateTime DataCadastro = DateTime.Now;

        List<Marca> listaDeMarcas = new List<Marca>();

        public string Cadastrar()
        {

            //instanciar um novo objeto para colocar ele em uma lista
            Marca listarMarca = new Marca();

            //realizar o cadastro da marca
            Console.WriteLine($"Seja bem vindo ao cadastro da marca!");
            Console.WriteLine($"Digite o código da marca:");
            listarMarca.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o nome do produto:");
            listarMarca.NomeProduto = Console.ReadLine();

            Console.WriteLine($"A data de cadastro é de = {DataCadastro}");

            listaDeMarcas.Add(listarMarca);

            return "objeto cadastrado com sucesso!";
                        
        }

        public void Listar()
        {
            foreach (var item in listaDeMarcas)
            {
                Console.WriteLine(@$"A seguinta marca está cadastrada no sistema:
                - Código de marca: {item.Codigo}
                - Nome da marca: {item.NomeProduto}
                - Data de cadastro: {DataCadastro}
                ");
                
            }
        }

        public void Deletar(int Codigo)
        {

        }
    }
}