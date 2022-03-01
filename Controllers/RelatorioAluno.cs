using Microsoft.AspNetCore.Mvc;

namespace Universidade.Controllers
{
    public class RelatorioAluno : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
