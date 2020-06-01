using BLL.DTO;
using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UI.ConsoleOperations;

namespace UI.Facade
{
	public class RecipeFacade
	{
		private readonly IService<RecipeDTO> service;
		private readonly RecipeConsole console;
		public RecipeFacade(IService<RecipeDTO> service, RecipeConsole console)
		{
			this.service = service;
			this.console = console;
		}
		public void Add(object sender, EventArgs e)
		{
			IEnumerable<RecipeDTO> items = console.Input();
			foreach(var one in items)
			{
				service.Add(one);
			}
		}
		public void Delete(object sender, EventArgs e)
		{
			int id = console.InputID();
			service.Delete(id);
		}
		public void Update(object sender, EventArgs e)
		{
			int id = console.InputID();
			RecipeDTO item = service.GetByID(id);
			console.Update(item);
			service.Update(item);
		}
		public void GetByID(object sender, EventArgs e)
		{
			int id = console.InputProductID();
			IEnumerable<RecipeDTO> items = service.GetAll().Where(t => t.ProductID == id);
			console.PrintAll(items);
		}
		public void GetAll(object sender, EventArgs e)
		{
			IEnumerable<RecipeDTO> list = service.GetAll();
			console.PrintAll(list);
		}
	}
}
