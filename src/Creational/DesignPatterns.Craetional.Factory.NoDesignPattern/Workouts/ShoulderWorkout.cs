using System;
using System.Collections.Generic;
using System.Threading;

namespace DesignPatters.Creational.Factory.NoDesignPatternApplyedExample.Workouts
{
    public class ShoulderWorkout
    {
        private readonly IEnumerable<string> _workoutList;
        public ShoulderWorkout()
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
