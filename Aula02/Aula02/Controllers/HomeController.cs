using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aula02.Models;

namespace Aula02.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var pessoa = new Pessoa
                            {
                                PessoaId = 1,
                                Nome = "Diogo Bruno",
                                Twitter = "@dbruno"
                            };
            return View(pessoa);
        }
        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {
            ViewData["PessoaId"] = pessoa.PessoaId; 
            ViewData["Nome"] = pessoa.Nome; 
            ViewData["Twitter"] = pessoa.Twitter;

            return View(pessoa);
        }
    }
}