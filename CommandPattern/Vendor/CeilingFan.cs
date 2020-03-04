using System;

namespace CommandPattern.Vendor
{
    public class CeilingFan : Device
    {
        private FanState _speed;
        
        public CeilingFan(string name) : base(name)
        {
            _speed = FanState.Off;
        }

        public void High()
        {
            LogAction(GetCaller());
            _speed = FanState.High;
        }
        
        public void Medium()
        {
            LogAction(GetCaller());
            _speed = FanState.Medium;
        }
        
        public void Low()
        {
            LogAction(GetCaller());
            _speed = FanState.Low;
        }
        
        public void Off()
        {
            LogAction(GetCaller());
            _speed = FanState.Off;
        }
        
        public FanState GetSpeed()
        {
            LogAction(GetCaller());
            return _speed;
        }
    }

    public enum FanState
    {
        High = 3,
        Medium = 2,
        Low = 1,
        Off = 0,
    }
}