using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using neggs.core;
using static System.Console;

namespace neggs.core
{
  [TestClass]
  public class ToEra
  {

    [TestMethod]
    public void ToEra_00_江戸時代()
    {
      var dt = "1868/9/7";
      var a = dt.ToDate().ToEra();
      System.Diagnostics.Debug.WriteLine($"{dt} → {a.Era}{a.Year}年");
      //  Windows は、1868/9/8 以降の元号しか対応していないので、
      //  元号変換できなかった時は、空文字が返却される仕様
      Assert.AreEqual(a.Era, string.Empty);
      Assert.AreEqual(a.Year, string.Empty);
    }

    [TestMethod]
    public void ToEra_01_明治元年()
    {
      var dt = "1868/9/8";
      var a = dt.ToDate().ToEra();
      System.Diagnostics.Debug.WriteLine($"{dt} → {a.Era}{a.Year}年");
      //Assert.AreEqual(a.Era, "明治");
      //Assert.AreEqual(a.Year, "元");
      CultureInfo culture = new CultureInfo("ja-JP", true);
      culture.DateTimeFormat.Calendar = new JapaneseCalendar();
      Assert.AreEqual(a.Era, dt.ToDate().ToString("gg", culture));
      Assert.AreEqual(a.Year, "元");
    }

    [TestMethod]
    public void ToEra_02_明治45年()
    {
      var dt = "1912/7/29";
      var a = dt.ToDate().ToEra();
      System.Diagnostics.Debug.WriteLine($"{dt} → {a.Era}{a.Year}年");
      //Assert.AreEqual(a.Era, "明治");
      //Assert.AreEqual(a.Year, "45");
      CultureInfo culture = new CultureInfo("ja-JP", true);
      culture.DateTimeFormat.Calendar = new JapaneseCalendar();
      Assert.AreEqual(a.Era, dt.ToDate().ToString("gg", culture));
      Assert.AreEqual(a.Year.StrConv(Microsoft.VisualBasic.VbStrConv.Narrow).ToInt()
                    , dt.ToDate().ToString("yy", culture).ToInt());
    }

    [TestMethod]
    public void ToEra_11_大正元年()
    {
      var dt = "1912/7/30";
      var a = dt.ToDate().ToEra();
      System.Diagnostics.Debug.WriteLine($"{dt} → {a.Era}{a.Year}年");
      //Assert.AreEqual(a.Era, "大正");
      //Assert.AreEqual(a.Year, "元");
      CultureInfo culture = new CultureInfo("ja-JP", true);
      culture.DateTimeFormat.Calendar = new JapaneseCalendar();
      Assert.AreEqual(a.Era, dt.ToDate().ToString("gg", culture));
      Assert.AreEqual(a.Year, "元");
    }

    [TestMethod]
    public void ToEra_12_大正15年()
    {
      var dt = "1926/12/24";
      var a = dt.ToDate().ToEra();
      System.Diagnostics.Debug.WriteLine($"{dt} → {a.Era}{a.Year}年");
      //Assert.AreEqual(a.Era, "大正");
      //Assert.AreEqual(a.Year, "15");
      CultureInfo culture = new CultureInfo("ja-JP", true);
      culture.DateTimeFormat.Calendar = new JapaneseCalendar();
      Assert.AreEqual(a.Era, dt.ToDate().ToString("gg", culture));
      Assert.AreEqual(a.Year.StrConv(Microsoft.VisualBasic.VbStrConv.Narrow).ToInt()
                    , dt.ToDate().ToString("yy", culture).ToInt());
    }

    [TestMethod]
    public void ToEra_21_昭和元年()
    {
      var dt = "1926/12/25";
      var a = dt.ToDate().ToEra();
      System.Diagnostics.Debug.WriteLine($"{dt} → {a.Era}{a.Year}年");
      //Assert.AreEqual(a.Era, "昭和");
      //Assert.AreEqual(a.Year, "元");
      CultureInfo culture = new CultureInfo("ja-JP", true);
      culture.DateTimeFormat.Calendar = new JapaneseCalendar();
      Assert.AreEqual(a.Era, dt.ToDate().ToString("gg", culture));
      Assert.AreEqual(a.Year, "元");
    }

    [TestMethod]
    public void ToEra_22_昭和64年()
    {
      var dt = "1989/1/7";
      var a = dt.ToDate().ToEra();
      System.Diagnostics.Debug.WriteLine($"{dt} → {a.Era}{a.Year}年");
      //Assert.AreEqual(a.Era, "昭和");
      //Assert.AreEqual(a.Year, "64");
      CultureInfo culture = new CultureInfo("ja-JP", true);
      culture.DateTimeFormat.Calendar = new JapaneseCalendar();
      Assert.AreEqual(a.Era, dt.ToDate().ToString("gg", culture));
      Assert.AreEqual(a.Year.StrConv(Microsoft.VisualBasic.VbStrConv.Narrow).ToInt()
                    , dt.ToDate().ToString("yy", culture).ToInt());
    }

    [TestMethod]
    public void ToEra_31_平成元年()
    {
      var dt = "1989/1/8";
      var a = dt.ToDate().ToEra();
      System.Diagnostics.Debug.WriteLine($"{dt} → {a.Era}{a.Year}年");
      //Assert.AreEqual(a.Era, "平成");
      //Assert.AreEqual(a.Year, "元");
      CultureInfo culture = new CultureInfo("ja-JP", true);
      culture.DateTimeFormat.Calendar = new JapaneseCalendar();
      Assert.AreEqual(a.Era, dt.ToDate().ToString("gg", culture));
      Assert.AreEqual(a.Year, "元");
    }

    [TestMethod]
    public void ToEra_32_平成２年()
    {
      var dt = "1990/1/8 23:59";
      var a = dt.ToDate().ToEra();
      System.Diagnostics.Debug.WriteLine($"{dt} → {a.Era}{a.Year}年");
      //Assert.AreEqual(a.Era, "平成");
      //Assert.AreEqual(a.Year, "２");
      CultureInfo culture = new CultureInfo("ja-JP", true);
      culture.DateTimeFormat.Calendar = new JapaneseCalendar();
      Assert.AreEqual(a.Era, dt.ToDate().ToString("gg", culture));
      Assert.AreEqual(a.Year.StrConv(Microsoft.VisualBasic.VbStrConv.Narrow).ToInt()
                    , dt.ToDate().ToString("yy", culture).ToInt());
    }

    [TestMethod]
    public void ToEra_41_令和元年()
    {
      var dt = "2019/5/1";
      var a = dt.ToDate().ToEra();
      System.Diagnostics.Debug.WriteLine($"{dt} → {a.Era}{a.Year}年");
      //Assert.AreEqual(a.Era, "平成");
      //Assert.AreEqual(a.Year, "元");
      CultureInfo culture = new CultureInfo("ja-JP", true);
      culture.DateTimeFormat.Calendar = new JapaneseCalendar();
      Assert.AreEqual(a.Era, dt.ToDate().ToString("gg", culture));
      Assert.AreEqual(a.Year, "元");
    }

    [TestMethod]
    public void ToEra_42_令和２年()
    {
      var dt = "2020/5/1 23:59";
      var a = dt.ToDate().ToEra();
      System.Diagnostics.Debug.WriteLine($"{dt} → {a.Era}{a.Year}年");
      //Assert.AreEqual(a.Era, "平成");
      //Assert.AreEqual(a.Year, "２");
      CultureInfo culture = new CultureInfo("ja-JP", true);
      culture.DateTimeFormat.Calendar = new JapaneseCalendar();
      Assert.AreEqual(a.Era, dt.ToDate().ToString("gg", culture));
      Assert.AreEqual(a.Year.StrConv(Microsoft.VisualBasic.VbStrConv.Narrow).ToInt()
                    , dt.ToDate().ToString("yy", culture).ToInt());
    }

    [TestMethod]
    public void ToEra_99_現在()
    {
      var dt = DateTime.Now.ToString();
      var a = dt.ToDate().ToEra();
      System.Diagnostics.Debug.WriteLine($"{dt} → {a.Era}{a.Year}年");

      CultureInfo culture = new CultureInfo("ja-JP", true);
      culture.DateTimeFormat.Calendar = new JapaneseCalendar();
      Assert.AreEqual(a.Era, dt.ToDate().ToString("gg", culture));
      Assert.AreEqual(a.Year.StrConv(Microsoft.VisualBasic.VbStrConv.Narrow).ToInt()
              , dt.ToDate().ToString("yy", culture).ToInt());
    }

  }
}
