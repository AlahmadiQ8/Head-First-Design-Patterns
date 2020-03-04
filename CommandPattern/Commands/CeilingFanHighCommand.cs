using CommandPattern.Vendor;

namespace CommandPattern.Commands
{
    public class CeilingFanHighCommand : ICommand
    {
        private readonly CeilingFan _ceilingFan;
        private FanState _previousSpeed;

        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _previousSpeed = _ceilingFan.GetSpeed();
            _ceilingFan.High();
        }

        public void Undo()
        {
            switch (_previousSpeed)
            {
                case FanState.High:
                    _ceilingFan.High();
                    break;
                case FanState.Medium:
                    _ceilingFan.Medium();
                    break;
                case FanState.Low:
                    _ceilingFan.Low();
                    break;
                default:
                    _ceilingFan.Off();
                    break;
            }
        }
    }
}