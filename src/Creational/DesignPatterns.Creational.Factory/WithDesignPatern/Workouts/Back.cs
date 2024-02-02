using DesingPatterns.Creational.Factory.WithDesignPatter.Workouts;
using System;
using System.Collections.Generic;
using System.Threading;

namespace DesignPatters.Creational.Factory.DesignPatternApplyedExample.Workouts
{
    public class Back : IWorkout
    {
        private readonly IEnumerable<string> _workoutList;
        public Back()
        {
            var workouts = new string[4];
            workouts[0] = "Pull-ups";
            workouts[1] = "Lat Pulldown";
            workouts[2] = "Barbell Row";
            workouts[3] = "Dumbbell Row";

            _workoutList = workouts;
        }

        public IEnumerable<string> GetWorkoutList() => _workoutList;

        public void ExecuteWorkout()
        {
            foreach (var workout in _workoutList)
            {
                Thread.Sleep(500);
                Console.WriteLine($"Performing a {workout}...");
            }
        }
    }
}
