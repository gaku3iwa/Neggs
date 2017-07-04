using System;
using System.Data.Common;

namespace neggs.db
{
	partial class Extensions
	{

		public static DateTime GetDate(this DbDataReader reader, string columnName)
		{
			return reader.GetDateTime(columnName).Date;
		}

		public static DateTime? GetNDate(this DbDataReader reader, string columnName)
		{
			DateTime? dt = reader.GetNDateTime(columnName);

			if (dt != null)
				return dt.Value.Date;

			return dt;
		}

	}
}
