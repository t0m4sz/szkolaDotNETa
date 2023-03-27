using System;

namespace Week2
{
    public static class Helpers
    {
        public const ConsoleColor EXERCISE_CAPTION_COLOR = ConsoleColor.Green;
        public const ConsoleColor CODE_COLOR = ConsoleColor.Magenta;
        public const ConsoleColor TEXT_COLOR = ConsoleColor.White;
        public const ConsoleColor WARNING_COLOR = ConsoleColor.Red;
        public const ConsoleColor SOLUTION_CAPTION_COLOR = ConsoleColor.Blue;


        public static void InitializeConsole()
        {
            Console.Clear();
            Console.Title = "Szkola dotNETa - Week 2";
            Console.ForegroundColor = TEXT_COLOR;
            Console.WindowHeight = 50;
        }

        public static void InitializeMenu(MenuActionService actionService)
        {
            actionService.AddNewAction(1, " - Lesson 4", "Main");
            actionService.AddNewAction(2, " - Lesson 7", "Main");
            actionService.AddNewAction(3, " - Lesson 8", "Main");
            actionService.AddNewAction(4, " - Exit app", "Main");

            actionService.AddNewAction(1, "Create a program in which you declare variables about company employee data. The data you want to hold are:\r\n\ta. First name,\r\n\tb. Last name\r\n\tc. Age\r\n\td. Gender ('m' or 'k')\r\n\te. PESEL\r\n\tf. Employee number (e.g. 2509324094)\r\nDeclare variables of appropriate types that can hold this information.\r\n", "Lesson4");
            actionService.AddNewAction(2, "Write a program in which you create 3 variables with one letter, and then write them out in the reverse order of how they were declared.\r\n", "Lesson4");
            actionService.AddNewAction(3, "Write a program that calculates the length of the diagonal based on the given width and hight of the rectangle. (To calculate the square of a number use Math.Pow() method).\r\n", "Lesson4");
            actionService.AddNewAction(4, "Write a program in which you create 2 numeric variables and one text variable, and then assign them the following values:\r\n\ta. 10\r\n\tb. Dotnet school\r\n\tc. 12,5\r\nRemember to use the correct data types.\r\n", "Lesson4");
            actionService.AddNewAction(5, "Write a program in which you ask a user for his/her personal information, i.e. First name, last name, phone number, email address, height, weight (e.g. 85.7), etc. (try to come up with as many as possible) and try to convert the response to the appropriate data type using  method:\r\ndataType.Parse(responseFromUser).\r\n", "Lesson4");
            actionService.AddNewAction(6, " - Back to main menu", "Lesson4");

            actionService.AddNewAction(1, "Write a program in C# that creates two int variables and checks if they are equal or not. Test data:\r\na : 5\r\nb : 5\r\nResult in the terminal:\r\n5 and 5 are equal\r\n", "Lesson7");
            actionService.AddNewAction(2, "Write a program in C# that checks whether the number given by the user is even or odd. \r\nTest data:  15\r\nResult in the terminal :\r\n15 is an odd number.\r\n", "Lesson7");
            actionService.AddNewAction(3, "Write a program in C# that checks whether the number given by the user is positive or negative. \r\nTest data: 14\r\nResult in terminal :\r\n14 is a positive number\r\n", "Lesson7");
            actionService.AddNewAction(4, "Write a program in C# to check if the year given by the user is a leap year. \r\nTest data: 2016\r\nResult in terminal :\r\n2016 is a leap year\r\n", "Lesson7");
            actionService.AddNewAction(5, "Write a program in C# to test whether the age given by the user entitles them to run for MP, Prime Minister, Senator, President. \r\nTest data: 21\r\nResult in terminal:\r\nYou can become an MP\r\n", "Lesson7");
            actionService.AddNewAction(6, "Write a program in C# that takes the user's height and assigns it an imaginary height category. \r\nTest data: 140\r\nResult in the terminal:\r\nYou are a dwarf\r\n", "Lesson7");
            actionService.AddNewAction(7, "Write a program in C# that takes 3 numbers from the user and checks which is the largest. \r\nTest data:\r\n25\r\n63\r\n79\r\nResult in terminal:\r\n79 is the largest of the given numbers\r\n", "Lesson7");
            actionService.AddNewAction(8, "Write a program to check whether a candidate can apply for a university place according to the following criteria:\r\nMaths Matriculation score above 70\r\nA Physics score of more than 55\r\nChemistry score above 45\r\nA total score of more than 180 in three subjects \r\nOr\r\nMaths and one subject score over 150\r\nTest data:\r\nMathematics 80\r\nPhysics 71\r\nChemistry 0\r\nTerminal result:\r\nCandidate admitted to the recruitment process\r\n", "Lesson7");
            actionService.AddNewAction(9, "Write a program that reads the temperature and returns a name like the following criteria\r\nTemp < 0 - it's freezing\r\nTemp 0 - 10 - cold\r\nTemp 10 - 20 - cool\r\nTemp 20 - 30 - just right\r\nTemp 30 - 40 - starting to feel weak because it's hot\r\nTemp >= 40 - and take me out to Alaska.\r\nTest data: 41\r\nResult in the terminal:\r\nand take me out to Alaska\r\n", "Lesson7");
            actionService.AddNewAction(10, "Write a program to check if a triangle can be made from the 3 given lengths.\r\nTest data : \r\n40\r\n55\r\n65\r\nResult in the terminal:\r\nA triangle can be constructed\r\n", "Lesson7");
            actionService.AddNewAction(11, "\r\n", "Lesson7");
            actionService.AddNewAction(12, "\r\n", "Lesson7");
            actionService.AddNewAction(13, "\r\n", "Lesson7");
            actionService.AddNewAction(14, " - Back to main menu", "Lesson7");

            actionService.AddNewAction(1, " ", "Lesson8");
            actionService.AddNewAction(2, " ", "Lesson8");
            actionService.AddNewAction(3, " ", "Lesson8");
            actionService.AddNewAction(4, " ", "Lesson8");
            actionService.AddNewAction(5, " ", "Lesson8");
            actionService.AddNewAction(6, " ", "Lesson8");
            actionService.AddNewAction(7, " ", "Lesson8");
            actionService.AddNewAction(8, " ", "Lesson8");
            actionService.AddNewAction(9, " ", "Lesson8");
            actionService.AddNewAction(10, " ", "Lesson8");
            actionService.AddNewAction(11, " - Back to main menu", "Lesson8");

        }


    }
}
