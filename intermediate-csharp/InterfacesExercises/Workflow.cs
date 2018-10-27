using System.Collections.Generic;

namespace InterfacesExercises
{
    public class Workflow
    {
        public readonly IList<IActivity> _activities;
        public Workflow()
        {
            _activities = new List<IActivity>();
        }

        public void Add(IActivity activity)
        {
            _activities.Add(activity);
        }

        public void Remove(IActivity activity)
        {
            _activities.Remove(activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _activities;
        }
    }
}