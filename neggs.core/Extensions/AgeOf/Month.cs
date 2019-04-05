using System;

namespace neggs.core
{
  partial class Extensions
  {

    /// <summary>
    /// 計算開始日から基準日までの月齢、余り日数計算し、null許容整数型の値を返します。
    /// <para>http://www.cid.nlbc.go.jp/pdf/getsurei_calc.pdf</para>
    /// </summary>
    /// <param name="self">基準日</param>
    /// <param name="StartDay">生年月日、購入年月日、また導入年月日等の計算開始日</param>
    /// <returns>Month、Item1:月齢、Day、Item2:余り日数 or null（計算不能）</returns>
    public static (int? Month, int? Day) AgeOfMonth(this DateTime self, DateTime StartDay)
    {
      int RETVAL_M;                                 /*　戻り値　　月齢　　　　*/
      int RETVAL_D;                                 /*　戻り値　　日数　　　　*/

      int BIRTH_Y;                                  /*　生年月日　年　　　　　*/
      int BIRTH_M;                                  /*　生年月日　月　　　　　*/
      int BIRTH_D;                                  /*　生年月日　日　　　　　*/

      int BASE_Y;                                   /*　基準日　　年　　　　　*/
      int BASE_M;                                   /*　基準日　　月　　　　　*/
      int BASE_D;                                   /*　基準日　　日　　　　　*/

      DateTime BASE_M_LDATE;                        /*　基準日　　当月末日付　*/
      int BASE_M_LDAY;                              /*　基準日　　当月末日　　*/

      DateTime BASE_M_LLDATE;                       /*　基準日　　前月末日付　*/
      int BASE_M_LLDAY;                             /*　基準日　　前月末日　　*/

      /*
      **  引数の大小関係が反対の場合、[NULL]を返す
      */
      if (StartDay > self)
      {
        return (null, null);
      }

      /*
      **  生年月日（導入年月日）の分解
      */
      BIRTH_Y = StartDay.Year;
      BIRTH_M = StartDay.Month;
      BIRTH_D = StartDay.Day;

      /*
      **  基準日の分解
      */
      BASE_Y = self.Year;
      BASE_M = self.Month;
      BASE_D = self.Day;

      /*
      **  基準日の当月末日
      */
      BASE_M_LDATE = self.EndOfMonth();
      BASE_M_LDAY = BASE_M_LDATE.Day;

      /*
      **  基準日の前月末日
      */
      BASE_M_LLDATE = self.BeginOfMonth().AddDays(-1);
      BASE_M_LLDAY = BASE_M_LLDATE.Day;

      /*
      **  月齢、余り日数計算 
      */
      RETVAL_M = (BASE_Y - BIRTH_Y) * 12 + (BASE_M - BIRTH_M);

      if (BASE_D == BIRTH_D)
      {
        RETVAL_D = 0;
      }
      else
      {
        if (BASE_D > BIRTH_D)
        {
          RETVAL_D = BASE_D - BIRTH_D;
        }
        else
        {
          if (BASE_D == BASE_M_LDAY)
          {
            RETVAL_D = 0;
          }
          else
          {
            RETVAL_M--;

            if (BASE_M_LLDAY > BIRTH_D)
            {
              RETVAL_D = BASE_M_LLDAY - BIRTH_D + BASE_D;
            }
            else
            {
              RETVAL_D = BASE_D;
            }
          }
        }
      }
      return (RETVAL_M, RETVAL_D);
    }

    /// <summary>
    /// 月初日を求め、DateTime型の値を返します。
    /// </summary>
    /// <param name="self">基準日</param>
    /// <returns>月初日</returns>
    public static System.DateTime BeginOfMonth(this DateTime self)
    {
      return new DateTime(self.Year, self.Month, 1);
    }

    /// <summary>
    /// 月末日を求め、DateTime型の値を返します。
    /// </summary>
    /// <param name="self">基準日</param>
    /// <returns>月末日</returns>
    public static System.DateTime EndOfMonth(this DateTime self)
    {
      var day = DateTime.DaysInMonth(self.Year, self.Month);
      return new DateTime(self.Year, self.Month, day);
    }

  }
}
