using DAL.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BLL.DTO
{
	public class UserDTO
	{
		public int ID { get; set; }
		public string CompanyName { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }
		public int UserType { get; set; }
		public ICollection<OrderDTO> Orders { get; set; }
	}
}
