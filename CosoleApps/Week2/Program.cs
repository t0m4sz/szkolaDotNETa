using System;
using System.ComponentModel;

namespace Week2
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            
            MenuActionService actionService = new MenuActionService();        
            Helpers.InitializeConsole();            
            Helpers.InitializeMenu(actionService);
            bool showInvalidInputMessage = false;

            while (true)
            {
                int actionChoice = actionService.MenuActionsView("Main", showInvalidInputMessage);
                showInvalidInputMessage = false;
                int exerciseNumber = 0;
                //bool exitFlag;

                switch (actionChoice)
                {                   
                    case 1:
                        while (true)
                        {
                            exerciseNumber = actionService.MenuActionsView("Lesson4", showInvalidInputMessage);
                            showInvalidInputMessage = false;
                            if (exerciseNumber > 0)
                            {
                                actionService.ShowExerciseDescription(exerciseNumber, "Lesson4");
                                Solution.ShowSolutionForExercise(exerciseNumber, "Lesson4");
                            }
                            else if (exerciseNumber == -1)
                                break;
                            else
                                showInvalidInputMessage = true;
                        }
                        break;
                    case 2:
                        exerciseNumber = actionService.MenuActionsView("Lesson7");
                        Solution.ShowSolutionForExercise(exerciseNumber, "Lesson7");
                        break;
                    case 3:
                        exerciseNumber = actionService.MenuActionsView("Lesson8");
                        Solution.ShowSolutionForExercise(exerciseNumber, "Lesson8");
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        showInvalidInputMessage = true;
                        break;
                }
            }
        }
      

        


    }

}