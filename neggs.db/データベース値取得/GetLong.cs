using System;
using System.Data.Common;

namespace neggs.db
{
	partial class Extensions
	{

		public static long GetLong(this DbDataReader reader, string columnName)
		{
			int idx = reader.GetOrdinal(columnName);

			if (reader.IsDBNull(idx))
				return 0;

			if (reader.GetDataTypeName(idx).ToLower() == "int")
				return reader.GetInt32(idx);
			else
				return reader.GetInt64(idx);
		}

		public static long? GetNLong(this DbDataReader reader, string columnName)
		{
			int idx = reader.GetOrdinal(columnName);

			if (reader.IsDBNull(idx))
				return null;

			if (reader.GetDataTypeName(idx).ToLower() == "int")
				return reader.GetInt32(idx);
			else
				return reader.GetInt64(idx);
		}

	}
}
