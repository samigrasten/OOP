namespace OOP._5._State.After
{
    public class PowerOnEngine : Engine, IEngine
    {
        public IEngine TurnPowerOn() => this;
        

        public IEngine TurnPowerOff()
        {
            SetDashboardLightsOn();
            return new PowerOffEngine();
        }

        public IEngine StartEngine() 
        {
            MakeSomeOddMotorsSounds();
            return new MotorStartedEngine();
        }

        public IEngine StopEngine() => this;
       
        public void Drive() { }

        public void Brake() { }
    }
}