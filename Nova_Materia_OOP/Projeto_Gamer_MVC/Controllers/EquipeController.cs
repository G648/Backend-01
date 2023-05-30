using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto_Gamer_MVC.Infra;

namespace Projeto_Gamer_MVC.Controllers
{
    [Route("[controller]")]
    public class EquipeController : Controller
    {
        private readonly ILogger<EquipeController> _logger;

        public EquipeController(ILogger<EquipeController> logger)
        {
            _logger = logger;
        }

        //instanciando um objeto da classe context da pasta infra para poder acessar o banco de dados
        Context conexaoBancoContext = new Context();

        //rota criada para listar as nossas equipes e depois passamos o caminho dessa rota 
        [Route("Listar")] //http://localhost/Equipe/Listar


        public IActionResult Index()
        {

            //criando uma mochila para armazenar as nossas equipes
            //viewbag é responsavel por ter acesso às equipes listadas;
            ViewBag.Equipe = conexaoBancoContext.Equipe.ToList();

            //retorna a view de equipe(TELA)
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}