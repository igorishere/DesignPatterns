using DesingPatterns.Creational.Factory.WithDesignPatter.Workouts;
using System;
using System.Collections.Generic;
using System.Threading;

namespace DesignPatters.Creational.Factory.DesignPatternApplyedExample.Workouts
{
    public class Arms : IWorkout
    {
        private readonly IEnumerable<string> _workoutList;
        public Arms()
        {
            var workouts = new string[4];
            workouts[0] = "Barbell Curl";
            workouts[1] = "Dumbbell Alternate Curl";
            workouts[2] = "Dumbbell Hammer Curl";
            workouts[3] = "Tricep Bench Dip";

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
