using DesignPatterns.Behavioral.State.WithDesignPattern.Entities;

namespace DesignPatterns.Behavioral.State.WithDesignPattern.States.Abstract
{
    public interface IElevatorState
    {
        public void ChangeState(IElevatorState state, Elevator elevator);

        public void OpenDoor(Elevator elevator);

        public void CloseDoor(Elevator elevator);

        public void MoveToFloor(Elevator elevator, int floor);
    }
}
