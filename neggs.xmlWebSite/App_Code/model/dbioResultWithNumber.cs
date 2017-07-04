/// <summary>
/// dbioResultWithNumber の概要の説明です
/// </summary>
public class dbioResultWithNumber : dbioResult
{

	/// <summary>
	/// 番号
	/// 初期値：ゼロ
	/// </summary>
	public long Number { get; set; } = 0;

	public void HappenErrorNumber(string numberName)
	{
		IsSuccess = false;
		Cause = numberName + "の採番に失敗しました。";
		Diagnosis = "再度、登録／更新して下さい。";
	}

}
