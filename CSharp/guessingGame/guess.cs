using System;

namespace variable
{
    class Program
    {




static void Main(string[] args)
{
    const int MAX_NUMBER = 20;
    
    Random random = new Random();
    int numberToGuess = random.Next(MAX_NUMBER) + 1;
    int userGuess = 0;
    int guesses = 0;
    
    Console.WriteLine("Welcome to 'Guess the Number'");
    Console.WriteLine("The number is between 1 and {0}.", MAX_NUMBER);

    while (userGuess != numberToGuess && guesses<5) 
    {
        guesses++;
        
        Console.Write("Enter your guess: ");
        int.TryParse(Console.ReadLine(), out userGuess);

        if (userGuess > numberToGuess)
        {
            Console.WriteLine("{0} is too high!", userGuess);
        }
        else if (userGuess < numberToGuess)
        {
            Console.WriteLine("{0} is too low!", userGuess);
        }
        else
        {
            Console.WriteLine("{0} is right! Congratulations.", userGuess);
            Console.WriteLine("Number of guesses: {0}", guesses);
        }
    }
}

    }
}