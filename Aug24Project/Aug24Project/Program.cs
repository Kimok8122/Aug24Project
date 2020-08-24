using System;

namespace Aug24Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------- Exercise 1
            // Name: Michael
            // Favorite Color: Blue
            // Favorite Animal: Walrus
            // Favorite Band: The Beatles

            Console.WriteLine("Welcome, may I ask for your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Thanks,{userName} what's you favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"Good Choice of {color}, if you could be any animal, what aniaml would it be?");
            var animal = Console.ReadLine();

            Console.WriteLine("Final question, what's your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Again, Welcome {userName}, I look forward to seeing a {color} {animal} while listening to {band} very soon :)");



        }
    }
}
