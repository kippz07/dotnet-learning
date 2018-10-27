using System;
using System.Collections.Generic;

namespace InterfacesExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.Add(new Activity());
            workflow.Add(new Activity2());
            workflow.Add(new Activity());
            workflow.Add(new Activity2());

            Engine.Run(workflow);
        }
    }
}
