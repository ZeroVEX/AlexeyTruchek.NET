using DAL.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
	public class Order : IEntity
	{
		[Key]
		public int ID { get; set; }
		[Required]
		public int UserID { get; set; }
		[Required]
		public int ProductID { get; set; }
		[Required]
		public int Quantity { get; set; }
		public DateTime Date { get; set; }
		public User User { get; set; }
		public Product Product { get; set; }
	}
}
