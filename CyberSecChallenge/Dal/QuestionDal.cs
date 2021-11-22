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

    public List<Question> GetQuestion()
    {
      var questions = new List<Question>();
      var query = $"select top 10 * from Question where Active = 1;";

      GetEntity(query, responseSQL =>
      {
        while (responseSQL.Read())
        {
          questions.Add(new Question
          {
            Id = (int)responseSQL["Id"],
            Title = (string)responseSQL["Title"]
          });
        }
      });

      var answers = new List<Answer>();

      for (int i = 0; i < questions.Count(); i++)
      {
        query = $"select * from Answer a where a.IdQuestion = {questions[i].Id};";

        GetEntity(query, responseSQL =>
        {
          while (responseSQL.Read())
          {
            answers.Add(new Answer
            {
              Id = (int)responseSQL["Id"],
              Alternative = (string)responseSQL["Alternative"],
              IdQuestion = (int)responseSQL["IdQuestion"],
              RightAnswer = (bool)responseSQL["RightAnswer"],
              Active = (bool)responseSQL["Active"]
            });
          }
        });

        questions[i].Answers = new List<Answer>();

        questions[i].Answers.AddRange(answers);

        answers.Clear();
      }

      return questions;
    }
  }
}
