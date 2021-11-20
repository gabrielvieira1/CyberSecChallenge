using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecChallenge
{
  class QuestionDal
  {
    public int InsertEntity(Question question)
    {
      string queryString = RetornarStringConexao();


      var query = "insert into Question (Title, Active) values ('@Title', 1)";

      using (SqlConnection con = new SqlConnection(queryString))
        try
        {
          SqlCommand cmd = new SqlCommand(query, con);

          cmd.Parameters.AddWithValue("@Title", question.Title);

          con.Open();

          int modified = Convert.ToInt32(cmd.ExecuteScalar());
          Console.WriteLine(modified);
          return modified;
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

    private void IncluirParametros(SqlCommand cmd, Question question)
    {
      cmd.Parameters.AddWithValue("@Title", question.Title);
      cmd.Parameters.AddWithValue("@Active", 1);
    }
  }
}
