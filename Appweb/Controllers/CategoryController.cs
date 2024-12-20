﻿using Appweb.Data;
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
		public IActionResult Add()
		{
			return View();
		}
        [HttpPost]
        public IActionResult Add(Category category)
		{
			if (string.IsNullOrEmpty(category.Name) || string.IsNullOrEmpty(category.Description))
			{
			}
			else if (category.Name.Equals(category.Description))
			{
				ModelState.AddModelError("Name", "Name should be different than Description");
			}

			if (ModelState.IsValid)
			{
				_dbContext.Categories.Add(category);
				_dbContext.SaveChanges();
				TempData["success"] = "Category is added succesfully";
				return RedirectToAction("Index");
			}

			return View();
		}
		public IActionResult Edit(int id)
        {
            return View();
        }
		[HttpPost]
		public IActionResult Edit(Category category)
		{
			if (ModelState.IsValid)
			{
				_dbContext.Categories.Update(category);
				_dbContext.SaveChanges();
				TempData["success"] = "Category is updated succesfully";
				return RedirectToAction("Index");
			}
			TempData["failed"] = "Category can not be updated";
			return View();
		}
		public IActionResult Delete(int id)
		{
			Category? category = _dbContext.Categories.FirstOrDefault(c => c.Id == id);
			if (category == null)
			{
				return NotFound();
			}
			return View(category);
		}
		[HttpPost]
		public IActionResult Delete(Category category)
		{
			_dbContext.Categories.Remove(category);
			_dbContext.SaveChanges();
			TempData["success"] = "Category is deleted succesfully";
			return RedirectToAction("Index");
		}
	}
}
