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
                                SolutionService.ShowExerciseSolution(exerciseNumber, "Lesson4");
                            }
                            else if (exerciseNumber == -1)
                                break;
                            else
                                showInvalidInputMessage = true;
                        }
                        break;
                    case 2:
                        while (true)
                        {
                            exerciseNumber = actionService.MenuActionsView("Lesson7", showInvalidInputMessage);
                            showInvalidInputMessage = false;
                            if (exerciseNumber > 0)
                            {
                                actionService.ShowExerciseDescription(exerciseNumber, "Lesson7");
                                SolutionService.ShowExerciseSolution(exerciseNumber, "Lesson7");
                            }
                            else if (exerciseNumber == -1)
                                break;
                            else
                                showInvalidInputMessage = true;
                        }
                        break;
                    case 3:
                        while (true)
                        {
                            exerciseNumber = actionService.MenuActionsView("Lesson8", showInvalidInputMessage);
                            showInvalidInputMessage = false;
                            if (exerciseNumber > 0)
                            {
                                actionService.ShowExerciseDescription(exerciseNumber, "Lesson8");
                                SolutionService.ShowExerciseSolution(exerciseNumber, "Lesson8");
                            }
                            else if (exerciseNumber == -1)
                                break;
                            else
                                showInvalidInputMessage = true;
                        }                        
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