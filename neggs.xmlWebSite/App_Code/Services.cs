using System.Web.Services;

/// <summary>
/// Services の概要の説明です
/// </summary>
[WebService(Namespace = "http://neggs_server/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// この Web サービスを、スクリプトから ASP.NET AJAX を使用して呼び出せるようにするには、次の行のコメントを解除します。
// [System.Web.Script.Services.ScriptService]
public partial class Services : System.Web.Services.WebService
{

  public Services()
  {
  }

}
