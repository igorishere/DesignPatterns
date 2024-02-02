using System;
using System.Collections.Generic;
using System.Threading;

namespace DesignPatters.Creational.Factory.NoDesignPattern.Workouts
{
    public class LegWorkout
    {
        private readonly IEnumerable<string> _workoutList;
        public LegWorkout()
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
