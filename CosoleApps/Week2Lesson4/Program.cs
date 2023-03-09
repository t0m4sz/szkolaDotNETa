using System.Diagnostics.Metrics;

namespace Week2Lesson4
{
    internal class Program
    {
        static void ShowMenu()
        {
            Console.WriteLine("Welcome to the homework app created for Week 2 Lesson 4 exercises. Below there is a list of tasks to do:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nExercise [1]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Create a program in which you declare variables about company employee data. The data you want to hold are:\r\n\ta. First name,\r\n\tb. Last name\r\n\tc. Age\r\n\td. Gender ('m' or 'k')\r\n\te. PESEL\r\n\tf. Employee number (e.g. 2509324094)\r\nDeclare variables of appropriate types that can hold this information ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nExercise [2]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Write a program in which you create 3 variables with one letter, and then write them out in the reverse order of how they were declared.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nExercise [3]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Write a program that calculates the length of the diagonal based on the given width and length of the rectangle. (To calculate the square of a number use Math.Pow() method)");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nExercise [4]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Write a program in which you create 2 numeric variables and one text variable, and then assign them the following values:\r\n\ta. 10\r\n\tb. Dotnet school\r\n\tc. 12,5\r\nRemember to use the correct data types.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nExercise [5]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Write a program in which you ask a user for his/her personal information, i.e. First name, last name, phone number, email address, height, weight (e.g. 85.7), etc. (try to come up with as many as possible) and try to convert the response to the appropriate data type using  method:\r\ndataType.Parse(responseFromUser)");
            Console.WriteLine("\nPlease chose which excersie you want to check (1-5):");
        }
        static void Main(string[] args)
        {
            int choice;

            Console.Clear();
            Console.Title = "Homework - Week 2 lesson 4";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WindowHeight = 50;
            Program.ShowMenu();

            Int32.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("The number is zero!");
                    break;
                case 2:
                    Console.WriteLine("The number is one!");
                    break;
                case 3:
                    Console.WriteLine("The number is one!");
                    break;
                case 4:
                    Console.WriteLine("The number is one!");
                    break;
                case 5:
                    Console.WriteLine("The number is one!");
                    break;
                default:
                    Console.WriteLine("I'm sorry, I don't understand that!");
                    break;
            }

        }

        


    }
}