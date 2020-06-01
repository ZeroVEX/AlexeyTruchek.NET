using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
	public class MyDbContext : DbContext
	{
		public MyDbContext()
		{
			//Database.EnsureCreated();
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocaldb;Database=SICLabs;Trusted_Connection=True;");
		}
		public DbSet<User> Users { get; set; }
		public DbSet<Recipe> Recipes { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Ingredient> Ingredients { get; set; }
	}
}
