using System;

namespace Aug24Project
{
    class Program
    {
        //-----------------  Exercise 2
        // Methods for Sum and Multiply 

        public static int Sum(int num1, int num2)
            {
            var sumAnswer = num1 + num2;
            return sumAnswer;
        }

        public static int Multiply(int num1, int num2)
            {
            var multiAnswer = num1 * num2;
            return multiAnswer;

        }

        static void Main(string[] args)
        {

 
            //-------------- Exercise 1
            //USER ADDED INFO
            // Name: 
            // Favorite Color:
            // Favorite Animal: 
            // Favorite Band:

            Console.WriteLine("Welcome, may I ask for your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Thanks,{userName} what's you favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"Good Choice of {color}, if you could be any animal, what aniaml would it be?");
            var animal = Console.ReadLine();

            Console.WriteLine("Final question, what's your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Again, Welcome {userName}, I look forward to seeing a {color} {animal} while listening to {band} very soon :)");

            Console.WriteLine($"Let's move on and see our next set of questions. Hit enter when ready.");
            var enter = Console.ReadLine();

            Console.WriteLine("How old are you, may I ask?");
            var num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("How many times have you seen the movie Deadpool?");
            var num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"So adding those two numbers you entered I get {Sum(num1,num2)}.");

            Console.WriteLine($"Then mulitpling those two numbers you entered I get {Multiply(num1, num2)}.");


        }
    }
}
