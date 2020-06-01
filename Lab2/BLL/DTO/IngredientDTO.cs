using DAL.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BLL.DTO
{
	public class IngredientDTO
	{
		public int ID { get; set; }
		public string Title { get; set; }
		public ICollection<RecipeDTO> Recipes { get; set; }
		public IngredientDTO(string Title)
		{
			this.Title = Title;
		}
	}
}
