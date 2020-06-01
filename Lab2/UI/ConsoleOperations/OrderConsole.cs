using BLL.DTO;
using System;
using System.Collections.Generic;

namespace UI.ConsoleOperations
{
	public class OrderConsole
	{
        public IEnumerable<OrderDTO> Input()
        {
            List<OrderDTO> list = new List<OrderDTO>();
            Console.WriteLine("Сколько продуктов будете заказывать");
            int count = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите ID пользователя");
            int userID = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                OrderDTO item = new OrderDTO();
                Console.WriteLine("Введите ID продукта");
                int prodID = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество продукта");
                int quant = Int32.Parse(Console.ReadLine());
                item.UserID = userID;
                item.ProductID = prodID;
                item.Quantity = quant;
                item.Date = DateTime.Now;
                list.Add(item);
            }
            return list;
        }
        public int InputID()
        {
            Console.WriteLine("Введите ID заказа");
            return Int32.Parse(Console.ReadLine());
        }
        public int InputUserID()
        {
            Console.WriteLine("Введите ID пользователя");
            return Int32.Parse(Console.ReadLine());
        }
        public void Update(OrderDTO item)
        {
            Console.WriteLine("Введите ID пользователя");
            item.UserID = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите ID продукта");
            item.ProductID = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество продукта");
            item.Quantity = Int32.Parse(Console.ReadLine());
        }
        public void PrintAll(IEnumerable<OrderDTO> list)
        {
            Console.WriteLine(string.Format("{0, 5}{1, 15}{2, 15}{3, 15}{4, 15}", "ID",
                "UserID", "ProductID", "Date", "Quantity\n"));
            foreach (OrderDTO one in list)
            {
                Console.WriteLine(string.Format("{0, 5}{1, 15}{2, 15}{3, 15}{4, 15}",
                    one.ID, one.UserID, one.ProductID, one.Quantity, one.Date));
            }
        }
    }
}
