﻿using System;
using Uno.Async;

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

        public ConsoleKeyInfo ShowMenuActions(string menuName)
        {
            var menuList = GetMenuActionsByMenuName(menuName);
            if (menuName == "Main")
            {
                Console.WriteLine("Welcome to week 2 homework app!");
                Console.WriteLine("Please select exercises from which lessons you would like to see?");

                foreach (var menuElement in menuList)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"[{menuElement.Id}]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(menuElement.Description);
                }
                Console.Write("\nYour choice: ");
                return Console.ReadKey();
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

                Console.WriteLine("\nPlease choose which exercise you want to check:");
                return Console.ReadKey();
            }
                        
        }
    }
}
