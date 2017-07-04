using System;
using System.Collections.Generic;
using System.Data.Common;
using neggs.db;
using neggs.web;
using static neggs.db.Constant;

namespace neggs.UT
{
	public static partial class Constant
	{

		private static Lazy<DBC> _dbc = new Lazy<DBC>(() => new DBC());
		public static DBC dbc => _dbc.Value;
		public static Services ws => Services.GetInstance();

		public static List<TableInfo> DatabaseSize(string connectionString, string providerName)
		{
			List<TableInfo> result = new List<TableInfo>();

			string query = DatabaseSizeQuery;

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
							tmp.marker   = reader.GetInt("L1          ".Trim());
							tmp.schema   = reader.GetStr("NAME_SCHEMA ".Trim());
							tmp.name     = reader.GetStr("NAME_TABLE  ".Trim());
							tmp.rows     = reader.GetLong("ROW_COUNT   ".Trim());
							tmp.reserved = reader.GetLong("RESERVED    ".Trim());
							tmp.dat_size = reader.GetLong("DATA_SIZE   ".Trim());
							tmp.idx_size = reader.GetLong("INDEX_SIZE  ".Trim());
							tmp.unused   = reader.GetLong("UNUSED      ".Trim());
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
