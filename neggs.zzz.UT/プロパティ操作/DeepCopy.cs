using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using neggs.core;

namespace neggs.UT
{
	[TestClass]
	public class DeepCopy
	{

		class HogeA
		{
			public string name { get; set; }
			public int age { get; set; }
		}

		[Serializable]
		class HogeB
		{
			public string name { get; set; }
			public int age { get; set; }
			public int sex { get; set; }
		}

		[TestMethod]
		public void DeepCopy_01()
		{
			var tmp = ((object)null).DeepCopy();
			Assert.AreEqual(tmp == null, true);
		}

		[TestMethod]
		public void DeepCopy_02()
		{
			HogeA aaa = new HogeA { name = "岩倉　学  ".Trim(), age = 46 };
			var aaaa = aaa.DeepCopy();

			//  hoge_A に [Serializable] の記述がないので、
			//  DeepCopy に失敗して、aaaa は null で差分あり
			Assert.AreEqual(aaa.IsDiff(aaaa), true);
		}

		[TestMethod]
		public void DeepCopy_03()
		{
			HogeB bbb = new HogeB { name = "岩倉　慎大".Trim(), age = 12, sex = 1 };
			var bbbb = bbb.DeepCopy();

			//  hoge_B に [Serializable] の記述があるので、
			//  DeepCopy は成功して、bbbb は内容一致で差分なし
			Assert.AreEqual(bbb.IsDiff(bbbb), false);
		}

	}
}