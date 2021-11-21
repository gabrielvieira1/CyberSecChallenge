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
  class AnswerDal : DalGeneric
  {
    public void InsertAnswer(IList<Answer> answer)
    {

      StringBuilder query = new StringBuilder();

      foreach (var item in answer)
      {
        query.Append($"insert into Answer (Alternative, IdQuestion, RightAnswer) values ('{item.Alternative}', {item.IdQuestion}, {Convert.ToInt32(item.RightAnswer)});");
      }

      InsertEntity(query.ToString());

    }
  }
}
