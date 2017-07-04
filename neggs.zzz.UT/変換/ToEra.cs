using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using neggs.core;
using static System.Console;

namespace neggs.UT
{
	[TestClass]
	public class ToEra
	{

		[TestMethod]
		public void ToEra_01_江戸()
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
		public void ToEra_02_明治()
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
		public void ToEra_03_大正()
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
		public void ToEra_04_昭和()
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
		public void ToEra_05_平成()
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
		public void ToEra_06_現在()
		{
			var dt_n = DateTime.Now;

			var a = dt_n.ToEra();
			System.Diagnostics.Debug.WriteLine($"{dt_n} → {a.Era}{a.Year}年");
			Assert.AreEqual(a.Era, "平成");
			Assert.AreEqual(a.Year, "29");
		}

	}
}