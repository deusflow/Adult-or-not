using System;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine(); // Get name from user

            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine()); // Get age from user

            if (age > 18)
            {
                Console.WriteLine(name + ", you are an adult!");
            }
            else
            {
                Console.WriteLine(name + ", you are a child.");
            }
        }
    }
}