using System;

namespace variable
{
    class guessingGame
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numberToGuess = random.Next(1,21);
           
            Console.WriteLine("Welcome to 'Guess the Number'");
            //Console.WriteLine(numberToGuess);
       
    
            for (int guessCtr = 0; guessCtr < 5; guessCtr++) 
            {

                    Console.WriteLine ("Please enter a number between 1 and 20");
                    string inputString = Console.ReadLine();
                    int num = int.Parse (inputString);

                    if (num == numberToGuess)
                    {
                        Console.WriteLine ("Your answer is correct");
                        break;
                    }
                    else 
                    {
                        if (num < numberToGuess)

                        {
                            Console.WriteLine ("Your answer is lower");

                        }
                    
                        else 
                        {
                        Console.WriteLine ("Your answer is higher ");

                        }
                    }

            }


        
        }   


    }
}
