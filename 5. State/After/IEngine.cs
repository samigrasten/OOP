namespace OOP._5._State.After
{
    public interface IEngine
    {
        IEngine TurnPowerOn();
        IEngine TurnPowerOff();
        IEngine StartEngine();
        IEngine StopEngine();

        void Drive();
        void Brake();
    }
}