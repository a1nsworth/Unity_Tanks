using Entities;
using UnityEngine;

namespace Controllers
{
    public class MoveForwardCommand : Command
    {
        public MoveForwardCommand(KeyCode keyCode) : base(keyCode)
        {
        }

        public override void Execute(in Tank tank)
        {
            tank.MoveForward();
        }
    }
}