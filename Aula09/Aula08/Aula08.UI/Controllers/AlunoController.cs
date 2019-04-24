using Aula08.Aplicacao;
using Aula08.Dominio;
using System.Web.Mvc;

namespace Aula08.UI.Controllers
{
    public class AlunoController : Controller
    {
        private AlunoAplicacao appEditora;

        public AlunoController()
        {
            appEditora = AlunoAplicacaoConstrutor.AlunoAplicacaoEF();
        }

        public ActionResult Index()
        {
            var listaDeAlunos = appEditora.ListarTodos();
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
                appEditora.Salvar(editora);
                return RedirectToAction("Index");
            }
            return View(editora);
        }

        public ActionResult Editar(string id)
        {
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
                appEditora.Salvar(editora);
                return RedirectToAction("Index");
            }
            return View(editora);
        }

        public ActionResult Detalhes(string id)
        {
            var editora = appEditora.ListaPorId(id);

            if (editora == null)
                return HttpNotFound();

            return View(editora);
        }

        public ActionResult Excluir(string id)
        {
            var editora = appEditora.ListaPorId(id);

            if (editora == null)
                return HttpNotFound();

            return View(editora);
        }
        [HttpPost, ActionName("Excluir")]
        [ValidateAntiForgeryToken]
        public ActionResult ExcluirConfirmado(string id)
        {
            var editora = appEditora.ListaPorId(id);
            appEditora.Excluir(editora);
            return RedirectToAction("Index");
        }
    }
}