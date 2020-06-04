using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BLL.Services;
using BLL.DTO;

namespace WebUI.Controllers
{
	public class UsersController : Controller
	{
		private readonly UserService userService;
		public UsersController(UserService userService)
		{
			this.userService = userService;
		}
		public IActionResult Users()
		{
			return View(userService.GetAll().ToList());
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
			return RedirectToAction("Users");
		}
		[HttpGet]
		public IActionResult DeleteUser()
		{
			return View();
		}
		[HttpPost]
		public IActionResult DeleteUser(int id)
		{
			userService.Delete(id);
			return RedirectToAction("Users");
		}
		[HttpGet]
		public IActionResult SearchUser()
		{
			return View();
		}
		[HttpPost]
		public IActionResult SearchUser(int id)
		{
			var item = userService.GetByID(id);
			return View(item);
		}
		[HttpGet]
		public IActionResult UpdateUser()
		{
			return View();
		}
		[HttpPost]
		public IActionResult UpdateUser(UserDTO user)
		{
			var item = userService.GetByID(user.ID);
			item.Login = user.Login;
			item.Password = user.Password;
			item.CompanyName = user.CompanyName;
			userService.Update(item);
			return RedirectToAction("Users");
		}
	}
}
