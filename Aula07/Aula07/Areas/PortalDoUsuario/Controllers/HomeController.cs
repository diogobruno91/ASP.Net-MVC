using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula07.Areas.PortalDoUsuario.Controllers
{
    public class HomeController : Controller
    {
        // GET: PortalDoUsuario/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}