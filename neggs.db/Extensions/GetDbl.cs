using System;
using System.Data.Common;

namespace neggs.db
{
  partial class Extensions
  {

    public static double GetDbl(this DbDataReader reader, string columnName)
    {
      int idx = reader.GetOrdinal(columnName);

      if (reader.IsDBNull(idx))
        return 0;

      return reader.GetDouble(idx);
    }

    public static double? GetNDbl(this DbDataReader reader, string columnName)
    {
      int idx = reader.GetOrdinal(columnName);

      if (reader.IsDBNull(idx))
        return null;

      return reader.GetDouble(idx);
    }

  }
}
