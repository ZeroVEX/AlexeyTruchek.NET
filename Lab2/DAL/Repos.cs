using DAL.Interfaces;
using Lab2;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
	public class Repos<T> : IRepository<T>
		where T : class, IEntity
	{
		private readonly MyDbContext db;
		public Repos(MyDbContext db)
		{
			this.db = db;
		}
		public void Add(T item)
		{
			db.Set<T>().Add(item);
			db.SaveChanges();
		}
		public void Delete(T item)
		{
			db.Set<T>().Remove(item);
			db.SaveChanges();
		}
		public void Update(T item)
		{
			db.Entry(item).State = EntityState.Modified;
			db.SaveChanges();
		}
		public T GetByID(int id)
		{
			return db.Set<T>().FirstOrDefault(item => item.ID == id);
		}
		public IEnumerable<T> GetAll()
		{
			return db.Set<T>().ToList();
		}
	}
}
