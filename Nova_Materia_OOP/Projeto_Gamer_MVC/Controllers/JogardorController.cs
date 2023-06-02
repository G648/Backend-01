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
    public class JogardorController : Controller
    {
        private readonly ILogger<JogardorController> _logger;

        public JogardorController(ILogger<JogardorController> logger)
        {
            _logger = logger;
        }

        Context conexaoBanco = new Context();

        [Route("Listar")]
        public IActionResult Index()
        {

            ViewBag.Jogador = conexaoBanco.Jogador.ToList();
            ViewBag.Equipe = conexaoBanco.Equipe.ToList();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}