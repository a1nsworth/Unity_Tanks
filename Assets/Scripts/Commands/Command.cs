using System;
using Entities;
using UnityEngine;

namespace Controllers
{
    [Serializable]
    public abstract class Command
    {
        [field: SerializeField] public KeyCode KeyCode { get; set; }

        protected Command(KeyCode keyCode) => KeyCode = keyCode;

        public abstract void Execute(in Tank tank);
    }
}