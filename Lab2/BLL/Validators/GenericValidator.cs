using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Validators
{
	public static class GenericValidator<T>
	{
		public static void Validate(T entity)
		{
			if (entity == null)
				throw new NullReferenceException();
		}
	}
}
