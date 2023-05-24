using System;
using Entities;
using UnityEngine;

namespace Commands.TankCommands
{
    [Serializable]
    public abstract class TankCommand
    {
        [field: SerializeField] public KeyCode KeyCode { get; set; }

        protected TankCommand(KeyCode keyCode) => KeyCode = keyCode;

        public abstract void Execute(in Tank tank);
    }
}