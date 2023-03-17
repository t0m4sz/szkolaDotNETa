using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

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
    }
}
