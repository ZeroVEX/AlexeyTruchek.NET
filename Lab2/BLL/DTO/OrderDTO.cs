using DAL.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace BLL.DTO
{
	public class OrderDTO
	{
		public int ID { get; set; }
		public int UserID { get; set; }
		public int ProductID { get; set; }
		public int Quantity { get; set; }
		public DateTime Date { get; set; }
		public UserDTO User { get; set; }
		public ProductDTO Product { get; set; }
		public OrderDTO()
		{

		}
	}
}
