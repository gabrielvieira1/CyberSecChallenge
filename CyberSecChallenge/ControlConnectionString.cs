using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecChallenge
{
  public static class ControlConnectionString
  {
    public static string _connection = null;

    public static string Retornar()
    {
      if (!string.IsNullOrEmpty(_connection))
        return _connection;

      string ambiente = RetornarAmbiente();

      if (ambiente == "PROD")
      {
        _connection = RetornarString("CyberSec_Challenge_ConnectionString_Prod");
      }
      else if (ambiente == "HOMOLOG")
      {
        _connection = RetornarString("CyberSec_Challenge_ConnectionString_Homolog");
      }
      else if (ambiente == "DESENV")
      {
        _connection = RetornarString("CyberSec_Challenge_ConnectionString_Desenv");
      }

      return _connection;
    }

    public static bool EhProducao()
    {
      string ambiente = RetornarAmbiente();

      return ambiente.Equals("PROD");
    }

    public static bool EhHomologacao()
    {
      string ambiente = RetornarAmbiente();

      return ambiente.Equals("HOMOLOG");
    }

    public static bool EhDesenvolvimento()
    {
      string ambiente = RetornarAmbiente();

      return ambiente.Equals("DESENV");
    }

    public static string RetornarAmbiente()
    {
      string ambiente = ConfigurationManager.AppSettings["CyberSec_Challenges_Ambiente"];
      return ambiente;
    }

    private static string RetornarString(string key)
    {
      var ConnectionString = ConfigurationManager.ConnectionStrings[key].ConnectionString;

      SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(ConnectionString);
      //builder.UserID = Decrypt.Generate(builder.UserID);
      //builder.Password = Decrypt.Generate(builder.Password);
      return builder.ConnectionString;
    }
  }
}
