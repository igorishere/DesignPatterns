using DesingPatterns.Creational.Factory.WithDesignPatter.Workouts;
using System;
using System.Collections.Generic;
using System.Threading;

namespace DesignPatters.Creational.Factory.DesignPatternApplyedExample.Workouts
{
    public class BreastPlate : IWorkout
    {
        private readonly IEnumerable<string> _workoutList;
        public BreastPlate()
        {
            var workouts = new string[4];
            workouts[0] = "Bench Press";
            workouts[1] = "Incline Bench Press";
            workouts[2] = "Dumbbell Flyes";
            workouts[3] = "Dumbbell Pullover";

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
