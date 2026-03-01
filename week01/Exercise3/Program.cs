using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;
        do {
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 100), userNumber;    
            do
            {
                while (true)
                {
                Console.WriteLine("Whats is your guess? ");
                string userInput = Console.ReadLine();
                    if (int.TryParse(userInput, out userNumber) && userNumber <= 100 )
                    {
                    break;
                    }
                    else
                    {
                        Console.WriteLine("Please type a number between 1 to 100");
                    }
                }
            
                if (userNumber > randomNumber) Console.WriteLine("Lower");
                else if (userNumber < randomNumber) Console.WriteLine("Higer");
                else Console.WriteLine("You guess it");     

            }while(userNumber!=randomNumber);
            
            Console.WriteLine("Play again? yes/no");
            playAgain = Console.ReadLine();

        }while(playAgain =="yes");
                   
    }
}