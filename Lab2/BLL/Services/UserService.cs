using BLL.DTO;
using BLL.Exceptions;
using BLL.Interfaces;
using BLL.Validators;
using DAL;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Services
{
	public class UserService : GenericService<UserDTO, User>
	{
		private readonly IRepository<User> CrudUser;
		public UserService()
		{
			this.CrudUser = new Repos<User>(new MyDbContext());
		}
		public void Add(User user)
		{
			CrudUser.Add(user);
		}
		public void Delete(int id)
		{
			User user = GetAll().FirstOrDefault(t => t.ID == id);
			CrudUser.Delete(user);
		}
		public void Update(int id, User item)
		{
			User user = GetAll().FirstOrDefault(t => t.ID == id);
			user.Login = item.Login;
			user.Password = item.Password;
			user.CompanyName = item.CompanyName;
			CrudUser.Update(user);
		}
		public User GetByID(int id)
		{
			return CrudUser.GetByID(id);
		}
		public IEnumerable<User> GetAll()
		{
			return CrudUser.GetAll();
		}
	}
}
