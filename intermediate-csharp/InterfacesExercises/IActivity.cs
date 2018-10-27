using System.Collections.Generic;

namespace InterfacesExercises
{
    public interface IActivity
    {
        void Execute();
    }

    public interface IWorkflow
    {
        void Add();
        void Remove();
        IEnumerable<IActivity> GetActivities();
    }
}