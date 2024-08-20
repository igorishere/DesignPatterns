using DesignPatterns.Behavioral.State.WithDesignPattern.Entities;

namespace DesignPatterns.Behavioral.State.WithDesignPattern.States.Abstract
{
    public abstract class BaseState : IElevatorState
    {
        public void ChangeState(IElevatorState state, Elevator elevator)
        {
            elevator.State = state;
        }

        public void CloseDoor(Elevator elevator)
        {
            elevator.Door.Close();
        }

        public abstract void MoveToFloor(Elevator elevator, int floor);

        public void OpenDoor(Elevator elevator)
        {
            elevator.Door.Open();
        }
    }
}