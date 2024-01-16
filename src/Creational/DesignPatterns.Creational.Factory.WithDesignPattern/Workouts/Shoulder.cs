using DesingPatterns.Creational.Factory.WithDesignPatter.Workouts;
using System;
using System.Collections.Generic;
using System.Threading;

namespace DesignPatters.Creational.Factory.DesignPatternApplyedExample.Workouts
{
    public class Shoulder : IWorkout
    {
        private readonly IEnumerable<string> _workoutList;
        public Shoulder()
        {
            var workouts = new string[4];
            workouts[0] = "Dumbbell Shoulder Press";
            workouts[1] = "Lateral Raises";
            workouts[2] = "Frontal Raises";
            workouts[3] = "Shrugs";

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
