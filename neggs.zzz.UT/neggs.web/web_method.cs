using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Console;

namespace neggs.web
{

	partial class web
	{

    [TestMethod]
    public void UT01_ConnectionString()
    {
      dbioResult result = ws.ConnectionString();
      WriteLine($"ConnectionString:[{result.Comments}]");
      Assert.AreEqual(result.IsSuccess, true);
    }

    [TestMethod]
    public void UT02_ProviderName()
    {
      dbioResult result = ws.ProviderName();
      WriteLine($"ProviderName:[{result.Comments}]");
      Assert.AreEqual(result.IsSuccess, true);
    }

    [TestMethod]
		public void UT03_DatabaseSize()
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
