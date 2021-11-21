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
  class QuestionDal : DalGeneric
  {

    public int InsertQuestion(Question question)
    {
      var query = $"insert into Question (Title) values ('{question.Title}'); select SCOPE_IDENTITY();";

      return InsertEntity(query);
    }

    public IList<Question> GetQuestion()
    {
      List<Question> questions = new List<Question>();

      var query = $"select top 10 * from Question";

      SqlConnection con = new SqlConnection(ControlConnectionString.Retornar());
      
      try
      {
        con.Open();
        SqlCommand cmd = new SqlCommand(query, con);
        SqlDataReader data = cmd.ExecuteReader();


        while (data.Read())
        {
          Question question = new Question();

        }

        data.Close();

      }
      finally
      {
        con.Close();
      }

      return questions;
    }
  }
}
