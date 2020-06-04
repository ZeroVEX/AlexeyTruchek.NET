using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BLL.Services;
using BLL.DTO;

namespace WebUI.Controllers
{
	public class OrdersController : Controller
	{
		private readonly OrderService orderService;
		public OrdersController(OrderService orderService)
		{
			this.orderService = orderService;
		}
		public IActionResult Order()
		{
			return View(orderService.GetAll().ToList());
		}
		[HttpGet]
		public IActionResult AddOrder()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddOrder(OrderDTO order)
		{
			order.Date = DateTime.Now;
			orderService.Add(order);
			return RedirectToAction("Order");
		}
		[HttpGet]
		public IActionResult DeleteOrder()
		{
			return View();
		}
		[HttpPost]
		public IActionResult DeleteOrder(int id)
		{
			orderService.Delete(id);
			return RedirectToAction("Order");
		}
		[HttpGet]
		public IActionResult SearchOrder()
		{
			return View();
		}
		[HttpPost]
		public IActionResult SearchOrder(int id)
		{
			var item = orderService.GetAll().Where(t => t.UserID == id);
			return View(item);
		}
		[HttpGet]
		public IActionResult UpdateOrder()
		{
			return View();
		}
		[HttpPost]
		public IActionResult UpdateOrder(OrderDTO order)
		{
			var item = orderService.GetByID(order.ID);
			item.ProductID = order.ProductID;
			item.UserID = order.UserID;
			item.Quantity = order.Quantity;
			orderService.Update(item);
			return RedirectToAction("Order");
		}
	}
}
