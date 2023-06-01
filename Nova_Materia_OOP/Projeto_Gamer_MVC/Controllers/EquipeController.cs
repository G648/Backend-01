using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto_Gamer_MVC.Infra;
using Projeto_Gamer_MVC.Models;

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

        [Route ("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            //novo objeto do tipo equipe
            Equipe novaEquipe = new Equipe();

            //atribuição de valores recebidos do formulário
            novaEquipe.Nome = form["Nome"].ToString();

            //aqui estava recebendo um valor de imagem em string, porém não é isso que queremos, vamos fazer a lógica para fazer o upload da nossa imagem
            // novaEquipe.Imagem = form["Imagem"].ToString();

            //Início upload da imagem
            if (form.Files.Count > 0)
            {
                //criando variável para alocar ar imagens desde o índice 0
                var file = form.Files[0];

                //criando uma varriável para criar o diretório Equipes
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                //gerar o caminho completo até o caminho do arquivo (imagem - nome com extensão)
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroo/img/", folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                novaEquipe.Imagem = file.FileName;
                
            }
            else
            {
                novaEquipe.Imagem = "padrao.png";
            }

            //remover a imagem da pasta de imagens quando excluir as imagens lá na minha view  


            //adiciona uma nova tabela no DB
            conexaoBancoContext.Equipe.Add(novaEquipe);

            //salvar alterações feitas no banco de dados
            conexaoBancoContext.SaveChanges();

            //retorna para o local chamando a rota de listar
            return LocalRedirect ("~/Equipe/Listar");
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        //criando o método de deletar
        [Route("Excluir/{id}")]
        public IActionResult Excluir (int id)
        {
            Equipe equipeEncontrada = conexaoBancoContext.Equipe.FirstOrDefault(x => x.IdEquipe == id);

            conexaoBancoContext.Remove(equipeEncontrada);

            conexaoBancoContext.SaveChanges();

            return LocalRedirect("~/Equipe/Listar");

        }

        [Route("Equipe/Editar/{id}")]
        public IActionResult Editar (int id)
        {
            Equipe equipeEncontrada = conexaoBancoContext.Equipe.FirstOrDefault(x => x.IdEquipe == id);

            conexaoBancoContext.SaveChanges();

            return LocalRedirect("~/Equipe/Listar");
        }
    }
}









































        // [Route("Deletar")]
        // public IActionResult Deletar(IFormCollection form)
        // {
        //     // //instancia de um novo objeto
        //     // Equipe deleteEquipe = new Equipe();

        //     // //atribuição de valores
        //     // deleteEquipe.Nome = form["Nome"].ToString();

        //     // var equipeEcontrada = conexaoBancoContext.Equipe.FirstOrDefault(x => x.IdEquipe == deleteEquipe.Nome)
        //     // Equipe equipeEncontrada = ViewBag.Find(x => x.Nome == deleteEquipe.Nome);

        //     return View();

        //     // return LocalRedirect ("~/Equipe/Listar");
        // }

        // [HttpPost]
        // [ValidateAntiForgeryToken] public ActionResult
        // Delete(int Studentid)
        // {
        //     using(var conexaoBancoContext = new Equipe())
        //     {
        //         var data = conexaoBancoContext.Equipe.FirstOrDefault(x = > x.StudentNo == Studentid);
        //         if (data != null) {
        //             conexaoBancoContext.Equipe.Remove(data);
        //             conexaoBancoContext.SaveChanges();
        //             return RedirectToAction("Read");
        //         }
        //         else
        //             return View();
        //     }
        // }