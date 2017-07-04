using System;
using System.Data.Common;

namespace neggs.db
{
	partial class Extensions
	{

		public static int GetInt(this DbDataReader reader, string columnName)
		{
			int idx = reader.GetOrdinal(columnName);

			if (reader.IsDBNull(idx))
				return 0;

			return reader.GetInt32(idx);
		}

		public static int? GetNInt(this DbDataReader reader, string columnName)
		{
			int idx = reader.GetOrdinal(columnName);

			if (reader.IsDBNull(idx))
				return null;

			return reader.GetInt32(idx);
		}

	}
}
