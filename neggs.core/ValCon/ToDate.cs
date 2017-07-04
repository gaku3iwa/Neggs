namespace neggs.core
{
	partial class ValCon
	{

		public static System.DateTime ToDate(string Value, bool AddDateSlash)
		{
			return ToDateTime(Value, AddDateSlash).Date;
		}

		public static System.DateTime ToDate(string Value)
		{
			return ToDateTime(Value).Date;
		}

		public static System.DateTime ToDate(object Value)
		{
			return ToDateTime(Value).Date;
		}

	}
}
