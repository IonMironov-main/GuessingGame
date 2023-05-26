namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int answer = rnd.Next(11);
            int userGuess;
            int count = 4;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10");
                userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == answer)
                {
                    Console.WriteLine("How'd you know?!");
                }
                else if (userGuess > 10)
                {
                    Console.WriteLine("Your answer must be between 1 and 10");

                }
                else if (answer != userGuess)
                {
                    if (answer > userGuess)
                    {
                        Console.WriteLine($"Sorry, that's incorrect. You were {answer - userGuess} digits away from the correct answer. You now have {count - 1} attempt(s) left");
                        count--;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, that's incorrect. You were {userGuess - answer} digits away from the correct answer. You now have {count - 1} attempt(s) left");
                        count--;
                    }

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