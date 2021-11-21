using System;
using System.Collections;
using CyberSecChallenge.Dal;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberSecChallenge.Entities;

namespace CyberSecChallenge.Controllers
{
  class QuestionController
  {
    QuestionDal questionDal = new QuestionDal();

    public int AddQuestion(Question question)
    {
      if (question == null)
      {
        return 0;
      }
      var id = questionDal.InsertQuestion(question);
      if (id > 0)
      {
        return id;
      }
      return 0;
    }


    public IList<Question> GetQuestions()
    {
      var lst = questionDal.GetQuestion();

      return lst;
    }

  }
}
