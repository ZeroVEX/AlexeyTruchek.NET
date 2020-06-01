using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using UI.Interfaces;

namespace UI.ConsoleOperations
{
	public class UserConsole : IConsole<UserDTO>
	{
        public UserDTO Input()
        {
            UserDTO item = new UserDTO();
            Console.WriteLine("Введите логин");
            item.Login = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            item.Password = Console.ReadLine();
            Console.WriteLine("Введите название компании пользователя");
            item.CompanyName = Console.ReadLine();
            item.UserType = 1;
            return item;
        }
        public int InputID()
        {
            Console.WriteLine("Введите ID пользователя");
            return Int32.Parse(Console.ReadLine());
        }
        public void Update(UserDTO item)
		{
            Console.WriteLine("Введите логин");
            item.Login = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            item.Password = Console.ReadLine();
            Console.WriteLine("Введите название компании пользователя");
            item.CompanyName = Console.ReadLine();
        }
        public void PrintOne(UserDTO one)
        {
            Console.WriteLine(string.Format("{0, 5}{1, 15}{2, 15}{3, 15}", "ID", "Login", "Password", "Company name\n"));
            Console.WriteLine(string.Format("{0, 5}{1, 15}{2, 15}{3, 15}", one.ID, one.Login, one.Password, one.CompanyName));
        }
        public void PrintAll(IEnumerable<UserDTO> list)
        {
            Console.WriteLine(string.Format("{0, 5}{1, 15}{2, 15}{3, 15}", "ID", "Login", "Password", "Company name\n"));
            foreach (UserDTO one in list)
			{
                Console.WriteLine(string.Format("{0, 5}{1, 15}{2, 15}{3, 15}", one.ID, one.Login, one.Password, one.CompanyName));
            }
        }
    }
}
