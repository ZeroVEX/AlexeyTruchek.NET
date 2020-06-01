using DAL.Interfaces;
using Lab2;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
	public class Repository<T> : IRepository<T>
		where T : class, IEntity
	{
		private readonly MyDbContext db;
		public Repository(MyDbContext db)
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
			T result = db.Set<T>().FirstOrDefault(item => item.ID == id);
			db.Entry(result).State = EntityState.Detached;
			return result;
		}
		public IEnumerable<T> GetAll()
		{
			return db.Set<T>().ToList();
		}
	}
}
