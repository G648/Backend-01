using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_CadastroProdutos_16_05
{
    public class Produto
    {

        public int CodigoProduto { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Usuario CadastradoPor { get; set; }
        public Marca marca = new Marca();

        List<Produto> listaDeProdutos = new List<Produto>();

        public void CadastrarProduto()
        {
          
        }

        public void ListarProduto()
        {

        }

        public void RemoverProduto()
        {

        }

        //esses métodos vão cher chamados no login do usuário 
    } 
}