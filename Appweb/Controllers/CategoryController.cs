using Appweb.Data;
using Appweb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Appweb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContext _dbContext;
        public CategoryController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Category> listCategory = _dbContext.Categories.ToList();
            return View(listCategory);
        }
        public IActionResult Edit(int id)
        {
            return View();
        }
    }
}
