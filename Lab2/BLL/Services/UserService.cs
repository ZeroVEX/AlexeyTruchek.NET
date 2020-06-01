using BLL.DTO;
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
		public UserService()
		{
		}
	}
}
