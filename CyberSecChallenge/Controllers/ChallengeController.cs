using CyberSecChallenge.Dal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecChallenge
{
  class ChallengeController
  {
    ChallengeDal challengeDal = new ChallengeDal();
    private const int point = 10;
    public int CheckCorrectAnswer(List<Answer> responseList)
    {
      int score = 0;

      foreach (var item in responseList)
      {
        if (item.RightAnswer)
          score += point;
      }

      return score;
    }

    internal void SaveChallenge(Challenge challenge)
    {
      if (challenge == null)
      {
        return;
      }
      challengeDal.InsertChallenge(challenge);
    }

    internal List<Challenge> ListRank()
    {
      var rank = challengeDal.GetChallenge();

      return rank;
    }
  }
}
