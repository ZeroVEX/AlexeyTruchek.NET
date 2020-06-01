using System;
using UI;
using System.Collections.Generic;
using System.Text;
using UI.Facade;

namespace UI.Controllers
{
	public class SubMenu<T>
	{
		public event EventHandler OnCreate;
		public event EventHandler OnRead;
		public event EventHandler OnUpdate;
		public event EventHandler OnDelete;
		public event EventHandler OnReadCollection;

        public SubMenu()
        {
        }
        public SubMenu(Facade<T> facade)
        {
            OnCreate += facade.Add;
            OnRead += facade.GetByID;
            OnUpdate += facade.Update;
            OnDelete += facade.Delete;
            OnReadCollection += facade.GetAll;
        }
        public SubMenu(RecipeFacade facade)
        {
            OnCreate += facade.Add;
            OnRead += facade.GetByID;
            OnUpdate += facade.Update;
            OnDelete += facade.Delete;
            OnReadCollection += facade.GetAll;
        }
        public SubMenu(OrderFacade facade)
        {
            OnCreate += facade.Add;
            OnRead += facade.GetByID;
            OnUpdate += facade.Update;
            OnDelete += facade.Delete;
            OnReadCollection += facade.GetAll;
        }

        public void Menu()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine($"\n\t\t\t {typeof(T).Name} menu" +
                                  $"\n\t1.Добавить" +
                                  $"\n\t2.Найти" +
                                  $"\n\t3.Изменить данные" +
                                  $"\n\t4.Удалить" +
                                  $"\n\t5.Посмотреть все данные" +
                                  $"\n\t6.Выход\n");

                ConsoleKeyInfo consoleKey = Console.ReadKey();

                Console.WriteLine();

                switch (consoleKey.Key)
                {
                    case ConsoleKey.D1:
                        OnCreate?.Invoke(this, EventArgs.Empty);
                        break;

                    case ConsoleKey.D2:
                        OnRead?.Invoke(this, EventArgs.Empty);
                        break;

                    case ConsoleKey.D3:
                        OnUpdate?.Invoke(this, EventArgs.Empty);
                        break;

                    case ConsoleKey.D4:
                        OnDelete?.Invoke(this, EventArgs.Empty);
                        break;

                    case ConsoleKey.D5:
                        OnReadCollection?.Invoke(this, EventArgs.Empty);
                        break;

                    default:
                        exit = true;
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
