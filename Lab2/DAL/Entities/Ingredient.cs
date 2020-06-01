using DAL.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
	public class Ingredient : IEntity
	{
		[Key]
		public int ID { get; set; }
		[Required]
		public string Title { get; set; }
		public ICollection<Recipe> Recipes { get; set; }
		public Ingredient(string Title)
		{
			this.Title = Title;
		}
		public Ingredient()
		{

		}
	}
}
