using DesignPatterns.Common;
using DesignPatters.Creational.Factory.NoDesignPattern.Workouts;
using DesingPatterns.Creational.Factory;
using System;
using System.Threading;

namespace DesignPatterns.Creational.Factory.NoDesignPattern
{
    public class Executor : ExecutorNoExample
    {
        public override string GetName() => "Factory";

        public override void Execute()
        {
            Console.WriteLine("Choose a muscular region to exercise. Tap the number related to the muscular group:");
            Console.WriteLine("1.Arms");
            Console.WriteLine("2.Legs");
            Console.WriteLine("3.Breast");
            Console.WriteLine("4.Backs");
            Console.WriteLine("5.Shoulders");

            string userInput = Console.ReadLine();

            Console.WriteLine($"You choose number {userInput}. Getting your workout list, wait...");

            Thread.Sleep(1000);

            int result;
            var userInputAsInteger = int.TryParse(userInput, out result);
            var type = (eMuscularGroup)result;

            if (type == eMuscularGroup.ARM)
            {
                var workout = new ArmsWorkout();

                var list = workout.GetWorkoutList();

                Console.WriteLine("Your workout routine for today is:");
                foreach (var item in list)
                    Console.WriteLine(item);

                workout.ExecuteWorkout();
            }

            if (type == eMuscularGroup.LEG)
            {
                var workout = new LegWorkout();

                var list = workout.GetWorkoutList();

                Console.WriteLine("Your workout routine for today is:");
                foreach (var item in list)
                    Console.WriteLine(item);

                workout.ExecuteWorkout();
            }

            if (type == eMuscularGroup.BREAST)
            {
                var workout = new BreastPlateWorkout();

                var list = workout.GetWorkoutList();

                Console.WriteLine("Your workout routine for today is:");
                foreach (var item in list)
                    Console.WriteLine(item);

                workout.ExecuteWorkout();
            }

            if (type == eMuscularGroup.BACK)
            {
                var workout = new BackWorkout();

                var list = workout.GetWorkoutList();

                Console.WriteLine("Your workout routine for today is:");
                foreach (var item in list)
                    Console.WriteLine(item);

                workout.ExecuteWorkout();
            }

            if (type == eMuscularGroup.SHOULDER)
            {
                var workout = new ShoulderWorkout();

                var list = workout.GetWorkoutList();

                Console.WriteLine("Your workout routine for today is:");
                foreach (var item in list)
                    Console.WriteLine(item);

                workout.ExecuteWorkout();
            }


            Console.ReadKey();
        }
    }
}