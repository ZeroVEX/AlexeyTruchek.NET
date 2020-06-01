using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Interfaces
{
	public interface IConsole<T>
	{
		T Input();
		int InputID();
		void Update(T item);
		void PrintOne(T one);
		void PrintAll(IEnumerable<T> list);
	}
}
