using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using neggs.web;
using static System.Console;
using static neggs.UT.Constant;

namespace neggs.UT
{

	partial class Db4Ws
	{

		[TestMethod]
		public void DatabaseSize_ws()
		{
			dbioResultOfTableInfo result = ws.DatabaseSize();
			WriteLine("+---------------+------------+----------+----------+----------+----------+");
			WriteLine("|TABLE NAME     |レコード数  |予約  [KB]|DATA  [KB]|INDEX [KB]|未使用[KB]|");
			WriteLine("+---------------+------------+----------+----------+----------+----------+");
			foreach (var i in result.List)
			{
				if (i.marker == 1) BackgroundColor = ConsoleColor.DarkGreen;
				WriteLine($"|{i.name,-15}|{i.rows,12:#,0}|{i.reserved,10:#,0}|{i.dat_size,10:#,0}|{i.idx_size,10:#,0}|{i.unused,10:#,0}|");
				ResetColor();
			}
			WriteLine("+---------------+------------+----------+----------+----------+----------+");
			Assert.AreEqual(result.IsSuccess, true);
		}

	}

}
