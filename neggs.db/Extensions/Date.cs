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

    public static Nullable<DateTime> GetNullableDate(this DbDataReader reader, string columnName)
    {
      Nullable<DateTime> dt = reader.GetNullableDateTime(columnName);

      if (dt != null)
        return dt.Value.Date;

      return dt;
    }

  }
}
