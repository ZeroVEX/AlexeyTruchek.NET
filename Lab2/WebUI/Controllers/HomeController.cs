using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebUI.Models;

namespace WebUI.Controllers
{
	public class HomeController : Controller
	{
		private readonly UserService userService;
		private readonly ProductService productService;
		private readonly IngredientService ingredientService;
		private readonly RecipeService recipeService;
		private readonly OrderService orderService;
		public HomeController(UserService userService, ProductService productService,
			IngredientService ingredientService, RecipeService recipeService, OrderService orderService)
		{
			this.userService = userService;
			this.productService = productService;
			this.ingredientService = ingredientService;
			this.recipeService = recipeService;
			this.orderService = orderService;
		}

		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Users()
		{
			return View(userService.GetAll().ToList());
		}
		public IActionResult Product()
		{
			return View(productService.GetAll().ToList());
		}
		public IActionResult Ingredient()
		{
			return View(ingredientService.GetAll().ToList());
		}
		public IActionResult Recipe()
		{
			return View(recipeService.GetAll().ToList());
		}
		public IActionResult Order()
		{
			return View(orderService.GetAll().ToList());
		}
		[HttpGet]
		public IActionResult AddUser()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddUser(UserDTO user)
		{
			userService.Add(user);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult AddProduct()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddProduct(ProductDTO product)
		{
			productService.Add(product);
			return RedirectToAction("Index");
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
			return RedirectToAction("Index");
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
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult AddOrder()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddOrder(OrderDTO order)
		{
			orderService.Add(order);
			return RedirectToAction("Index");
		}
	}
}
