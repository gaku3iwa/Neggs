using System;
using System.Collections.Generic;
using System.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using neggs.core;
using neggs.web;
using static System.Console;

namespace neggs.db
{

  partial class db
  {

    [TestMethod]
    public void UT01_ConnectionString()
    {
      WriteLine($"ConnectionString:[{dbc.ConnectionString}]");
    }

    [TestMethod]
    public void UT02_ProviderName()
    {
      WriteLine($"ProviderName:[{dbc.ProviderName}]");
    }

    [TestMethod]
    public void UT03_DatabaseSize()
    {
      List<TableInfo> result = DatabaseSize(dbc.ConnectionString, dbc.ProviderName);
      WriteLine("+---------------+------------+----------+----------+----------+----------+");
      WriteLine("|TABLE NAME     |レコード数  |予約  [KB]|DATA  [KB]|INDEX [KB]|未使用[KB]|");
      WriteLine("+---------------+------------+----------+----------+----------+----------+");
      foreach (var i in result)
      {
        if (i.marker == 1) BackgroundColor = ConsoleColor.DarkGreen;
        WriteLine($"|{i.name,-15}|{i.rows,12:#,0}|{i.reserved,10:#,0}|{i.dat_size,10:#,0}|{i.idx_size,10:#,0}|{i.unused,10:#,0}|");
        ResetColor();
      }
      WriteLine("+---------------+------------+----------+----------+----------+----------+");
      Assert.AreNotEqual(result, null);
    }

    /*
		[TestMethod]
		public void DatabaseSize_cs_setting_by_ws()
		{
			string connectionString = ws.ConnectionString().Comments;
			string providerName = ws.ProviderName().Comments;
			List<TableInfo> result = DatabaseSize(connectionString, providerName);
			WriteLine("+---------------+------------+----------+----------+----------+----------+");
			WriteLine("|TABLE NAME     |レコード数  |予約  [KB]|DATA  [KB]|INDEX [KB]|未使用[KB]|");
			WriteLine("+---------------+------------+----------+----------+----------+----------+");
			foreach (var i in result)
			{
				if (i.marker == 1) BackgroundColor = ConsoleColor.DarkGreen;
				WriteLine($"|{i.name,-15}|{i.rows,12:#,0}|{i.reserved,10:#,0}|{i.dat_size,10:#,0}|{i.idx_size,10:#,0}|{i.unused,10:#,0}|");
				ResetColor();
			}
			WriteLine("+---------------+------------+----------+----------+----------+----------+");
			Assert.AreNotEqual(result, null);
		}
    */

    public static List<TableInfo> DatabaseSize(string connectionString, string providerName)
    {
      List<TableInfo> result = new List<TableInfo>();

      string query = Const.DatabaseSizeQuery;

      DBC dbc = new DBC(connectionString, providerName);
      try
      {
        dbc.Open();
        using (DbDataReader reader = dbc.ExecuteReader(query))
        {
          while (reader.Read())
          {
            TableInfo tmp = new TableInfo();
            {
              //-------------------------------------------------
              //  TableInfo
              tmp.marker    = reader.GetInt ("L1          ".Trim());
              tmp.schema    = reader.GetStr ("NAME_SCHEMA ".Trim());
              tmp.name      = reader.GetStr ("NAME_TABLE  ".Trim());
              tmp.rows      = reader.GetLong("ROW_COUNT   ".Trim());
              tmp.reserved  = reader.GetLong("RESERVED    ".Trim());
              tmp.dat_size  = reader.GetLong("DATA_SIZE   ".Trim());
              tmp.idx_size  = reader.GetLong("INDEX_SIZE  ".Trim());
              tmp.unused    = reader.GetLong("UNUSED      ".Trim());
            }
            result.Add(tmp);
          }
        }
      }
      catch (Exception)
      {
        ;
      }
      finally
      {
        dbc.Dispose();
      }
      return result;
    }

  }
}
