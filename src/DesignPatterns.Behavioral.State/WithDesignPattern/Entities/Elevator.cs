using DesignPatterns.Behavioral.State.Common;
using DesignPatterns.Behavioral.State.WithDesignPattern.States;
using DesignPatterns.Behavioral.State.WithDesignPattern.States.Abstract;

namespace DesignPatterns.Behavioral.State.WithDesignPattern.Entities
{
    public class Elevator
    {
        public int CurrentFloor { get; set; }

        public Door Door { get; set; }

        public IElevatorState State { get; set; }

        public Elevator()
        {
            State = new WaitingForInstructionState();
            CurrentFloor = 0;
            this.Door = new Door(doorState: eDoorState.CLOSED);
        }

        public void MoveToFloor(int floor)
        {
            this.State.MoveToFloor(this, floor);
        }
    }
}