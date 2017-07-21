using System;

namespace neggs.core
{
	public static partial class Extensions
	{

		/// <summary>
		/// ２点間の距離を求める
		/// </summary>
		/// <param name="p1"></param>
		/// <param name="p2"></param>
		/// <returns></returns>
		public static double Distance(this System.Windows.Input.StylusPoint p1, System.Windows.Input.StylusPoint p2)
		{
			return Math.Sqrt(p1.X.Distance(p2.X) * p1.X.Distance(p2.X)
						   + p1.Y.Distance(p2.Y) * p1.Y.Distance(p2.Y));
		}

		/// <summary>
		/// ２点間の距離を求める
		/// </summary>
		/// <param name="p1"></param>
		/// <param name="p2"></param>
		/// <returns></returns>
		public static double Distance(this System.Drawing.Point p1, System.Drawing.Point p2)
		{
			return Math.Sqrt(p1.X.Distance(p2.X) * p1.X.Distance(p2.X)
						   + p1.Y.Distance(p2.Y) * p1.Y.Distance(p2.Y));
		}

		/// <summary>
		/// ２点間の距離を求める
		/// </summary>
		/// <param name="p1"></param>
		/// <param name="p2"></param>
		/// <returns></returns>
		public static double Distance(this double p1, double p2)
		{
			return Math.Abs(p1 - p2);
		}

		/// <summary>
		/// ２点間の距離を求める
		/// </summary>
		/// <param name="p1"></param>
		/// <param name="p2"></param>
		/// <returns></returns>
		public static int Distance(this int p1, int p2)
		{
			return Math.Abs(p1 - p2);
		}

	}
}
