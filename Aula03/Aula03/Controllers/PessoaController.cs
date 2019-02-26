using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aula03.Models;
using System.Collections.ObjectModel;

namespace Aula03.Controllers
{
    public class PessoaController : Controller
    {
        // GET: Pessoa
        public ActionResult Index()
        {
            var pessoa = new Pessoa();
            return View(pessoa);
        }
        [HttpPost]
        public ActionResult Index(Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", pessoa);
            }
            return View(pessoa);
        }

        public ActionResult Resultado(Pessoa pessoa)
        {
            return View(pessoa);
        }

        public ActionResult LoginUnico(string login)
        {
            var bancoFake = new Collection<string>
            {
                "Diogo",
                "Bruno",
                "Juliana"
            };
            return Json(bancoFake.All(X => X.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet );
        }
    }
}