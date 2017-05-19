using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using neggs.core;

namespace neggs.UT
{
  [TestClass]
  public class Core4Base
  {
    public Core4Base()
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
    public void deepcopy_01()
    {
      var tmp = ((object)null).DeepCopy();
      Assert.AreEqual(tmp == null, true);
    }

    class hoge_A
    {
      public string name { get; set; }
      public int age { get; set; }
    }

    [TestMethod]
    public void deepcopy_02()
    {
      hoge_A aaa = new hoge_A { name = "岩倉　学  ".Trim(), age = 45 };
      var aaaa = aaa.DeepCopy();

      //  hoge_A に [Serializable] の記述がないので、
      //  DeepCopy に失敗して、aaaa は null で差分あり
      Assert.AreEqual(aaa.IsDiff(aaaa), true);
    }

    [Serializable]
    class hoge_B
    {
      public string name { get; set; }
      public int age { get; set; }
      public int sex { get; set; }
    }

    [TestMethod]
    public void deepcopy_03()
    {
      hoge_B bbb = new hoge_B { name = "岩倉　慎大".Trim(), age = 12, sex = 1 };
      var bbbb = bbb.DeepCopy();

      //  hoge_B に [Serializable] の記述があるので、
      //  DeepCopy は成功して、bbbb は内容一致で差分なし
      Assert.AreEqual(bbb.IsDiff(bbbb), false);
    }

    [TestMethod]
    public void isdiff_01()
    {
      Assert.AreEqual(((object)null).IsDiff((object)null), true);
    }

    [TestMethod]
    public void isdiff_02()
    {
      hoge_A aaa = new hoge_A { name = "岩倉　学", age = 45 };
      Assert.AreEqual(aaa.IsDiff((object)null), true);
      Assert.AreEqual(((object)null).IsDiff(aaa), true);
    }

    [TestMethod]
    public void isdiff_03()
    {
      hoge_A aaa = new hoge_A { name = "岩倉　学", age = 45 };
      hoge_B bbb = new hoge_B { name = "岩倉　学", age = 45, sex = 1 };
      Assert.AreEqual(aaa.IsDiff(bbb), false);
    }

    [TestMethod]
    public void isdiff_04()
    {
      hoge_A aaa = new hoge_A { name = "岩倉　学", age = 45 };
      hoge_B bbb = new hoge_B { name = "岩倉　学", age = 45, sex = 1 };
      Assert.AreEqual(bbb.IsDiff(aaa), false);
    }

  }
}
