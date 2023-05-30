using Entities;
using UnityEngine;

namespace Commands.TankCommands
{
    public class ShootTankCommand : TankCommand
    {
        public ShootTankCommand(KeyCode keyCode) : base(keyCode)
        {
        }

        public override void Execute(in Tank tank)
        {
            tank.Shoot();
        }
    }
}