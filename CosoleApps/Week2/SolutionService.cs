using System;
using System.Net.NetworkInformation;
using System.Xml.Linq;

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
        private static void WarningMessageView(string message)
        {
            Console.ForegroundColor = Helpers.WARNING_COLOR;
            Console.WriteLine(message);
            Console.ForegroundColor = Helpers.TEXT_COLOR;
        }
        private static int ReadIntFromInput(string inputMessage)
        {
            int value = 0;
            bool isValid = false;
            while (!isValid)
            {
                Console.Write(inputMessage);
                isValid = Int32.TryParse(Console.ReadLine(), out value);
                if (!isValid)
                {
                    WarningMessageView("It is not valid number! Try again.");
                }
            }
            return value;
        }
        private static double ReadDoubleFromInput(string inputMessage)
        {
            double value = 0;
            bool isValid = false;
            while (!isValid)
            {
                Console.Write(inputMessage);
                isValid = Double.TryParse(Console.ReadLine(), out value);
                if (!isValid)
                {
                    WarningMessageView("It is not valid number! Try again.");
                }
            }
            return value;
        }
        private static string ReadStringFromInput(string inputMessage)
        {
            string inputText = "";
            bool isEmpty = true;
            while (isEmpty)
            {
                Console.Write(inputMessage);
                inputText = Console.ReadLine();
                isEmpty = String.IsNullOrEmpty(inputText);
                if (isEmpty)
                {
                    WarningMessageView("You didn't provide any info! Try again.");
                }
            }
            return inputText;
        }
        private static void WriteColorText(string text, ConsoleColor colour)
        {
            Console.ForegroundColor = colour;
            Console.WriteLine(text);
            Console.ForegroundColor = Helpers.TEXT_COLOR;
        }
        public static void ShowExerciseSolution(int exerciseNumber, string lessonNumber)
        {

            if (exerciseNumber == 1 && lessonNumber == "Lesson4")
            {
                SolutionCaptionView();
                Console.WriteLine("There is no console output. Only code to review.");
                WriteColorText(" \r\nstring name;\r\nstring surname;\r\nint age;\r\nchar sex;\r\nint personalIdNumber;\r\nstring employeeId;", Helpers.CODE_COLOR);

                Console.WriteLine("\r\nPress any key to return to the previous menu...");
                Console.ReadKey();
            }
            else if (exerciseNumber == 2 && lessonNumber == "Lesson4")
            {
                SolutionCaptionView();
                Console.WriteLine("Code to review.");
                WriteColorText("\r\nchar a = \'a\';\r\nchar b = \'b\';\r\nchar c = \'c\';\r\nConsole.WriteLine($\"{c} {b} {a}\");\r\n", Helpers.CODE_COLOR);
                WriteColorText("Console output:", Helpers.SOLUTION_CAPTION_COLOR);

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
                    Console.WriteLine();
                    double a = ReadDoubleFromInput("Give the length of side A of the rectangle: ");
                    double b = ReadDoubleFromInput("Give the length of side B of the rectangle: "); ;
                    double diagonal = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

                    string result = diagonal.ToString("F2");
                    Console.WriteLine($"Your diagonal length is: {result}");
                    continueLoop = ExitSolutionMenuView();
                }
            }
            else if (exerciseNumber == 4 && lessonNumber == "Lesson4")
            {
                SolutionCaptionView();
                Console.WriteLine("There is no console output. Only code to review.");
                WriteColorText("\r\nint number = 10;\r\nstring text = \"Szkoła Dotneta\";\r\ndouble numberD = 12.5;\r\n", Helpers.CODE_COLOR);

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
                    Console.WriteLine();

                    string name = ReadStringFromInput("What is your name: ");
                    string lastName = ReadStringFromInput("What is your last name: ");
                    string phoneNumber = ReadStringFromInput("Your phone number: ");
                    string email = ReadStringFromInput("Type your email address: ");
                    int age = ReadIntFromInput("What is your age in years: ");
                    int height = ReadIntFromInput("What is your height in cm: ");
                    double weight = ReadDoubleFromInput("What is your weight in kg: ");

                    Console.WriteLine("\r\nBelow information you provided:");
                    Console.Write($"Your name is {name} {lastName}.\r\nYou are {age} years old.\r\nYour phone number is {phoneNumber}.\r\nYour email address is {email}.\r\nYou are {height}cm tall and your weight is {weight}kg.\r\n");

                    continueLoop = ExitSolutionMenuView();
                }
            }
            else if (exerciseNumber == 1 && lessonNumber == "Lesson7")
            {
                SolutionCaptionView();

                bool continueLoop = true;
                while (continueLoop)
                {
                    Console.WriteLine();
                    int number1 = ReadIntFromInput("Please write first number: ");
                    int number2 = ReadIntFromInput("Please write second number: ");

                    string result = (number1 == number2) ? "Numbers are equal" : "Numbers are not equal";
                    Console.WriteLine(result);
                    continueLoop = ExitSolutionMenuView();
                }
            }
            else if (exerciseNumber == 2 && lessonNumber == "Lesson7")
            {
                SolutionCaptionView();

                bool continueLoop = true;
                while (continueLoop)
                {
                    Console.WriteLine();
                    int number = ReadIntFromInput("Please type the number: ");

                    string result = (number % 2 != 0) ? "odd." : "even.";
                    Console.WriteLine($"{number} is {result}");
                    continueLoop = ExitSolutionMenuView();
                }
            }
            else if (exerciseNumber == 3 && lessonNumber == "Lesson7")
            {
                SolutionCaptionView();

                bool continueLoop = true;
                while (continueLoop)
                {
                    Console.WriteLine();
                    int number = ReadIntFromInput("Please type the number: ");
                    string result = (number > 0) ? "positive number."
                        : (number < 0) ? "negative number."
                        : "just zero :)";
                    Console.WriteLine($"{number} is {result}");

                    continueLoop = ExitSolutionMenuView();
                }
            }
            else if (exerciseNumber == 4 && lessonNumber == "Lesson7")
            {
                SolutionCaptionView();

                bool continueLoop = true;
                while (continueLoop)
                {
                    Console.WriteLine();
                    int year = ReadIntFromInput("Please type the year: ");
                    string result="";
                    
                    if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) result = "a leap year.";
                    else result = "not a leap year.";

                    Console.WriteLine($"{year} is {result}");
                    continueLoop = ExitSolutionMenuView();
                }
            }
            else if (exerciseNumber == 5 && lessonNumber == "Lesson7")
            {
                SolutionCaptionView();

                bool continueLoop = true;
                while (continueLoop)
                {
                    Console.WriteLine();
                    int age = ReadIntFromInput("Please type the age: ");
                    string result = "";

                    if (age >= 35)
                    {
                        result = "you can become President, Prime Minister, Member of Parliament, and Senator.";
                    }
                    else if (age >= 30 && age < 35)
                    {
                        result = "you can become Prime Minister, Member of Parliament, and Senator.";
                    }
                    else if (age >= 21 && age < 30)
                    {
                        result = "you can become Prime Minister and Member of Parliament.";
                    }
                    else
                        result = "you do not meet the age requirements for any of the positions.";

                    Console.WriteLine($"At the age of {age}, {result}");
                    continueLoop = ExitSolutionMenuView();
                }
            }
            else if (exerciseNumber == 6 && lessonNumber == "Lesson7")
            {
                SolutionCaptionView();

                bool continueLoop = true;
                while (continueLoop)
                {
                    Console.WriteLine();
                    int height = ReadIntFromInput("Please type your height in cm: ");
                    string result = "";

                    if (height <= 140)
                    {
                        result = "you are dwarf :)";
                    }
                    else if (height <= 160)
                    {
                        result = "you are a bit of a taller dwarf :)";
                    }
                    else if (height <= 180)
                    {
                        result = "you are within the European average :)";
                    }
                    else if (height <= 200)
                    {
                        result = "you can call yourself tall.";
                    }
                    else
                        result = "you can play in NBA :)";

                    Console.WriteLine($"Having {height}cm, {result}");
                    continueLoop = ExitSolutionMenuView();
                }
            }
            else if (exerciseNumber == 7 && lessonNumber == "Lesson7")
            {
                SolutionCaptionView();

                bool continueLoop = true;
                while (continueLoop)
                {
                    Console.WriteLine();
                    int number1 = ReadIntFromInput("Please write number 1: ");
                    int number2 = ReadIntFromInput("Please write number 2: ");
                    int number3 = ReadIntFromInput("Please write number 3: ");

                    int biggestNumber = number1;
                    if (number2 > biggestNumber)
                        biggestNumber = number2;
                    if (number3 > biggestNumber)
                        biggestNumber = number3;

                    Console.WriteLine($"{biggestNumber} is the biggest number.");
                    continueLoop = ExitSolutionMenuView();
                }
            }
            else if (exerciseNumber == 8 && lessonNumber == "Lesson7")
            {
                SolutionCaptionView();

                bool continueLoop = true;
                while (continueLoop)
                {
                    Console.WriteLine();
                    int mathScore = ReadIntFromInput("Please write math score: ");
                    int physicsScore = ReadIntFromInput("Please write physic score: ");
                    int chemistryScore = ReadIntFromInput("Please write chemistry score: ");

                    if ((mathScore + physicsScore + chemistryScore) > 180 || (mathScore + physicsScore) >= 150 || (mathScore + chemistryScore >= 150))
                    {
                        Console.WriteLine("Candidate admitted to the recruitment process.");
                    }
                    else Console.WriteLine("Candidate not admitted to the recruitment process.");

                    continueLoop = ExitSolutionMenuView();
                }
            }
            else if (exerciseNumber == 9 && lessonNumber == "Lesson7")
            {
                SolutionCaptionView();

                bool continueLoop = true;
                while (continueLoop)
                {
                    Console.WriteLine();
                    int temp = ReadIntFromInput("Please enter the temperature: ");

                    if (temp < 0) Console.WriteLine("It's f.king freezing!");
                    else if (temp >= 0 && temp < 10) Console.WriteLine("It's cold!");
                    else if (temp >= 10 && temp < 20) Console.WriteLine("It's chilly!");
                    else if (temp >= 20 && temp < 30) Console.WriteLine("Warm and nice...");
                    else if (temp >= 30 && temp < 40) Console.WriteLine("It's starting to get bad, it's hot!");
                    else Console.WriteLine("It is too hot, take me to Alaska!");

                    continueLoop = ExitSolutionMenuView();
                }
            }
            else if (exerciseNumber == 10 && lessonNumber == "Lesson7")
            {
                SolutionCaptionView();

                bool continueLoop = true;
                while (continueLoop)
                {
                    Console.WriteLine();
                    int a = ReadIntFromInput("Please enter length A: ");
                    int b = ReadIntFromInput("Please enter length B: ");
                    int c = ReadIntFromInput("Please enter length C: ");

                    if (a > 0 && b > 0 && c > 0)
                    {
                        if (a + b > c && b + c > a && c + a > b) Console.WriteLine("A triangle can be created!");
                        else Console.WriteLine("Sorry, but a triangle cannot be created!");
                    }
                    else WriteColorText("Sorry, but one of the lengths can't be zero or negative!", Helpers.WARNING_COLOR);

                    continueLoop = ExitSolutionMenuView();
                }
            }
            else if (exerciseNumber == 11 && lessonNumber == "Lesson7")
            {
                SolutionCaptionView();

                bool continueLoop = true;
                while (continueLoop)
                {
                    Console.WriteLine();
                    int numberGrade = ReadIntFromInput("Please enter the grade (1-6): ");
                    string textGrade = "";

                    if (numberGrade >= 1 && numberGrade <= 6)
                    {
                        switch (numberGrade)
                        {
                            case 1: textGrade = "Poor"; break;
                            case 2: textGrade = "Pass"; break;
                            case 3: textGrade = "Satisfactory"; break;
                            case 4: textGrade = "Good"; break;
                            case 5: textGrade = "Very Good"; break;
                            case 6: textGrade = "Excellent"; break;
                        }
                        Console.WriteLine($"Your grade is {textGrade}!");
                    }
                    else
                    {
                        WriteColorText("Sorry, but it is not a proper grade!", Helpers.WARNING_COLOR);
                        continueLoop = true;
                        continue;
                    }
                    continueLoop = ExitSolutionMenuView();
                }
            }
            else if (exerciseNumber == 12 && lessonNumber == "Lesson7")
            {
                SolutionCaptionView();

                bool continueLoop = true;
                while (continueLoop)
                {
                    Console.WriteLine();
                    int numberDay = ReadIntFromInput("Please enter the number of the day (1-7): ");
                    string textDay = "";

                    if (numberDay >= 1 && numberDay <= 7)
                    {
                        switch (numberDay)
                        {
                            case 1: textDay = "Monday"; break;
                            case 2: textDay = "Tuesday"; break;
                            case 3: textDay = "Wednesday"; break;
                            case 4: textDay = "Thursday"; break;
                            case 5: textDay = "Friday"; break;
                            case 6: textDay = "Saturday"; break;
                            case 7: textDay = "Sunday"; break;
                        }

                        Console.WriteLine($"Your day is {textDay}!");
                    }
                    else
                    {
                        WriteColorText("Sorry, but it is not a proper day number!", Helpers.WARNING_COLOR);
                        continueLoop = true;
                        continue;
                    }
                    continueLoop = ExitSolutionMenuView();
                }
            }
            else if (exerciseNumber == 13 && lessonNumber == "Lesson7")
            {
                SolutionCaptionView();

                bool continueLoop = true;
                while (continueLoop)
                {
                    Console.WriteLine();
                    double a = ReadDoubleFromInput("Please enter number A: ");
                    double b = ReadDoubleFromInput("Please enter number B: ");
                    double result = 0;

                    Console.WriteLine("Please select an action:\r\n1 - addition (A + B)\r\n2 - subtraction (A - B)\r\n3 - multiplication (A * B)\r\n4 - dividing (A : B)\r\n");
                    Console.Write("Your choice: ");
                    ConsoleKeyInfo choice = Console.ReadKey();
                    switch (choice.KeyChar)
                    {
                        case '1':
                            result = a + b;
                            break;
                        case '2':
                            result = a - b;
                            break;
                        case '3':
                            result = a * b;
                            break;
                        case '4':
                            if (b != 0) result = a / b;
                            else WriteColorText("\r\nError - dividing by zero! \r\nYour variable B cannot be zero if you want to do the division.", Helpers.WARNING_COLOR);
                            break;
                    }
                    if (b != 0) Console.WriteLine($"\r\nResult of operation: {result}");
                    continueLoop = ExitSolutionMenuView();
                }
            }
            else if (exerciseNumber == 1 && lessonNumber == "Lesson8")
            {
                SolutionCaptionView();

                bool continueLoop = true;
                while (continueLoop)
                {
                    Console.WriteLine();
                    int count = 0;
                    for (int i = 2; i <= 100; i++)
                    {
                        bool isPrime = true;
                        for (int j = 2; j < i; j++)
                        {
                            if (i % j == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                        if (isPrime)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"There is {count} prime numbers in the range 0-100.");
                    continueLoop = ExitSolutionMenuView();
                }
            }
            else if (exerciseNumber == 2 && lessonNumber == "Lesson8")
            {
                SolutionCaptionView();

                bool continueLoop = true;
                while (continueLoop)
                {
                    Console.WriteLine();

                    int i = 1;
                    int count = 0;
                    do {
                        if (i % 2 == 0)
                        {
                            Console.Write($" {i},");
                            count++;
                        }                            
                        i++;
                    }
                    while(i <= 1000);
                    Console.WriteLine($"\r\n\r\nThere is {count} even numbers in the range 0-1000.");

                    continueLoop = ExitSolutionMenuView();
                }
            }
            else if (exerciseNumber == 3 && lessonNumber == "Lesson8")
            {
                SolutionCaptionView();

                bool continueLoop = true;
                while (continueLoop)
                {
                    int fNumber = ReadIntFromInput("Enter the number of Fibonacci sequence terms to generate: ");
                    int[] fSequence = new int[fNumber];

                    for (int i = 0; i < fNumber; i++)
                    {
                        if ( i == 0) fSequence[i] = 0;
                        else if ( i == 1) fSequence[i] = 1;
                        else fSequence[i] = fSequence[i - 1] + fSequence[i - 2];
                    }
                    Console.Write("\r\nYour Fibonacci sequence is: ");
                    //dodpisać wynik

                    continueLoop = ExitSolutionMenuView();
                }
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
