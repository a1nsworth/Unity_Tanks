using Entities;
using UnityEngine;

namespace Commands.TankCommands
{
    public class SpinAntiClockwiseTankCommand : TankCommand
    {
        public SpinAntiClockwiseTankCommand(KeyCode keyCode) : base(keyCode)
        {
        }

        public override void Execute(in Tank tank)
        {
            tank.SpinAntiClockWise();
        }
    }
}