using DesingPatterns.Creational.Factory.WithDesignPatter.Workouts;
using System;
using System.Collections.Generic;
using System.Threading;

namespace DesignPatters.Creational.Factory.DesignPatternApplyedExample.Workouts
{
    public class Leg : IWorkout
    {
        private readonly IEnumerable<string> _workoutList;
        public Leg()
        {
            var workouts = new string[4];
            workouts[0] = "Squat";
            workouts[1] = "Legpress";
            workouts[2] = "Leg curl";
            workouts[3] = "Leg extension";

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
