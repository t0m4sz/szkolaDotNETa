using System;
using Uno;

namespace Week2
{
    public class MenuActionService
    {
        private List<MenuAction> menuActions = new List<MenuAction>();

        public void AddNewAction(int id, string description, string menuName)
        {
            MenuAction menuAction = new MenuAction() {Id = id, Description = description, MenuName = menuName};
            menuActions.Add(menuAction);
        }

        public List<MenuAction> GetMenuActionsByMenuName(string menuName)
        {
            List<MenuAction> result = new List<MenuAction>();
            foreach (var menuAction in menuActions)
            {
                if (menuAction.MenuName ==  menuName)
                {
                    result.Add(menuAction);
                }
            }
            return result;
        }

        public int MenuActionsView(string menuName, bool showWarning = false)
        {
            Console.Clear();
            var menuList = GetMenuActionsByMenuName(menuName);
            if (menuName == "Main")
            {
                Console.WriteLine("Welcome to week 2 homework app!");
                Console.WriteLine("Please select exercises from which lesson you would like to see?");

                foreach (var menuElement in menuList)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"[{menuElement.Id}]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(menuElement.Description);
                }

                if (showWarning == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\r\nSorry, that is not a valid number! Try again!");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.Write("\nYour choice: ");
                var choice = Console.ReadKey();
                //ValidateMenuChoice

            }
            else
            {
                for(int i = 0; i < (menuList.Count - 1); i++) 
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"Exercise [{menuList[i].Id}]" + "\r\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(menuList[i].Description);
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"[{menuList[menuList.Count-1].Id}]");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(menuList[menuList.Count-1].Description);

                Console.Write("\nPlease choose which exercise you want to check :");
                return Console.ReadLine();
            }
                        
        }
        public void ShowExerciseDescription(int menuId, string menuName)
        {
            Console.Clear();
            var menuList = GetMenuActionsByMenuName(menuName);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Exercise [{menuId}]" + "\r\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(menuList[menuId-1].Description);
            
        }

        private bool ValidateMenuChoice()
        {
            return true;
        }
    }
}
