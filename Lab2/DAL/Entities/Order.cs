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
		public Order(int UserID, int ProductID, int Quantity, DateTime Date)
		{
			this.UserID = UserID;
			this.ProductID = ProductID;
			this.Quantity = Quantity;
			this.Date = Date;
		}
		public Order()
		{

		}
	}
}
