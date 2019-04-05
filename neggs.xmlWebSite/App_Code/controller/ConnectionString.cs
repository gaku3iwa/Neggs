using System;
using System.Web.Services;
using neggs.db;

public partial class Services
{

  [WebMethod]
  public dbioResult ConnectionString()
  {
    dbioResult result = new dbioResult();

    DBC dbc = new DBC();
    try
    {
      result.Comments = dbc.ConnectionString;
    }
    catch (Exception ex)
    {
      result.HappenError(ex);
    }
    finally
    {
      dbc.Dispose();
    }
    return result;
  }

}
