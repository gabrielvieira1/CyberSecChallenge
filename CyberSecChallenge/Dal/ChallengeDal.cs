using CyberSecChallenge.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecChallenge.Dal
{
  class ChallengeDal : DalGeneric
  {
    public void InsertChallenge(Challenge challenge)
    {
      var query = $"insert into Challenge (IdPlayer, Score) values ({challenge.IdPlayer}, {challenge.Score});";

      InsertEntity(query);
    }

    public List<Challenge> GetChallenge()
    {
      var challenge = new List<Challenge>();
      var query = "select top 10 * from Challenge order by score desc;";

      GetEntity(query, responseSQL =>
      {
        while (responseSQL.Read())
        {
          challenge.Add(new Challenge
          {
            IdPlayer = (int)responseSQL["IdPlayer"],
            Score = (int)responseSQL["Score"]
          });
        }
      });

      for (int i = 0; i < challenge.Count(); i++)
      {
        query = $"select * from Player where Id = {challenge[i].IdPlayer};";

        GetEntity(query, responseSQL =>
        {
          while (responseSQL.Read())
          {
            challenge[i].Player = new Player
            {
              Id = (int)responseSQL["Id"],
              Nome = (string)responseSQL["Nome"],
              Email = (string)responseSQL["Email"]
            };
          }
        });
      }
      return challenge;
    }
  }
}
