using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BLL.Services;
using BLL.DTO;

namespace WebUI.Controllers
{
	public class ProductsController : Controller
	{
		private readonly ProductService productService;
		public ProductsController(ProductService productService)
		{
			this.productService = productService;
		}
		public IActionResult Product()
		{
			return View(productService.GetAll().ToList());
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
			return RedirectToAction("Product");
		}
		[HttpGet]
		public IActionResult DeleteProduct()
		{
			return View();
		}
		[HttpPost]
		public IActionResult DeleteProduct(int id)
		{
			productService.Delete(id);
			return RedirectToAction("Product");
		}
		[HttpGet]
		public IActionResult SearchProduct()
		{
			return View();
		}
		[HttpPost]
		public IActionResult SearchProduct(int id)
		{
			var item = productService.GetByID(id);
			return View(item);
		}
		[HttpGet]
		public IActionResult UpdateProduct()
		{
			return View();
		}
		[HttpPost]
		public IActionResult UpdateProduct(ProductDTO product)
		{
			var item = productService.GetByID(product.ID);
			item.Title = product.Title;
			productService.Update(item);
			return RedirectToAction("Product");
		}
	}
}
