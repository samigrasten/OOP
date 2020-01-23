namespace OOP._5._State.After
{
    public class MotorStartedEngine : Engine, IEngine
    {
        public IEngine TurnPowerOn() => this;

        public IEngine TurnPowerOff() => this;

        public IEngine StartEngine() => this;

        public IEngine StopEngine()
        {
            StopAllMotorSound();
            return new PowerOnEngine();
        }

        public void Drive() => IncreaseSpeed();

        public void Brake() => DecreaseSpeed();
    }
}