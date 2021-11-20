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
  class AnswerDal
  {
    public void InsertEntity(IList<Answer> answer)
    {
      string queryString = RetornarStringConexao();

      List<string> query = new List<string>();

      foreach (var item in answer)
      {
        query.Add($"insert into Answer (Alternative, IdQuestion, RightAnswer) values ('{item.Alternative}', {item.IdQuestion}, {Convert.ToInt32(item.RightAnswer)});");

      }

      using (SqlConnection con = new SqlConnection(queryString))
        try
        {
          foreach (var item in query)
          {
            SqlCommand cmd = new SqlCommand(item, con);
            con.Open();
            cmd.ExecuteScalar();
          }
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
