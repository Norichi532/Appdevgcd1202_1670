using Microsoft.AspNetCore.Mvc;

namespace Appweb.Controllers
{
    public class CateguryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
