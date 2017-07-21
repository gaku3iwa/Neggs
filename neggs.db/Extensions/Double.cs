using System;
using System.Data.Common;

namespace neggs.db
{
  partial class Extensions
  {

    public static double GetDouble(this DbDataReader reader, string columnName)
    {
      int idx = reader.GetOrdinal(columnName);

      if (reader.IsDBNull(idx))
        return 0;

      return reader.GetDouble(idx);
    }

    public static Nullable<double> GetNullableDouble(this DbDataReader reader, string columnName)
    {
      int idx = reader.GetOrdinal(columnName);

      if (reader.IsDBNull(idx))
        return null;

      return reader.GetDouble(idx);
    }

  }
}
