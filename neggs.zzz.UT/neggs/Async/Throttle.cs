using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace neggs
{
	public partial class Async
  {

    [TestMethod]
		public void TestMethod1()
		{
			(new ThrottleForm()).ShowDialog();
		}

  }
}
