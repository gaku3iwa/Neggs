using System;
using System.Data.Common;

namespace neggs.db
{
  partial class Extensions
  {

    public static decimal GetDec(this DbDataReader reader, string columnName)
    {
      int idx = reader.GetOrdinal(columnName);

      if (reader.IsDBNull(idx))
        return 0;

      return reader.GetDecimal(idx);
    }

    public static decimal? GetNDec(this DbDataReader reader, string columnName)
    {
      int idx = reader.GetOrdinal(columnName);

      if (reader.IsDBNull(idx))
        return null;

      return reader.GetDecimal(idx);
    }

  }
}
