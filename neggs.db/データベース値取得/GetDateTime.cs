using System;
using System.Data.Common;

namespace neggs.db
{
	partial class Extensions
	{

		public static DateTime GetDateTime(this DbDataReader reader, string columnName)
		{
			int idx = reader.GetOrdinal(columnName);

			if (reader.IsDBNull(idx))
				return DateTime.MinValue;

			return reader.GetDateTime(idx);
		}

		public static DateTime? GetNDateTime(this DbDataReader reader, string columnName)
		{
			int idx = reader.GetOrdinal(columnName);

			if (reader.IsDBNull(idx))
				return null;

			return reader.GetDateTime(idx);
		}

	}
}
