using Microsoft.AspNetCore.Mvc;

namespace MovimentacaoContainer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
