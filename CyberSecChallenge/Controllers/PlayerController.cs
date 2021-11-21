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
  class PlayerController
  {
    PlayerDal playerDal = new PlayerDal();

    public int AddPlayer(Player player)
    {
      if (player == null)
      {
        return 0;
      }
      var id = playerDal.InsertPlayer(player);

      if (id > 0)
      {
        return id;
      }
      return 0;
    }
  }
}
