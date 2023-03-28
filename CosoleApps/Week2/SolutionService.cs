using System;
using Uno.Extensions;

namespace Week2
{
    public static class SolutionService
    {
        private static void SolutionCaptionView()
        {
            Console.ForegroundColor = Helpers.SOLUTION_CAPTION_COLOR;
            Console.WriteLine("SOLUTION");
            Console.ForegroundColor = Helpers.TEXT_COLOR;
        }

        private static bool ExitSolutionMenuView()
        {
            Console.Write("\r\nPress 'a' key to run script again. \r\nPress any other key to return to previous menu :");
            ConsoleKeyInfo choice = Console.ReadKey();
            switch (choice.KeyChar)
            {
                case 'a':
                    return true;                    
                default:
                    return false;
            }
        }
        public static void ShowExerciseSolution(int exerciseNumber, string lessonNumber)
        {
            
            if (exerciseNumber == 1 && lessonNumber == "Lesson4")
            {
                SolutionCaptionView();
                Console.WriteLine("There is no console output. Only code to review.");
                Console.ForegroundColor = Helpers.CODE_COLOR;
                Console.WriteLine(" \r\nstring name;\r\nstring surname;\r\nint age;\r\nchar sex;\r\nint personalIdNumber;\r\nstring employeeId;");
                Console.ForegroundColor = Helpers.TEXT_COLOR;
                Console.WriteLine("\r\nPress any key to return to the previous menu...");
                Console.ReadKey();
            }
            else if (exerciseNumber == 2 && lessonNumber == "Lesson4") 
            {
                SolutionCaptionView();
                Console.WriteLine("Code to review.");
                Console.ForegroundColor = Helpers.CODE_COLOR;
                Console.WriteLine("\r\nchar a = \'a\';\r\nchar b = \'b\';\r\nchar c = \'c\';");
                Console.WriteLine("Console.WriteLine($\"{c} {b} {a}\");\r\n");
                Console.ForegroundColor = Helpers.SOLUTION_CAPTION_COLOR;
                Console.WriteLine("Console output:");
                Console.ForegroundColor = Helpers.TEXT_COLOR;
                
                char a = 'a'; char b = 'b'; char c = 'c';
                Console.WriteLine($"{c} {b} {a}");

                Console.WriteLine("\r\nPress any key to return to the previous menu...");
                Console.ReadKey();
            }
            else if (exerciseNumber == 3 && lessonNumber == "Lesson4")
            {
                SolutionCaptionView();
                bool continueLoop = true;
                while (continueLoop)
                {
                    double a; 
                    double b; 
                    double diagonal;
                    Console.Write("\r\nGive the length of side A of the rectangle: ");
                    Double.TryParse(Console.ReadLine(),out a);
                    Console.Write("Give the length of side B of the rectangle: ");
                    Double.TryParse(Console.ReadLine(), out b);

                    diagonal = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

                    string result = diagonal.ToString("F2");
                    Console.WriteLine($"Your diagonal length is: {result}");

                    continueLoop = ExitSolutionMenuView();                 
                }
            }
            else if (exerciseNumber == 4 && lessonNumber == "Lesson4")
            {
                SolutionCaptionView();
                Console.WriteLine("There is no console output. Only code to review.");
                Console.ForegroundColor = Helpers.CODE_COLOR;
                Console.WriteLine("\r\nint numberI = 10;\r\nstring text = \"Szkoła Dotneta\";\r\ndouble numberD = 12.5;\r\n");
                Console.ForegroundColor = Helpers.TEXT_COLOR;
                Console.WriteLine("\r\nPress any key to return to the previous menu...");
                Console.ReadKey();
            }
            else if (exerciseNumber == 5 && lessonNumber == "Lesson4")
            {
                SolutionCaptionView();
                Console.WriteLine("Welcome to the app! Please provide some information below.");
                bool continueLoop = true;
                while (continueLoop)
                {
                    string name = string.Empty;
                    string lastName = string.Empty;
                    string phoneNumber = string.Empty;
                    string email = string.Empty;
                    double height = 0;
                    double weight = 0;
                    int age = 0;
                    
                    Console.Write("\r\nWhat is your name: ");
                    name = Console.ReadLine();
                    while (name.IsNullOrEmpty())
                    {
                        Console.ForegroundColor = Helpers.WARNING_COLOR;
                        Console.WriteLine("You didn't provide any info! Try again.");
                        Console.ForegroundColor = Helpers.TEXT_COLOR;
                        Console.Write("What is your name: ");
                        name = Console.ReadLine();
                    }
                    Console.Write("What is your last name: ");
                    lastName = Console.ReadLine();
                    while (lastName.IsNullOrEmpty())
                    {
                        Console.ForegroundColor = Helpers.WARNING_COLOR;
                        Console.WriteLine("You didn't provide any info! Try again.");
                        Console.ForegroundColor = Helpers.TEXT_COLOR;
                        Console.Write("What is your name: ");
                        lastName = Console.ReadLine();
                    }
                    Console.Write("Your phone number: ");
                    phoneNumber = Console.ReadLine();
                    while (phoneNumber.IsNullOrEmpty())
                    {
                        Console.ForegroundColor = Helpers.WARNING_COLOR;
                        Console.WriteLine("You didn't provide any info! Try again.");
                        Console.ForegroundColor = Helpers.TEXT_COLOR;
                        Console.Write("What is your name: ");
                        phoneNumber = Console.ReadLine();
                    }
                    Console.Write("Type your email address: ");
                    email = Console.ReadLine();
                    while (email.IsNullOrEmpty())
                    {
                        Console.ForegroundColor = Helpers.WARNING_COLOR;
                        Console.WriteLine("You didn't provide any info! Try again.");
                        Console.ForegroundColor = Helpers.TEXT_COLOR;
                        Console.Write("What is your name: ");
                        email = Console.ReadLine();
                    }
                    Console.Write("What is your age in years: ");
                    while (!Int32.TryParse(Console.ReadLine(), out age))
                    {
                        Console.ForegroundColor = Helpers.WARNING_COLOR;
                        Console.WriteLine("It is not valid number! Try again.");
                        Console.ForegroundColor = Helpers.TEXT_COLOR;
                        Console.Write("What is your age in years: ");
                    }
                    Console.Write("What is your height: ");
                    while (!Double.TryParse(Console.ReadLine(), out height))
                    {
                        Console.ForegroundColor = Helpers.WARNING_COLOR;
                        Console.WriteLine("It is not valid number! Try again.");
                        Console.ForegroundColor = Helpers.TEXT_COLOR;
                        Console.Write("What is your height in cm: ");
                    }
                    Console.Write("What is your weight in kg: ");
                    while (!Double.TryParse(Console.ReadLine(), out weight))
                    {
                        Console.ForegroundColor = Helpers.WARNING_COLOR;
                        Console.WriteLine("It is not valid number! Try again.");
                        Console.ForegroundColor = Helpers.TEXT_COLOR;
                        Console.Write("What is your weight in kg: ");
                    }
                    Console.WriteLine("\r\nBelow information you provided:");
                    Console.Write($"Your name is {name} {lastName}.\r\nYou are {age} years old.\r\nYour phone number is {phoneNumber}.\r\nYour email address is {email}.\r\nYou are {height}cm tall and your weight is {weight}kg.\r\n");
                    continueLoop = ExitSolutionMenuView();
                }
            }
            else if (exerciseNumber == 1 && lessonNumber == "Lesson7")
            {
                Console.WriteLine("Rozwiazanie zadania 1 lekcja 7");
                Console.ReadKey();
            }
            else if (exerciseNumber == 2 && lessonNumber == "Lesson7")
            {
                Console.WriteLine("Rozwiazanie zadania 2 lekcja 7");
                Console.ReadKey();
            }
            else if (exerciseNumber == 3 && lessonNumber == "Lesson7")
            {
                Console.WriteLine("Rozwiazanie zadania 3 lekcja 7");
                Console.ReadKey();
            }
            else if (exerciseNumber == 4 && lessonNumber == "Lesson7")
            {
                Console.WriteLine("Rozwiazanie zadania 4 lekcja 7");
                Console.ReadKey();
            }
            else if (exerciseNumber == 5 && lessonNumber == "Lesson7")
            {
                Console.WriteLine("Rozwiazanie zadania 5 lekcja 7");
                Console.ReadKey();
            }
            else if (exerciseNumber == 6 && lessonNumber == "Lesson7")
            {
                Console.WriteLine("Rozwiazanie zadania 6 lekcja 7");
                Console.ReadKey();
            }
            else if (exerciseNumber == 7 && lessonNumber == "Lesson7")
            {
                Console.WriteLine("Rozwiazanie zadania 7lekcja 7");
                Console.ReadKey();
            }
            else if (exerciseNumber == 8 && lessonNumber == "Lesson7")
            {
                Console.WriteLine("Rozwiazanie zadania 8 lekcja 7");
                Console.ReadKey();
            }
            else if (exerciseNumber == 9 && lessonNumber == "Lesson7")
            {
                Console.WriteLine("Rozwiazanie zadania 9 lekcja 7");
                Console.ReadKey();
            }
            else if (exerciseNumber == 10 && lessonNumber == "Lesson7")
            {
                Console.WriteLine("Rozwiazanie zadania 10 lekcja 7");
                Console.ReadKey();
            }
            else if (exerciseNumber == 11 && lessonNumber == "Lesson7")
            {
                Console.WriteLine("Rozwiazanie zadania 11 lekcja 7");
                Console.ReadKey();
            }
            else if (exerciseNumber == 12 && lessonNumber == "Lesson7")
            {
                Console.WriteLine("Rozwiazanie zadania 12 lekcja 7");
                Console.ReadKey();
            }
            else if (exerciseNumber == 13 && lessonNumber == "Lesson7")
            {
                Console.WriteLine("Rozwiazanie zadania 13 lekcja 7");
                Console.ReadKey();
            }
            else if (exerciseNumber == 1 && lessonNumber == "Lesson8")
            {
                Console.WriteLine("Rozwiazanie zadania 1 lekcja 8");
                Console.ReadKey();
            }
            else if (exerciseNumber == 2 && lessonNumber == "Lesson8")
            {
                Console.WriteLine("Rozwiazanie zadania 2 lekcja 8");
                Console.ReadKey();
            }
            else if (exerciseNumber == 3 && lessonNumber == "Lesson8")
            {
                Console.WriteLine("Rozwiazanie zadania 3 lekcja 8");
                Console.ReadKey();
            }
            else if (exerciseNumber == 4 && lessonNumber == "Lesson8")
            {
                Console.WriteLine("Rozwiazanie zadania 4 lekcja 8");
                Console.ReadKey();
            }
            else if (exerciseNumber == 5 && lessonNumber == "Lesson6")
            {
                Console.WriteLine("Rozwiazanie zadania 5 lekcja 8");
                Console.ReadKey();
            }
            else if (exerciseNumber == 6 && lessonNumber == "Lesson8")
            {
                Console.WriteLine("Rozwiazanie zadania 6 lekcja 8");
                Console.ReadKey();
            }
            else if (exerciseNumber == 7 && lessonNumber == "Lesson8")
            {
                Console.WriteLine("Rozwiazanie zadania 7lekcja 8");
                Console.ReadKey();
            }
            else if (exerciseNumber == 8 && lessonNumber == "Lesson8")
            {
                Console.WriteLine("Rozwiazanie zadania 8 lekcja 8");
                Console.ReadKey();
            }
            else if (exerciseNumber == 9 && lessonNumber == "Lesson8")
            {
                Console.WriteLine("Rozwiazanie zadania 9 lekcja 8");
                Console.ReadKey();
            }
            else if (exerciseNumber == 10 && lessonNumber == "Lesson8")
            {
                Console.WriteLine("Rozwiazanie zadania 10 lekcja 8");
                Console.ReadKey();
            }

        }

                
    }
}
