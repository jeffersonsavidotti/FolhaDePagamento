using Microsoft.AspNetCore.Mvc;

namespace Prova.Controllers
{
    public class FuncionariosController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Nome"] = "Naiara";
            ViewData["RA"] = "Matricula: G545648";
            ViewData["Cargo"] = "Desenvolvedora Web";
            return View();
        }

        public IActionResult Index1()
        {
            ViewData["Nome"] = "Jefferson";
            ViewData["RA"] = "Matricula: N723254";
            ViewData["Cargo"] = "Desenvolvedor Back-end";
            return View();
        }
    }
}
