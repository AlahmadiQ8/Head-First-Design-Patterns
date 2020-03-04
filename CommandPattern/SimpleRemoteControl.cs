using System;
using System.Collections.Generic;

namespace CommandPattern
{
    public class SimpleRemoteControl : Device
    {
        private readonly IList<Action> _onCommands;
        private readonly IList<Action> _offCommands;
        private Action _undoCommand;

        public SimpleRemoteControl(string name) : base(name)
        {
            _undoCommand = () => { };
            _onCommands = new List<Action>();
            _offCommands = new List<Action>();

            for (var i = 0; i < 7; i++)
            {
                _onCommands.Add(() =>{});
                _offCommands.Add(() =>{});
            }
        }

        public void SetCommand(int slot, Action onCommand, Action offCommand)
        {
            ValidateSlot(slot);
            LogAction(GetCaller());
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPressed(int slot)
        {
            ValidateSlot(slot);
            LogAction(GetCaller());
            _onCommands[slot]();
            _undoCommand = _onCommands[slot];
        }
        
        public void OffButtonWasPressed(int slot)
        {
            ValidateSlot(slot);
            LogAction(GetCaller());
            _offCommands[slot]();
            _undoCommand = _offCommands[slot];
        }

        public void UndoButtonWasPushed(int slot)
        {
            ValidateSlot(slot);
            LogAction(GetCaller());
            _undoCommand();
        }

        public override string ToString()
        {
            var result = "\n------ Remote Control ------\n";
            for (var i = 0; i < 7; i++)
            {
                result += $"[slot {i}] {_onCommands[i].GetType().Name}   {_offCommands[i].GetType().Name}\n";
            }

            result += "--------------------\n";

            return result;
        }

        private void ValidateSlot(int slot)
        {
            if (slot < 0 || slot > 7)
            {
                throw new ArgumentOutOfRangeException(nameof(slot), "must be within 0 and 7");
            }
        }
    }
}