using BLL.DTO;
using BLL.Services;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using UI.ConsoleOperations;

namespace UI.Controllers
{
	public class MainMenu
	{
        public MainMenu()
        {
        }

        public void Menu()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine($"\t\t\tГлавное меню\n" +
                    $"\t1. Пользователи\n" +
                    $"\t2. Продукты\n" +
                    $"\t3. Ингредиенты\n" +
                    $"\t4. Рецепты\n" +
                    $"\t5. Заказы\n" +
                    $"\t6. Выход\n");

                var keyInfo = Console.ReadKey();

                Console.WriteLine();

                switch (keyInfo.Key)
                {

                    case ConsoleKey.D1:
                        new SubMenu<UserDTO>(new Facade<UserDTO>(new UserService(), new UserConsole())).Menu();
                        break;

                    case ConsoleKey.D2:
                        break;

                    case ConsoleKey.D3:
                        break;

                    case ConsoleKey.D4:
                        break;

                    case ConsoleKey.D5:
                        break;

                    case ConsoleKey.D6:
                        exit = true;
                        break;

                }
                Console.Clear();
            }
        }
    }
}
