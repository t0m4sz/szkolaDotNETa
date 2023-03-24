using Microsoft.VisualBasic;
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
                    WriteMenuLine(menuElement.Id, menuElement.Description);
                }

                if (showWarning == true)
                {
                    showInvalidInputMessage("\r\nSorry, that is not a valid number! Try again!");
                }

                Console.Write("\nYour choice: ");
                string choice = Console.ReadLine();
                int menuId = ValidateMenuChoice(choice, menuName);
                return menuId;
            }
            else
            {
                for(int i = 0; i < (menuList.Count - 1); i++) 
                {
                    WriteExerciseMenuLine(menuList[i].Id, menuList[i].Description);

                    //Console.ForegroundColor = Helpers.CAPTION_COLOR;
                    //Console.Write($"Exercise [{menuList[i].Id}]" + "\r\n");
                    //Console.ForegroundColor = Helpers.TEXT_COLOR;
                    //Console.WriteLine(menuList[i].Description);
                }
                
                WriteMenuLine(menuList[menuList.Count - 1].Id, menuList[menuList.Count - 1].Description);
                
                if (showWarning == true)
                {
                    showInvalidInputMessage("\r\nSorry, that is not a valid number! Try again!");
                }

                Console.Write("\nPlease choose which exercise you want to check: ");
                string choice = Console.ReadLine();
                int menuId = ValidateMenuChoice(choice, menuName);

                if (menuId == menuList.Count)
                    return -1;
                else
                    return menuId;
            }
                        
        }
        private void WriteMenuLine (int menuId, string menuDescription)
        {
            Console.ForegroundColor = Helpers.CAPTION_COLOR;
            Console.Write($"[{menuId}]");
            Console.ForegroundColor = Helpers.TEXT_COLOR;
            Console.WriteLine(menuDescription);
        }

        private void WriteExerciseMenuLine(int menuId, string menuDescription)
        {
            Console.ForegroundColor = Helpers.CAPTION_COLOR;
            Console.Write($"Exercise [{menuId}]" + "\r\n");
            Console.ForegroundColor = Helpers.TEXT_COLOR;
            Console.WriteLine(menuDescription);


            //Console.ForegroundColor = Helpers.CAPTION_COLOR;
            //Console.Write($"[{menuId}]");
            //Console.ForegroundColor = Helpers.TEXT_COLOR;
            //Console.WriteLine(menuDescription);
        }

        public void ShowExerciseDescription(int menuId, string menuName)
        {
            Console.Clear();
            var menuList = GetMenuActionsByMenuName(menuName);

            Console.ForegroundColor = Helpers.CAPTION_COLOR;
            Console.Write($"Exercise [{menuId}]" + "\r\n");
            Console.ForegroundColor = Helpers.TEXT_COLOR;
            Console.WriteLine(menuList[menuId-1].Description);
            
        }

        private int ValidateMenuChoice(string choice, string menuName)
        {
            int choiceAsNumber = 0;
            if (choice != null)
            {
                if (Int32.TryParse(choice, out choiceAsNumber))
                {
                    var menuList = GetMenuActionsByMenuName(menuName) ;
                    if (choiceAsNumber <= menuList.Count)
                    {
                        return choiceAsNumber;
                    }
                    else return 0;
                }                    
                else return 0;  
            } 
            else return 0;
        }

        private void showInvalidInputMessage (string message)
        {
            Console.ForegroundColor = Helpers.WARNING_COLOR;
            Console.WriteLine(message);
            Console.ForegroundColor = Helpers.TEXT_COLOR;
        }
    }
}
