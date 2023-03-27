using Microsoft.VisualBasic;
using System;
using System.Reflection.Metadata.Ecma335;
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

        public int MenuActionsView(string menuName, bool warningFlag = false)
        {
            Console.Clear();
            List<MenuAction> menuList = GetMenuActionsByMenuName(menuName);
            if (menuName == "Main")
            {
                Console.WriteLine("Welcome to week 2 homework app!");
                Console.WriteLine("Please select exercises from which lesson you would like to see?");

                MenuLinesView(menuName);
                WarningMessageView(warningFlag);

                int choosenId = ChoiceMenuView(menuName);
                return choosenId;
            }
            else
            {
                MenuLinesView(menuName);
                WarningMessageView(warningFlag);

                int choosenId = ChoiceMenuView(menuName);

                if (choosenId == menuList.Count)
                    return -1;
                else
                    return choosenId;
            }
        }
        private void WarningMessageView(bool warningFlag)
        {
            if (warningFlag == true)
            {
                InvalidMsgView("\r\nSorry, that is not a valid choice! Try again!");
            }
        }
        
        public void MenuLinesView (string menuName)
        {
            
            List<MenuAction> menuList = GetMenuActionsByMenuName(menuName);
            
            if (menuName == "Main")
            {
                foreach (var menuElement in menuList)
                {
                    Console.ForegroundColor = Helpers.EXERCISE_CAPTION_COLOR;
                    Console.Write($"[{menuElement.Id}]");
                    Console.ForegroundColor = Helpers.TEXT_COLOR;
                    Console.WriteLine(menuElement.Description);
                }                
            }            
            else
            {                
                for (int i = 0; i < (menuList.Count - 1); i++)
                {
                    Console.ForegroundColor = Helpers.EXERCISE_CAPTION_COLOR;
                    Console.Write($"Exercise [{menuList[i].Id}]" + "\r\n");
                    Console.ForegroundColor = Helpers.TEXT_COLOR;
                    Console.WriteLine(menuList[i].Description);
                }
                Console.ForegroundColor = Helpers.EXERCISE_CAPTION_COLOR;
                Console.Write($"[{menuList[menuList.Count - 1].Id}]");
                Console.ForegroundColor = Helpers.TEXT_COLOR;
                Console.WriteLine(menuList[menuList.Count - 1].Description);
            }
        }
        public void ExerciseDescriptionView(int menuId, string menuName)
        {
            Console.Clear();
            List<MenuAction> menuList = GetMenuActionsByMenuName(menuName);

            Console.ForegroundColor = Helpers.EXERCISE_CAPTION_COLOR;
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
        private void InvalidMsgView (string message)
        {
            Console.ForegroundColor = Helpers.WARNING_COLOR;
            Console.WriteLine(message);
            Console.ForegroundColor = Helpers.TEXT_COLOR;
        }

        private int ChoiceMenuView(string menuName)
        {
            Console.Write("\nPlease choose which exercise do you want to check: ");
            string choice = Console.ReadLine();
            int choosenId = ValidateMenuChoice(choice, menuName);
            return choosenId;
        }
    }
}
