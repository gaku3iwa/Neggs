using System;
using System.Runtime.InteropServices;

namespace neggs.core
{
	partial class Extensions
	{
		/// <summary>
		/// IFELanguage2 Interface ID
		/// [Guid("21164102-C24A-11d1-851A-00C04FCC6B14")]
		/// </summary>
		[ComImport]
		[Guid("019F7152-E6DB-11d0-83C3-00C04FDDB82E")]
		[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		public interface IFELanguage
		{
			int Open();
			int Close();
			int GetJMorphResult(uint dwRequest, uint dwCMode, int cwchInput, [MarshalAs(UnmanagedType.LPWStr)] string pwchInput, IntPtr pfCInfo, out object ppResult);
			int GetConversionModeCaps(ref uint pdwCaps);
			int GetPhonetic([MarshalAs(UnmanagedType.BStr)] string @string, int start, int length, [MarshalAs(UnmanagedType.BStr)] out string result);
			int GetConversion([MarshalAs(UnmanagedType.BStr)] string @string, int start, int length, [MarshalAs(UnmanagedType.BStr)] out string result);
		}

		/// <summary>
		/// MSIMEに基づき、よみがな変換した文字列型の値を返します。
		/// </summary>
		/// <param name="Value"></param>
		/// <returns></returns>
		private static string Phonetic(this string Value)
		{
			string よみがな = string.Empty; ;
			IFELanguage ifelang = null;
			try
			{
				ifelang = Activator.CreateInstance(Type.GetTypeFromProgID("MSIME.Japan")) as IFELanguage;
				int iRcd = ifelang.Open();
				if (iRcd != 0)
				{
					throw Marshal.GetExceptionForHR(iRcd);
				}
				iRcd = ifelang.GetPhonetic(Value, 1, -1, out よみがな);
				if (iRcd != 0)
				{
					throw Marshal.GetExceptionForHR(iRcd);
				}
				return よみがな;
			}
			finally
			{
				if (ifelang != null)
					ifelang.Close();
			}
		}

		/// <summary>
		/// ひらがな変換した文字列型を返します。
		/// </summary>
		/// <param name="Value"></param>
		/// <returns></returns>
		public static string ToKana(this string Value)
		{
			return Value.Phonetic();
		}

		/// <summary>
		/// 指定に従って文字列型の値を返します。
		/// </summary>
		/// <param name="Value"></param>
		/// <param name="Conversion"></param>
		/// <returns></returns>
		public static string ToKana(this string Value, Microsoft.VisualBasic.VbStrConv Conversion)
		{
			if (Value.IsEmpty()) return string.Empty;
			return Value.Phonetic().StrConv(Conversion);
		}

	}
}
