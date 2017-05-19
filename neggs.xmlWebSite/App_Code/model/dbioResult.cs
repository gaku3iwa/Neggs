using System;
using System.Collections.Generic;

/// <summary>
/// dbioResult の概要の説明です
/// </summary>
public class dbioResult
{

  /// <summary>
  /// 成否判定フラグ
  /// true ：成功
  /// false：失敗
  /// </summary>
  public bool IsSuccess { get; set; } = true;

  /// <summary>
  /// 例外発生時のエラー原因
  /// </summary>
  public string Cause { get; set; } = string.Empty;

  /// <summary>
  /// 例外発生時のエラー診断
  /// </summary>
  public string Diagnosis { get; set; } = string.Empty;

  /// <summary>
  /// 簡易的な文字列型の値を返します。
  /// </summary>
  public string Comments { get; set; } = string.Empty;

  public void HappenError(Exception ex)
  {
    IsSuccess = false;
    Cause = ex.ToString();
    Diagnosis = "システム管理者まで連絡してください。";
  }

  public void HappenError(string cause, string diag)
  {
    IsSuccess = false;
    Cause = cause;
    Diagnosis = diag;
  }

}

public class dbioResult<T>
{

  /// <summary>
  /// 成否判定フラグ
  /// true ：成功
  /// false：失敗
  /// </summary>
  public bool IsSuccess { get; set; } = true;

  /// <summary>
  /// 例外発生時のエラー原因
  /// </summary>
  public string Cause { get; set; } = string.Empty;

  /// <summary>
  /// 例外発生時のエラー診断
  /// </summary>
  public string Diagnosis { get; set; } = string.Empty;

  /// <summary>
  /// 簡易的な文字列型の値を返します。
  /// </summary>
  public string Comments { get; set; } = string.Empty;

  /// <summary>
  /// リストデータ
  /// </summary>
  public List<T> List { get; set; } = new List<T>();

  public void HappenError(Exception ex)
  {
    IsSuccess = false;
    Cause = ex.ToString();
    Diagnosis = "システム管理者まで連絡してください。";
  }

  public void HappenError(string cause, string diag)
  {
    IsSuccess = false;
    Cause = cause;
    Diagnosis = diag;
  }

}