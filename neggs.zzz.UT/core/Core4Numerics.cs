using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using neggs.core;
using static System.Console;

namespace neggs.UT
{
  [TestClass]
  public class Core4Numerics
  {
    public Core4Numerics()
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
    public void numeric_01()
    {
      var s = @"123,456-7890 ０９８７６５４３２１";

      WriteLine("target：" + s);
      WriteLine(s.InNumberChar());
      WriteLine(s.StrConv(VbStrConv.Narrow));
      WriteLine(s.StrConv(VbStrConv.Narrow).InNumberChar().ToDecimal().ToString());
    }

    [TestMethod]
    public void numeric_02()
    {
      var s = @"123,456.4999999";

      WriteLine("target：" + s);
      WriteLine(s.ToInt().ToString());
      WriteLine(s.ToLong().ToString());
      WriteLine(s.ToDouble().ToString());
      WriteLine(s.ToDecimal().ToString());
      WriteLine(s.ToBool().ToString());
    }

    [TestMethod]
    public void numeric_03()
    {
      var s = @"\-123,456.789";

      WriteLine("target：" + s);
      WriteLine(s.ToInt().ToString());
      WriteLine(s.ToLong().ToString());
      WriteLine(s.ToDouble().ToString());
      WriteLine(s.ToDecimal().ToString());
      WriteLine(s.ToBool().ToString());
    }

    [TestMethod]
    public void numeric_04()
    {
      var s = @"0.00";

      WriteLine("target：" + s);
      WriteLine(s.ToInt().ToString());
      WriteLine(s.ToLong().ToString());
      WriteLine(s.ToDouble().ToString());
      WriteLine(s.ToDecimal().ToString());
      WriteLine(s.ToBool().ToString());
    }

  }
}
