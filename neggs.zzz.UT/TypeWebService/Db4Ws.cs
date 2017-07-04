using Microsoft.VisualStudio.TestTools.UnitTesting;
using neggs.web;
using static System.Console;
using static neggs.UT.Constant;

namespace neggs.UT
{

	[TestClass]
	public partial class Db4Ws
	{
		public Db4Ws()
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

		[TestMethod]
		public void ConnectionString_ws()
		{
			dbioResult result = ws.ConnectionString();
			WriteLine($"ConnectionString:[{result.Comments}]");
			Assert.AreEqual(result.IsSuccess, true);
		}

		[TestMethod]
		public void ProviderName_ws()
		{
			dbioResult result = ws.ProviderName();
			WriteLine($"ProviderName:[{result.Comments}]");
			Assert.AreEqual(result.IsSuccess, true);
		}

	}

}
