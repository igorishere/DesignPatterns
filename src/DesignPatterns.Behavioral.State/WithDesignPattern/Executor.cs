using DesignPatterns.Behavioral.State.WithDesignPattern.Entities;
using DesignPatterns.Common;

namespace DesignPatterns.Behavioral.State.WithDesignPattern
{
    public class Executor : ExecutorWithExample
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
