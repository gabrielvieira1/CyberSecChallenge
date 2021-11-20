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
  class AnswerController
  {
    AnswerDal answerDal = new AnswerDal();

    public void AddAnswer(IList<Answer> answer)
    {
      if (answer == null)
      {
        return;
      }
      answerDal.InsertEntity(answer);
    }
  }
}
