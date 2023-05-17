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
        public DateTime DataCadastro { get; set; }

        List<Marca> listaDeMarcas = new List<Marca>();

        public void Cadastrar()
        {
            
        }

        public void Listar()
        {

        }

        public void Deletar(int Codigo)
        {

        }
    }
}