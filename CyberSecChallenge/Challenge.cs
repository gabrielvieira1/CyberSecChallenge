using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecChallenge
{
  class Challenge
  {
    private int Id { get; set; }
    public int IdQuestion { get; set; }
    public int IdAnswer { get; set; }
    public int Score { get; set; }
    public int IdPlayer { get; set; }
    public static int Rank { get; private set; }
  }
}
