
using DesignPatterns.Behavioral.State.NoDesignPattern.Entities;
using DesignPatterns.Common;

namespace DesignPatterns.Behavioral.State.NoDesignPattern
{
    public class Executor : ExecutorNoExample
    {
        public override void Execute()
        {
            var elevator = new Elevator();
            elevator.MoveToFloor(5);
            elevator.MoveToFloor(7);
            elevator.MoveToFloor(1);
            elevator.MoveToFloor(8);
            elevator.MoveToFloor(0);
        }

        public override string GetName() => "State";
    }
}