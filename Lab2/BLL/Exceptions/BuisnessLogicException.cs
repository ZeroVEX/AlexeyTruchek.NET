using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Exceptions
{
	public class BuisnessLogicException : Exception
	{
		BuisnessLogicException()
		{

		}
		BuisnessLogicException(string message) : base(message)
		{

		}
	}
}
