using System;
using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using neggs.core;
using static System.Console;

namespace neggs.core
{
	public partial class Convert
	{

		[TestMethod]
		public void Numerics_01()
		{
			var s = @"123,456-7890 ０９８７６５４３２１";

			WriteLine("target：" + s);
			WriteLine(s.InNumberChar());
			WriteLine(s.StrConv(VbStrConv.Narrow));
			WriteLine(s.StrConv(VbStrConv.Narrow).InNumberChar().ToDec().ToString());
		}

		[TestMethod]
		public void Numerics_02()
		{
			var s = @"123,456.4999999";

			WriteLine("target：" + s);
			WriteLine(s.ToInt().ToString());
			WriteLine(s.ToLong().ToString());
			WriteLine(s.ToDbl().ToString());
			WriteLine(s.ToDec().ToString());
			WriteLine(s.ToBool().ToString());
		}

		[TestMethod]
		public void Numerics_03()
		{
			var s = @"\-123,456.789";

			WriteLine("target：" + s);
			WriteLine(s.ToInt().ToString());
			WriteLine(s.ToLong().ToString());
			WriteLine(s.ToDbl().ToString());
			WriteLine(s.ToDec().ToString());
			WriteLine(s.ToBool().ToString());
		}

		[TestMethod]
		public void Numerics_04()
		{
			var s = @"0.00";

			WriteLine("target：" + s);
			WriteLine(s.ToInt().ToString());
			WriteLine(s.ToLong().ToString());
			WriteLine(s.ToDbl().ToString());
			WriteLine(s.ToDec().ToString());
			WriteLine(s.ToBool().ToString());
		}

	}
}
