namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int answer = 7;
            Console.WriteLine("Guess a number between 1 and 10:");

            int userGuess = Convert.ToInt32(Console.ReadLine());

            if (userGuess == answer)
            {
                Console.WriteLine("How'd you know?!");
            }
            else if (userGuess > 10)
            {
                Console.WriteLine("Your answer must be between 1 and 10");
            }
            else
                Console.WriteLine("Sorry, that's incorrect.");
        }
    }
}