using BLL.DTO;
using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UI.ConsoleOperations;

namespace UI.Facade
{
	public class OrderFacade
	{
		private readonly IService<OrderDTO> service;
		private readonly OrderConsole console;
		public OrderFacade(IService<OrderDTO> service, OrderConsole console)
		{
			this.service = service;
			this.console = console;
		}
		public void Add(object sender, EventArgs e)
		{
			IEnumerable<OrderDTO> items = console.Input();
			foreach (var one in items)
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
			OrderDTO item = service.GetByID(id);
			console.Update(item);
			service.Update(item);
		}
		public void GetByID(object sender, EventArgs e)
		{
			int id = console.InputUserID();
			IEnumerable<OrderDTO> items = service.GetAll().Where(t => t.UserID == id);
			console.PrintAll(items);
		}
		public void GetAll(object sender, EventArgs e)
		{
			IEnumerable<OrderDTO> list = service.GetAll();
			console.PrintAll(list);
		}
	}
}
