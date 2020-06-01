using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
	public interface IService<T>
	{
		void Add(T item);
		void Delete(int id);
		void Update(int id, T item);
		T GetByID(int id);
		IEnumerable<T> GetAll();
	}
}
