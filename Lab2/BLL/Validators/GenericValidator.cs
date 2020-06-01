using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Validators
{
	public class GenericValidator<T> : IValidator<T>
	{
		public void Validate(T entity)
		{
			if (entity == null)
				throw new NullReferenceException();
		}
	}
}
