//imports libraries that allows us to use objects and methods
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//defining the namespace of this entire project
namespace Lab1_HelloWorld
{
    //the first class of the program, houses methods and properties/vars needed
    class Program
    {
        //first method of class
        static void Main(string[] args)
        {
            //defining variables for user's first and last names
            String firstName = "", lastName = "", fullName = "";
            int answer = 0;


            //asking and reading input for first name 
            Console.Write("Please enter your first name: ");
            firstName = Console.ReadLine();

            //asking and reading input for last name 
            Console.Write("Please enter your last name: ");
            lastName = Console.ReadLine();

            //asking how they would like their name presented
            Console.Write("Would you like you like to be greeted by your last name first? (Y/N) ");
            answer = Console.Read();

            //assigning fullName according to user preference
            if (answer == 121 || answer == 89)
                fullName = lastName + ", " + firstName;
            else
                fullName = firstName + ", " + lastName;

            //greeting user using their full name
            Console.WriteLine("\nHello " + fullName);
        }
    }
}

