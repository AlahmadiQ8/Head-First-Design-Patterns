using CommandPattern.Vendor;

namespace CommandPattern.Commands
{
    public class GarageDoorCloseCommand : ICommand
    {
        private readonly GarageDoor _garageDoor;

        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Down();
        }

        public void Undo()
        {
            _garageDoor.Up();
        }
    }
}