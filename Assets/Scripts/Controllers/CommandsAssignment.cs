using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Controllers
{
    [Serializable]
    public struct TypeCommandAndKeyCode
    {
        [field: SerializeField] public TypeCommand TypeCommand { get; set; }
        [field: SerializeField] public KeyCode KeyCode { get; set; }
    }

    public class CommandsAssignment : ICollection<Command>
    {
        private readonly List<Command> _commands;
        public int Count { get; private set; }
        public bool IsReadOnly => true;

        public CommandsAssignment(IEnumerable<Command> commands)
        {
            foreach (var command in commands) _commands.Add(command);

            Count = _commands.Count;
        }


        IEnumerator<Command> IEnumerable<Command>.GetEnumerator() => _commands.GetEnumerator();
        public IEnumerator GetEnumerator() => _commands.GetEnumerator();

        public void Add(Command command)
        {
            _commands.Add(command ?? throw new NullReferenceException("command is null"));
            Count = _commands.Count;
        }

        public void Clear()
        {
            _commands.Clear();
            Count = _commands.Count;
        }

        public bool Contains(Command command) =>
            _commands.Contains(command ?? throw new NullReferenceException("command is null"));

        public void CopyTo(Command[] commands, int arrayIndex) => _commands.CopyTo(commands, arrayIndex);

        public bool Remove(Command command)
        {
            var isRemoved = _commands.Remove(command ?? throw new NullReferenceException("command is null"));
            Count = _commands.Count;

            return isRemoved;
        }
    }
}