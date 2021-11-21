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
  class PlayerDal : DalGeneric
  {
    public int InsertPlayer(Player player)
    {
      string query = $"insert into Player (Nome, Email) values ('{player.Nome}', '{player.Email}'); select SCOPE_IDENTITY();";

      return InsertEntity(query);
    }

  }
}
