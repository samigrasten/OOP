namespace OOP._5._State.After
{
    public class PowerOffEngine : Engine, IEngine {
        public IEngine TurnPowerOn()
        {
            SetDashboardLightsOn();
            return new PowerOnEngine();
        }

        public IEngine TurnPowerOff() => this;

        public IEngine StartEngine() => this;

        public IEngine StopEngine() => this;

        public void Drive() { }

        public void Brake() { }
    }
}