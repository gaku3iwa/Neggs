using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using neggs.core;
using static System.Console;

namespace neggs.UT
{
	[TestClass]
	public class AgeOfMonths
	{

		[TestMethod]
		public void AgeOfMonth_01()
		{
			var dt1 = "2015/2/1";
			var dt2 = "2015/2/2";
			var ans = dt2.ToDate().AgeOfMonth(dt1.ToDate());
			WriteLine("基準日１　：" + dt1.ToDate().ToShortDateString());
			WriteLine("基準日２　：" + dt2.ToDate().ToShortDateString());
			WriteLine("月齢　　　：" + ans.Month.Value.ToString());
			WriteLine("余り日数　：" + ans.Day.Value.ToString());
			Assert.AreEqual(ans.Month.Value, 0);
			Assert.AreEqual(ans.Day.Value, 1);
		}

		[TestMethod]
		public void AgeOfMonth_02()
		{
			var dt1 = "2015/2/2";
			var dt2 = "2015/2/2";
			var ans = dt2.ToDate().AgeOfMonth(dt1.ToDate());
			WriteLine("基準日１　：" + dt1.ToDate().ToShortDateString());
			WriteLine("基準日２　：" + dt2.ToDate().ToShortDateString());
			WriteLine("月齢　　　：" + ans.Month.Value.ToString());
			WriteLine("余り日数　：" + ans.Day.Value.ToString());
			Assert.AreEqual(ans.Month, 0);
			Assert.AreEqual(ans.Day, 0);
		}

		[TestMethod]
		public void AgeOfMonth_03()
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
		public void AgeOfMonth_04()
		{
			var dt1 = "2016/2/27";
			var dt2 = "2016/3/2";
			var ans = dt2.ToDate().AgeOfMonth(dt1.ToDate());
			WriteLine("基準日１　：" + dt1.ToDate().ToShortDateString());
			WriteLine("基準日２　：" + dt2.ToDate().ToShortDateString());
			WriteLine("月齢　　　：" + ans.Month.Value.ToString());
			WriteLine("余り日数　：" + ans.Day.Value.ToString());
			Assert.AreEqual(ans.Month, 0);
			Assert.AreEqual(ans.Day, 4);
		}

		[TestMethod]
		public void AgeOfMonth_05()
		{
			var dt1 = "2016/2/27";
			var dt2 = "2016/3/26";
			var ans = dt2.ToDate().AgeOfMonth(dt1.ToDate());
			WriteLine("基準日１　：" + dt1.ToDate().ToShortDateString());
			WriteLine("基準日２　：" + dt2.ToDate().ToShortDateString());
			WriteLine("月齢　　　：" + ans.Month.Value.ToString());
			WriteLine("余り日数　：" + ans.Day.Value.ToString());
			Assert.AreEqual(ans.Month, 0);
			Assert.AreEqual(ans.Day, 28);
		}

		[TestMethod]
		public void AgeOfMonth_06()
		{
			var dt1 = "2016/2/27";
			var dt2 = "2016/3/27";
			var ans = dt2.ToDate().AgeOfMonth(dt1.ToDate());
			WriteLine("基準日１　：" + dt1.ToDate().ToShortDateString());
			WriteLine("基準日２　：" + dt2.ToDate().ToShortDateString());
			WriteLine("月齢　　　：" + ans.Month.Value.ToString());
			WriteLine("余り日数　：" + ans.Day.Value.ToString());
			Assert.AreEqual(ans.Month, 1);
			Assert.AreEqual(ans.Day, 0);
		}

		[TestMethod]
		public void AgeOfMonth_07()
		{
			var dt1 = "2016/2/27";
			var dt2 = "2016/3/28";
			var ans = dt2.ToDate().AgeOfMonth(dt1.ToDate());
			WriteLine("基準日１　：" + dt1.ToDate().ToShortDateString());
			WriteLine("基準日２　：" + dt2.ToDate().ToShortDateString());
			WriteLine("月齢　　　：" + ans.Month.Value.ToString());
			WriteLine("余り日数　：" + ans.Day.Value.ToString());
			Assert.AreEqual(ans.Month, 1);
			Assert.AreEqual(ans.Day, 1);
		}

		[TestMethod]
		public void AgeOfMonth_08()
		{
			var dt1 = "2016/7/27";
			var dt2 = "2016/8/26";
			var ans = dt2.ToDate().AgeOfMonth(dt1.ToDate());
			WriteLine("基準日１　：" + dt1.ToDate().ToShortDateString());
			WriteLine("基準日２　：" + dt2.ToDate().ToShortDateString());
			WriteLine("月齢　　　：" + ans.Month.Value.ToString());
			WriteLine("余り日数　：" + ans.Day.Value.ToString());
			Assert.AreEqual(ans.Month, 0);
			Assert.AreEqual(ans.Day, 30);
		}

		[TestMethod]
		public void AgeOfMonth_09()
		{
			var dt1 = "2016/7/27";
			var dt2 = "2016/8/27";
			var ans = dt2.ToDate().AgeOfMonth(dt1.ToDate());
			WriteLine("基準日１　：" + dt1.ToDate().ToShortDateString());
			WriteLine("基準日２　：" + dt2.ToDate().ToShortDateString());
			WriteLine("月齢　　　：" + ans.Month.Value.ToString());
			WriteLine("余り日数　：" + ans.Day.Value.ToString());
			Assert.AreEqual(ans.Month, 1);
			Assert.AreEqual(ans.Day, 0);
		}

		[TestMethod]
		public void AgeOfMonth_10()
		{
			var dt1 = "2016/7/27";
			var dt2 = "2016/8/28";
			var ans = dt2.ToDate().AgeOfMonth(dt1.ToDate());
			WriteLine("基準日１　：" + dt1.ToDate().ToShortDateString());
			WriteLine("基準日２　：" + dt2.ToDate().ToShortDateString());
			WriteLine("月齢　　　：" + ans.Month.Value.ToString());
			WriteLine("余り日数　：" + ans.Day.Value.ToString());
			Assert.AreEqual(ans.Month, 1);
			Assert.AreEqual(ans.Day, 1);
		}

	}
}