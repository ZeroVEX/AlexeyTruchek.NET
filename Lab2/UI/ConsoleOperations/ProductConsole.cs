using BLL.DTO;
using System;
using System.Collections.Generic;
using UI.Interfaces;

namespace UI.ConsoleOperations
{
	public class ProductConsole : IConsole<ProductDTO>
	{
        public ProductDTO Input()
        {
            ProductDTO item = new ProductDTO();
            Console.WriteLine("Введите название продукта");
            item.Title = Console.ReadLine();
            return item;
        }
        public int InputID()
        {
            Console.WriteLine("Введите ID продукта");
            return Int32.Parse(Console.ReadLine());
        }
        public void Update(ProductDTO item)
        {
            Console.WriteLine("Введите название продукта");
            item.Title = Console.ReadLine();
        }
        public void PrintOne(ProductDTO one)
        {
            Console.WriteLine(string.Format("{0, 5}{1, 15}", "ID", "Title\n"));
            Console.WriteLine(string.Format("{0, 5}{1, 15}", one.ID, one.Title));
        }
        public void PrintAll(IEnumerable<ProductDTO> list)
        {
            Console.WriteLine(string.Format("{0, 5}{1, 15}", "ID", "Title\n"));
            foreach (ProductDTO one in list)
            {
                Console.WriteLine(string.Format("{0, 5}{1, 15}", one.ID, one.Title));
            }
        }
    }
}
