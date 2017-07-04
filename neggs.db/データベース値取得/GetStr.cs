using System;
using System.Data.Common;

namespace neggs.db
{
	partial class Extensions
	{

		public static string GetStr(this DbDataReader reader, string columnName)
		{
			int idx = reader.GetOrdinal(columnName);

			if (reader.IsDBNull(idx))
				return string.Empty;

			return reader.GetString(idx);
		}

		public static string GetNStr(this DbDataReader reader, string columnName)
		{
			int idx = reader.GetOrdinal(columnName);

			if (reader.IsDBNull(idx))
				return null;

			return reader.GetString(idx);
		}

	}
}
