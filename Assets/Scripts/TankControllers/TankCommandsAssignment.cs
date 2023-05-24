using System;
using System.Collections;
using System.Collections.Generic;
using Commands.TankCommands;

namespace TankControllers
{
    public class TankCommandsAssignment : ICollection<TankCommand>
    {
        private readonly List<TankCommand> _commands = new();

        public int Count => _commands.Count;

        public bool IsReadOnly => true;

        public TankCommandsAssignment() => _commands = new List<TankCommand>();

        public TankCommandsAssignment(List<TypeTankCommandAndKeyCode> typeTankCommandAndKeyCodes)
        {
            foreach (var typeTankCommandAndKeyCode in typeTankCommandAndKeyCodes)
            {
                _commands.Add(
                    SimpleFactoryTankCommands.CreateTankCommand(typeTankCommandAndKeyCode));
            }
        }

        public TankCommandsAssignment(IEnumerable<TankCommand> commands)
        {
            foreach (var command in commands)
                _commands.Add(command);
        }

        IEnumerator<TankCommand> IEnumerable<TankCommand>.GetEnumerator() => _commands.GetEnumerator();
        public IEnumerator GetEnumerator() => _commands.GetEnumerator();

        public void Add(TankCommand tankCommand) =>
            _commands.Add(tankCommand ?? throw new NullReferenceException("command is null"));

        public void Clear() => _commands.Clear();

        public bool Contains(TankCommand tankCommand) =>
            _commands.Contains(tankCommand ?? throw new NullReferenceException("command is null"));

        public void CopyTo(TankCommand[] commands, int arrayIndex) => _commands.CopyTo(commands, arrayIndex);

        public bool Remove(TankCommand tankCommand) =>
            _commands.Remove(tankCommand ?? throw new NullReferenceException("command is null"));
    }
}