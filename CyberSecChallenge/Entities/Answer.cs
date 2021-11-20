using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecChallenge
{
  class Answer
  {
    public int Id { get; set; }
    public string Alternative { get; set; }
    public int IdQuestion { get; set; }
    public bool RightAnswer { get; set; }
    public bool Active { get; set; }

  }
}
