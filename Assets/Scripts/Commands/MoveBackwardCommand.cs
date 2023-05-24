using Entities;
using UnityEngine;

namespace Controllers
{
    public class MoveBackwardCommand : Command
    {
        public MoveBackwardCommand(KeyCode keyCode) : base(keyCode)
        {
        }

        public override void Execute(in Tank tank)
        {
            tank.MoveBackward();
        }
    }
}