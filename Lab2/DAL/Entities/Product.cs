using DAL.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
	public class Product : IEntity
	{
		[Key]
		public int ID { get; set; }
		[Required]
		public string Title { get; set; }
		public ICollection<Recipe> Recipes { get; set; }
		public ICollection<Order> Orders { get; set; }
		public Product()
		{

		}
	}
}
