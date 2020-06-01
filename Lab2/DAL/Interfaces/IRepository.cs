using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
	public interface IRepository<T>
	{
		void Add(T item);
		void Delete(T item);
		void Update(T item);
		T GetByID(int id);
		IEnumerable<T> GetAll();
	}
}
