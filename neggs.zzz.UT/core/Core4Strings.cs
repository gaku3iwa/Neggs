using Microsoft.VisualStudio.TestTools.UnitTesting;
using neggs.core;
using static System.Console;

namespace neggs.UT
{
  [TestClass]
  public class Core4Strings
  {
    public Core4Strings()
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
    public void strings_01()
    {
      var s = "株式会社　ＡＢＣ　TEL:011-123-4567 FAX:011-123-4568 ";

      WriteLine("\ntarget：" + s);
      WriteLine(s.RemovalSpace());
      WriteLine(s.RemovalSpace().InNumberChar());
    }

    [TestMethod]
    public void strings_02()
    {
      var s = "四月朔日　一";

      WriteLine("\ntarget：" + s);
      WriteLine(s.ToKana());
    }

    [TestMethod]
    public void strings_03()
    {
      var s = "一　千歳";

      WriteLine("\ntarget：" + s);
      WriteLine(s.ToKana());
    }

    [TestMethod]
    public void strings_04()
    {
      var s = "十二月一日　実篤";

      WriteLine("\ntarget：" + s);
      WriteLine(s.ToKana());
    }

    [TestMethod]
    public void strings_05()
    {
      var s = "十二月一日　実篤";

      WriteLine("\ntarget：" + s);
      WriteLine(s.sjisLength().ToString());
      WriteLine(s.sjisSubString(2, 6).ToString());
    }

    [TestMethod]
    public void strings_06()
    {
      string a = null;
      WriteLine(a.IsNullOrEmpty());
    }

  }
}
