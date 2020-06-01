using BLL.DTO;
using System;
using System.Collections.Generic;
using UI.Interfaces;

namespace UI.ConsoleOperations
{
	public class IngredientConsole : IConsole<IngredientDTO>
	{
        public IngredientDTO Input()
        {
            IngredientDTO item = new IngredientDTO();
            Console.WriteLine("Введите название ингредиента");
            item.Title = Console.ReadLine();
            return item;
        }
        public int InputID()
        {
            Console.WriteLine("Введите ID ингредиента");
            return Int32.Parse(Console.ReadLine());
        }
        public void Update(IngredientDTO item)
        {
            Console.WriteLine("Введите название ингредиента");
            item.Title = Console.ReadLine();
        }
        public void PrintOne(IngredientDTO one)
        {
            Console.WriteLine(string.Format("{0, 5}{1, 15}", "ID", "Title\n"));
            Console.WriteLine(string.Format("{0, 5}{1, 15}", one.ID, one.Title));
        }
        public void PrintAll(IEnumerable<IngredientDTO> list)
        {
            Console.WriteLine(string.Format("{0, 5}{1, 15}", "ID", "Title\n"));
            foreach (IngredientDTO one in list)
            {
                Console.WriteLine(string.Format("{0, 5}{1, 15}", one.ID, one.Title));
            }
        }
    }
}
