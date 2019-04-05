using System;
using Microsoft.VisualBasic;

namespace neggs.core
{
  partial class ValCon
  {

    public static string ToStringEmpty(byte Value)
    {
      if (Value == 0)
      {
        return "";
      }
      string tmp = Convert.ToString(Value);
      return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
    }

    public static string ToStringEmpty(byte Value, string Format)
    {
      if (Value == 0)
      {
        return "";
      }
      string tmp = Value.ToString(Format);
      return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
    }

    public static string ToStringEmpty(short Value)
    {
      if (Value == 0)
      {
        return "";
      }
      string tmp = Convert.ToString(Value);
      return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
    }

    public static string ToStringEmpty(short Value, string Format)
    {
      if (Value == 0)
      {
        return "";
      }
      string tmp = Value.ToString(Format);
      return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
    }

    public static string ToStringEmpty(long Value)
    {
      if (Value == 0)
      {
        return "";
      }
      string tmp = Convert.ToString(Value);
      return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
    }

    public static string ToStringEmpty(long Value, string Format)
    {
      if (Value == 0)
      {
        return "";
      }
      string tmp = Value.ToString(Format);
      return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
    }

    public static string ToStringEmpty(int Value)
    {
      if (Value == 0)
      {
        return "";
      }
      string tmp = Convert.ToString(Value);
      return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
    }

    public static string ToStringEmpty(int Value, string Format)
    {
      if (Value == 0)
      {
        return "";
      }
      string tmp = Value.ToString(Format);
      return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
    }

    public static string ToStringEmpty(float Value)
    {
      if (Value == 0)
      {
        return "";
      }
      string tmp = Convert.ToString(Value);
      return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
    }

    public static string ToStringEmpty(float Value, string Format)
    {
      if (Value == 0)
      {
        return "";
      }
      string tmp = Value.ToString(Format);
      return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
    }

    public static string ToStringEmpty(double Value)
    {
      if (Value == 0)
      {
        return "";
      }
      string tmp = Convert.ToString(Value);
      return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
    }

    public static string ToStringEmpty(double Value, string Format)
    {
      if (Value == 0)
      {
        return "";
      }
      string tmp = Value.ToString(Format);
      return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
    }

    public static string ToStringEmpty(decimal Value)
    {
      if (Value == 0)
      {
        return "";
      }
      string tmp = Convert.ToString(Value);
      return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
    }

    public static string ToStringEmpty(decimal Value, string Format)
    {
      if (Value == 0)
      {
        return "";
      }
      string tmp = Value.ToString(Format);
      return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
    }

    public static string ToStringEmpty(string Value)
    {
      string tmp = Convert.ToString(Value);
      return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
    }

    public static string ToStringEmpty(DateTime Value, string Format)
    {
      if (Value == DateTime.MinValue)
      {
        return "";
      }
      string tmp = Value.ToString(Format);
      return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
    }

    public static string ToStringEmpty(DateTime Value)
    {
      if (Value == DateTime.MinValue)
      {
        return "";
      }
      string tmp = Value.ToString();
      return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
    }

    public static string ToStringEmpty(DateTime Value, bool DateSlash)
    {
      if (Value == DateTime.MinValue)
      {
        return "";
      }
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

  }
}
