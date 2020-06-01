using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using UI.Interfaces;

namespace UI.ConsoleOperations
{
	public class UserConsole : IConsole<User>
	{
        public User Input()
        {
            User user = new User();
            Console.WriteLine("Введите логин");
            user.Login = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            user.Password = Console.ReadLine();
            Console.WriteLine("Введите название компании пользователя");
            user.CompanyName = Console.ReadLine();
            user.UserType = 1;
            return user;
        }
        public int InputID()
        {
            Console.WriteLine("Введите ID пользователя");
            return Int32.Parse(Console.ReadLine());
        }
        public void PrintOne(User one)
        {
            Console.WriteLine(string.Format("{0, 5}{1, 15}{2, 15}{3, 15}", "ID", "Login", "Password", "Company name\n"));
            Console.WriteLine(string.Format("{0, 5}{1, 15}{2, 15}{3, 15}", one.ID, one.Login, one.Password, one.CompanyName));
        }
        public void PrintAll(IEnumerable<User> list)
        {
            Console.WriteLine(string.Format("{0, 5}{1, 15}{2, 15}{3, 15}", "ID", "Login", "Password", "Company name\n"));
            foreach (User one in list)
			{
                Console.WriteLine(string.Format("{0, 5}{1, 15}{2, 15}{3, 15}", one.ID, one.Login, one.Password, one.CompanyName));
            }
        }
    }
}
