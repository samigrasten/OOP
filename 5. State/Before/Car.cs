namespace OOP._5._State.Before
{
    public class Car
    {
        public enum EngineStatus { PowerOff, PowerOn, MotorStarted }

        public void TurnPowerOn()
        {
            if (_engine == EngineStatus.PowerOff)
            {
                _engine = EngineStatus.PowerOn;
                SetDashboardLightsOn();
            }
        }
        public void TurnPowerOff()
        {
            if (_engine == EngineStatus.PowerOn)
            {
                _engine = EngineStatus.PowerOff;
                SetDashboardLightsOn();
            }
        }

        public void StartEngine()
        {
            if (_engine == EngineStatus.PowerOn)
            {
                _engine = EngineStatus.MotorStarted;
                MakeSomeOddMotorsSounds();
            }
        }

        public void StopEngine()
        {
            if (_engine == EngineStatus.MotorStarted)
            {
                _engine = EngineStatus.PowerOn;
                StopAllMotorSound();
            }
        }

        public void Drive()
        {
            if (_engine != EngineStatus.MotorStarted) return;

            IncreaseSpeed();
        }

        public void Brake()
        {
            if (_engine != EngineStatus.MotorStarted) return;

            DecreaseSpeed();
        }

        private void IncreaseSpeed()
        {
            // Increase car speed    
        }

        private void DecreaseSpeed()
        {
            // Decrease car speed
        }


        private void SetDashboardLightsOn()
        {
            // turn car's ligth on
        }

        private void SetDashboardLightsOff()
        {
            // turn car's light off
        }

        private void MakeSomeOddMotorsSounds()
        {
            // Add some rattle and clinking
        }

        private void StopAllMotorSound()
        {
            // Stop all sounds
        }

        private EngineStatus _engine;
    }
}