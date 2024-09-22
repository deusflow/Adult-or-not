using System;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Interactive Program!"); // Greeting message

            // Ask for user's name
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine(); // Get name from user

            // Ask for user's age
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine()); // Get age from user

            // Ask for user's favorite color
            Console.WriteLine("What is your favorite color?");
            string favoriteColor = Console.ReadLine(); // Get favorite color from user

            // Personalized greeting
            Console.WriteLine($"Hello {name}! Your favorite color is {favoriteColor}."); 

            // Check if user is an adult or a child
            if (age > 18)
            {
                Console.WriteLine(name + ", you are an adult!");
            }
            else
            {
                Console.WriteLine(name + ", you are a child.");
            }

            // Closing message
            Console.WriteLine($"Thank you for sharing, {name}. Have a great day with lots of {favoriteColor}!");
        }
    }
}