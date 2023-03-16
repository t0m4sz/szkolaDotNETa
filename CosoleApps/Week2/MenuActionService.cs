using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    public class MenuActionService
    {
        private List<MenuAction> menuActions;

        public void AddNewAction(int id, string name, string weekName)
        {
            MenuAction menuAction = new MenuAction() {Id = id, Name = name, WeekName = weekName};
            menuActions.Add(menuAction);
        }

        public List<MenuAction> GetMenuActionsByMenuName(string weekName)
        {
            List<MenuAction> result = new List<MenuAction>();
            foreach (var menuAction in menuActions)
            {
                if (menuAction.WeekName ==  weekName)
                {
                    result.Add(menuAction);

                }
            }
            return result;
        }
    }
}
