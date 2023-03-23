using System;

namespace Week2
{
    public static class Helpers
    {
        public const ConsoleColor CAPTION_COLOR = ConsoleColor.Green;
        public const ConsoleColor CODE_COLOR = ConsoleColor.DarkCyan;
        public const ConsoleColor TEXT_COLOR = ConsoleColor.White;
        public const ConsoleColor WARNING_COLOR = ConsoleColor.Red;


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
            actionService.AddNewAction(3, "Write a program that calculates the length of the diagonal based on the given width and length of the rectangle. (To calculate the square of a number use Math.Pow() method).\r\n", "Lesson4");
            actionService.AddNewAction(4, "Write a program in which you create 2 numeric variables and one text variable, and then assign them the following values:\r\n\ta. 10\r\n\tb. Dotnet school\r\n\tc. 12,5\r\nRemember to use the correct data types.\r\n", "Lesson4");
            actionService.AddNewAction(5, "Write a program in which you ask a user for his/her personal information, i.e. First name, last name, phone number, email address, height, weight (e.g. 85.7), etc. (try to come up with as many as possible) and try to convert the response to the appropriate data type using  method:\r\ndataType.Parse(responseFromUser).\r\n", "Lesson4");
            actionService.AddNewAction(6, " - Back to main menu", "Lesson4");

            actionService.AddNewAction(1, " ", "Lesson7");
            actionService.AddNewAction(2, " ", "Lesson7");
            actionService.AddNewAction(3, " ", "Lesson7");
            actionService.AddNewAction(4, " ", "Lesson7");
            actionService.AddNewAction(5, " ", "Lesson7");
            actionService.AddNewAction(6, " ", "Lesson7");
            actionService.AddNewAction(7, " ", "Lesson7");
            actionService.AddNewAction(8, " ", "Lesson7");
            actionService.AddNewAction(9, " ", "Lesson7");
            actionService.AddNewAction(10, " ", "Lesson7");
            actionService.AddNewAction(11, " ", "Lesson7");
            actionService.AddNewAction(12, " ", "Lesson7");
            actionService.AddNewAction(13, " ", "Lesson7");
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
