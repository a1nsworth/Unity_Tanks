using Entities;
using UnityEngine;

namespace Controllers
{
    public class SpinClockwiseCommand : Command
    {
        public SpinClockwiseCommand(KeyCode keyCode) : base(keyCode)
        {
        }

        public override void Execute(in Tank tank)
        {
            tank.SpinClockWise();
        }
    }
}