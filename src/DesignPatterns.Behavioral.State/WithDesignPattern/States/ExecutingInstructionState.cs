using DesignPatterns.Behavioral.State.WithDesignPattern.Entities;
using DesignPatterns.Behavioral.State.WithDesignPattern.States.Abstract;

namespace DesignPatterns.Behavioral.State.WithDesignPattern.States
{
    public class ExecutingInstructionState : BaseState
    {
        public override void MoveToFloor(Elevator elevator, int floor)
        {
            this.CloseDoor(elevator);

            var currentFloor = elevator.CurrentFloor;
            var targetFloor = floor;

            while (currentFloor > targetFloor)
            {
                currentFloor--;
                MoveToFloor(currentFloor);
            }

            while (currentFloor < targetFloor)
            {
                currentFloor++;
                MoveToFloor(currentFloor);
            }

            elevator.CurrentFloor = targetFloor;
            Console.WriteLine($"The elevator stoped on floor {elevator.CurrentFloor}");
            this.ChangeState(new WaitingForInstructionState(), elevator);
        }

        private void MoveToFloor(int floor)
        {
            Console.WriteLine($"Moving to floor {floor}");
            Thread.Sleep(1500);
        }
    }
}