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
        Console.WriteLine("3 - Ver o Rank");
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

        if (opcao == 3)
        {
          Console.Clear();
          VerRank();
        }

        if (opcao == 0)
        {
          Environment.Exit(0);
        }

      } while (opcao != 0);

    }

    private static void VerRank()
    {
      ChallengeController challengeController = new ChallengeController();
      var option = 0;

      do
      {
        var rank = challengeController.ListRank();

        foreach (var item in rank)
        {
          Console.WriteLine($"{item.Player.Nome} - {item.Player.Email}: {item.Score}\n");
        }
        Console.WriteLine("Digite 0 para sair");
        option = Convert.ToInt32(Console.ReadLine());

        Console.Clear();

      } while (option != 0);
    }

    private static void InciarDesafio()
    {
      ChallengeController challengeController = new ChallengeController();
      QuestionController questionController = new QuestionController();
      PlayerController playerController = new PlayerController();
      List<Answer> responseList = new List<Answer>();
      Player player = new Player();
      Challenge challenge = new Challenge();
      var option = 0;
      var response = 0;

      do
      {

        Console.WriteLine("Digite o seu Nome:");
        player.Nome = Console.ReadLine();

        Console.WriteLine("Digite o seu Email:");
        player.Email = Console.ReadLine();
        int idPlayer = playerController.AddPlayer(player);

        Console.Clear();

        var questions = questionController.GetQuestions();

        foreach (var question in questions)
        {
          Console.WriteLine(question.Title);

          for (int i = 0; i < question.Answers.Count(); i++)
          {
            Console.WriteLine($"{(i + 1)} - {question.Answers[i].Alternative}");
          }
          response = Convert.ToInt32(Console.ReadLine());

          var selectedAnswer = question.Answers[response - 1];

          responseList.Add(selectedAnswer);

          Console.Clear();
        }
        var score = challengeController.CheckCorrectAnswer(responseList);

        Console.WriteLine($"Sua pontuação foi de {score} pontos");

        challenge.IdPlayer = idPlayer;
        challenge.Score = score;

        challengeController.SaveChallenge(challenge);

        Console.WriteLine("Deseja tentar novamente?");
        Console.WriteLine("1 - Sim");
        Console.WriteLine("2 - Não");
        option = Convert.ToInt32(Console.ReadLine());

        Console.Clear();

      } while (option != 2);

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

      } while (option != 2);

    }
  }
}
