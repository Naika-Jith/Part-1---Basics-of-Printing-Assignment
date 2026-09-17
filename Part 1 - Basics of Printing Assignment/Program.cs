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
            Console.WriteLine("Please press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the Basics of Printing Assignment");
            Console.WriteLine();

            string firstName = "Naika";
            string favMovie = "The Matrix";


            Console.WriteLine($"hey there, my name is {firstName.ToLower()} and my favourite movie is {favMovie.ToLower()}");
            Console.WriteLine();


            favMovie = favMovie.ToUpper();
            Console.WriteLine(favMovie);
            Console.WriteLine();
           Console.WriteLine(favMovie.Contains("THE"));
            Console.WriteLine();

            favMovie = favMovie.Replace("A", "@");
            favMovie = favMovie.Replace("E", "3");
            Console.WriteLine(favMovie);

            //ASCII ART

            Console.WriteLine(" __         __\r\n/  \\.-\"\"\"-./  \\\r\n\\    -   -    /\r\n |   o   o   |\r\n \\  .-'''-.  /\r\n  '-\\__Y__/-'\r\n     `---`");
            Console.Write("((_,...,_))\r\n   |o o|\r\n   \\   /\r\n    ^_^   ");

        }
    }
}
