using System;
//number guessing game using ()(random , loops) X over under 7 (two dice)
namespace GuessNumber
{
    class NumberGuesser
    {
        static void Main(string[] arg)
        {
            System.Console.WriteLine("Hello");
            Random random = new Random();
            int? diceOne = random.Next(1,6);
            int? diceTwo = random.Next(1,6);
            int? totalScore = diceOne+diceTwo;

        }
    }
}