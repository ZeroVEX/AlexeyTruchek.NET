using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
	public interface IModelMapper
	{
		TModel Map<T, TModel>(T item);
	}
}
