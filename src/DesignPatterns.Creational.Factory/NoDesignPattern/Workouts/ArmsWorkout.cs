using System;
using System.Collections.Generic;
using System.Threading;

namespace DesignPatters.Creational.Factory.NoDesignPattern.Workouts
{
    public class ArmsWorkout
    {
        private readonly IEnumerable<string> _workoutList;
        public ArmsWorkout()
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
