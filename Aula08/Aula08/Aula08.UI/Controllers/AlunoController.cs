using Aula08.Aplicacao;
using Aula08.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula08.UI.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        public ActionResult Index()
        {
            var appAluno = new AlunoAplicacao();
            var listaDeAlunos = appAluno.ListarTodos();
            return View(listaDeAlunos);
        }
        public ActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Editora editora)
        {
            if (ModelState.IsValid)
            {
                var appEditora = new AlunoAplicacao();
                appEditora.Salvar(editora);
                return RedirectToAction("Index");
            }
            return View(editora);
        }

        public ActionResult Editar(int id)
        {
            var appEditora = new AlunoAplicacao();
            var editora = appEditora.ListaPorId(id);

            if(editora == null)            
                return HttpNotFound();

            return View(editora);
            
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Editora editora)
        {
            if (ModelState.IsValid)
            {
                var appEditora = new AlunoAplicacao();
                appEditora.Salvar(editora);
                return RedirectToAction("Index");
            }
            return View(editora);
        }

        public ActionResult Detalhes(int id)
        {
            var appEditora = new AlunoAplicacao();
            var editora = appEditora.ListaPorId(id);

            if (editora == null)
                return HttpNotFound();

            return View(editora);
        }

        public ActionResult Excluir(int id)
        {
            var appEditora = new AlunoAplicacao();
            var editora = appEditora.ListaPorId(id);

            if (editora == null)
                return HttpNotFound();

            return View(editora);
        }
        [HttpPost, ActionName("Excluir")]
        [ValidateAntiForgeryToken]
        public ActionResult ExcluirConfirmado(int id)
        {
            var appEditora = new AlunoAplicacao();
            appEditora.Excluir(id);
            return RedirectToAction("Index");
        }
    }
}