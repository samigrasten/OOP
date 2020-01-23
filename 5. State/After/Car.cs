using System.IO;

namespace OOP._5._State.After
{
    public class Car
    {
        public void TurnPowerOn() => _engine = _engine.TurnPowerOn();
        
        public void TurnPowerOff() => _engine = _engine.TurnPowerOff();

        public void StartEngine() => _engine = _engine.StartEngine();
        
        public void StopEngine() => _engine = _engine.StopEngine();

        public void Drive() => _engine.Drive();

        public void Brake() => _engine.Brake();

        private IEngine _engine = new PowerOffEngine();
    }
}