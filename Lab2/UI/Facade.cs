using BLL.Interfaces;
using BLL.Services;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using UI.Interfaces;

namespace UI
{
	public class Facade<T>
	{
		private readonly IService<T> service;
		private readonly IConsole<T> console;
		public Facade(IService<T> service, IConsole<T> console)
		{
			this.service = service;
			this.console = console;
		}
		public void Add(object sender, EventArgs e)
		{
			T item = console.Input();
			service.Add(item);
		}
		public void Delete(object sender, EventArgs e)
		{
			int id = console.InputID();
			service.Delete(id);
		}
		public void Update(object sender, EventArgs e)
		{
			//int id = console.InputID();
			//T item = console.Input();
			//service.Update(id, item);
		}
		public void GetByID(object sender, EventArgs e)
		{
			int id = console.InputID();
			T item = service.GetByID(id);
			console.PrintOne(item);
		}
		public void GetAll(object sender, EventArgs e)
		{
			IEnumerable<T> list = service.GetAll();
			console.PrintAll(list);
		}
	}
}
