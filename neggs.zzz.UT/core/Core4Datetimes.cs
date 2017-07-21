using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using neggs.core;
using static System.Console;

namespace neggs.UT
{
  [TestClass]
  public class Core4Datetimes
  {
    public Core4Datetimes()
    {
      //
      // TODO: コンストラクター ロジックをここに追加します
      //
    }

    private TestContext testContextInstance;

    /// <summary>
    ///現在のテストの実行についての情報および機能を
    ///提供するテスト コンテキストを取得または設定します。
    ///</summary>
    public TestContext TestContext
    {
      get
      {
        return testContextInstance;
      }
      set
      {
        testContextInstance = value;
      }
    }

    #region 追加のテスト属性
    //
    // テストを作成する際には、次の追加属性を使用できます:
    //
    // クラス内で最初のテストを実行する前に、ClassInitialize を使用してコードを実行してください
    // [ClassInitialize()]
    // public static void MyClassInitialize(TestContext testContext) { }
    //
    // クラス内のテストをすべて実行したら、ClassCleanup を使用してコードを実行してください
    // [ClassCleanup()]
    // public static void MyClassCleanup() { }
    //
    // 各テストを実行する前に、TestInitialize を使用してコードを実行してください
    // [TestInitialize()]
    // public void MyTestInitialize() { }
    //
    // 各テストを実行した後に、TestCleanup を使用してコードを実行してください
    // [TestCleanup()]
    // public void MyTestCleanup() { }
    //
    #endregion

    string sep = new string('-', 50);

    [TestMethod]
    public void age_of_month_01()
    {
      var dt1 = "2015/2/1";
      var dt2 = "2015/2/2";
      var ans = dt2.ToDate().AgeOfMonth(dt1.ToDate());
      WriteLine("基準日１　：" + dt1.ToDate().ToShortDateString());
      WriteLine("基準日２　：" + dt2.ToDate().ToShortDateString());
      WriteLine("月齢　　　：" + ans.Item1.Value.ToString());
      WriteLine("余り日数　：" + ans.Item2.Value.ToString());
      Assert.AreEqual(ans.Month.Value, 0);
      Assert.AreEqual(ans.Day.Value, 1);
    }

    [TestMethod]
    public void age_of_month_02()
    {
      var dt1 = "2015/2/2";
      var dt2 = "2015/2/2";
      var ans = dt2.ToDate().AgeOfMonth(dt1.ToDate());
      WriteLine("基準日１　：" + dt1.ToDate().ToShortDateString());
      WriteLine("基準日２　：" + dt2.ToDate().ToShortDateString());
      WriteLine("月齢　　　：" + ans.Item1.Value.ToString());
      WriteLine("余り日数　：" + ans.Item2.Value.ToString());
      Assert.AreEqual(ans.Month, 0);
      Assert.AreEqual(ans.Day, 0);
    }

    [TestMethod]
    public void age_of_month_03()
    {
      var dt1 = "2015/2/5";
      var dt2 = "2015/2/2";
      var ans = dt2.ToDate().AgeOfMonth(dt1.ToDate());
      WriteLine("基準日１　：" + dt1.ToDate().ToShortDateString());
      WriteLine("基準日２　：" + dt2.ToDate().ToShortDateString());
      WriteLine("計算不能");
      Assert.AreEqual(ans.Month.HasValue, false);
      Assert.AreEqual(ans.Day.HasValue, false);
    }

    [TestMethod]
    public void age_of_month_04()
    {
      var dt1 = "2016/2/27";
      var dt2 = "2016/3/2";
      var ans = dt2.ToDate().AgeOfMonth(dt1.ToDate());
      WriteLine("基準日１　：" + dt1.ToDate().ToShortDateString());
      WriteLine("基準日２　：" + dt2.ToDate().ToShortDateString());
      WriteLine("月齢　　　：" + ans.Item1.Value.ToString());
      WriteLine("余り日数　：" + ans.Item2.Value.ToString());
      Assert.AreEqual(ans.Month, 0);
      Assert.AreEqual(ans.Day, 4);
    }

    [TestMethod]
    public void age_of_month_05()
    {
      var dt1 = "2016/2/27";
      var dt2 = "2016/3/26";
      var ans = dt2.ToDate().AgeOfMonth(dt1.ToDate());
      WriteLine("基準日１　：" + dt1.ToDate().ToShortDateString());
      WriteLine("基準日２　：" + dt2.ToDate().ToShortDateString());
      WriteLine("月齢　　　：" + ans.Item1.Value.ToString());
      WriteLine("余り日数　：" + ans.Item2.Value.ToString());
      Assert.AreEqual(ans.Month, 0);
      Assert.AreEqual(ans.Day, 28);
    }

    [TestMethod]
    public void age_of_month_06()
    {
      var dt1 = "2016/2/27";
      var dt2 = "2016/3/27";
      var ans = dt2.ToDate().AgeOfMonth(dt1.ToDate());
      WriteLine("基準日１　：" + dt1.ToDate().ToShortDateString());
      WriteLine("基準日２　：" + dt2.ToDate().ToShortDateString());
      WriteLine("月齢　　　：" + ans.Item1.Value.ToString());
      WriteLine("余り日数　：" + ans.Item2.Value.ToString());
      Assert.AreEqual(ans.Month, 1);
      Assert.AreEqual(ans.Day, 0);
    }

    [TestMethod]
    public void age_of_month_07()
    {
      var dt1 = "2016/2/27";
      var dt2 = "2016/3/28";
      var ans = dt2.ToDate().AgeOfMonth(dt1.ToDate());
      WriteLine("基準日１　：" + dt1.ToDate().ToShortDateString());
      WriteLine("基準日２　：" + dt2.ToDate().ToShortDateString());
      WriteLine("月齢　　　：" + ans.Item1.Value.ToString());
      WriteLine("余り日数　：" + ans.Item2.Value.ToString());
      Assert.AreEqual(ans.Month, 1);
      Assert.AreEqual(ans.Day, 1);
    }

    [TestMethod]
    public void age_of_month_08()
    {
      var dt1 = "2016/7/27";
      var dt2 = "2016/8/26";
      var ans = dt2.ToDate().AgeOfMonth(dt1.ToDate());
      WriteLine("基準日１　：" + dt1.ToDate().ToShortDateString());
      WriteLine("基準日２　：" + dt2.ToDate().ToShortDateString());
      WriteLine("月齢　　　：" + ans.Item1.Value.ToString());
      WriteLine("余り日数　：" + ans.Item2.Value.ToString());
      Assert.AreEqual(ans.Month, 0);
      Assert.AreEqual(ans.Day, 30);
    }

    [TestMethod]
    public void age_of_month_09()
    {
      var dt1 = "2016/7/27";
      var dt2 = "2016/8/27";
      var ans = dt2.ToDate().AgeOfMonth(dt1.ToDate());
      WriteLine("基準日１　：" + dt1.ToDate().ToShortDateString());
      WriteLine("基準日２　：" + dt2.ToDate().ToShortDateString());
      WriteLine("月齢　　　：" + ans.Item1.Value.ToString());
      WriteLine("余り日数　：" + ans.Item2.Value.ToString());
      Assert.AreEqual(ans.Month, 1);
      Assert.AreEqual(ans.Day, 0);
    }

    [TestMethod]
    public void age_of_month_10()
    {
      var dt1 = "2016/7/27";
      var dt2 = "2016/8/28";
      var ans = dt2.ToDate().AgeOfMonth(dt1.ToDate());
      WriteLine("基準日１　：" + dt1.ToDate().ToShortDateString());
      WriteLine("基準日２　：" + dt2.ToDate().ToShortDateString());
      WriteLine("月齢　　　：" + ans.Item1.Value.ToString());
      WriteLine("余り日数　：" + ans.Item2.Value.ToString());
      Assert.AreEqual(ans.Month, 1);
      Assert.AreEqual(ans.Day, 1);
    }



    [TestMethod]
    public void convert_era_01()
    {
      var dt_t = "1868/9/7";
      var ans = dt_t.ToDate().ToEra();

      //  Windows は、1868/9/8 以降の元号しか対応していないので、
      //  元号変換できなかった時は、空文字が返却される仕様
      System.Diagnostics.Debug.WriteLine($"{dt_t} → {ans.Era}{ans.Year}年");
      Assert.AreEqual(ans.Era, string.Empty);
      Assert.AreEqual(ans.Year, string.Empty);
    }

    [TestMethod]
    public void convert_era_02_明治()
    {
      var dt_m1 = "1868/9/8";
      var dt_m2 = "1912/7/29";

      var a = dt_m1.ToDate().ToEra();
      System.Diagnostics.Debug.WriteLine($"{dt_m1} → {a.Era}{a.Year}年");
      Assert.AreEqual(a.Era, "明治");
      Assert.AreEqual(a.Year, "元");

      a = dt_m2.ToDate().ToEra();
      System.Diagnostics.Debug.WriteLine($"{dt_m2} → {a.Era}{a.Year}年");
      Assert.AreEqual(a.Era, "明治");
      Assert.AreEqual(a.Year, "45");
    }

    [TestMethod]
    public void convert_era_03_大正()
    {
      var dt_t1 = "1912/7/30";
      var dt_t2 = "1926/12/24";

      var a = dt_t1.ToDate().ToEra();
      System.Diagnostics.Debug.WriteLine($"{dt_t1} → {a.Era}{a.Year}年");
      Assert.AreEqual(a.Era, "大正");
      Assert.AreEqual(a.Year, "元");

      a = dt_t2.ToDate().ToEra();
      System.Diagnostics.Debug.WriteLine($"{dt_t2} → {a.Era}{a.Year}年");
      Assert.AreEqual(a.Era, "大正");
      Assert.AreEqual(a.Year, "15");
    }

    [TestMethod]
    public void convert_era_04_昭和()
    {
      var dt_s1 = "1926/12/25";
      var dt_s2 = "1989/1/7";

      var a = dt_s1.ToDate().ToEra();
      System.Diagnostics.Debug.WriteLine($"{dt_s1} → {a.Era}{a.Year}年");
      Assert.AreEqual(a.Era, "昭和");
      Assert.AreEqual(a.Year, "元");

      a = dt_s2.ToDate().ToEra();
      System.Diagnostics.Debug.WriteLine($"{dt_s2} → {a.Era}{a.Year}年");
      Assert.AreEqual(a.Era, "昭和");
      Assert.AreEqual(a.Year, "64");
    }

    [TestMethod]
    public void convert_era_05_平成()
    {
      var dt_h1 = "1989/1/8";
      var dt_h2 = "1990/1/8 23:59";

      var a = dt_h1.ToDate().ToEra();
      System.Diagnostics.Debug.WriteLine($"{dt_h1} → {a.Era}{a.Year}年");
      Assert.AreEqual(a.Era, "平成");
      Assert.AreEqual(a.Year, "元");

      a = dt_h2.ToDate().ToEra();
      System.Diagnostics.Debug.WriteLine($"{dt_h2} → {a.Era}{a.Year}年");
      Assert.AreEqual(a.Era, "平成");
      Assert.AreEqual(a.Year, "２");
    }

    [TestMethod]
    public void convert_era_06()
    {
      var dt_n = DateTime.Now;

      var a = dt_n.ToEra();
      System.Diagnostics.Debug.WriteLine($"{dt_n} → {a.Era}{a.Year}年");
      Assert.AreEqual(a.Era, "平成");
      Assert.AreEqual(a.Year, "29");
    }

  }
}
