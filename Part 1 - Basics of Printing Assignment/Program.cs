using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1___Basics_of_Printing_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Basics Of Printing Assignment");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Welcome to the Basics of Printing Assignment");
            Console.WriteLine();

            string firstName = "Naika";
            string favMovie = " The Matrix";

            Console.WriteLine($"hey there, my name is {firstName} and " +
                $"my favourite movie is the {favMovie}");

            Console.WriteLine(firstName.ToLower());
            Console.WriteLine(favMovie.ToLower());

            Console.WriteLine(favMovie.ToUpper());
            Console.WriteLine($"{favMovie}");

            Console.WriteLine(favMovie.Contains("THE"));

            favMovie = favMovie.Replace("A", "@");
            favMovie = favMovie.Replace("E", "3");
            Console.WriteLine(favMovie);
        }
    }
}
