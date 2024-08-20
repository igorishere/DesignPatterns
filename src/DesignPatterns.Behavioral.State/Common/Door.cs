namespace DesignPatterns.Behavioral.State.Common
{
    public class Door
    {
        public Door(eDoorState doorState)
        {
            this.State = doorState;
        }

        public eDoorState State { get; private set; }

        public void Open()
        {
            this.State = eDoorState.OPEN;
            Console.WriteLine("The door is opening");
        }

        public void Close()
        {
            this.State = eDoorState.CLOSED;
            Console.WriteLine("The door is closing");
        }
    }
}