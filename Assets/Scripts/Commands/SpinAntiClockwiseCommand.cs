using Entities;
using UnityEngine;

namespace Controllers
{
    public class SpinAntiClockwiseCommand : Command
    {
        public SpinAntiClockwiseCommand(KeyCode keyCode) : base(keyCode)
        {
        }

        public override void Execute(in Tank tank)
        {
            tank.SpinAntiClockWise();
        }
    }
}