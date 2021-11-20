using CyberSecChallenge.Controllers;
using CyberSecChallenge.Entities;
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
      Menu();
      Console.ReadLine();
    }

    public static void Menu()
    {
      var opcao = 0;
      do
      {
        Console.WriteLine("MENU:\n");
        Console.WriteLine("1 - Iniciar Desafio");
        Console.WriteLine("2 - Adcionar Pergunta");
        Console.WriteLine("0 - Encerrar programa");
        opcao = Convert.ToInt32(Console.ReadLine());

        if (opcao == 1)
        {
          Console.Clear();
          InciarDesafio();
        }

        if (opcao == 2)
        {
          Console.Clear();
          AddQuestions();
        }

      } while (opcao != 0);

    }

    private static void InciarDesafio()
    {
      throw new NotImplementedException();
    }

    private static void AddQuestions()
    {
      QuestionController questionController = new QuestionController();
      AnswerController answerController = new AnswerController();
      Question question = new Question();
      IList<Answer> optionAnswer = new List<Answer>();
      var option = 0;

      do
      {
        Console.WriteLine("Digite o titulo da pergunta:");
        question.Title = Console.ReadLine();
        int idquestion = questionController.AddQuestion(question);

        Console.Clear();

        Console.WriteLine("Quantas alternativas tem essa pergunta?");
        var qtdAlternative = Convert.ToInt32(Console.ReadLine());

        Console.Clear();

        for (int i = 0; i < qtdAlternative; i++)
        {
          Console.WriteLine("Digite a opção de nº " + (i + 1));
          var questionAlternative = Console.ReadLine();

          Console.WriteLine("Essa é a resposta correta (apenas Números):");
          Console.WriteLine("1 - Sim");
          Console.WriteLine("2 - Não");
          int right = Convert.ToInt32(Console.ReadLine());
          bool rightAnswer = true;

          if (right != 1)
          {
            rightAnswer = false;
          }

          Answer answer = new Answer()
          {
            Alternative = questionAlternative,
            IdQuestion = idquestion,
            RightAnswer = rightAnswer
          };

          optionAnswer.Add(answer);

          Console.Clear();
        };


        answerController.AddAnswer(optionAnswer);

        Console.WriteLine("Deseja adicionar mais uma Pergunta?");
        Console.WriteLine("1 - Sim");
        Console.WriteLine("2 - Não");
        option = Convert.ToInt32(Console.ReadLine());

        Console.Clear();

      } while (option != 1);

    }
  }
}
