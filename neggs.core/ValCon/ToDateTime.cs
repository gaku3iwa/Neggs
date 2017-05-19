using System;
using Microsoft.VisualBasic;

namespace neggs.core
{
  partial class ValCon
  {

    public static System.DateTime ToDateTime(string Value, bool AddDateSlash)
    {
      System.DateTime ReturnValue = System.DateTime.MinValue;
      System.DateTime ErrorValue = System.DateTime.MinValue;
      if (Value == null)
      {
        return ErrorValue;
      }
      if (AddDateSlash && (Information.IsNumeric(Value) || string.IsNullOrEmpty(Value)))
      {
        string DateuValue = Value.Trim();
        string DefDate = System.DateTime.MinValue.ToString("yyyyMMddHHmmss");
        if (DateuValue.Length >= 14)
        {
          DateuValue = Strings.Left(DateuValue, 14);
        }
        else
        {
          DateuValue = DateuValue + Strings.Mid(DefDate, DateuValue.Length + 1);
        }
        DateuValue = Strings.Mid(DateuValue, 0x01, 4) + "/"
                    + Strings.Mid(DateuValue, 0x05, 2) + "/"
                    + Strings.Mid(DateuValue, 0x07, 2) + " "
                    + Strings.Mid(DateuValue, 0x09, 2) + ":"
                    + Strings.Mid(DateuValue, 0x0B, 2) + ":"
                    + Strings.Mid(DateuValue, 0x0D, 2);
        return System.DateTime.TryParse(DateuValue, out ReturnValue) ? ReturnValue : ErrorValue;
      }
      return System.DateTime.TryParse(Value, out ReturnValue) ? ReturnValue : ErrorValue;
    }

    public static System.DateTime ToDateTime(string Value)
    {
      System.DateTime ReturnValue = System.DateTime.MinValue;
      System.DateTime ErrorValue = System.DateTime.MinValue;
      if (Value == null)
      {
        return ErrorValue;
      }
      string DateuValue = Value.Trim();
      string DefDate = System.DateTime.MinValue.ToString("yyyyMMddHHmmss");
      if (Information.IsNumeric(Value) || string.IsNullOrEmpty(Value))
      {
        if (DateuValue.Length >= 14)
        {
          DateuValue = Strings.Left(DateuValue, 14);
        }
        else
        {
          DateuValue = DateuValue + Strings.Mid(DefDate, DateuValue.Length + 1);
        }
        DateuValue = Strings.Mid(DateuValue, 0x01, 4) + "/"
                    + Strings.Mid(DateuValue, 0x05, 2) + "/"
                    + Strings.Mid(DateuValue, 0x07, 2) + " "
                    + Strings.Mid(DateuValue, 0x09, 2) + ":"
                    + Strings.Mid(DateuValue, 0x0B, 2) + ":"
                    + Strings.Mid(DateuValue, 0x0D, 2);
        return System.DateTime.TryParse(DateuValue, out ReturnValue) ? ReturnValue : ErrorValue;
      }
      return System.DateTime.TryParse(Value, out ReturnValue) ? ReturnValue : ErrorValue;
    }

    public static System.DateTime ToDateTime(object Value)
    {
      if (Value == null)
      {
        return System.DateTime.MinValue;
      }
      if (Information.IsDBNull(Value))
      {
        return System.DateTime.MinValue;
      }
      if (Value is string)
      {
        return ToDateTime((string)Value);
      }
      return Convert.ToDateTime(Value);
    }

  }
}