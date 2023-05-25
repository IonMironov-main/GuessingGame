namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int answer = 7;

            int userGuess;
            int count = 4;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10:");
                userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == answer)
                {
                    Console.WriteLine("How'd you know?!");
                }

                else if (userGuess > 10)
                {
                    Console.WriteLine("Your answer must be between 1 and 10.");
                }

                else
                {
                    Console.WriteLine($"Sorry, that's incorrect.You have {count - 1} attempt(s) left.");
                    count--;
                    if (count == 0)
                    {
                        Console.WriteLine("You have reached your max amount of tries. Sorry!");
                        break;
                    }
                }
            } while (userGuess != answer);
        }
    }
}