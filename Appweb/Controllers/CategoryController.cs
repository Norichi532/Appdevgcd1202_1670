using Microsoft.AspNetCore.Mvc;

namespace Appweb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
