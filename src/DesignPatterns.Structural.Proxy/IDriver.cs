namespace DesignPatterns.Structural.Proxy
{
    public interface IDriver
    {
        int GetDesiredSpeed();
        void PressAcceletor();
        void PressBreak();
    }
}
