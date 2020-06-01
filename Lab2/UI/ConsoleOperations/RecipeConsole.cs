using BLL.DTO;
using System;
using System.Collections.Generic;

namespace UI.ConsoleOperations
{
	public class RecipeConsole
	{
        public IEnumerable<RecipeDTO> Input()
        {
            List<RecipeDTO> list = new List<RecipeDTO>();
            Console.WriteLine("Сколько ингредиентов будет в продукте");
            int count = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите ID продукта");
            int prodID = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
			{
                RecipeDTO item = new RecipeDTO();
                Console.WriteLine("Введите ID ингредиента");
                int ingID = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество ингредиента");
                int quant = Int32.Parse(Console.ReadLine());
                item.ProductID = prodID;
                item.IngredientID = ingID;
                item.Quantity = quant;
                list.Add(item);
            }
            return list;
        }
        public int InputID()
        {
            Console.WriteLine("Введите ID рецепта");
            return Int32.Parse(Console.ReadLine());
        }
        public int InputProductID()
        {
            Console.WriteLine("Введите ID продукта");
            return Int32.Parse(Console.ReadLine());
        }
        public void Update(RecipeDTO item)
        {
            Console.WriteLine("Введите ID продукта");
            item.ProductID = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите ID ингредиента");
            item.IngredientID = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество ингредиента");
            item.Quantity = Int32.Parse(Console.ReadLine());
        }
        public void PrintAll(IEnumerable<RecipeDTO> list)
        {
            Console.WriteLine(string.Format("{0, 5}{1, 15}{2, 15}{3, 15}", "ID", "ProductID", "IngredientID", "Quantity\n"));
            foreach (RecipeDTO one in list)
            {
                Console.WriteLine(string.Format("{0, 5}{1, 15}{2, 15}{3, 15}", one.ID, one.ProductID, one.IngredientID, one.Quantity));
            }
        }
    }
}
