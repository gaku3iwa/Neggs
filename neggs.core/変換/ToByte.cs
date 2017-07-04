using System;
using System.Globalization;
using Microsoft.VisualBasic;

namespace neggs.core
{
	partial class Extensions
	{

		public static byte ToByte(this string Value)
		{
			return Convert.ToByte(Value.ToDec());
		}

	}
}
