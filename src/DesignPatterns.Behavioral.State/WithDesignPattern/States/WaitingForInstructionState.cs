using DesignPatterns.Behavioral.State.WithDesignPattern.Entities;
using DesignPatterns.Behavioral.State.WithDesignPattern.States.Abstract;

namespace DesignPatterns.Behavioral.State.WithDesignPattern.States
{
    public class WaitingForInstructionState : BaseState
    {
        public override void MoveToFloor(Elevator elevator, int floor)
        {
            if (IsAtCurrentFloor(elevator, floor))
            {
                this.OpenDoor(elevator);
            }
            else
            {
                this.CloseDoor(elevator);
                this.ChangeState(new ExecutingInstructionState(), elevator);
                elevator.MoveToFloor(floor);
            }
        }

        private bool IsAtCurrentFloor(Elevator elevator, int floor)
        {
            return elevator.CurrentFloor.Equals(floor);
        }
    }
}