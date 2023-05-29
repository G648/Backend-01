using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_Console_MVC.model;
using Projeto_Console_MVC.View;

namespace Projeto_Console_MVC.Controller
{
    public class ProdutoController
    {
        //instanciar objeto produto e produtoview

        Produto produto = new Produto();

        ProdutoView produtoview = new ProdutoView();

        //método controlador para acessar a listagem de produtos
        public void ListarProdutos()
        {
            //listagem de produtos na model
            List<Produto> produtos = produto.Ler();

            //método de exibição da view
            produtoview.Listar(produtos);
        }
    }
}