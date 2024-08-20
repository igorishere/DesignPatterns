
using DesignPatterns.Behavioral.State.Common;

namespace DesignPatterns.Behavioral.State.NoDesignPattern.Entities
{
    public class Elevator
    {
        public int CurrentFloor { get; set; }

        public Door Door { get; set; }

        public Elevator()
        {
            CurrentFloor = 0;
            this.Door = new Door(doorState: eDoorState.CLOSED);
        }

        public void MoveToFloor(int floor)
        {
            if (IsAtCurrentFloor(this, floor))
                this.Door.Open();
            else
            {
                this.Door.Close();
                Move(floor);
            }
        }

        private void Move(int floor)
        {
            var currentFloor = CurrentFloor;
            var targetFloor = floor;

            while (currentFloor > targetFloor)
            {
                currentFloor--;
                Log(currentFloor);
            }

            while (currentFloor < targetFloor)
            {
                currentFloor++;
                Log(currentFloor);
            }

            CurrentFloor = targetFloor;
            Console.WriteLine($"The elevator stoped on floor {CurrentFloor}");
            
        }

        private void Log(int floor)
        {
            Console.WriteLine($"Moving to floor {floor}");
            Thread.Sleep(1500);
        }

        private bool IsAtCurrentFloor(Elevator elevator, int floor)
        {
            return elevator.CurrentFloor.Equals(floor);
        }
    }
}
