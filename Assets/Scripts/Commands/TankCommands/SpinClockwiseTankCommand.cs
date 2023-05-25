using Entities;
using UnityEngine;

namespace Commands.TankCommands
{
    public class SpinClockwiseTankCommand : TankCommand
    {
        public SpinClockwiseTankCommand(KeyCode keyCode) : base(keyCode)
        {
        }

        public override void Execute(in Tank tank)
        {
            tank.SpinClockWise();
        }
    }
}