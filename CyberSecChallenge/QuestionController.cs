using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecChallenge
{
  class QuestionController
  {
    QuestionDal questionDal = new QuestionDal();
    public void AddQuestion(Question question)
    {
      if (question == null)
      {
        return;
      }

      var id = questionDal.InsertEntity(question);
      if (id > 0)
      {
        Console.WriteLine(id + "Foi inserido com sucesso!");
      }
    }
  }
}
