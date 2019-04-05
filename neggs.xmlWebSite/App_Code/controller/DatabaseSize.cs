using System;
using System.Data.Common;
using System.Web.Services;
using neggs.core;
using neggs.db;

public partial class Services
{
	public class TableInfo
	{
		public int    marker   { get; set; } = 0;
		public string schema   { get; set; } = string.Empty;
		public string name     { get; set; } = string.Empty;
		public long   rows     { get; set; } = 0;
		public long   reserved { get; set; } = 0;
		public long   dat_size { get; set; } = 0;
		public long   idx_size { get; set; } = 0;
		public long   unused   { get; set; } = 0;
	}

	[WebMethod]
	public dbioResult<TableInfo> DatabaseSize()
	{
		dbioResult<TableInfo> result = new dbioResult<TableInfo>();

		string query = Const.DatabaseSizeQuery;

		DBC dbc = new DBC();
		try
		{
			dbc.Open();
			DbDataReader reader = dbc.ExecuteReader(query);
			try
			{
				while (reader.Read())
				{
					TableInfo tmp = new TableInfo();
					{
						//-----------------------------------------------------------------
						//  TableInfo
						tmp.marker   = reader.GetInt ("L1          ".Trim());
						tmp.schema   = reader.GetStr ("NAME_SCHEMA ".Trim());
						tmp.name     = reader.GetStr ("NAME_TABLE  ".Trim());
						tmp.rows     = reader.GetLong("ROW_COUNT   ".Trim());
						tmp.reserved = reader.GetLong("RESERVED    ".Trim());
						tmp.dat_size = reader.GetLong("DATA_SIZE   ".Trim());
						tmp.idx_size = reader.GetLong("INDEX_SIZE  ".Trim());
						tmp.unused   = reader.GetLong("UNUSED      ".Trim());
					}
					result.List.Add(tmp);
				}
			}
			finally
			{
				if (!reader.IsClosed)
					reader.Close();
			}
		}
		catch (Exception ex)
		{
			result.HappenError(ex);
		}
		finally
		{
			dbc.Dispose();
		}
		return result;
	}

}
