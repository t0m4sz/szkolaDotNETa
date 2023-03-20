using System;
using System.ComponentModel;
using Uno;

namespace Week2
{
    public class Program
    {
        private const int TEXT_COLOR = (int)ConsoleColor.Green;
        private const int CODE_COLOR = (int)ConsoleColor.DarkCyan;

        static void Main(string[] args)
        {
            MenuActionService actionService = new MenuActionService();

            InitializeConsole();            
            InitializeMenu(actionService);

            Console.WriteLine("Welcome to week 2 homework app!");
            Console.WriteLine("Please select exercises from which lessons you would like to see?");

            var mainMenu = actionService.GetMenuActionsByMenuName("Main");
            foreach (var menuElement in mainMenu)
            {
                Console.WriteLine($"{menuElement.Id} {menuElement.Description}");
            }

            var actionChoice = Console.ReadKey();

            switch (actionChoice.KeyChar)
            {
                case '1':
                    Console.WriteLine("The number is 1!");
                    break;
                case '2':
                    Console.WriteLine("The number is 2!");
                    break;
                case '3':
                    Console.WriteLine("The number is 3!");
                    break;
                default:
                    Console.WriteLine("Sorry, that is not a valid number. Try again!");
                    break;
            }

        }
        private static void ShowMenu()
        {
            Program.WriteColorTextLine("\r\nExercise [1]", TEXT_COLOR);
            
            
            Program.WriteColorTextLine("\r\nExercise [2]", TEXT_COLOR);
            
            
            Program.WriteColorTextLine("\r\nExercise [3]", TEXT_COLOR);
            

            Program.WriteColorTextLine("\r\nExercise [4]", TEXT_COLOR);
            

            Program.WriteColorTextLine("\r\nExercise [5]", TEXT_COLOR);
            

            Console.WriteLine("\nPlease choose which exercise you want to check (1-5):");
        }

        private static void WriteColorTextLine(string txt, int txtColor)
        {
            Console.ForegroundColor = (ConsoleColor)txtColor;
            Console.WriteLine(txt);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void InitializeConsole() 
        {
            Console.Clear();
            Console.Title = "Szkola dotNETa - Week 2";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WindowHeight = 50;
        }

        private static void InitializeMenu(MenuActionService actionService)
        {
            actionService.AddNewAction(1, "Lesson 4", "Main");
            actionService.AddNewAction(2, "Lesson 7", "Main");
            actionService.AddNewAction(3, "Lesson 8", "Main");

            actionService.AddNewAction(1, "Create a program in which you declare variables about company employee data. The data you want to hold are:\r\n\ta. First name,\r\n\tb. Last name\r\n\tc. Age\r\n\td. Gender ('m' or 'k')\r\n\te. PESEL\r\n\tf. Employee number (e.g. 2509324094)\r\nDeclare variables of appropriate types that can hold this information", "Lesson4");
            actionService.AddNewAction(2, "Write a program in which you create 3 variables with one letter, and then write them out in the reverse order of how they were declared.", "Lesson4");
            actionService.AddNewAction(3, "Write a program that calculates the length of the diagonal based on the given width and length of the rectangle. (To calculate the square of a number use Math.Pow() method)", "Lesson4");
            actionService.AddNewAction(4, "Write a program in which you create 2 numeric variables and one text variable, and then assign them the following values:\r\n\ta. 10\r\n\tb. Dotnet school\r\n\tc. 12,5\r\nRemember to use the correct data types.", "Lesson4");
            actionService.AddNewAction(5, "Write a program in which you ask a user for his/her personal information, i.e. First name, last name, phone number, email address, height, weight (e.g. 85.7), etc. (try to come up with as many as possible) and try to convert the response to the appropriate data type using  method:\r\ndataType.Parse(responseFromUser)", "Lesson4");
            


        }
    }

}