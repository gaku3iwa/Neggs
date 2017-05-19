using System;
using System.Data.Common;

namespace neggs.db
{
  partial class Extensions
  {

    public static int GetInteger(this DbDataReader reader, string columnName)
    {
      int idx = reader.GetOrdinal(columnName);

      if (reader.IsDBNull(idx))
        return 0;

      return reader.GetInt32(idx);
    }

    public static Nullable<int> GetNullableInteger(this DbDataReader reader, string columnName)
    {
      int idx = reader.GetOrdinal(columnName);

      if (reader.IsDBNull(idx))
        return null;

      return reader.GetInt32(idx);
    }

  }
}
