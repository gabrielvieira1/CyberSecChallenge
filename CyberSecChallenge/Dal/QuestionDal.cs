using CyberSecChallenge.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecChallenge.Dal
{
  class QuestionDal
  {
    public int InsertEntity(Question question)
    {
      string queryString = RetornarStringConexao();

      var query = $"insert into Question (Title) values ('{question.Title}'); select SCOPE_IDENTITY();";

      using (SqlConnection con = new SqlConnection(queryString))
        try
        {
          SqlCommand cmd = new SqlCommand(query, con);

          con.Open();

          int ret = Convert.ToInt32(cmd.ExecuteScalar());

          return ret;
        }
        catch (Exception e)
        {
          Console.WriteLine(e);
          throw;
        }
        finally
        {
          con.Close();
        }
    }

    private string RetornarStringConexao()
    {
      return ControlConnectionString.Retornar();
    }
  }
}
