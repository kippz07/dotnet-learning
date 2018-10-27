namespace InterfacesExercises
{
    public class Engine
    {
        public static void Run(Workflow workflow)
        {
            foreach (IActivity activity in workflow.GetActivities())
            {
                activity.Execute();
            }
        }
    }
}