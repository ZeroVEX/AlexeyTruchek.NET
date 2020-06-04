using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BLL.Services;
using BLL.DTO;

namespace WebUI.Controllers
{
	public class RecipesController : Controller
	{
		private readonly RecipeService recipeService;
		public RecipesController(RecipeService recipeService)
		{
			this.recipeService = recipeService;
		}
		public IActionResult Recipe()
		{
			return View(recipeService.GetAll().ToList());
		}
		[HttpGet]
		public IActionResult AddRecipe()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddRecipe(RecipeDTO recipe)
		{
			recipeService.Add(recipe);
			return RedirectToAction("Recipe");
		}
		[HttpGet]
		public IActionResult DeleteRecipe()
		{
			return View();
		}
		[HttpPost]
		public IActionResult DeleteRecipe(int id)
		{
			recipeService.Delete(id);
			return RedirectToAction("Recipe");
		}
		[HttpGet]
		public IActionResult SearchRecipe()
		{
			return View();
		}
		[HttpPost]
		public IActionResult SearchRecipe(int id)
		{
			var item = recipeService.GetAll().Where(t => t.ProductID == id);
			return View(item);
		}
		[HttpGet]
		public IActionResult UpdateRecipe()
		{
			return View();
		}
		[HttpPost]
		public IActionResult UpdateRecipe(RecipeDTO recipe)
		{
			var item = recipeService.GetByID(recipe.ID);
			item.ProductID = recipe.ProductID;
			item.IngredientID = recipe.IngredientID;
			item.Quantity = recipe.Quantity;
			recipeService.Update(item);
			return RedirectToAction("Recipe");
		}
	}
}
