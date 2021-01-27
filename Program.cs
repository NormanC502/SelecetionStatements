using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 5;

            Console.WriteLine("What number are you thinking of? Hint it's in the middle somewhere!");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber) 
            {
                Console.WriteLine("Too Low, Try again!");
            }
            else if (userInput > favNumber) 
            {
                Console.WriteLine("Too High, Try again!");
            }
            else if (userInput == favNumber)
            {
                Console.WriteLine("You know me, Hooray!");
            }
            else
            {
                Console.WriteLine("Never Mind, you didn't get it!");
            }            
        }
    }
}
