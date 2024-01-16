using System.Collections.Generic;

namespace DesingPatterns.Creational.Factory.WithDesignPatter.Workouts
{
    public interface IWorkout
    {
        IEnumerable<string> GetWorkoutList();

        void ExecuteWorkout();
    }
}
