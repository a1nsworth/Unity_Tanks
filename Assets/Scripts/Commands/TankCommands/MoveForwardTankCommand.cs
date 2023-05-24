using Entities;
using UnityEngine;

namespace Commands.TankCommands
{
    public class MoveForwardTankCommand : TankCommand
    {
        public MoveForwardTankCommand(KeyCode keyCode) : base(keyCode)
        {
        }

        public override void Execute(in Tank tank)
        {
            tank.MoveForward();
        }
    }
}