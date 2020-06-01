using BLL.DTO;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Text;
using UI.ConsoleOperations;
using UI.Facade;

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
                        new SubMenu<ProductDTO>(new Facade<ProductDTO>(new ProductService(), new ProductConsole())).Menu();
                        break;

                    case ConsoleKey.D3:
                        new SubMenu<IngredientDTO>(new Facade<IngredientDTO>(new IngredientService(), new IngredientConsole())).Menu();
                        break;

                    case ConsoleKey.D4:
                        new SubMenu<RecipeDTO>(new RecipeFacade(new RecipeService(), new RecipeConsole())).Menu();
                        break;

                    case ConsoleKey.D5:
                        new SubMenu<OrderDTO>(new OrderFacade(new OrderService(), new OrderConsole())).Menu();
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
