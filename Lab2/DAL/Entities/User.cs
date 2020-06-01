using DAL.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
	public class User : IEntity
	{
		[Key]
		public int ID { get; set; }
		[Required]
		[MaxLength(20)]
		public string CompanyName { get; set; }
		[Required]
		[MaxLength(20)]
		public string Login { get; set; }
		[Required]
		[MaxLength(20)]
		public string Password { get; set; }
		public int UserType { get; set; }
		public ICollection<Order> Orders { get; set; }
	}
}
