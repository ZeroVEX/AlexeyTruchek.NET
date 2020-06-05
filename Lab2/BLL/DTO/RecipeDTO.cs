using BLL.Interfaces;
using DAL.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace BLL.DTO
{
	public class RecipeDTO : IModel
	{
		public int ID { get; set; }
		public int IngredientID { get; set; }
		public int ProductID { get; set; }
		public double Quantity { get; set; }
		public ProductDTO Product { get; set; }
		public IngredientDTO Ingredient { get; set; }
	}
}
