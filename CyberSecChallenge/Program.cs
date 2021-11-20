using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecChallenge
{
  class Program
  {
    static void Main(string[] args)
    {
      QuestionController questionController = new QuestionController();
      Question question = new Question();


      Console.WriteLine("Digite o titulo da pergunta:");
      question.Title = Console.ReadLine();

      questionController.AddQuestion(question);

      Console.ReadLine();
    }
  }
}
