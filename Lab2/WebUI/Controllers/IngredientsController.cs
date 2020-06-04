using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BLL.Services;
using BLL.DTO;

namespace WebUI.Controllers
{
	public class IngredientsController : Controller
	{
		private readonly IngredientService ingredientService;
		public IngredientsController(IngredientService ingredientService)
		{
			this.ingredientService = ingredientService;
		}
		public IActionResult Ingredient()
		{
			return View(ingredientService.GetAll().ToList());
		}
		[HttpGet]
		public IActionResult AddIngredient()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddIngredient(IngredientDTO ing)
		{
			ingredientService.Add(ing);
			return RedirectToAction("Ingredient");
		}
		[HttpGet]
		public IActionResult DeleteIngredient()
		{
			return View();
		}
		[HttpPost]
		public IActionResult DeleteIngredient(int id)
		{
			ingredientService.Delete(id);
			return RedirectToAction("Ingredient");
		}
		[HttpGet]
		public IActionResult SearchIngredient()
		{
			return View();
		}
		[HttpPost]
		public IActionResult SearchIngredient(int id)
		{
			var item = ingredientService.GetByID(id);
			return View(item);
		}
		[HttpGet]
		public IActionResult UpdateIngredient()
		{
			return View();
		}
		[HttpPost]
		public IActionResult UpdateIngredient(IngredientDTO ing)
		{
			var item = ingredientService.GetByID(ing.ID);
			item.Title = ing.Title;
			ingredientService.Update(item);
			return RedirectToAction("Ingredient");
		}
	}
}
