using System;

namespace CsharpTaskThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            int guess = 0;
            bool gameOver = false;
                        
            Console.WriteLine("This is a number guessing game. \nSelect a game level:");
            string[] gameLevel = {"1 for Easy", "2 for Medium", "3 for Hard"};
            foreach(string i in gameLevel)
            {
                Console.WriteLine(i);
            }

            try
            {
                Console.Write("Level: ");
                input = int.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                Console.WriteLine("Please enter a number");
            }
            if(input == 1)
            {           
                Random random = new Random();
                int correctNumber = random.Next(1, 11);
                Console.WriteLine("Guess a number from 1 to 10");
                int guessLimit = 6;

                while(gameOver == false)
                {
                    try
                    {
                        Console.Write("Guess: ");
                        guess = int.Parse(Console.ReadLine());
                                                                              
                        if(guess == correctNumber)
                        {
                            Console.WriteLine("That's correct! YOU WIN!!");
                            gameOver = true;
                        }
                        else if(guess != correctNumber && guessLimit == 1)
                        {
                            Console.WriteLine("You failed to guess the number. Game over!");
                            gameOver = true;
                        }
                        else
                        {
                            guessLimit -= 1;
                            Console.WriteLine($"Wrong! You have {guessLimit} guess(es) remaining");
                        }
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Please enter a number");
                    }                
                }
            }
            if(input == 2)
            {           
                Random random = new Random();
                int correctNumber = random.Next(1, 21);
                Console.WriteLine("Guess a number from 1 to 20");
                int guessLimit = 4;

                while(gameOver == false)
                {
                    try
                    {
                        Console.Write("Guess: ");
                        guess = int.Parse(Console.ReadLine());         

                        if(guess == correctNumber)
                        {
                            Console.WriteLine("That's correct! YOU WIN!!");
                            gameOver = true;
                        }
                        else if(guess != correctNumber && guessLimit == 1)
                        {
                            Console.WriteLine("You failed to guess the number. Game over!");
                            gameOver = true;
                        }
                        else
                        {
                            guessLimit -= 1;
                            Console.WriteLine($"Wrong! You have {guessLimit} guess(es) remaining");
                        }
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Please enter a number");
                    }                
                }
                
            }
            if(input == 3)
            {           
                Random random = new Random();
                int correctNumber = random.Next(1, 51);
                Console.WriteLine("Guess a number from 1 to 50");
                int guessLimit = 3;

                while(gameOver == false)
                {
                    try
                    {
                        Console.Write("Guess: ");
                        guess = int.Parse(Console.ReadLine());
                        
                        if(guess == correctNumber)
                        {
                            Console.WriteLine("That's correct! YOU WIN!!");
                            gameOver = true;
                        }
                        else if(guess != correctNumber && guessLimit == 1)
                        {
                            Console.WriteLine("You failed to guess the number. Game over!");
                            gameOver = true;
                        }
                        else
                        {
                            guessLimit -= 1;
                            Console.WriteLine($"Wrong! You have {guessLimit} guess(es) remaining"); 
                        }
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Please enter a number");
                    }
                }
                
            }
        } 
    }
}
