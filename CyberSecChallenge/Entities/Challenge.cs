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
    public int Id { get; set; }
    public int Score { get; set; }
    public int IdPlayer { get; set; }
    public virtual Player Player { get; set; }
  }
}
