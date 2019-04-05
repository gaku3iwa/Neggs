using System;
using Microsoft.VisualBasic;

namespace neggs.core
{
  partial class ValCon
  {

    public static string ToString(bool Value)
    {
      string tmp = Convert.ToString(Value);
      return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
    }

    public static string ToString(char Value)
    {
      string tmp = Convert.ToString(Value);
      return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
    }

    public static string ToString(byte Value)
    {
      string tmp = Convert.ToString(Value);
      return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
    }

    public static string ToString(short Value)
    {
      string tmp = Convert.ToString(Value);
      return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
    }

    public static string ToString(long Value)
    {
      string tmp = Convert.ToString(Value);
      return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
    }

    public static string ToString(long Value, string Format)
    {
      return Value.ToString(Format);
    }

    public static string ToString(int Value)
    {
      string tmp = Convert.ToString(Value);
      return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
    }

    public static string ToString(int Value, string Format)
    {
      return Value.ToString(Format);
    }

    public static string ToString(float Value)
    {
      string tmp = Convert.ToString(Value);
      return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
    }

    public static string ToString(float Value, string Format)
    {
      return Value.ToString(Format);
    }

    public static string ToString(double Value)
    {
      string tmp = Convert.ToString(Value);
      return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
    }

    public static string ToString(double Value, string Format)
    {
      return Value.ToString(Format);
    }

    public static string ToString(decimal Value)
    {
      string tmp = Convert.ToString(Value);
      return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
    }

    public static string ToString(decimal Value, string Format)
    {
      return Value.ToString(Format);
    }

    public static string ToString(string Value)
    {
      string tmp = Convert.ToString(Value);
      return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
    }

    public static string ToString(DateTime Value, string Format)
    {
      string tmp = Value.ToString(Format);
      return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
    }

    public static string ToString(DateTime Value)
    {
      string tmp = Value.ToString();
      return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
    }

    public static string ToString(DateTime Value, bool DateSlash)
    {
      if (DateSlash == false)
      {
        string tmp = Value.ToString("yyyyMMddHHmmss");
        return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
      }
      else
      {
        string tmp = Value.ToString();
        return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
      }
    }

    public static string ToString(object Value)
    {
      return ToString(Value, true);
    }

    public static string ToString(object Value, bool AddDateSlash)
    {
      if (Information.IsDBNull(Value))
      {
        return "";
      }
      if (Value == null)
      {
        return "";
      }
      if (AddDateSlash == false)
      {
        DateTime TmpDate = default(DateTime);
        if (Value is DateTime)
        {
          TmpDate = (DateTime)Value;
          string tmp = TmpDate.ToString("yyyyMMddHHmmss");
          return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
        }
        if (Value is System.DateTime)
        {
          TmpDate = Convert.ToDateTime(Value);
          string tmp = TmpDate.ToString("yyyyMMddHHmmss");
          return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
        }
        if (Information.IsDate(Value))
        {
          TmpDate = Convert.ToDateTime(Value);
          string tmp = TmpDate.ToString("yyyyMMddHHmmss");
          return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
        }
      }
      string tmp2 = Convert.ToString(Value);
      return tmp2.Replace(Strings.ChrW(12316).ToString(), "～");
    }

  }
}
