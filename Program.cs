using System;
using System.Threading;

namespace GuessNumber
{
  class Program
  {
    static void Main(string[] args)
    {

      while (true)
      {

        var guess = 50;
        var high = 100;
        var low = 1;

        Console.Clear();
        string welcome = "Welcome to the Magical Mystery Number Dungeon. I am the Dungeon's master Babu, and I will guess any number you choose between 1 and 100. Open your mind and choose your number.";
        foreach (char c in welcome)
        {
          Console.Write(c);
          Thread.Sleep(50);
        }

        Console.WriteLine("\nPress SPACE_BAR to continue");
        Console.ReadKey();
        string firstGuess = $"BABU IS USING HIS TELEPATHIC POWERS.....Is {guess} your Magical Number??!!\nYou MUST type YES if I am correct!, or tell me HIGHER OR LOWER.\n";
        foreach (char c in firstGuess)
        {
          Console.Write(c);
          Thread.Sleep(50);
        }

        var input = Console.ReadLine();

        while (input != "yes")

        {

          if (input == "lower")
          {
            high = guess;
            guess = (low + high) / 2;
            string lowerGuess = $"BABU IS USING HIS TELEPATHIC POWERS.....Is {guess} your Magical Number??!! You MUST type YES if I am correct!, or tell me HIGHER OR LOWER.\n";
            foreach (char c in lowerGuess)
            {
              Console.Write(c);
              Thread.Sleep(50);
            }
            input = Console.ReadLine();
          }

          if (input == "higher")
          {
            low = guess;
            guess = (low + high) / 2;
            string higherGuess = $"BABU IS USING HIS TELEPATHIC POWERS.....Is {guess} your Magical Number??!! You MUST type YES if I am correct!, or tell me HIGHER OR LOWER.\n";
            foreach (char c in higherGuess)
            {
              Console.Write(c);
              Thread.Sleep(50);
            }
            input = Console.ReadLine();
          }
        }

        if (input == "yes")
        {
          string correct = "HAHAHAHA Babu's superior power has chosen wisely ONCE AGAIN! Please come back soon to my Magical Dungeon!!\n";
          foreach (char c in correct)
          {
            Console.Write(c);
            Thread.Sleep(50);

          }
          string again = "\nWould you like to play again? Type y or n\n";
          foreach (char c in again)
          {
            Console.Write(c);
            Thread.Sleep(50);
          }
          input = Console.ReadLine();
          if (input != "y") break;
        }
      }
    }
  }
}
